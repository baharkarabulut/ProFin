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
	public partial class FrmMusteriListesi : Form
	{
		public FrmMusteriListesi()
		{
			InitializeComponent();
		}
		DbProFinEntities db = new DbProFinEntities();
		public int SecilenMusteriID { get; set; } = -1;
		private void Listele()
		{
			var musteriler = from musteri in db.Musteriler
							 select new
							 {
								 musteri.MusteriID,
								 musteri.AdSoyad,
								 musteri.Telefon,
								 musteri.Eposta,
								 musteri.Adres,
								 musteri.Notlar
							 };

			gridControl1.DataSource = musteriler.ToList();
		}
		private void FrmMusteriListesi_Load(object sender, EventArgs e)
		{
			gridView1.OptionsSelection.MultiSelect = false;
			gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
			gridView1.OptionsSelection.InvertSelection = false;
			Listele();
		}

		private void BtnYenile_Click(object sender, EventArgs e)
		{
			Listele();
		}

		private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
		{
			int musteriID = Convert.ToInt32(gridView1.GetFocusedRowCellValue("MusteriID"));
			FrmMusteriDetay musteriDetay = new FrmMusteriDetay();
			musteriDetay.MusteriID = musteriID;
			musteriDetay.ShowDialog();
			Listele();
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

		private void btnYazdir_Click(object sender, EventArgs e)
		{
			GridControlYazdir();
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
	}
}
