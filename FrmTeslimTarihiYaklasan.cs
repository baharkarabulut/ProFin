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
	public partial class FrmTeslimTarihiYaklasan : Form
	{
		public FrmTeslimTarihiYaklasan()
		{
			InitializeComponent();
		}
		DbProFinEntities db = new DbProFinEntities();

		private void FrmTeslimTarihiYaklasan_Load(object sender, EventArgs e)
		{
			TeslimTarihiYaklasanProjeleriListele();
		}

		private void TeslimTarihiYaklasanProjeleriListele()
		{
			try
			{
				DateTime bugun = DateTime.Today;
				DateTime altmisGunSonra = bugun.AddDays(60);

				var teslimTarihiYaklasanProjeler = db.Projeler
					.Where(p => p.TeslimTarihi.HasValue &&
								p.TeslimTarihi > bugun &&
								p.TeslimTarihi <= altmisGunSonra)
					.Select(p => new
					{
						p.ProjeID,
						p.ProjeAdi,
						MusteriAdi = p.Musteriler.AdSoyad,
						p.TeslimTarihi
					})
					.ToList();

				gridControlTeslimTarihiYaklasan.DataSource = teslimTarihiYaklasanProjeler;

				if (!teslimTarihiYaklasanProjeler.Any())
				{
					MessageBox.Show("Teslim tarihi 60 gün içinde yaklaşan proje bulunmamaktadır.",
									"Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

	}
}
