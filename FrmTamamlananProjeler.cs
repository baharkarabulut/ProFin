using DevExpress.XtraCharts;
using DevExpress.XtraPrinting;
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
	public partial class FrmTamamlananProjeler : Form
	{
		public FrmTamamlananProjeler()
		{
			InitializeComponent();
		}
		DbProFinEntities db = new DbProFinEntities();
		private void FrmTamamlananProjeler_Load(object sender, EventArgs e)
		{
			ListeleTamamlananProjeler();
			GridSatirDetaylariniGoster();
			HesaplaIstatistikler();
			ProjeKazancBarGrafik();
		}

		private void ListeleTamamlananProjeler()
		{
			using (var db = new DbProFinEntities())
			{
				var tamamlananProjeler = (from proje in db.Projeler
										  join musteri in db.Musteriler
										  on proje.MusteriID equals musteri.MusteriID
										  where proje.Durum == "Tamamlandı"
										  select new
										  {
											  proje.ProjeID,
											  proje.ProjeAdi,
											  MusteriAdi = musteri.AdSoyad,
											  proje.BaslangicTarihi,
											  proje.BitisTarihi,
											  proje.ToplamTutar
										  }).ToList();

				gridControl1.DataSource = tamamlananProjeler;

				gridView1.Columns["ProjeID"].Caption = "Proje ID";
				gridView1.Columns["ProjeAdi"].Caption = "Proje Adı";
				gridView1.Columns["MusteriAdi"].Caption = "Müşteri Adı";
				gridView1.Columns["BaslangicTarihi"].Caption = "Başlangıç Tarihi";
				gridView1.Columns["BitisTarihi"].Caption = "Bitiş Tarihi";
				gridView1.Columns["ToplamTutar"].Caption = "Toplam Tutar";

				gridView1.Columns["ProjeID"].Width = 50;
				gridView1.Columns["ProjeAdi"].Width = 220;
				gridView1.Columns["MusteriAdi"].Width = 150;
				gridView1.Columns["BaslangicTarihi"].Width = 110;
				gridView1.Columns["BitisTarihi"].Width = 110;
				gridView1.Columns["ToplamTutar"].Width = 100;

				// Tarih sütunları için format ayarı
				gridView1.Columns["BaslangicTarihi"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
				gridView1.Columns["BaslangicTarihi"].DisplayFormat.FormatString = "dd.MM.yyyy";

				gridView1.Columns["BitisTarihi"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
				gridView1.Columns["BitisTarihi"].DisplayFormat.FormatString = "dd.MM.yyyy";
			}
		}

		private void GridSatirDetaylariniGoster()
		{
			if (gridView1.GetFocusedRow() is null) return;

			var proje = gridView1.GetFocusedRowCellValue("ProjeAdi")?.ToString();
			var musteri = gridView1.GetFocusedRowCellValue("MusteriAdi")?.ToString();
			var baslangic = gridView1.GetFocusedRowCellValue("BaslangicTarihi")?.ToString();
			var bitis = gridView1.GetFocusedRowCellValue("BitisTarihi")?.ToString();
			var tutar = gridView1.GetFocusedRowCellValue("ToplamTutar")?.ToString();

			lblProjeAdi.Text = $"Proje Adı: {proje}";
			lblMusteriAdi.Text = $"Müşteri Adı: {musteri}";
			lblBaslangicTarihi.Text = $"Başlangıç Tarihi: {baslangic}";
			lblBitisTarihi.Text = $"Bitiş Tarihi: {bitis}";
			lblToplamTutar.Text = $"Toplam Tutar: {tutar}";
		}

		private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{
			GridSatirDetaylariniGoster();
			if (gridView1.GetFocusedRowCellValue("BaslangicTarihi") != null &&
	   gridView1.GetFocusedRowCellValue("BitisTarihi") != null)
			{
				// Tarihleri yalnızca "dd.MM.yyyy" formatında alıyoruz
				string baslangic = Convert.ToDateTime(gridView1.GetFocusedRowCellValue("BaslangicTarihi")).ToString("dd.MM.yyyy");
				string bitis = Convert.ToDateTime(gridView1.GetFocusedRowCellValue("BitisTarihi")).ToString("dd.MM.yyyy");

				// Label'lara formatlanmış tarihleri atıyoruz
				lblBaslangicTarihi.Text = $"Başlangıç Tarihi: {baslangic}";
				lblBitisTarihi.Text = $"Bitiş Tarihi: {bitis}";
			}
			else
			{
				// Eğer veri yoksa varsayılan mesajları gösteriyoruz
				lblBaslangicTarihi.Text = "Başlangıç tarihi yok";
				lblBitisTarihi.Text = "Bitiş tarihi yok";
			}
		}

		private void gridView1_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
		{
			// Tarih sütunları için özelleştirilmiş format
			if (e.Column.FieldName == "BaslangicTarihi" || e.Column.FieldName == "BitisTarihi")
			{
				if (e.Value != null && e.Value is DateTime dateTimeValue)
				{
					e.DisplayText = dateTimeValue.ToString("dd.MM.yyyy");
				}
			}
		}

		private void HesaplaIstatistikler()
		{
			using (var db = new DbProFinEntities())
			{
				// Tamamlanan projelerin toplam sayısı
				int toplamProjeSayisi = db.Projeler.Count(p => p.Durum == "Tamamlandı");

				// Tamamlanan projelerin toplam kazancı
				decimal toplamKazanc = db.Projeler
										 .Where(p => p.Durum == "Tamamlandı")
										 .Sum(p => (decimal?)p.ToplamTutar) ?? 0;

				// İstatistikleri Label'lara yazdır
				lblToplamProjeSayisi.Text = $"Toplam Proje Sayısı: {toplamProjeSayisi}";
				lblToplamKazanc.Text = $"Toplam Kazanç: {toplamKazanc:C}";
			}
		}

		private void ProjeKazancBarGrafik()
		{
			using (var db = new DbProFinEntities())
			{
				// Tamamlanan projeleri al
				var tamamlananProjeler = (from proje in db.Projeler
										  where proje.Durum == "Tamamlandı"
										  select new
										  {
											  proje.ProjeAdi,
											  proje.ToplamTutar
										  }).ToList();

				// Grafik serisi oluştur
				Series barSeries = new Series("", ViewType.Bar);

				foreach (var proje in tamamlananProjeler)
				{
					// Bar serisine veri ekle
					barSeries.Points.Add(new SeriesPoint(proje.ProjeAdi, proje.ToplamTutar));
				}

				// Grafik özelliklerini ayarla
				chartProjeKazanc.Series.Clear();
				chartProjeKazanc.Series.Add(barSeries);

				// Bar renklerini özelleştir (isteğe bağlı)
				barSeries.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
				barSeries.Label.TextPattern = "{A}: {V:C2}"; // Proje adı ve kazanç (para formatında)

				chartProjeKazanc.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
				chartProjeKazanc.Legend.AlignmentHorizontal = LegendAlignmentHorizontal.Center;
				chartProjeKazanc.Legend.AlignmentVertical = LegendAlignmentVertical.Bottom;

				// Grafik başlığı ekle
				ChartTitle chartTitle = new ChartTitle();
				chartTitle.Text = "Proje Kazançları";
				chartProjeKazanc.Titles.Clear();
				chartProjeKazanc.Titles.Add(chartTitle);
			}
		}

		private void btnExcelAktar_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "Excel Dosyası (*.xlsx)|*.xlsx";
			saveFileDialog.Title = "Excel Dosyası Kaydet";

			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				string filePath = saveFileDialog.FileName;
				gridControl1.ExportToXlsx(filePath);
				MessageBox.Show("Excel dosyası başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void btnPdfAktar_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "PDF Dosyası (*.pdf)|*.pdf";
			saveFileDialog.Title = "PDF Dosyası Kaydet";

			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				string filePath = saveFileDialog.FileName;
				gridControl1.ExportToPdf(filePath); 
				MessageBox.Show("PDF dosyası başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void GridControlYazdir()
		{
			try
			{
				// Yazıcı seçimi için bir PrintDialog oluştur
				PrintDialog printDialog = new PrintDialog();

				// Varsayılan yazıcıyı ayarla
				printDialog.UseEXDialog = true;

				// Eğer kullanıcı bir yazıcı seçerse işlemi başlat
				if (printDialog.ShowDialog() == DialogResult.OK)
				{
					// DevExpress GridControl'ün yazıcıya gönderme fonksiyonu
					PrintableComponentLink link = new PrintableComponentLink(new PrintingSystem())
					{
						Component = gridControl1
					};

					// Seçilen yazıcıya yazdır
					link.Print(printDialog.PrinterSettings.PrinterName);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Yazdırma sırasında hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnYazdir_Click(object sender, EventArgs e)
		{
			GridControlYazdir();
		}
	}
}
