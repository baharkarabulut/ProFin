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
	public partial class FrmProjeListesi : Form
	{
		public FrmProjeListesi()
		{
			InitializeComponent();
		}
		DbProFinEntities db = new DbProFinEntities();
		public int SecilenProjeID { get; set; } = -1;
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
							   Durum = (proje.Durum == "1" ? "Başlanmadı" :
									   proje.Durum == "2" ? "Devam Ediyor" :
									   proje.Durum == "3" ? "Tamamlandı" : "Bilinmiyor"),
							   proje.BaslangicTarihi,
							   proje.BitisTarihi,
							   proje.ToplamTutar,
							   proje.Notlar
						   };

			gridControl1.DataSource = projeler.ToList();
		}
		private void FrmProjeListesi_Load(object sender, EventArgs e)
		{
			Listele();

			// GridView ayarları
			gridView1.OptionsSelection.MultiSelect = false;
			gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
			gridView1.OptionsSelection.InvertSelection = false;
			Listele();
		}

		private void BtnYenile_Click(object sender, EventArgs e)
		{
			Listele();
		}

		private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
		{
			int ProjeID = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ProjeID"));

			FrmProjeDetay projeDetay = new FrmProjeDetay();
			projeDetay.ProjeID = ProjeID;
			projeDetay.ShowDialog();
		}
	}
}
