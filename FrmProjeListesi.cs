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
	public partial class FrmProjeListesi : Form
	{
		public FrmProjeListesi()
		{
			InitializeComponent();
		}
		DbProFinEntities db = new DbProFinEntities();
		public int SecilenProjeID { get; set; } = -1;
		private void Listele()
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
		}
		private void FrmProjeListesi_Load(object sender, EventArgs e)
		{
			Listele();
		}

		private void BtnYenile_Click(object sender, EventArgs e)
		{
			Listele();
		}

		private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
		{
			int ProjeID = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ProjeID"));

			FrmProjeDetay projeDetay = new FrmProjeDetay();
			projeDetay.ProjeID = ProjeID;

			if (projeDetay.ShowDialog() == DialogResult.OK)
			{
				Listele();
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
