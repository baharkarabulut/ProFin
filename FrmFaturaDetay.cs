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
				// FaturaID ile faturayı sorgula
				var fatura = db.Faturalar.FirstOrDefault(f => f.FaturaID == FaturaID);

				if (fatura != null)
				{
					// Fatura bilgilerini doldur
					txtFaturaID.Text = fatura.FaturaID.ToString(); // FaturaID görüntülenir
					txtFaturaNumarasi.Text = fatura.FaturaNumarasi;
					txtMusteriAdi.Text = fatura.Musteriler.AdSoyad; // Eğer ilişkili bir müşteri varsa
					txtProjeAdi.Text = fatura.Projeler.ProjeAdi;    // Eğer ilişkili bir proje varsa
					txtFaturaTarihi.Text = fatura.FaturaTarihi != null
						? fatura.FaturaTarihi.Value.ToString("yyyy-MM-dd")
						: "Tarih belirtilmemiş";
					txtToplamTutar.Text = ((decimal)fatura.ToplamTutar).ToString("C2", CultureInfo.CurrentCulture);
					txtKDVOrani.Text = fatura.KDVOrani.ToString();
					txtOdemeDurumu.Text = fatura.OdemeDurumu;
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
				// Seçili Faturayı Al
				int faturaID = Convert.ToInt32(txtFaturaID.Text);
				var fatura = db.Faturalar.FirstOrDefault(x => x.FaturaID == faturaID);

				if (fatura != null)
				{
					// Güncellenecek Alanları Ayarla
					fatura.FaturaNumarasi = txtFaturaNumarasi.Text;

					// Tarih Değeri Almak
					if (DateTime.TryParse(txtFaturaTarihi.Text, out DateTime faturaTarihi))
					{
						fatura.FaturaTarihi = faturaTarihi;
					}
					else
					{
						MessageBox.Show("Lütfen geçerli bir tarih girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return;
					}

					// Toplam Tutar
					string toplamTutarText = txtToplamTutar.Text
						.Replace("₺", "")         // Para birimi simgesini temizle
						.Replace(".", "")         // Binlik ayırıcı noktaları temizle
						.Replace(",", ".");       // Virgülü noktaya çevir (ondalık format için)

					if (decimal.TryParse(toplamTutarText, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out decimal toplamTutar))
					{
						fatura.ToplamTutar = toplamTutar;
					}
					else
					{
						MessageBox.Show("Lütfen geçerli bir toplam tutar girin (örneğin: 45000.00)!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return;
					}


					// KDV Oranı
					if (int.TryParse(txtKDVOrani.Text, out int kdvOrani))
					{
						fatura.KDVOrani = kdvOrani;
					}
					else
					{
						MessageBox.Show("Lütfen geçerli bir KDV oranı girin (örneğin: 18)!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return;
					}

					// Ödeme Durumu
					fatura.OdemeDurumu = txtOdemeDurumu.Text;


					// Değişiklikleri Kaydet
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
	}
}