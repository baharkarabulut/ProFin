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
	public partial class FrmFaturaListesi : Form
	{
		public FrmFaturaListesi()
		{
			InitializeComponent();
		}
		DbProFinEntities db = new DbProFinEntities();

		public int SecilenFaturaID { get; set; } = -1;
		private void Listele()
		{
			var faturalar = from fatura in db.Faturalar
							join musteri in db.Musteriler
							on fatura.MusteriID equals musteri.MusteriID
							join proje in db.Projeler
							on fatura.ProjeID equals proje.ProjeID
							select new
							{
								fatura.FaturaID,
								MusteriAdi = musteri.AdSoyad,
								ProjeAdi = proje.ProjeAdi,
								fatura.FaturaNumarasi,
								fatura.FaturaTarihi,
								fatura.ToplamTutar,
								fatura.KDVOrani,
								fatura.OdemeDurumu,
								fatura.DurumBilgi
							};

			gridControl1.DataSource = faturalar.ToList();
		}
		private void FrmFaturaListesi_Load(object sender, EventArgs e)
		{
			try
			{
				var faturalar = from fatura in db.Faturalar
								join musteri in db.Musteriler
								on fatura.MusteriID equals musteri.MusteriID
								join proje in db.Projeler
								on fatura.ProjeID equals proje.ProjeID
								select new
								{
									fatura.FaturaID,
									MusteriAdi = musteri.AdSoyad,
									ProjeAdi = proje.ProjeAdi,
									fatura.FaturaNumarasi,
									fatura.FaturaTarihi,
									fatura.ToplamTutar,
									fatura.KDVOrani,
									fatura.OdemeDurumu,
									fatura.DurumBilgi
								};

				gridControl1.DataSource = faturalar.ToList();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Faturalar listelenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			gridView1.OptionsSelection.MultiSelect = false;
			gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
			gridView1.OptionsSelection.InvertSelection = false;
			Listele();
		}

		private void simpleButton1_Click(object sender, EventArgs e)
		{
			try
			{
				FaturaOlustur faturaOlustur = new FaturaOlustur();
				faturaOlustur.ShowDialog();

				Listele();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Yeni fatura ekleme sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
		{
			int faturaID = Convert.ToInt32(gridView1.GetFocusedRowCellValue("FaturaID"));

			FrmFaturaDetay faturaDetay = new FrmFaturaDetay();
			faturaDetay.FaturaID = faturaID;
			faturaDetay.ShowDialog();
		}

		private void BtnYenile_Click(object sender, EventArgs e)
		{
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
