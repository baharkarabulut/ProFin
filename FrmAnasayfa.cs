﻿using DevExpress.XtraCharts;
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

		private decimal GetToplamGider()
		{
			using (var dbContext = new DbProFinEntities())
			{
				var toplamGider = dbContext.Giderler
										   .Sum(g => (decimal?)g.Tutar) ?? 0;

				return toplamGider;
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
								   proje.TeslimTarihi,
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
				gridView1.Columns["TeslimTarihi"].Caption = "Teslim Tarihi";
				gridView1.Columns["Notlar"].Caption = "Notlar";

				gridView1.Columns["ProjeID"].Width = 60; 
				gridView1.Columns["ProjeAdi"].Width = 210;  
				gridView1.Columns["MusteriAdi"].Width = 150; 
				gridView1.Columns["Durum"].Width = 120; 
				gridView1.Columns["BaslangicTarihi"].Width = 110; 
				gridView1.Columns["BitisTarihi"].Width = 110; 
				gridView1.Columns["ToplamTutar"].Width = 100;
				gridView1.Columns["TeslimTarihi"].Width = 110;
				gridView1.Columns["Notlar"].Width = 140; 
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
		private void AylikFinansalDurum()
		{
			var aylikVeriler = db.Faturalar
				.Where(f => f.FaturaTarihi.HasValue)
				.GroupBy(f => f.FaturaTarihi.Value.Month)
				.Select(g => new
				{
					Ay = g.Key,
					ToplamTutar = g.Sum(f => (decimal?)f.ToplamTutar) ?? 0,
					OdenmisTutar = g.Where(f => f.OdemeDurumu == "Ödendi").Sum(f => (decimal?)f.ToplamTutar) ?? 0,
					OdenmemisTutar = g.Where(f => f.OdemeDurumu == "Ödenmedi").Sum(f => (decimal?)f.ToplamTutar) ?? 0,
					KismiOdenmisTutar = g.Where(f => f.OdemeDurumu == "Kısmi Ödendi").Sum(f => (decimal?)f.ToplamTutar) ?? 0
				}).ToList();

			chartControl1.Series.Clear();

			var toplamTutarSeri = new DevExpress.XtraCharts.Series("Toplam Tutar", DevExpress.XtraCharts.ViewType.Line);
			toplamTutarSeri.DataSource = aylikVeriler;
			toplamTutarSeri.ArgumentDataMember = "Ay";
			toplamTutarSeri.ValueDataMembers.AddRange("ToplamTutar");

			var odenmisTutarSeri = new DevExpress.XtraCharts.Series("Ödenmiş Tutar", DevExpress.XtraCharts.ViewType.Line);
			odenmisTutarSeri.DataSource = aylikVeriler;
			odenmisTutarSeri.ArgumentDataMember = "Ay";
			odenmisTutarSeri.ValueDataMembers.AddRange("OdenmisTutar");

			var odenmemisTutarSeri = new DevExpress.XtraCharts.Series("Ödenmemiş Tutar", DevExpress.XtraCharts.ViewType.Line);
			odenmemisTutarSeri.DataSource = aylikVeriler;
			odenmemisTutarSeri.ArgumentDataMember = "Ay";
			odenmemisTutarSeri.ValueDataMembers.AddRange("OdenmemisTutar");

			var kismiOdenmisTutarSeri = new DevExpress.XtraCharts.Series("Kısmi Ödenmiş Tutar", DevExpress.XtraCharts.ViewType.Line);
			kismiOdenmisTutarSeri.DataSource = aylikVeriler;
			kismiOdenmisTutarSeri.ArgumentDataMember = "Ay";
			kismiOdenmisTutarSeri.ValueDataMembers.AddRange("KismiOdenmisTutar");

			chartControl1.Series.AddRange(new[] { toplamTutarSeri, odenmisTutarSeri, odenmemisTutarSeri, kismiOdenmisTutarSeri });
		}

		private void MusteriBazliDurumDagilimi()
		{
			using (var db = new DbProFinEntities())
			{
				var durumDagilimi = db.Musteriler
					.Select(m => new
					{
						MusteriAdi = m.AdSoyad,
						TamamlananProjeler = db.Projeler.Count(p => p.MusteriID == m.MusteriID && p.Durum == "Tamamlandı"),
						DevamEdenProjeler = db.Projeler.Count(p => p.MusteriID == m.MusteriID && p.Durum == "Devam Ediyor"),
						IptalEdilenProjeler = db.Projeler.Count(p => p.MusteriID == m.MusteriID && p.Durum == "İptal Edildi")
					})
					.ToList();

				gridControl3.DataSource = durumDagilimi;

				// Mevcut sütun isimlerini kontrol et
				foreach (DevExpress.XtraGrid.Columns.GridColumn column in gridView1.Columns)
				{
					Console.WriteLine($"Column Name: {column.FieldName}");
				}

			}
		}

		private void FrmAnasayfa_Load(object sender, EventArgs e)
		{
			// Gelir-Gider Grafiği
			Series series = new Series("Gelir-Gider", ViewType.Pie3D);

			decimal toplamGelir = GetToplamGelir();
			decimal toplamGider = GetToplamGider();

			SeriesPoint gelirPoint = new SeriesPoint("Gelir", toplamGelir);
			gelirPoint.Color = ColorTranslator.FromHtml("#9bcd9b"); 

			SeriesPoint giderPoint = new SeriesPoint("Gider", toplamGider);
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
			chartTitle.Text = "";
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

			ChartTitle projeDurumTitle = new ChartTitle { Text = "" };
			chartProjeDurumu.Titles.Clear();
			chartProjeDurumu.Titles.Add(projeDurumTitle);

			ProjeleriListele();

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

			progressTamamlandi.EditValue = yuzdelikler.ContainsKey("Tamamlandı") ? Math.Round(yuzdelikler["Tamamlandı"], 2) : 0;
			progressDevamEdiyor.EditValue = yuzdelikler.ContainsKey("Devam Ediyor") ? Math.Round(yuzdelikler["Devam Ediyor"], 2) : 0;
			progressIptalEdildi.EditValue = yuzdelikler.ContainsKey("İptal Edildi") ? Math.Round(yuzdelikler["İptal Edildi"], 2) : 0;

			lblTamamlandi.Text = $"Tamamlandı: %{(yuzdelikler.ContainsKey("Tamamlandı") ? Math.Round(yuzdelikler["Tamamlandı"], 2) : 0)}";
			lblDevamEdiyor.Text = $"Devam Ediyor: %{(yuzdelikler.ContainsKey("Devam Ediyor") ? Math.Round(yuzdelikler["Devam Ediyor"], 2) : 0)}";
			lblIptalEdildi.Text = $"İptal Edildi: %{(yuzdelikler.ContainsKey("İptal Edildi") ? Math.Round(yuzdelikler["İptal Edildi"], 2) : 0)}";

			listView1.Columns.Clear();
			listView1.Columns.Add("Proje ID", 56);
			listView1.Columns.Add("Proje Adı", 210);
			listView1.Columns.Add("Bitiş Tarihi", 120);
			listView1.Columns.Add("Kalan Gün", 100);
			listView1.View = View.Details; 
			listView1.FullRowSelect = true;

			ProjeKalanSureleriniListele();
			InitializeTimer();
			AylikFinansalDurum();
			MusteriBazliDurumDagilimi();
		}
	}
}
