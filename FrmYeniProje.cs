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
							   proje.TeslimTarihi,
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
							   proje.ProjeID,
							   proje.ProjeAdi,
							   MusteriAdi = musteri.AdSoyad,
							   Durum = (proje.Durum == "Başlanmadı" ? "Başlanmadı" :
									   proje.Durum == "Devam Ediyor" ? "Devam Ediyor" :
									   proje.Durum == "Tamamlandı" ? "Tamamlandı" :
									   proje.Durum == "İptal Edildi" ? "İptal Edildi" : "Bilinmiyor"),
							   proje.BaslangicTarihi,
							   proje.BitisTarihi,
							   proje.ToplamTutar,
							   proje.TeslimTarihi,
							   proje.Notlar
						   };

			gridControl1.DataSource = projeler.ToList();

			lookUpEditMusteri.Properties.DisplayMember = "AdSoyad";
			lookUpEditMusteri.Properties.ValueMember = "MusteriID";
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
				dtpTeslimTarihi.EditValue = proje.TeslimTarihi;
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
				TeslimTarihi = dtpTeslimTarihi.DateTime,
				Notlar = memoEditNotlar.Text
			};
			DateTime baslangicTarihi = dtpBaslangicTarihi.DateTime; 
			DateTime bitisTarihi = dtpBitisTarihi.DateTime;
			DateTime teslimTarihi = dtpTeslimTarihi.DateTime;
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
