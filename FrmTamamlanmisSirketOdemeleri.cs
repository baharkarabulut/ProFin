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
	public partial class FrmTamamlanmisSirketOdemeleri : Form
	{
		public FrmTamamlanmisSirketOdemeleri()
		{
			InitializeComponent();
		}
		DbProFinEntities db = new DbProFinEntities();
		private void FrmTamamlanmisSirketOdemeleri_Load(object sender, EventArgs e)
		{
			OdenenGiderleriListele();
		}

		private void OdenenGiderleriListele()
		{
			try
			{
				var odenenGiderler = db.Giderler
					.Where(g => g.OdemeDurumu == true)
					.Select(g => new
					{
						g.GiderID,
						g.Kategori,
						g.Tutar,
						g.Tarih,
						g.Aciklama
					}).ToList();

				gridControl1.DataSource = odenenGiderler;

				lblOdenmeyenSayisi.Text = $"Toplam Ödenen Giderler: {odenenGiderler.Count} adet fatura";
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
