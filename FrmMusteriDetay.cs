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
	public partial class FrmMusteriDetay : Form
	{
		public FrmMusteriDetay()
		{
			InitializeComponent();
		}
		DbProFinEntities db = new DbProFinEntities();
		public int MusteriID { get; set; }
	

		private void FrmMusteriDetay_Load(object sender, EventArgs e)
		{
			using (var db = new DbProFinEntities())
			{
				var musteri = db.Musteriler.FirstOrDefault(x => x.MusteriID == MusteriID);
				if (musteri != null)
				{
					txtMusteriID.Text = musteri.MusteriID.ToString();
					txtMusteriAdi.Text = musteri.AdSoyad;
					txtTelefon.Text = musteri.Telefon;
					txtEmail.Text = musteri.Eposta;
					txtAdres.Text = musteri.Adres;
					txtNotlar.Text = musteri.Notlar;
				}
				else
				{
					MessageBox.Show("Müşteri bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					Close();
				}
			}
		}

		private void BtnMusteriGuncelle_Click_1(object sender, EventArgs e)
		{
			try
			{
				int musteriID = Convert.ToInt32(txtMusteriID.Text);
				var musteri = db.Musteriler.FirstOrDefault(x => x.MusteriID == musteriID);


				if (musteri != null)
				{
					musteri.AdSoyad = txtMusteriAdi.Text;
					musteri.Telefon = txtTelefon.Text;
					musteri.Eposta = txtEmail.Text;
					musteri.Adres = txtAdres.Text;
					musteri.Notlar = txtNotlar.Text;

					db.SaveChanges();
					MessageBox.Show("Müşteri başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("Müşteri bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}

			catch (Exception ex)
			{
				MessageBox.Show($"Güncelleme sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
