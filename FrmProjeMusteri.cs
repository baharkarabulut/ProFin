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
	public partial class FrmProjeMusteri : Form
	{
		public FrmProjeMusteri()
		{
			InitializeComponent();
		}
		DbProFinEntities db = new DbProFinEntities();

		private void labelControl2_Click(object sender, EventArgs e)
		{

		}
		
		private void FrmProjeMusteri_Load(object sender, EventArgs e)
		{
			var veriler = db.Projeler.Select(p => new
			{
				p.ProjeID,
				p.ProjeAdi,
				MusteriAdi = p.Musteriler.AdSoyad,
				p.BaslangicTarihi,
				p.BitisTarihi,
				p.Durum,
				p.ToplamTutar,
				p.TeslimTarihi,
				Not = p.Notlar
			}).ToList();

			treeList1.DataSource = veriler;

			treeList1.Columns.Clear();

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
				FieldName = "BaslangicTarihi",
				Caption = "Başlangıç Tarihi",
				Visible = true
			});

			treeList1.Columns.Add(new DevExpress.XtraTreeList.Columns.TreeListColumn
			{
				FieldName = "BitisTarihi",
				Caption = "Bitiş Tarihi",
				Visible = true
			});

			treeList1.Columns.Add(new DevExpress.XtraTreeList.Columns.TreeListColumn
			{
				FieldName = "TeslimTarihi",
				Caption = "Teslim Tarihi",
				Visible = true
			});

			treeList1.Columns.Add(new DevExpress.XtraTreeList.Columns.TreeListColumn
			{
				FieldName = "Durum",
				Caption = "Durum",
				Visible = true
			});

			treeList1.Columns.Add(new DevExpress.XtraTreeList.Columns.TreeListColumn
			{
				FieldName = "ToplamTutar",
				Caption = "Toplam Tutar",
				Visible = true,
				Format = { FormatType = DevExpress.Utils.FormatType.Numeric, FormatString = "c2" }
			});

			treeList1.Columns.Add(new DevExpress.XtraTreeList.Columns.TreeListColumn
			{
				FieldName = "Not",
				Caption = "Not",
				Visible = true
			});

			lblBilgi.Text = "Bir proje seçiniz...";
		}

		private void treeList1_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
		{
			var selectedNode = e.Node;
			if (selectedNode != null)
			{
				lblBilgi.Text = $"Proje Adı: {selectedNode.GetValue("ProjeAdi")}\n\n" +
								$"Müşteri Adı: {selectedNode.GetValue("MusteriAdi")}\n\n" +
								$"Başlangıç Tarihi: {selectedNode.GetValue("BaslangicTarihi")}\n\n" +
								$"Bitiş Tarihi: {selectedNode.GetValue("BitisTarihi")}\n\n" +
								$"Durum: {selectedNode.GetValue("Durum")}\n\n" +
								$"Toplam Tutar: {selectedNode.GetValue("ToplamTutar")}\n\n" +
								$"Teslim Tarihi: {selectedNode.GetValue("TeslimTarihi")}\n\n" +
								$"Not: {selectedNode.GetValue("Not")}";
			}
			else
			{
				lblBilgi.Text = "Bir proje seçiniz...";
			}
		}

		private void treeList1_CustomUnboundColumnData(object sender, DevExpress.XtraTreeList.TreeListCustomColumnDataEventArgs e)
		{
			if (e.IsGetData)
			{
				if (e.Column.FieldName == "BaslangicTarihi")
				{
					var tarih = e.Node.GetValue("BaslangicTarihi") as DateTime?;
					e.Value = tarih.HasValue ? tarih.Value.ToString("dd.MM.yyyy") : "Belirtilmedi";
				}
				else if (e.Column.FieldName == "BitisTarihi")
				{
					var tarih = e.Node.GetValue("BitisTarihi") as DateTime?;
					e.Value = tarih.HasValue ? tarih.Value.ToString("dd.MM.yyyy") : "Belirtilmedi";
				}
				else if (e.Column.FieldName == "TeslimTarihi")
				{
					var tarih = e.Node.GetValue("TeslimTarihi") as DateTime?;
					e.Value = tarih.HasValue ? tarih.Value.ToString("dd.MM.yyyy") : "Belirtilmedi";
				}
			}
		}
	}
}
