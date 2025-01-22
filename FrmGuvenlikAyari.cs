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
	public partial class FrmGuvenlikAyari : Form
	{
		public FrmGuvenlikAyari()
		{
			InitializeComponent();
		}

		private void FrmGuvenlikAyari_Load(object sender, EventArgs e)
		{

		}

		private void btnSifreDegistir_Click(object sender, EventArgs e)
		{
			string mevcutSifre = txtMevcutSifre.Text;
			string yeniSifre = txtYeniSifre.Text;
			string yeniSifreTekrar = txtYeniSifreTekrar.Text;

			if (string.IsNullOrEmpty(mevcutSifre) || string.IsNullOrEmpty(yeniSifre) || string.IsNullOrEmpty(yeniSifreTekrar))
			{
				MessageBox.Show("Tüm alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (yeniSifre != yeniSifreTekrar)
			{
				MessageBox.Show("Yeni şifreler eşleşmiyor.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			using (var db = new DbProFinEntities())
			{
				var kullanici = db.Kullanicilar.FirstOrDefault(k => k.KullaniciID == CurrentSession.KullaniciID);
				if (kullanici != null)
				{
					if (kullanici.Sifre != mevcutSifre)
					{
						MessageBox.Show("Mevcut şifreniz hatalı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}

					kullanici.Sifre = yeniSifre;
					db.SaveChanges();
					MessageBox.Show("Şifreniz başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

					this.Close();
				}
				else
				{
					MessageBox.Show("Kullanıcı bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
	}
}
