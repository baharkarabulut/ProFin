using DevExpress.XtraGrid;
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
	public partial class FaturaOlustur : Form
	{
		public FaturaOlustur()
		{
			InitializeComponent();
		}
		DbProFinEntities db = new DbProFinEntities();

		private void BtnKaydet_Click(object sender, EventArgs e)
		{
			if (lookUpEditMusteri.EditValue == null || string.IsNullOrWhiteSpace(txtFaturaNumarasi.Text) || string.IsNullOrWhiteSpace(txtToplamTutar.Text))
			{
				MessageBox.Show("Lütfen müşteri, fatura numarası ve toplam tutar alanlarını doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			// Yeni fatura kaydı oluşturma
			Faturalar yeniFatura = new Faturalar
			{
				MusteriID = Convert.ToInt32(lookUpEditMusteri.EditValue),
				ProjeID = lookUpEditProje.EditValue != null ? Convert.ToInt32(lookUpEditProje.EditValue) : (int?)null,
				FaturaNumarasi = txtFaturaNumarasi.Text,
				FaturaTarihi = dtpFaturaTarihi.DateTime,
				ToplamTutar = decimal.Parse(txtToplamTutar.Text),
				KDVOrani = Convert.ToInt32(spinKDVOrani.EditValue),
				OdemeDurumu = cmbOdemeDurumu.SelectedItem.ToString()
			};

			db.Faturalar.Add(yeniFatura);
			db.SaveChanges();

			MessageBox.Show("Fatura başarıyla kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
			this.Close();
		}

		private void FaturaOlustur_Load(object sender, EventArgs e)
		{
			var musteriler = db.Musteriler.Select(m => new
			{
				m.MusteriID,
				m.AdSoyad
			}).ToList();
			lookUpEditMusteri.Properties.DataSource = musteriler;
			lookUpEditMusteri.Properties.DisplayMember = "AdSoyad";
			lookUpEditMusteri.Properties.ValueMember = "MusteriID";

			// Projeleri yükle
			var projeler = db.Projeler.Select(p => new
			{
				p.ProjeID,
				p.ProjeAdi
			}).ToList();
			lookUpEditProje.Properties.DataSource = projeler;
			lookUpEditProje.Properties.DisplayMember = "ProjeAdi";
			lookUpEditProje.Properties.ValueMember = "ProjeID";

			// Ödeme durumu seçenekleri
			cmbOdemeDurumu.Properties.Items.AddRange(new string[] { "Ödendi", "Ödenmedi", "Kısmi Ödendi" });

			// Varsayılan tarih
			dtpFaturaTarihi.EditValue = DateTime.Now;
		}
	}
}
