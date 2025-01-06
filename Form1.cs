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
			FrmAnasayfa fr = new FrmAnasayfa();
			fr.MdiParent = this;
			fr.Show();
		}

		private void barButtonItem56_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

		}

		private void BtnYeniProje_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			FrmYeniProje YeniProje = new FrmYeniProje();
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
			FrmGelirGider GelirGiderGrafik = new FrmGelirGider();
			GelirGiderGrafik.ShowDialog();
		}

		private void BtnGelirGider_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			FrmGelirGider GelirGiderGrafik = new FrmGelirGider();
			GelirGiderGrafik.ShowDialog();
		}

		private void BtnTamamlananProjeler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			FrmTamamlananProjeler tamamlananProjeler = new FrmTamamlananProjeler();
			tamamlananProjeler.ShowDialog();
		}

		private void BtnTamamlananProje_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			FrmTamamlananProjeler tamamlananProjeler = new FrmTamamlananProjeler();
			tamamlananProjeler.ShowDialog();
		}

		private void btnDevamEdenProjeler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			FrmDevamEdenProjeler devamEdenProjeler = new FrmDevamEdenProjeler();
			devamEdenProjeler.ShowDialog();
		}

		private void btnDevamEdenProjeRapor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			FrmDevamEdenProjeler devamEdenProjeler = new FrmDevamEdenProjeler();
			devamEdenProjeler.ShowDialog();
		}

		private void btniptalEdilenProjeler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			FrmiptalEdilenProjeler iptalEdilenProjeler = new FrmiptalEdilenProjeler();
			iptalEdilenProjeler.ShowDialog();
		}

		private void btniptalEdilenProje_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			FrmiptalEdilenProjeler iptalEdilenProjeler = new FrmiptalEdilenProjeler();
			iptalEdilenProjeler.ShowDialog();
		}
	}
}
