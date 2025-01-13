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
	public partial class FrmGiderGir : Form
	{
		public FrmGiderGir()
		{
			InitializeComponent();
		}
		DbProFinEntities db = new DbProFinEntities();
		private void FrmGiderGir_Load(object sender, EventArgs e)
		{
			lookupKategori.Properties.DataSource = new[]
			{
				"Elektrik", "Su", "Kira", "Doğalgaz", "İnternet", "Teknik Ekipman","Personel Maaş","Telefon","Yazılım Lisansı","Pazarlama","Temizlik","Yemek", "Diğer"
			};

			lookupDurum.Properties.DataSource = new[]
			{
				"Ödenmedi", "Ödendi"
			};

			dateTarih.DateTime = DateTime.Now;
		}

		private void Temizle()
		{
			lookupKategori.EditValue = null;
			txtTutar.Clear();
			memoAciklama.Clear();
			lookupDurum.EditValue = null;
			dateTarih.DateTime = DateTime.Now;
		}

		private void btnKaydet_Click(object sender, EventArgs e)
		{
			try
			{
				if (!GirdiKontrol())
					return;

				Giderler yeniGider = new Giderler
				{
					Kategori = lookupKategori.Text,
					Tutar = Convert.ToDecimal(txtTutar.Text),
					Aciklama = memoAciklama.Text,
					OdemeDurumu = lookupDurum.Text == "Ödendi",
					Tarih = dateTarih.DateTime
				};

				db.Giderler.Add(yeniGider);
				db.SaveChanges();

				MessageBox.Show("Gider başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

				Temizle();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private bool GirdiKontrol()
		{
			if (lookupKategori.EditValue == null || string.IsNullOrWhiteSpace(lookupKategori.Text))
			{
				MessageBox.Show("Lütfen bir kategori seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}

			if (string.IsNullOrWhiteSpace(txtTutar.Text) || !decimal.TryParse(txtTutar.Text, out _))
			{
				MessageBox.Show("Lütfen geçerli bir tutar girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}

			if (string.IsNullOrWhiteSpace(memoAciklama.Text))
			{
				MessageBox.Show("Lütfen bir açıklama girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}

			if (lookupDurum.EditValue == null || string.IsNullOrWhiteSpace(lookupDurum.Text))
			{
				MessageBox.Show("Lütfen bir ödeme durumu seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}

			return true;
		}
	}
}