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
	public partial class FrmKullaniciEkle : Form
	{
		public FrmKullaniciEkle()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void btnKaydet_Click(object sender, EventArgs e)
		{
			using (var db = new DbProFinEntities())
			{
				var yeniKullanici = new Kullanicilar
				{
					AdSoyad = txtAdSoyad.Text,
					KullaniciAdi = txtKullaniciAdi.Text,
					Sifre = txtSifre.Text,
					Eposta = txtEposta.Text,
					Rol = cmbRol.SelectedItem.ToString()
				};

				db.Kullanicilar.Add(yeniKullanici);
				db.SaveChanges();

				MessageBox.Show("Kullanıcı başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

				KullaniciEklendi?.Invoke();

				this.Close();
			}
		}
		public event Action KullaniciEklendi;

		private void FrmKullaniciEkle_Load(object sender, EventArgs e)
		{

		}
	}
}
