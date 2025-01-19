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
			ApplySavedTheme();
		}
		private void ApplySavedTheme()
		{
			var savedTheme = Properties.Settings.Default.Theme;
			if (!string.IsNullOrEmpty(savedTheme))
			{
				DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(savedTheme);
			}
			else
			{
				DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("The Bezier"); 
			}
		}
		private void barButtonItem56_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			FrmGiderListesi giderListesi = new FrmGiderListesi();
			giderListesi.ShowDialog();
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

		private void btnOdenmemisFatura_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			FrmOdenmemisFaturalar odenmemisFaturalar = new FrmOdenmemisFaturalar();
			odenmemisFaturalar.ShowDialog();
		}

		private void btnOdenmemisFaturalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			FrmOdenmemisFaturalar odenmemisFaturalar = new FrmOdenmemisFaturalar();
			odenmemisFaturalar.ShowDialog();
		}

		private void btnOdenmemisFaturalar1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			FrmOdenmemisFaturalar odenmemisFaturalar = new FrmOdenmemisFaturalar();
			odenmemisFaturalar.ShowDialog();
		}

		private void btnMusteriAnalizi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			FrmMusteriAnalizi musteriAnalizi = new FrmMusteriAnalizi();
			musteriAnalizi.Show();
		}

		private void btnEtkilesimGecmisi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			FrmEtkilesimGecmisi etkilesimGecmisi = new FrmEtkilesimGecmisi();
			etkilesimGecmisi.Show();
		}

		private void btnBugunTeslim_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			FrmBugunTeslim frmBugunTeslim = new FrmBugunTeslim();
			frmBugunTeslim.ShowDialog();
		}

		private void btnTeslimTarihiYaklasan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			FrmTeslimTarihiYaklasan frmTeslimTarihiYaklasan= new FrmTeslimTarihiYaklasan();
			frmTeslimTarihiYaklasan.ShowDialog();
		}

		private void BtnTamamlananProjeler1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			FrmTamamlananProjeler tamamlananProjeler = new FrmTamamlananProjeler();
			tamamlananProjeler.ShowDialog();
		}

		private void btnDevamEdenProjeler1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			FrmDevamEdenProjeler devamEdenProjeler = new FrmDevamEdenProjeler();
			devamEdenProjeler.ShowDialog();
		}

		private void btniptalEdilenProjeler1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			FrmiptalEdilenProjeler iptalEdilenProjeler = new FrmiptalEdilenProjeler();
			iptalEdilenProjeler.ShowDialog();
		}

		private void btnGiderGir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			FrmGiderGir giderGir = new FrmGiderGir();
			giderGir.ShowDialog();
		}

		private void btnGiderListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			FrmGiderListesi giderListesi = new FrmGiderListesi();
			giderListesi.ShowDialog();
		}

		private void btnOdenmeyenGiderler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			FrmOdenmeyenGiderler frm = new FrmOdenmeyenGiderler();
			frm.ShowDialog();
		}

		private void btnOdenmeyenGiderler1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			FrmOdenmeyenGiderler frm = new FrmOdenmeyenGiderler();
			frm.ShowDialog();
		}

		private void btnOdenmeyenGiderler2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			FrmOdenmeyenGiderler frm = new FrmOdenmeyenGiderler();
			frm.ShowDialog();
		}

		private void btnTamamlanmisSirketOdemeleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			FrmTamamlanmisSirketOdemeleri frm = new FrmTamamlanmisSirketOdemeleri();
			frm.ShowDialog();
		}

		private void BtnProjeTakvimi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			FrmProjeTakvimi frm = new FrmProjeTakvimi();
			frm.ShowDialog();
		}

		private void BtnProjeMusteri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			FrmProjeMusteri frm = new FrmProjeMusteri();
			frm.ShowDialog();
		}

		private void BtnProjeFatura_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			FrmProjeFatura frm = new FrmProjeFatura();
			frm.ShowDialog();
		}

		private void BtnMusteriProje_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			FrmMusteriProje frm = new FrmMusteriProje();
			frm.ShowDialog();
		}

		private void BtnFaturaAnaliz_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			FrmFaturaAnaliz frm = new FrmFaturaAnaliz();
			frm.ShowDialog();
		}

		private void BtnFaturaFinansal_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			FrmFaturaFinansal frm = new FrmFaturaFinansal();	
			frm.ShowDialog();
		}

		private void BtnFaturaListesi1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			FrmFaturaListesi FaturaListesi = new FrmFaturaListesi();
			FaturaListesi.ShowDialog();
		}

		private void BtnMusteriProje1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			FrmMusteriProje frm = new FrmMusteriProje();
			frm.ShowDialog();
		}

		private void BtnFaturaAnaliz1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			FrmFaturaAnaliz frm = new FrmFaturaAnaliz();
			frm.ShowDialog();
		}

		private void BtnFaturaFinansal1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			FrmFaturaFinansal frm = new FrmFaturaFinansal();
			frm.ShowDialog();
		}

		private void BtnFaturaListesi2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			FrmFaturaListesi FaturaListesi = new FrmFaturaListesi();
			FaturaListesi.ShowDialog();
		}

		private void BtnProjeTakvimi1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			FrmProjeTakvimi frm = new FrmProjeTakvimi();
			frm.ShowDialog();
		}

		private void btnDarkMode_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Office 2019 Black"); 
			SaveTheme("Office 2019 Black");
		}

		private void btnLightMode_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("The Bezier"); 
			SaveTheme("The Bezier");
		}
		private void SaveTheme(string themeName)
		{
			Properties.Settings.Default.Theme = themeName; 
			Properties.Settings.Default.Save();
		}
	}
}
