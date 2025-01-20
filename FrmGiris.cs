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
	public partial class FrmGiris : Form
	{
		public FrmGiris()
		{
			InitializeComponent();
		}

		private void FrmGiris_Load(object sender, EventArgs e)
		{

		}

		private void btnGiris_Click(object sender, EventArgs e)
		{
			string kullaniciAdi = txtKullaniciAdi.Text.Trim();
			string sifre = txtSifre.Text.Trim();

			using (var db = new DbProFinEntities())
			{
				var kullanici = db.Kullanicilar
					.FirstOrDefault(k => k.KullaniciAdi == kullaniciAdi && k.Sifre == sifre);

				if (kullanici != null)
				{
					CurrentSession.KullaniciID = kullanici.KullaniciID;
					CurrentSession.KullaniciAdi = kullanici.KullaniciAdi;
					CurrentSession.AdSoyad = kullanici.AdSoyad;
					CurrentSession.Eposta = kullanici.Eposta;
					CurrentSession.Rol = kullanici.Rol;

					Form1 anasayfa = new Form1();
					anasayfa.Show();
					this.Hide();
				}
				else
				{
					MessageBox.Show("Hatalı kullanıcı adı veya şifre.", "Giriş Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
	}
}
