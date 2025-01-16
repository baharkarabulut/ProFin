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
	public partial class FrmMusteriProje : Form
	{
		public FrmMusteriProje()
		{
			InitializeComponent();
		}
		DbProFinEntities db = new DbProFinEntities();
		private void FrmMusteriProje_Load(object sender, EventArgs e)
		{
			var veriler = db.Musteriler.Select(m => new
			{
				m.MusteriID,
				MusteriAdi = m.AdSoyad,
				ProjeSayisi = m.Projeler.Count,
				ToplamTutar = m.Projeler.Sum(p => (decimal?)p.ToplamTutar) ?? 0,
				Projeler = m.Projeler.Select(p => new
				{
					p.ProjeID,
					p.ProjeAdi,
					p.BaslangicTarihi,
					p.BitisTarihi,
					p.TeslimTarihi,
					p.Durum,
					p.ToplamTutar,
					p.Notlar
				}).ToList()
			}).ToList();

			treeList1.DataSource = veriler;

			treeList1.Columns.Clear();

			treeList1.Columns.Add(new DevExpress.XtraTreeList.Columns.TreeListColumn
			{
				FieldName = "MusteriAdi",
				Caption = "Müşteri Adı",
				Visible = true
			});

			treeList1.Columns.Add(new DevExpress.XtraTreeList.Columns.TreeListColumn
			{
				FieldName = "ProjeSayisi",
				Caption = "Proje Sayısı",
				Visible = true
			});

			treeList1.Columns.Add(new DevExpress.XtraTreeList.Columns.TreeListColumn
			{
				FieldName = "ToplamTutar",
				Caption = "Toplam Tutar",
				Visible = true,
				Format = { FormatType = DevExpress.Utils.FormatType.Numeric, FormatString = "c2" }
			});

			lblBilgi.Text = "Bir müşteri seçiniz...";
		}

		private void treeList1_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
		{
			var selectedNode = e.Node;
			if (selectedNode != null && selectedNode.GetValue("MusteriAdi") != null)
			{
				lblBilgi.Text = $"Müşteri Adı: {selectedNode.GetValue("MusteriAdi")}\n\n" +
								$"Proje Sayısı: {selectedNode.GetValue("ProjeSayisi")}\n\n" +
								$"Toplam Tutar: {selectedNode.GetValue("ToplamTutar")}";
			}
			else
			{
				lblBilgi.Text = "Bir müşteri veya proje seçiniz...";
			}
		}
	}
}
