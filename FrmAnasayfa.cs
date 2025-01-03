using DevExpress.XtraCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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

				gridControl1.DataSource = projeler.ToList();
				gridView1.Columns["ProjeID"].Caption = "Proje ID";
				gridView1.Columns["ProjeAdi"].Caption = "Proje Adı";
				gridView1.Columns["MusteriAdi"].Caption = "Müşteri Adı";
				gridView1.Columns["Durum"].Caption = "Durum";
				gridView1.Columns["BaslangicTarihi"].Caption = "Başlangıç Tarihi";
				gridView1.Columns["BitisTarihi"].Caption = "Bitiş Tarihi";
				gridView1.Columns["ToplamTutar"].Caption = "Toplam Tutar";
				gridView1.Columns["Notlar"].Caption = "Notlar";

				gridView1.Columns["ProjeID"].Width = 60; 
				gridView1.Columns["ProjeAdi"].Width = 210;  
				gridView1.Columns["MusteriAdi"].Width = 150; 
				gridView1.Columns["Durum"].Width = 120; 
				gridView1.Columns["BaslangicTarihi"].Width = 120; 
				gridView1.Columns["BitisTarihi"].Width = 120; 
				gridView1.Columns["ToplamTutar"].Width = 120;  
				gridView1.Columns["Notlar"].Width = 150; 
			}
		}

		private void MusterileriListele()
		{
			using (var db = new DbProFinEntities())
			{
				var musteriler = from musteri in db.Musteriler
								 select new
								 {
									 musteri.MusteriID,
									 musteri.AdSoyad,
									 musteri.Eposta
								 };

				gridControl2.DataSource = musteriler.ToList();

				gridView2.Columns["MusteriID"].Caption = "ID";
				gridView2.Columns["AdSoyad"].Caption = "Müşteri";
				gridView2.Columns["Eposta"].Caption = "Mail";

				gridView2.Columns["MusteriID"].Width = 70;
				gridView2.Columns["AdSoyad"].Width = 200;
				gridView2.Columns["Eposta"].Width = 250;
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

		private void ProjeKalanSureleriniListele()
		{
			using (var db = new DbProFinEntities())
			{
				var devamEdenProjeler = db.Projeler
										  .Where(p => p.Durum == "Devam Ediyor" && p.BitisTarihi.HasValue)
										  .Select(p => new
										  {
											  p.ProjeID,
											  p.ProjeAdi,
											  p.BitisTarihi,
											  KalanGun = DbFunctions.DiffDays(DateTime.Now, p.BitisTarihi)
										  })
										  .Where(p => p.KalanGun > 0)
										  .OrderBy(p => p.KalanGun)
										  .ToList();

				listView1.Items.Clear();

				foreach (var proje in devamEdenProjeler)
				{
					ListViewItem item = new ListViewItem(proje.ProjeID.ToString()); 
					item.SubItems.Add(proje.ProjeAdi);                            
					item.SubItems.Add(proje.BitisTarihi?.ToShortDateString());    
					item.SubItems.Add(proje.KalanGun?.ToString());                 

					if (proje.KalanGun < 50)
					{
						item.BackColor = Color.LightCoral;
					}
					else
					{
						item.BackColor = Color.LightGreen;
					}

					listView1.Items.Add(item);
				}
			}

			ListViewRenkAyarla();
		}
		private void ListViewRenkAyarla()
		{
			foreach (ListViewItem item in listView1.Items)
			{
				if (int.TryParse(item.SubItems[3].Text, out int kalanGun) && kalanGun >= 0)
				{
					if (kalanGun > 50)
						item.BackColor = Color.LightGreen;
					else if (kalanGun > 5)
						item.BackColor = Color.LightCoral;
				}
			}
		}
		private void InitializeTimer()
		{
			Timer timer = new Timer();
			timer.Interval = 60000; 
			timer.Tick += (s, e) => ProjeKalanSureleriniListele();
			timer.Start();
		}

		private void GuncelleHedefler()
		{
			using (var db = new DbProFinEntities())
			{
				decimal gelirHedefi = 350000;
				decimal toplamGelir = db.Faturalar
									   .Where(f => f.DurumBilgi == "Geçerli")
									   .Sum(f => (decimal?)f.ToplamTutar) ?? 0;

				decimal kalanGelir = gelirHedefi - toplamGelir;

				lblGelirHedefi.Text =
					$"Gelir Hedefi: {gelirHedefi:C}\n" +
					$"Şu Anki Gelir: {toplamGelir:C}\n" +
					$"Kalan Hedef: {(kalanGelir > 0 ? kalanGelir.ToString("C") : "Tamamlandı!")}";

				int projeHedefi = 15; 
				int tamamlananProjeler = db.Projeler.Count(p => p.Durum == "Tamamlandı");

				int kalanProje = projeHedefi - tamamlananProjeler;

				lblProjeHedefi.Text =
					$"Proje Hedefi: {projeHedefi} Proje\n" +
					$"Tamamlanan Projeler: {tamamlananProjeler}\n" +
					$"Kalan Hedef: {(kalanProje > 0 ? $"{kalanProje} Proje" : "Tamamlandı!")}";

				progressGelir.EditValue = toplamGelir / gelirHedefi * 100;
				progressProje.EditValue = tamamlananProjeler / (double)projeHedefi * 100;
			}
		}

		private void EtkinlikleriListele()
		{
			using (var db = new DbProFinEntities())
			{
				var etkinlikler = db.Etkinlik
					.OrderBy(e => e.Tarih)
					.Select(e => new
					{
						e.EtkinlikAdi,
						e.Tarih,
						Durum = e.Durum == 1 ? "Yaklaşan" :
								e.Durum == 2 ? "Tamamlandı" :
								"Gecikmiş",
						e.Aciklama
					})
					.ToList();

				listViewEtkinlikler.Items.Clear();

				foreach (var etkinlik in etkinlikler)
				{
					ListViewItem item = new ListViewItem(etkinlik.EtkinlikAdi);
					item.SubItems.Add(etkinlik.Tarih.HasValue
	? etkinlik.Tarih.Value.ToString("dd.MM.yyyy")
	: "Belirtilmemiş");

					if (etkinlik.Durum == "Yaklaşan")
						item.BackColor = Color.LightBlue;
					else if (etkinlik.Durum == "Tamamlandı")
						item.BackColor = Color.LightGreen;
					else if (etkinlik.Durum == "Gecikmiş")
						item.BackColor = Color.LightCoral;

					listViewEtkinlikler.Items.Add(item);
				}
			}
		}
		private void InitializeEtkinlikListesi()
		{
			listViewEtkinlikler.Clear();

			listViewEtkinlikler.Columns.Add("Etkinlik Adı", 147);
			listViewEtkinlikler.Columns.Add("Tarih", 80);

			listViewEtkinlikler.View = View.Details;
			listViewEtkinlikler.FullRowSelect = true;
			listViewEtkinlikler.GridLines = true;
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


			//Proje durum izleyici
			var yuzdelikler = GetProjeDurumYuzdelik();

			progressTamamlandi.EditValue = yuzdelikler.ContainsKey("Tamamlandı") ? yuzdelikler["Tamamlandı"] : 0;
			progressDevamEdiyor.EditValue = yuzdelikler.ContainsKey("Devam Ediyor") ? yuzdelikler["Devam Ediyor"] : 0;
			progressIptalEdildi.EditValue = yuzdelikler.ContainsKey("İptal Edildi") ? yuzdelikler["İptal Edildi"] : 0;

			lblTamamlandi.Text = $"Tamamlandı: {(yuzdelikler.ContainsKey("Tamamlandı") ? yuzdelikler["Tamamlandı"] : 0)}%";
			lblDevamEdiyor.Text = $"Devam Ediyor: {(yuzdelikler.ContainsKey("Devam Ediyor") ? yuzdelikler["Devam Ediyor"] : 0)}%";
			lblIptalEdildi.Text = $"İptal Edildi: {(yuzdelikler.ContainsKey("İptal Edildi") ? yuzdelikler["İptal Edildi"] : 0)}%";

			//Proje süresi izleyici
			listView1.Columns.Clear();
			listView1.Columns.Add("Proje ID", 56);
			listView1.Columns.Add("Proje Adı", 210);
			listView1.Columns.Add("Bitiş Tarihi", 120);
			listView1.Columns.Add("Kalan Gün", 100);
			listView1.View = View.Details; 
			listView1.FullRowSelect = true;

			ProjeKalanSureleriniListele();
			InitializeTimer();

			GuncelleHedefler();

			//Etkinlik Listesi
			InitializeEtkinlikListesi();
			EtkinlikleriListele();
		}
	}
}
