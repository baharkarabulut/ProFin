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
	public partial class FrmMusteriListesi : Form
	{
		public FrmMusteriListesi()
		{
			InitializeComponent();
		}
		DbProFinEntities db = new DbProFinEntities();
		public int SecilenMusteriID { get; set; } = -1;
		private void Listele()
		{
			var musteriler = from musteri in db.Musteriler
							 select new
							 {
								 musteri.MusteriID,
								 musteri.AdSoyad,
								 musteri.Telefon,
								 musteri.Eposta,
								 musteri.Adres,
								 musteri.Notlar
							 };

			gridControl1.DataSource = musteriler.ToList();
		}
		private void FrmMusteriListesi_Load(object sender, EventArgs e)
		{
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
			int musteriID = Convert.ToInt32(gridView1.GetFocusedRowCellValue("MusteriID"));
			FrmMusteriDetay musteriDetay = new FrmMusteriDetay();
			musteriDetay.MusteriID = musteriID; // Detay formuna ID'yi geçiyoruz.
			musteriDetay.ShowDialog();
			Listele();
		}
	}
}
