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
	}
}
