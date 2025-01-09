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
	public partial class FrmMusteriAnalizi : Form
	{
		public FrmMusteriAnalizi()
		{
			InitializeComponent();
		}
		DbProFinEntities db = new DbProFinEntities();
		private void FrmMusteriAnalizi_Load(object sender, EventArgs e)
		{
			GenelIstatistikleriGetir();
			MusteriDetaylariniListele();
			MusteriBazliDurumDagilimi();
			EnUzunSureliProjeleriDoldur();
		}

		private void MusteriDetaylariniListele()
		{
			var musteriDetaylar = (from musteri in db.Musteriler
								   join proje in db.Projeler on musteri.MusteriID equals proje.MusteriID
								   where proje.Durum == "Tamamlandı" || proje.Durum == "Devam Ediyor" 
								   group proje by new { musteri.MusteriID, musteri.AdSoyad } into g
								   select new
								   {
									   g.Key.MusteriID,
									   g.Key.AdSoyad,
									   ProjeSayisi = g.Count(),
									   ToplamGelir = g.Sum(p => p.ToplamTutar)
								   }).ToList();

			gridControlMusteriAnalizi.DataSource = musteriDetaylar;
		}

		private void GenelIstatistikleriGetir()
		{
			lblToplamMusteri.Text = $"Toplam Müşteri: {db.Musteriler.Count()}";

			var enCokProje = db.Projeler
				.Where(p => p.Durum == "Tamamlandı" || p.Durum == "Devam Ediyor")
				.GroupBy(p => p.MusteriID)
				.OrderByDescending(g => g.Count())
				.Select(g => new { MusteriID = g.Key, ProjeSayisi = g.Count() })
				.FirstOrDefault();

			lblEnCokProje.Text = enCokProje != null
				? $"En Çok Proje Tamamlayan: {db.Musteriler.Find(enCokProje.MusteriID).AdSoyad} ({enCokProje.ProjeSayisi} Proje)"
				: "En Çok Proje Tamamlayan: -";

			var enYuksekGelir = db.Projeler
				.Where(p => p.Durum == "Tamamlandı" || p.Durum == "Devam Ediyor") 
				.GroupBy(p => p.MusteriID)
				.OrderByDescending(g => g.Sum(pr => pr.ToplamTutar))
				.Select(g => new { MusteriID = g.Key, Gelir = g.Sum(pr => pr.ToplamTutar) })
				.FirstOrDefault();

			lblEnYuksekGelir.Text = enYuksekGelir != null
				? $"En Yüksek Gelir Getiren: {db.Musteriler.Find(enYuksekGelir.MusteriID).AdSoyad} ({enYuksekGelir.Gelir:C2})"
				: "En Yüksek Gelir Getiren: -";
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

				gridControl1.DataSource = durumDagilimi;

				// Mevcut sütun isimlerini kontrol et
				foreach (DevExpress.XtraGrid.Columns.GridColumn column in gridView1.Columns)
				{
					Console.WriteLine($"Column Name: {column.FieldName}");
				}
				
			}
		}

		private void EnUzunSureliProjeleriDoldur()
		{
			using (var db = new DbProFinEntities())
			{
				var enUzunSureliProjeler = db.Musteriler
					.Select(m => new
					{
						MusteriAdi = m.AdSoyad,
						EnUzunProjeSuresi = db.Projeler
							.Where(p => p.MusteriID == m.MusteriID && p.BaslangicTarihi != null && p.BitisTarihi != null)
							.Select(p => DbFunctions.DiffDays(p.BaslangicTarihi, p.BitisTarihi))
							.Max() ?? 0 
					})
					.Where(x => x.EnUzunProjeSuresi > 0) 
					.ToList();

				gridControl2.DataSource = enUzunSureliProjeler;

				var gridView = gridControl2.MainView as DevExpress.XtraGrid.Views.Grid.GridView;
				gridView.Columns["MusteriAdi"].Caption = "Müşteri Adı";
				gridView.Columns["EnUzunProjeSuresi"].Caption = "En Uzun Proje Süresi (Gün)";
				gridView.Columns["EnUzunProjeSuresi"].Width = 150;
			}
		}




	}
}
