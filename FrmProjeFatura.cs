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
	public partial class FrmProjeFatura : Form
	{
		public FrmProjeFatura()
		{
			InitializeComponent();
		}
		DbProFinEntities db = new DbProFinEntities();
		private void FrmProjeFatura_Load(object sender, EventArgs e)
		{
			// Veritabanından projeye bağlı fatura bilgilerini çekiyoruz.
			var veriler = db.Faturalar.Select(f => new
			{
				f.FaturaID,
				ProjeAdi = f.Projeler.ProjeAdi,
				MusteriAdi = f.Projeler.Musteriler.AdSoyad,
				f.FaturaNumarasi,
				f.FaturaTarihi,
				f.KDVOrani,
				f.OdemeDurumu,
				f.IsDeleted,
				f.DurumBilgi
			}).ToList();

			// TreeList'e veri bağlama
			treeList1.DataSource = veriler;

			// Sütunları temizleyip yeniden ekliyoruz
			treeList1.Columns.Clear();

			treeList1.Columns.Add(new DevExpress.XtraTreeList.Columns.TreeListColumn
			{
				FieldName = "FaturaNumarasi",
				Caption = "Fatura No",
				Visible = true
			});

			treeList1.Columns.Add(new DevExpress.XtraTreeList.Columns.TreeListColumn
			{
				FieldName = "ProjeAdi",
				Caption = "Proje Adı",
				Visible = true
			});

			treeList1.Columns.Add(new DevExpress.XtraTreeList.Columns.TreeListColumn
			{
				FieldName = "MusteriAdi",
				Caption = "Müşteri Adı",
				Visible = true
			});

			treeList1.Columns.Add(new DevExpress.XtraTreeList.Columns.TreeListColumn
			{
				FieldName = "FaturaTarihi",
				Caption = "Tarih",
				Visible = true,
				UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.DateTime
			});
			treeList1.Columns.Add(new DevExpress.XtraTreeList.Columns.TreeListColumn
			{
				FieldName = "KDVOrani",
				Caption = "KDV Oranı",
				Visible = true
			});

			treeList1.Columns.Add(new DevExpress.XtraTreeList.Columns.TreeListColumn
			{
				FieldName = "OdemeDurumu",
				Caption = "Ödeme Durumu",
				Visible = true
			});

			treeList1.Columns.Add(new DevExpress.XtraTreeList.Columns.TreeListColumn
			{
				FieldName = "IsDeleted",
				Caption = "Silindi mi?",
				Visible = true
			});

			treeList1.Columns.Add(new DevExpress.XtraTreeList.Columns.TreeListColumn
			{
				FieldName = "DurumBilgi",
				Caption = "Durum Bilgisi",
				Visible = true
			});

			lblBilgi.Text = "Bir fatura seçiniz...";
		}

		private void treeList1_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
		{
			var selectedNode = e.Node;
			if (selectedNode != null)
			{
				lblBilgi.Text = $"Fatura No: {selectedNode.GetValue("FaturaNumarasi")}\n\n" +
								$"Proje Adı: {selectedNode.GetValue("ProjeAdi")}\n\n" +
								$"Müşteri Adı: {selectedNode.GetValue("MusteriAdi")}\n\n" +
								$"Tarih: {selectedNode.GetValue("FaturaTarihi")}\n\n" +
								$"KDV Oranı: %{selectedNode.GetValue("KDVOrani")}\n\n" +
					$"Ödeme Durumu: {selectedNode.GetValue("OdemeDurumu")}\n\n" +
					$"Silindi mi?: {(Convert.ToBoolean(selectedNode.GetValue("IsDeleted")) ? "Evet" : "Hayır")}\n\n" +
					$"Durum Bilgisi: {selectedNode.GetValue("DurumBilgi")}\n\n";

			}

			else
				{
					lblBilgi.Text = "Bir fatura seçiniz...";
				}
			}

		private void treeList1_CustomUnboundColumnData(object sender, DevExpress.XtraTreeList.TreeListCustomColumnDataEventArgs e)
		{
			if (e.IsGetData)
			{
				if (e.Column.FieldName == "FaturaTarihi")
				{
					var tarih = e.Node.GetValue("FaturaTarihi") as DateTime?;
					e.Value = tarih.HasValue ? tarih.Value.ToString("dd.MM.yyyy") : "Belirtilmedi";
				}
			}
		}
	}
}
