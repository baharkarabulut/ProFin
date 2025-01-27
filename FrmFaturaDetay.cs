﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using DevExpress.XtraGrid;
using DevExpress.XtraPrinting;
using System.Drawing.Printing;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Kernel.Font;
using System.IO;
namespace ProFin
{
	public partial class FrmFaturaDetay : Form
	{
		public FrmFaturaDetay()
		{
			InitializeComponent();
		}
		public int FaturaID { get; set; }
		DbProFinEntities db = new DbProFinEntities();
		

		private void FrmFaturaDetay_Load(object sender, EventArgs e)
		{
			using (var db = new DbProFinEntities())
			{
				var fatura = db.Faturalar.FirstOrDefault(f => f.FaturaID == FaturaID);

				if (fatura != null)
				{
					txtFaturaID.Text = fatura.FaturaID.ToString(); 
					txtFaturaNumarasi.Text = fatura.FaturaNumarasi;
					txtMusteriAdi.Text = fatura.Musteriler.AdSoyad; 
					txtProjeAdi.Text = fatura.Projeler.ProjeAdi; 
					txtFaturaTarihi.Text = fatura.FaturaTarihi != null
						? fatura.FaturaTarihi.Value.ToString("yyyy-MM-dd")
						: "Tarih belirtilmemiş";
					txtToplamTutar.Text = ((decimal)fatura.ToplamTutar).ToString("C2", CultureInfo.CurrentCulture);
					txtKDVOrani.Text = fatura.KDVOrani.ToString();
					txtOdemeDurumu.Text = fatura.OdemeDurumu;
					txtDurumBilgi.Text = fatura.DurumBilgi;
				}
				else
				{
					MessageBox.Show("Fatura bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					Close();
				}
			}
		}

		private void BtnGuncelle_Click(object sender, EventArgs e)
		{
			try
			{
				int faturaID = Convert.ToInt32(txtFaturaID.Text);
				var fatura = db.Faturalar.FirstOrDefault(x => x.FaturaID == faturaID);

				if (fatura != null)
				{
					fatura.FaturaNumarasi = txtFaturaNumarasi.Text;

					if (DateTime.TryParse(txtFaturaTarihi.Text, out DateTime faturaTarihi))
					{
						fatura.FaturaTarihi = faturaTarihi;
					}
					else
					{
						MessageBox.Show("Lütfen geçerli bir tarih girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return;
					}

					string toplamTutarText = txtToplamTutar.Text
						.Replace("₺", "")      
						.Replace(".", "")         
						.Replace(",", ".");      

					if (decimal.TryParse(toplamTutarText, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out decimal toplamTutar))
					{
						fatura.ToplamTutar = toplamTutar;
					}
					else
					{
						MessageBox.Show("Lütfen geçerli bir toplam tutar girin (örneğin: 45000.00)!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return;
					}

					if (int.TryParse(txtKDVOrani.Text, out int kdvOrani))
					{
						fatura.KDVOrani = kdvOrani;
					}
					else
					{
						MessageBox.Show("Lütfen geçerli bir KDV oranı girin (örneğin: 18)!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return;
					}

					fatura.OdemeDurumu = txtOdemeDurumu.Text;
					fatura.DurumBilgi = txtDurumBilgi.Text;

					db.SaveChanges();

					MessageBox.Show("Fatura başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("Fatura bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Güncelleme sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void btnIptalEt_Click(object sender, EventArgs e)
		{
			try
			{
				int faturaId = Convert.ToInt32(txtFaturaID.Text); 

				using (var dbContext = new DbProFinEntities()) 
				{
					var fatura = dbContext.Faturalar.FirstOrDefault(f => f.FaturaID == faturaId); 

					if (fatura != null)
					{
						if (fatura.DurumBilgi == "Geçerli")
						{
							fatura.DurumBilgi = "İptal Edildi";  
							dbContext.SaveChanges(); 

							MessageBox.Show("Fatura başarıyla iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

							
						}
						else
						{
							MessageBox.Show("Bu fatura zaten iptal edilmiştir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						}
					}
					else
					{
						MessageBox.Show("Fatura bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"İptal işlemi sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnYazdir_Click(object sender, EventArgs e)
		{
			YazdirFaturaDetay();
		}
		private void YazdirFaturaDetay()
		{
			PrintDocument printDocument = new PrintDocument();
			printDocument.PrintPage += new PrintPageEventHandler(FaturaDetay_PrintPage);

			PrintDialog printDialog = new PrintDialog
			{
				Document = printDocument
			};

			if (printDialog.ShowDialog() == DialogResult.OK)
			{
				printDocument.Print();
			}
		}

		private void FaturaDetay_PrintPage(object sender, PrintPageEventArgs e)
		{
			Graphics g = e.Graphics;
			float yPosition = 20;
			float leftMargin = e.MarginBounds.Left;
			Font font = new Font("Arial", 14);

			g.DrawString("Fatura Detayları", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, leftMargin, yPosition);
			yPosition += 40;

			g.DrawString($"Fatura ID: {txtFaturaID.Text}", font, Brushes.Black, leftMargin, yPosition);
			yPosition += 30;
			g.DrawString($"Fatura Numarası: {txtFaturaNumarasi.Text}", font, Brushes.Black, leftMargin, yPosition);
			yPosition += 30;
			g.DrawString($"Müşteri Adı: {txtMusteriAdi.Text}", font, Brushes.Black, leftMargin, yPosition);
			yPosition += 30;
			g.DrawString($"Proje Adı: {txtProjeAdi.Text}", font, Brushes.Black, leftMargin, yPosition);
			yPosition += 30;
			g.DrawString($"Fatura Tutarı: {txtToplamTutar.Text}", font, Brushes.Black, leftMargin, yPosition);
			yPosition += 30;
			g.DrawString($"KDV Oranı: {txtKDVOrani.Text}", font, Brushes.Black, leftMargin, yPosition);
			yPosition += 30;
			g.DrawString($"Fatura Tarihi: {txtFaturaTarihi.Text}", font, Brushes.Black, leftMargin, yPosition);
			yPosition += 40;

			g.DrawString("Teşekkür ederiz!", new Font("Arial", 16, FontStyle.Italic), Brushes.Black, leftMargin, yPosition);
		}

		private void btnPdfAktar_Click(object sender, EventArgs e)
		{
			PdfAktarFaturaDetay();
		}
		private void PdfAktarFaturaDetay()
		{
			using (SaveFileDialog saveFileDialog = new SaveFileDialog())
			{
				saveFileDialog.Filter = "PDF Dosyası (*.pdf)|*.pdf"; 
				saveFileDialog.Title = "Faturayı Kaydet"; 
				saveFileDialog.FileName = "FaturaDetaylari.pdf"; 

				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					string dosyaYolu = saveFileDialog.FileName; 

					try
					{
						using (PdfWriter writer = new PdfWriter(dosyaYolu))
						{
							using (PdfDocument pdf = new PdfDocument(writer))
							{
								iText.Layout.Document document = new iText.Layout.Document(pdf);

								PdfFont helveticaBold = PdfFontFactory.CreateFont("Helvetica-Bold");
								document.Add(new Paragraph("Fatura Detayları")
									.SetFont(helveticaBold)
									.SetFontSize(18)
									.SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER));

								document.Add(new Paragraph("\n"));

								PdfFont regularFont = PdfFontFactory.CreateFont("Helvetica");
								document.Add(new Paragraph($"Fatura ID: {txtFaturaID.Text}")
									.SetFont(regularFont)
									.SetFontSize(12));
								document.Add(new Paragraph($"Fatura Numarası: {txtFaturaNumarasi.Text}")
									.SetFont(regularFont)
									.SetFontSize(12));
								document.Add(new Paragraph($"Müşteri Adı: {txtMusteriAdi.Text}")
									.SetFont(regularFont)
									.SetFontSize(12));
								document.Add(new Paragraph($"Proje Adı: {txtProjeAdi.Text}")
									.SetFont(regularFont)
									.SetFontSize(12));
								document.Add(new Paragraph($"Fatura Tutarı: {txtToplamTutar.Text}")
									.SetFont(regularFont)
									.SetFontSize(12));
								document.Add(new Paragraph($"KDV Oranı: {txtKDVOrani.Text}")
									.SetFont(regularFont)
									.SetFontSize(12));
								document.Add(new Paragraph($"Fatura Tarihi: {txtFaturaTarihi.Text}")
									.SetFont(regularFont)
									.SetFontSize(12));

								document.Add(new Paragraph("\n"));

								PdfFont helveticaOblique = PdfFontFactory.CreateFont("Helvetica-Oblique");
								document.Add(new Paragraph("Teşekkür ederiz!")
									.SetFont(helveticaOblique)
									.SetFontSize(16)
									.SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER));

							}
						}

						if (new FileInfo(dosyaYolu).Length == 0)
						{
							MessageBox.Show("Dosya oluşturulurken bir hata oluştu. PDF dosyası boş.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
						else
						{
							MessageBox.Show($"Fatura detayları {dosyaYolu} dosyasına kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

							System.Diagnostics.Process.Start(dosyaYolu);
						}
					}
					catch (IOException ioEx)
					{
						MessageBox.Show($"Dosya işlemi sırasında hata oluştu: {ioEx.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					catch (iText.Kernel.Exceptions.PdfException pdfEx)
					{
						MessageBox.Show($"PDF yazarken hata oluştu: {pdfEx.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					catch (Exception ex)
					{
						MessageBox.Show($"Beklenmeyen bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}



	}
}
