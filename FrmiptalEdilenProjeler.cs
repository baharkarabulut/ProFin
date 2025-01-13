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
	public partial class FrmiptalEdilenProjeler : Form
	{
		public FrmiptalEdilenProjeler()
		{
			InitializeComponent();
		}
		DbProFinEntities db = new DbProFinEntities();
		private void FrmiptalEdilenProjeler_Load(object sender, EventArgs e)
		{
			ListeleiptalEdilenProjeler();
			HesaplaIstatistikler();
		}

		private void ListeleiptalEdilenProjeler()
		{
			using (var db = new DbProFinEntities())
			{
				var iptalEdilenProjeler = (from proje in db.Projeler
										  join musteri in db.Musteriler
										  on proje.MusteriID equals musteri.MusteriID
										  where proje.Durum == "İptal Edildi"
										  select new
										  {
											  proje.ProjeID,
											  proje.ProjeAdi,
											  MusteriAdi = musteri.AdSoyad,
											  proje.BaslangicTarihi,
											  proje.BitisTarihi,
											  proje.ToplamTutar,
											  proje.TeslimTarihi
										  }).ToList();

				gridControl1.DataSource = iptalEdilenProjeler;

				gridView1.Columns["ProjeID"].Caption = "Proje ID";
				gridView1.Columns["ProjeAdi"].Caption = "Proje Adı";
				gridView1.Columns["MusteriAdi"].Caption = "Müşteri Adı";
				gridView1.Columns["BaslangicTarihi"].Caption = "Başlangıç Tarihi";
				gridView1.Columns["BitisTarihi"].Caption = "Bitiş Tarihi";
				gridView1.Columns["ToplamTutar"].Caption = "Toplam Tutar";
				gridView1.Columns["TeslimTarihi"].Caption = "Teslim Tarihi";

				gridView1.Columns["ProjeID"].Width = 50;
				gridView1.Columns["ProjeAdi"].Width = 220;
				gridView1.Columns["MusteriAdi"].Width = 150;
				gridView1.Columns["BaslangicTarihi"].Width = 100;
				gridView1.Columns["BitisTarihi"].Width = 100;
				gridView1.Columns["ToplamTutar"].Width = 90;
				gridView1.Columns["TeslimTarihi"].Width = 100;

				gridView1.Columns["BaslangicTarihi"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
				gridView1.Columns["BaslangicTarihi"].DisplayFormat.FormatString = "dd.MM.yyyy";

				gridView1.Columns["BitisTarihi"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
				gridView1.Columns["BitisTarihi"].DisplayFormat.FormatString = "dd.MM.yyyy";

				gridView1.Columns["TeslimTarihi"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
				gridView1.Columns["TeslimTarihi"].DisplayFormat.FormatString = "dd.MM.yyyy";
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
			var teslim = gridView1.GetFocusedRowCellValue("TeslimTarihi")?.ToString();

			lblProjeAdi.Text = $"Proje Adı: {proje}";
			lblMusteriAdi.Text = $"Müşteri Adı: {musteri}";
			lblBaslangicTarihi.Text = $"Başlangıç Tarihi: {baslangic}";
			lblBitisTarihi.Text = $"Bitiş Tarihi: {bitis}";
			lblToplamTutar.Text = $"Toplam Tutar: {tutar}";
			lblTeslimTarihi.Text = $"Teslim Tarihi: {teslim}";
		}

		private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{
			GridSatirDetaylariniGoster();
			if (gridView1.GetFocusedRowCellValue("BaslangicTarihi") != null &&
	   gridView1.GetFocusedRowCellValue("BitisTarihi") != null)
			{
				string baslangic = Convert.ToDateTime(gridView1.GetFocusedRowCellValue("BaslangicTarihi")).ToString("dd.MM.yyyy");
				string bitis = Convert.ToDateTime(gridView1.GetFocusedRowCellValue("BitisTarihi")).ToString("dd.MM.yyyy");
				string teslim = Convert.ToDateTime(gridView1.GetFocusedRowCellValue("TeslimTarihi")).ToString("dd.MM.yyyy");

				lblBaslangicTarihi.Text = $"Başlangıç Tarihi: {baslangic}";
				lblBitisTarihi.Text = $"Bitiş Tarihi: {bitis}";
				lblTeslimTarihi.Text = $"Teslim Tarihi: {teslim}";
			}
			else
			{
				lblBaslangicTarihi.Text = "Başlangıç tarihi yok";
				lblBitisTarihi.Text = "Bitiş tarihi yok";
				lblTeslimTarihi.Text = "Teslim tarihi yok";
			}
		}

		private void gridView1_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
		{
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
				int toplamProjeSayisi = db.Projeler.Count(p => p.Durum == "İptal Edildi");

				decimal toplamKazanc = db.Projeler
										 .Where(p => p.Durum == "İptal Edildi")
										 .Sum(p => (decimal?)p.ToplamTutar) ?? 0;

				lblToplamProjeSayisi.Text = $"İptal Edilen Proje Sayısı: {toplamProjeSayisi}";
				lblToplamKazanc.Text = $"Toplam Kayıp: {toplamKazanc:C}";
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
				PrintDialog printDialog = new PrintDialog();

				printDialog.UseEXDialog = true;

				if (printDialog.ShowDialog() == DialogResult.OK)
				{
					PrintableComponentLink link = new PrintableComponentLink(new PrintingSystem())
					{
						Component = gridControl1
					};

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
