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
	public partial class FrmBugunTeslim : Form
	{
		public FrmBugunTeslim()
		{
			InitializeComponent();
		}
		DbProFinEntities db = new DbProFinEntities();
		private void FrmBugunTeslim_Load(object sender, EventArgs e)
		{
			BugunkuProjeleriListele();
		}

		private void BugunkuProjeleriListele()
		{
			DateTime bugunBaslangic = DateTime.Today;
			DateTime bugunBitis = bugunBaslangic.AddDays(1);

			var bugunTeslimProjeler = db.Projeler
				.Where(p => p.TeslimTarihi.HasValue &&
							p.TeslimTarihi >= bugunBaslangic &&
							p.TeslimTarihi < bugunBitis)
				.Select(p => new
				{
					p.ProjeID,
					p.ProjeAdi,
					p.Musteriler.AdSoyad,
					TeslimTarihi = p.TeslimTarihi.Value
				})
				.ToList();

			if (bugunTeslimProjeler.Any())
			{
				gridControlBugunTeslim.DataSource = bugunTeslimProjeler;
			}
			else
			{
				MessageBox.Show("Bugün teslim tarihi olan proje bulunmamaktadır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Close(); 
			}
		}


	}
}
