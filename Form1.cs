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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		
		private void Form1_Load(object sender, EventArgs e)
		{
			
		}

		private void barButtonItem56_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

		}

		private void BtnYeniProje_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			FrmYeniProje fr = new FrmYeniProje();
			fr.MdiParent = this;
			fr.Show();
		}

		private void BtnYeniMusteri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			FrmYeniMusteri fr = new FrmYeniMusteri();
			fr.MdiParent = this;
			fr.Show();
		}

		private void BtnProjeListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			FrmProjeListesi fr = new FrmProjeListesi();
			fr.MdiParent = this;
			fr.Show();
		}

		private void BtnYeniProje1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			FrmYeniProje fr = new FrmYeniProje();
			fr.MdiParent = this;
			fr.Show();
		}

		private void BtnMusteriListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			FrmMusteriListesi fr = new FrmMusteriListesi();
			fr.MdiParent = this;
			fr.Show();

		}

		private void BtnYeniMusteri1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			FrmYeniMusteri fr = new FrmYeniMusteri();
			fr.MdiParent = this;
			fr.Show();
		}

		private void BtnFaturaOlustur_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			FaturaOlustur faturaOlustur = new FaturaOlustur();
			faturaOlustur.ShowDialog();
		}

		private void BtnFaturaOlustur1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			FaturaOlustur faturaOlustur = new FaturaOlustur();
			faturaOlustur.ShowDialog();
		}

		private void BtnFaturaListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			FrmFaturaListesi fr = new FrmFaturaListesi();
			fr.MdiParent = this;
			fr.Show();
		}

		private void BtnFaturaDetay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			FrmFaturaListesi FaturaListesi = new FrmFaturaListesi();
			FaturaListesi.ShowDialog();

			if (FaturaListesi.SecilenFaturaID > 0)
			{
				FrmFaturaDetay frmFaturaDetay = new FrmFaturaDetay();
				frmFaturaDetay.FaturaID = FaturaListesi.SecilenFaturaID;
				frmFaturaDetay.ShowDialog();
			}
		}

		private void BtnMusteriDetay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			FrmMusteriListesi MusteriListesi = new FrmMusteriListesi();
			MusteriListesi.ShowDialog();

			if (MusteriListesi.SecilenMusteriID > 0)
			{
				FrmMusteriDetay frmMusteriDetay = new FrmMusteriDetay();
				frmMusteriDetay.MusteriID = MusteriListesi.SecilenMusteriID;
				frmMusteriDetay.ShowDialog();
			}
		}

		private void BtnProjeGuncelle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			FrmProjeListesi ProjeListesi = new FrmProjeListesi();
			ProjeListesi.ShowDialog();

			if (ProjeListesi.SecilenProjeID > 0)
			{
				FrmProjeDetay frmProjeDetay = new FrmProjeDetay();
				frmProjeDetay.ProjeID = ProjeListesi.SecilenProjeID;
				frmProjeDetay.ShowDialog();
			}
		}

		private void BtnToplamGelir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			FrmAnasayfa fr = new FrmAnasayfa();
			fr.MdiParent = this;
			fr.Show();
		}

		private void BtnGelirGider_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			FrmAnasayfa fr = new FrmAnasayfa();
			fr.MdiParent = this;
			fr.Show();
		}
	}
}
