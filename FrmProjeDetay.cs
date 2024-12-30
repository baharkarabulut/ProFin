using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProFin
{
	public partial class FrmProjeDetay : Form
	{
		public FrmProjeDetay()
		{
			InitializeComponent();
		}
		DbProFinEntities db = new DbProFinEntities();
		public int ProjeID { get; set; }
		private void FrmProjeDetay_Load(object sender, EventArgs e)
		{
			using (var db = new DbProFinEntities())
			{
				// ProjeID ile projeyi bul
				var proje = db.Projeler.FirstOrDefault(x => x.ProjeID == ProjeID);

				if (proje != null)
				{
					// Proje bilgilerini doldur
					txtProjeID.Text = proje.ProjeID.ToString();
					txtProjeAdi.Text = proje.ProjeAdi;

					// Müşteri LookUpEdit
					var musteriler = db.Musteriler
						.Select(x => new { x.MusteriID, x.AdSoyad })
						.ToList();
					lkpMusteri.Properties.DataSource = musteriler;
					lkpMusteri.Properties.DisplayMember = "AdSoyad";
					lkpMusteri.Properties.ValueMember = "MusteriID";
					lkpMusteri.EditValue = proje.MusteriID; // Seçili müşteri

					// Durum ComboBoxEdit
					cmbDurum.Properties.Items.AddRange(new string[] { "Devam Ediyor", "Tamamlandı", "İptal Edildi" });
					cmbDurum.EditValue = proje.Durum;

					// Tarihler
					if (proje.BaslangicTarihi != null)
						dtBaslangicTarihi.EditValue = proje.BaslangicTarihi;
					if (proje.BitisTarihi != null)
						dtBitisTarihi.EditValue = proje.BitisTarihi;

					// Toplam Tutar
					txtToplamTutar.Text = ((decimal)proje.ToplamTutar).ToString("C2", CultureInfo.CurrentCulture);

					// Notlar
					memoNotlar.Text = proje.Notlar;
				}
				else
				{
					MessageBox.Show("Proje bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					Close();
				}
			}
		}

		private void BtnGuncelle_Click(object sender, EventArgs e)
		{
			try
			{
				using (var db = new DbProFinEntities())
				{
					// ProjeID'yi al
					int projeID = Convert.ToInt32(txtProjeID.Text);
					var proje = db.Projeler.FirstOrDefault(x => x.ProjeID == projeID);

					if (proje != null)
					{
						// Proje bilgilerini güncelle
						proje.ProjeAdi = txtProjeAdi.Text;

						// Müşteri ID
						if (lkpMusteri.EditValue != null && int.TryParse(lkpMusteri.EditValue.ToString(), out int musteriID))
						{
							proje.MusteriID = musteriID;
						}
						else
						{
							MessageBox.Show("Geçerli bir müşteri seçin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
							return;
						}

						// Durum
						if (!string.IsNullOrEmpty(cmbDurum.Text))
						{
							proje.Durum = cmbDurum.Text;
						}
						else
						{
							MessageBox.Show("Durum seçimi boş bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
							return;
						}

						// Başlangıç Tarihi
						if (DateTime.TryParse(dtBaslangicTarihi.Text, out DateTime baslangicTarihi))
						{
							proje.BaslangicTarihi = baslangicTarihi;
						}

						// Bitiş Tarihi
						if (DateTime.TryParse(dtBitisTarihi.Text, out DateTime bitisTarihi))
						{
							proje.BitisTarihi = bitisTarihi;
						}

						// Toplam Tutar
						string toplamTutarText = txtToplamTutar.Text
							.Replace("₺", "")
							.Replace(".", "")
							.Replace(",", ".");
						if (decimal.TryParse(toplamTutarText, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out decimal toplamTutar))
						{
							proje.ToplamTutar = toplamTutar;
						}
						else
						{
							MessageBox.Show("Geçerli bir toplam tutar girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
							return;
						}

						// Notlar
						proje.Notlar = memoNotlar.Text;

						// Değişiklikleri Kaydet
						db.SaveChanges();
						MessageBox.Show("Proje başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else
					{
						MessageBox.Show("Proje bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Güncelleme sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void BtnSil_Click(object sender, EventArgs e)
		{
			try
			{
				// Seçili Projeyi Al
				int projeID = Convert.ToInt32(txtProjeID.Text);
				var proje = db.Projeler.FirstOrDefault(x => x.ProjeID == projeID);

				if (proje != null)
				{
					// Durumu "İptal Edildi" olarak değiştir
					proje.Durum = "İptal Edildi";

					// Değişiklikleri Kaydet
					db.SaveChanges();
					MessageBox.Show("Proje durumu 'İptal Edildi' olarak güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

					// Listeyi Yenilemek için Ana Forma Bilgi Gönder
					this.DialogResult = DialogResult.OK;
					this.Close();
				}
				else
				{
					MessageBox.Show("Proje bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Güncelleme sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
