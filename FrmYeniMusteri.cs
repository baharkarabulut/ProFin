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
	public partial class FrmYeniMusteri : Form
	{
		public FrmYeniMusteri()
		{
			InitializeComponent();
		}
		DbProFinEntities db = new DbProFinEntities();


		private void Listele()
		{
			try
			{
				var musteriler = db.Musteriler.Select(m => new
				{
					m.MusteriID,
					m.AdSoyad,
					m.Telefon,
					m.Eposta,
					m.Adres,
					m.Notlar
				}).ToList();

				// Verileri gridControl'e ata
				gridControl1.DataSource = musteriler;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Listeleme sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private void Temizle()
		{
			txtMusteriAdSoyad.Text = "";
			txtTelefon.Text = "";
			txtEposta.Text = "";
			memoEditAdres.Text = "";
			memoEditNotlar.Text = "";
		}

		private void BtnKaydet_Click(object sender, EventArgs e)
		{
			try
			{
				// Yeni müşteri nesnesi oluştur
				Musteriler yeniMusteri = new Musteriler
				{
					AdSoyad = txtMusteriAdSoyad.Text,
					Telefon = txtTelefon.Text,
					Eposta = txtEposta.Text,
					Adres = memoEditAdres.Text,
					Notlar = memoEditNotlar.Text
				};

				// Müşteriyi veritabanına ekle
				db.Musteriler.Add(yeniMusteri);

				// Değişiklikleri kaydet
				db.SaveChanges();

				// Kullanıcıya bilgi ver
				MessageBox.Show("Yeni müşteri başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

				// Formu temizle ve listeyi yenile
				Temizle();
				Listele();
			}
			catch (Exception ex)
			{
				// Hata durumunda kullanıcıya bilgi ver
				MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void FrmYeniMusteri_Load_1(object sender, EventArgs e)
		{
			Listele();
		}
	}
}
