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
	public partial class FrmOdenmeyenGiderler : Form
	{
		public FrmOdenmeyenGiderler()
		{
			InitializeComponent();
		}
		DbProFinEntities db = new DbProFinEntities();

		private void FrmOdenmeyenGiderler_Load(object sender, EventArgs e)
		{
			OdenmeyenGiderleriListele();
		}

		private void OdenmeyenGiderleriListele()
		{
			try
			{
				var odenmeyenGiderler = db.Giderler
					.Where(g => g.OdemeDurumu == false) 
					.Select(g => new
					{
						g.GiderID,
						g.Kategori,
						g.Tutar,
						g.Tarih,
						g.Aciklama
					}).ToList();

				gridControl1.DataSource = odenmeyenGiderler;

				lblOdenmeyenSayisi.Text = $"Toplam Ödenmesi Gereken: {odenmeyenGiderler.Count} adet fatura";
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			gridView1.Columns["Kategori"].Caption = "Kategori";
			gridView1.Columns["Tutar"].Caption = "Tutar (₺)";
			gridView1.Columns["Tarih"].Caption = "Tarih";
			gridView1.Columns["Aciklama"].Caption = "Açıklama";

			gridView1.Columns["Kategori"].Width = 150;
			gridView1.Columns["Tutar"].Width = 100;
			gridView1.Columns["Tarih"].Width = 120;
			gridView1.Columns["Aciklama"].Width = 250;
		}
	}
}
