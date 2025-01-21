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
	public partial class FrmKullaniciBilgi : Form
	{
		public FrmKullaniciBilgi()
		{
			InitializeComponent();
		}

		private void FrmKullaniciBilgi_Load(object sender, EventArgs e)
		{
			ListeleKullanicilar();
		}

		private void ListeleKullanicilar()
		{
			using (var db = new DbProFinEntities())
			{
				var kullanicilar = db.Kullanicilar
					.Select(k => new
					{
						k.KullaniciID,
						k.AdSoyad,
						k.KullaniciAdi,
						k.Rol
					}).ToList();

				gridControl1.DataSource = kullanicilar;
			}
		}

		private void btnKullaniciEkle_Click(object sender, EventArgs e)
		{
			FrmKullaniciEkle ekle = new FrmKullaniciEkle();
			ekle.KullaniciEklendi += () =>
			{
				ListeleKullanicilar(); 
			};
			ekle.ShowDialog();
		}
	}
}
