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
	public partial class FrmOdenmemisFaturalar : Form
	{
		public FrmOdenmemisFaturalar()
		{
			InitializeComponent();
		}
		DbProFinEntities db = new DbProFinEntities();
		private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
		{
		
		}

		private void ListeleOdenmemisFaturalar()
		{
			var odenmemisFaturalar = (from fatura in db.Faturalar
									  where fatura.OdemeDurumu == "Ödenmedi" || fatura.OdemeDurumu == "Kısmi Ödendi"
									  select new
									  {
										  fatura.FaturaID,
										  fatura.FaturaNumarasi,
										  fatura.ToplamTutar,
										  fatura.OdemeDurumu
									  }).ToList();

			gridControl1.DataSource = odenmemisFaturalar;

			gridView1.Columns["FaturaID"].Caption = "Fatura ID";
			gridView1.Columns["FaturaNumarasi"].Caption = "Fatura No";
			gridView1.Columns["ToplamTutar"].Caption = "Toplam Tutar";
			gridView1.Columns["OdemeDurumu"].Caption = "Ödeme Durumu";

			gridView1.Columns["FaturaID"].Width = 80;
			gridView1.Columns["FaturaNumarasi"].Width = 120;
			gridView1.Columns["ToplamTutar"].Width = 120;
			gridView1.Columns["OdemeDurumu"].Width = 120;
		}
		private void FrmOdenmemisFaturalar_Load(object sender, EventArgs e)
		{
			ListeleOdenmemisFaturalar();
		}

		private void btnOdemeYap_Click(object sender, EventArgs e)
		{
			// GroupBox'taki bilgileri kontrol et
			if (string.IsNullOrWhiteSpace(txtFaturaID.Text))
			{
				MessageBox.Show("Lütfen ödeme yapmak için bir fatura seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			int faturaID = Convert.ToInt32(txtFaturaID.Text);

			// Faturayı bul ve ödeme durumunu güncelle
			var fatura = db.Faturalar.FirstOrDefault(f => f.FaturaID == faturaID);

			if (fatura != null)
			{
				fatura.OdemeDurumu = "Ödendi";
				db.SaveChanges();

				MessageBox.Show($"Fatura (ID: {faturaID}) ödendi olarak güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

				// Güncellenen listeyi yeniden yükle
				ListeleOdenmemisFaturalar();
			}
			else
			{
				MessageBox.Show("Fatura bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{
			// Seçili satırdan bilgileri al
			if (gridView1.GetFocusedRowCellValue("FaturaID") != null)
			{
				int faturaID = Convert.ToInt32(gridView1.GetFocusedRowCellValue("FaturaID"));
				string faturaNumarasi = gridView1.GetFocusedRowCellValue("FaturaNumarasi").ToString();
				decimal toplamTutar = Convert.ToDecimal(gridView1.GetFocusedRowCellValue("ToplamTutar"));
				string odemeDurumu = gridView1.GetFocusedRowCellValue("OdemeDurumu").ToString();

				// GroupBox içindeki etiketlere aktar
				txtFaturaID.Text = faturaID.ToString();
				txtFaturaNumarasi.Text = faturaNumarasi;
				txtToplamTutar.Text = $"{toplamTutar:C2}"; // Para birimi formatında göster
				txtOdemeDurumu.Text = odemeDurumu;
			}
		}
	}
}
