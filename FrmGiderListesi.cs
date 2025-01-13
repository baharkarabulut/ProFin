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
	public partial class FrmGiderListesi : Form
	{
		public FrmGiderListesi()
		{
			InitializeComponent();
		}
		DbProFinEntities db = new DbProFinEntities();
		private void FrmGiderListesi_Load(object sender, EventArgs e)
		{
			GiderleriListele();
		}

		private void GiderleriListele()
		{
			try
			{
				var giderListesi = db.Giderler.Select(g => new
				{
					g.GiderID,
					g.Kategori,
					g.Tutar,
					g.Tarih,
					g.Aciklama,
					Durum = g.OdemeDurumu.HasValue && g.OdemeDurumu.Value ? "Ödendi" : "Ödenmedi"
				}).ToList();

				gridControl1.DataSource = giderListesi;
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Giderler yüklenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

	}
}
