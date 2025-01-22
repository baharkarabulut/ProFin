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
		DbProFinEntities db = new DbProFinEntities();
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

		private void btnKullaniciSil_Click(object sender, EventArgs e)
		{
			var selectedRow = gridView1.GetFocusedRowCellValue("KullaniciID");
			if (selectedRow != null)
			{
				int id = Convert.ToInt32(selectedRow);

				using (var db = new DbProFinEntities())
				{
					var kullanici = db.Kullanicilar.Find(id);
					if (kullanici != null)
					{
						db.Kullanicilar.Remove(kullanici);
						db.SaveChanges();

						MessageBox.Show("Kullanıcı silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
						ListeleKullanicilar();
					}
				}
			}
			else
			{
				MessageBox.Show("Lütfen silmek için bir kullanıcı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
	}
}
