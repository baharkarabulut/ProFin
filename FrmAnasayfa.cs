using DevExpress.XtraCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProFin
{
	public partial class FrmAnasayfa : Form
	{
		public FrmAnasayfa()
		{
			InitializeComponent();
		}
		DbProFinEntities db = new DbProFinEntities();

		private decimal GetToplamGelir()
		{
			using (var dbContext = new DbProFinEntities())
			{
				var toplamGelir = dbContext.Faturalar
										   .Where(f => f.DurumBilgi == "Geçerli")
										   .Sum(f => (decimal?)f.ToplamTutar) ?? 0;

				return toplamGelir;
			}
		}
		private int GetTamamlananProjeSayisi()
		{
			using (var dbContext = new DbProFinEntities())
			{
				return dbContext.Projeler.Count(p => p.Durum == "Tamamlandı");
			}
		}

		private int GetDevamEdenProjeSayisi()
		{
			using (var dbContext = new DbProFinEntities())
			{
				return dbContext.Projeler.Count(p => p.Durum == "Devam Ediyor");
			}
		}

		private void ProjeleriListele()
		{
			using (var db = new DbProFinEntities())
			{
				// Proje ve müşteri bilgilerini sorgula
				var projeler = from proje in db.Projeler
							   join musteri in db.Musteriler
							   on proje.MusteriID equals musteri.MusteriID
							   select new
							   {
								   proje.ProjeID,
								   proje.ProjeAdi,
								   MusteriAdi = musteri.AdSoyad,
								   Durum = (proje.Durum == "Başlanmadı" ? "Başlanmadı" :
										   proje.Durum == "Devam Ediyor" ? "Devam Ediyor" :
										   proje.Durum == "Tamamlandı" ? "Tamamlandı" :
										   proje.Durum == "İptal Edildi" ? "İptal Edildi" : "Bilinmiyor"),
								   proje.BaslangicTarihi,
								   proje.BitisTarihi,
								   proje.ToplamTutar,
								   proje.Notlar
							   };

				// Verileri gridControl'e ata
				gridControl1.DataSource = projeler.ToList();
				gridView1.Columns["ProjeID"].Caption = "Proje ID";
				gridView1.Columns["ProjeAdi"].Caption = "Proje Adı";
				gridView1.Columns["MusteriAdi"].Caption = "Müşteri Adı";
				gridView1.Columns["Durum"].Caption = "Durum";
				gridView1.Columns["BaslangicTarihi"].Caption = "Başlangıç Tarihi";
				gridView1.Columns["BitisTarihi"].Caption = "Bitiş Tarihi";
				gridView1.Columns["ToplamTutar"].Caption = "Toplam Tutar";
				gridView1.Columns["Notlar"].Caption = "Notlar";
			}
		}

		private void MusterileriListele()
		{
			using (var db = new DbProFinEntities())
			{
				// Müşteri bilgilerini sorgula
				var musteriler = from musteri in db.Musteriler
								 select new
								 {
									 musteri.MusteriID,
									 musteri.AdSoyad,
									 musteri.Eposta
								 };

				// Verileri gridControl2'ye ata
				gridControl2.DataSource = musteriler.ToList();
				gridView2.Columns["MusteriID"].Caption = "Müşteri ID";
				gridView2.Columns["AdSoyad"].Caption = "Ad Soyad";
				gridView2.Columns["Eposta"].Caption = "Mail";
			}
		}

		private dynamic GetSonOdenenFatura()
		{
			using (var dbContext = new DbProFinEntities())
			{
				var sonFatura = dbContext.Faturalar
					.Where(f => f.OdemeDurumu == "Ödendi")
					.OrderByDescending(f => f.FaturaTarihi)
					.Select(f => new
					{
						f.FaturaTarihi,
						f.ToplamTutar,
						MusteriAdi = f.Musteriler.AdSoyad
					})
					.FirstOrDefault();

				return sonFatura;
			}
		}

		private Dictionary<string, double> GetProjeDurumYuzdelik()
		{
			using (var dbContext = new DbProFinEntities())
			{
				int toplamProje = dbContext.Projeler.Count();
				if (toplamProje == 0) return new Dictionary<string, double>();

				var durumlar = dbContext.Projeler
					.GroupBy(p => p.Durum)
					.Select(g => new
					{
						Durum = g.Key,
						Yuzde = (g.Count() / (double)toplamProje) * 100
					})
					.ToDictionary(x => x.Durum, x => x.Yuzde);

				return durumlar;
			}
		}

		private int GetToplamMusteriSayisi()
		{
			using (var dbContext = new DbProFinEntities())
			{
				return dbContext.Musteriler.Count();
			}
		}
		private void FrmAnasayfa_Load(object sender, EventArgs e)
		{
			// Gelir-Gider Grafiği
			Series series = new Series("Gelir-Gider", ViewType.Pie3D);

			SeriesPoint gelirPoint = new SeriesPoint("Gelir", GetToplamGelir());
			gelirPoint.Color = ColorTranslator.FromHtml("#9bcd9b");

			SeriesPoint giderPoint = new SeriesPoint("Gider", 60000);
			giderPoint.Color = ColorTranslator.FromHtml("#ee5c42");

			series.Points.Add(gelirPoint);
			series.Points.Add(giderPoint);

			chartToplamGelir.Series.Clear(); 
			chartToplamGelir.Series.Add(series);

			Pie3DSeriesView pieView = (Pie3DSeriesView)series.View;
			pieView.ExplodedPoints.Add(series.Points[0]); 
			pieView.ExplodeMode = PieExplodeMode.UsePoints;
			pieView.Depth = 20;

			ChartTitle chartTitle = new ChartTitle();
			chartTitle.Text = "Toplam Gelir/Gider";
			chartToplamGelir.Titles.Clear(); 
			chartToplamGelir.Titles.Add(chartTitle);

			// Proje Durumu Grafiği
			Series projeDurumSeries = new Series("Proje Durumu", ViewType.Bar);
			projeDurumSeries.Points.Add(new SeriesPoint("Tamamlanan Projeler", GetTamamlananProjeSayisi()));
			projeDurumSeries.Points.Add(new SeriesPoint("Devam Eden Projeler", GetDevamEdenProjeSayisi()));
			projeDurumSeries.Points[0].Color = ColorTranslator.FromHtml("#519fdb");
			projeDurumSeries.Points[1].Color = ColorTranslator.FromHtml("#f9f995"); 


			chartProjeDurumu.Series.Clear();
			chartProjeDurumu.Series.Add(projeDurumSeries);

			SideBySideBarSeriesView barView = (SideBySideBarSeriesView)projeDurumSeries.View;
			barView.ColorEach = true;

			ChartTitle projeDurumTitle = new ChartTitle { Text = "Proje Durumu Grafiği" };
			chartProjeDurumu.Titles.Clear();
			chartProjeDurumu.Titles.Add(projeDurumTitle);

			ProjeleriListele();
			MusterileriListele();

			var sonFatura = GetSonOdenenFatura();

			if (sonFatura != null)
			{
				lblSonFaturaTarih.Text = $"Tarih: {sonFatura.FaturaTarihi:yyyy-MM-dd}";
				lblSonFaturaTutar.Text = $"Tutar: {sonFatura.ToplamTutar:C2}";
				lblSonFaturaMusteri.Text = $"Müşteri: {sonFatura.MusteriAdi}";
			}
			else
			{
				lblSonFaturaTarih.Text = "Tarih: -";
				lblSonFaturaTutar.Text = "Tutar: -";
				lblSonFaturaMusteri.Text = "Müşteri: -";
			}

			var toplamMusteriSayisi = GetToplamMusteriSayisi();
			lblMusteriSayisi.Text = toplamMusteriSayisi.ToString();



			var yuzdelikler = GetProjeDurumYuzdelik();

			// Mevcut ProgressBarControl'leri doldur
			progressTamamlandi.EditValue = yuzdelikler.ContainsKey("Tamamlandı") ? yuzdelikler["Tamamlandı"] : 0;
			progressDevamEdiyor.EditValue = yuzdelikler.ContainsKey("Devam Ediyor") ? yuzdelikler["Devam Ediyor"] : 0;
			progressIptalEdildi.EditValue = yuzdelikler.ContainsKey("İptal Edildi") ? yuzdelikler["İptal Edildi"] : 0;

			// Label ile yüzdelikleri göster
			lblTamamlandi.Text = $"Tamamlandı: {(yuzdelikler.ContainsKey("Tamamlandı") ? yuzdelikler["Tamamlandı"] : 0)}%";
			lblDevamEdiyor.Text = $"Devam Ediyor: {(yuzdelikler.ContainsKey("Devam Ediyor") ? yuzdelikler["Devam Ediyor"] : 0)}%";
			lblIptalEdildi.Text = $"İptal Edildi: {(yuzdelikler.ContainsKey("İptal Edildi") ? yuzdelikler["İptal Edildi"] : 0)}%";



		}
	}
}
