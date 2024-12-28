using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ProFin
{
	public partial class FrmYeniProje : Form
	{
		public FrmYeniProje()
		{
			InitializeComponent();
		}
		DbProFinEntities db = new DbProFinEntities();


		private void Listele()
		{
			var projeler = from proje in db.Projeler
						   join musteri in db.Musteriler
						   on proje.MusteriID equals musteri.MusteriID
						   select new
						   {
							   proje.ProjeID,
							   proje.ProjeAdi,
							   MusteriAdi = musteri.AdSoyad,
							   proje.Durum,
							   proje.BaslangicTarihi,
							   proje.BitisTarihi,
							   proje.ToplamTutar,
							   proje.Notlar
						   };

			gridControl1.DataSource = projeler.ToList();
		}

		private void FrmYeniProje_Load(object sender, EventArgs e)
		{
			var projeler = from proje in db.Projeler
						   join musteri in db.Musteriler
						   on proje.MusteriID equals musteri.MusteriID
						   select new
						   {
							   proje.ProjeAdi,
							   MusteriAdi = musteri.AdSoyad,
							   Durum = (string.IsNullOrEmpty(proje.Durum) ? "Bilinmiyor" :
		 proje.Durum == "1" ? "Başlanmadı" :
		 proje.Durum == "2" ? "Devam Ediyor" :
		 proje.Durum == "3" ? "Tamamlandı" : "Bilinmiyor"),
							   proje.BaslangicTarihi,
							   proje.BitisTarihi,
							   proje.ToplamTutar,
							   proje.Notlar
						   };

			gridControl1.DataSource = projeler.ToList();

			var musteriler = db.Musteriler.Select(m => new
			{
				m.MusteriID,
				m.AdSoyad
			}).ToList();

			lookUpEditMusteri.Properties.DataSource = musteriler;
			lookUpEditMusteri.Properties.DisplayMember = "AdSoyad";
			lookUpEditMusteri.Properties.ValueMember = "MusteriID";
			lookUpEditMusteri.Properties.NullText = "Bir müşteri seçin";

			cmbDurum.Properties.Items.AddRange(new string[] { "Başlanmadı", "Devam Ediyor", "Tamamlandı" });
		}

		private void gridControl1_Click(object sender, EventArgs e)
		{
			int projeID = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ProjeID"));
			var proje = db.Projeler.FirstOrDefault(x => x.ProjeID == projeID);

			if (proje != null)
			{
				txtProjeAdi.Text = proje.ProjeAdi;
				lookUpEditMusteri.EditValue = proje.MusteriID;
				cmbDurum.SelectedItem = proje.Durum;
				dtpBaslangicTarihi.EditValue = proje.BaslangicTarihi;
				dtpBitisTarihi.EditValue = proje.BitisTarihi;
				txtToplamTutar.Text = proje.ToplamTutar.ToString();
				memoEditNotlar.Text = proje.Notlar;
			}
		}

		private void BtnKaydet_Click(object sender, EventArgs e)
		{
			Projeler yeniProje = new Projeler
			{
				ProjeAdi = txtProjeAdi.Text,
				MusteriID = Convert.ToInt32(lookUpEditMusteri.EditValue),
				Durum = cmbDurum.SelectedItem.ToString(),
				BaslangicTarihi = dtpBaslangicTarihi.DateTime, 
				BitisTarihi = dtpBitisTarihi.DateTime,
				ToplamTutar = decimal.Parse(txtToplamTutar.Text),
				Notlar = memoEditNotlar.Text
			};
			DateTime baslangicTarihi = dtpBaslangicTarihi.DateTime; 
			DateTime bitisTarihi = dtpBitisTarihi.DateTime;         
			if (baslangicTarihi > bitisTarihi)
			{
				MessageBox.Show("Bitiş tarihi başlangıç tarihinden önce olamaz!", "Tarih Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			db.Projeler.Add(yeniProje);
			db.SaveChanges();

			MessageBox.Show("Yeni proje başarıyla kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void BtnYenile_Click(object sender, EventArgs e)
		{
			Listele();
		}
	}
}
