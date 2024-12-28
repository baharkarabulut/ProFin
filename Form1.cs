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
			FrmYeniProje YeniProje= new FrmYeniProje();
			YeniProje.ShowDialog(); 
		}

		private void BtnYeniMusteri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			FrmYeniMusteri YeniMusteri = new FrmYeniMusteri();
			YeniMusteri.ShowDialog();
		}

		private void BtnProjeListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			FrmProjeListesi ProjeListesi = new FrmProjeListesi();
			ProjeListesi.ShowDialog();
		}

		private void BtnYeniProje1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			FrmYeniProje YeniProje = new FrmYeniProje();
			YeniProje.ShowDialog();
		}

		private void BtnMusteriListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			FrmMusteriListesi MusteriListesi = new FrmMusteriListesi();
			MusteriListesi.ShowDialog();
		}

		private void BtnYeniMusteri1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			FrmYeniMusteri YeniMusteri = new FrmYeniMusteri();
			YeniMusteri.ShowDialog();
		}

		private void BtnFaturaOlustur_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			FaturaOlustur YeniFaturaOlustur = new FaturaOlustur();
			YeniFaturaOlustur.ShowDialog();
		}

		private void BtnFaturaOlustur1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			FaturaOlustur YeniFaturaOlustur = new FaturaOlustur();
			YeniFaturaOlustur.ShowDialog();
		}

		private void BtnFaturaListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			FrmFaturaListesi FaturaListesi = new FrmFaturaListesi();
			FaturaListesi.ShowDialog();
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
	}
}
