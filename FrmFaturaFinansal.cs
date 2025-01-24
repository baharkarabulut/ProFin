using DevExpress.XtraCharts;
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
	public partial class FrmFaturaFinansal : Form
	{
		public FrmFaturaFinansal()
		{
			InitializeComponent();
		}
		DbProFinEntities db = new DbProFinEntities();
		private void FrmFaturaFinansal_Load(object sender, EventArgs e)
		{
			GenelFinansalDurum();
			AylikFinansalDurum();
			MusteriBazliFinansalDurum();
			FaturaYaslanmaAnalizi();
		}

		private void GenelFinansalDurum()
		{
			var toplamTutar = db.Faturalar.Sum(f => f.ToplamTutar ?? 0);
			var odenmisTutar = db.Faturalar.Where(f => f.OdemeDurumu == "Ödendi").Sum(f => f.ToplamTutar ?? 0);
			var odenmemisTutar = toplamTutar - odenmisTutar;

			lblToplamTutar.Text = $"Toplam Tutar: {toplamTutar:C2}";
			LblOdenmisTutar.Text = $"Ödenmiş Tutar: {odenmisTutar:C2}";
			LblOdenmemisTutar.Text = $"Ödenmemiş Tutar: {odenmemisTutar:C2}";

			var odenmeOrani = (odenmisTutar / toplamTutar) * 100;
			var odenmemeOrani = 100 - odenmeOrani;

			lblOdemeOrani.Text = $"Ödenme Oranı: %{odenmeOrani:F2}";
			lblOdenmemeOrani.Text = $"Ödenmeme Oranı: %{odenmemeOrani:F2}";
		}

		private void AylikFinansalDurum()
		{
			var aylikVeriler = db.Faturalar
				.Where(f => f.FaturaTarihi.HasValue) 
				.GroupBy(f => f.FaturaTarihi.Value.Month) 
				.Select(g => new
				{
					Ay = g.Key,
					ToplamTutar = g.Sum(f => (decimal?)f.ToplamTutar) ?? 0, 
					OdenmisTutar = g.Where(f => f.OdemeDurumu == "Ödendi").Sum(f => (decimal?)f.ToplamTutar) ?? 0, 
					OdenmemisTutar = g.Where(f => f.OdemeDurumu == "Ödenmedi").Sum(f => (decimal?)f.ToplamTutar) ?? 0, 
					KismiOdenmisTutar = g.Where(f => f.OdemeDurumu == "Kısmi Ödendi").Sum(f => (decimal?)f.ToplamTutar) ?? 0 
				}).ToList();

			chartControl1.Series.Clear();

			var toplamTutarSeri = new DevExpress.XtraCharts.Series("Toplam Tutar", DevExpress.XtraCharts.ViewType.Line);
			toplamTutarSeri.DataSource = aylikVeriler;
			toplamTutarSeri.ArgumentDataMember = "Ay";
			toplamTutarSeri.ValueDataMembers.AddRange("ToplamTutar");

			var odenmisTutarSeri = new DevExpress.XtraCharts.Series("Ödenmiş Tutar", DevExpress.XtraCharts.ViewType.Line);
			odenmisTutarSeri.DataSource = aylikVeriler;
			odenmisTutarSeri.ArgumentDataMember = "Ay";
			odenmisTutarSeri.ValueDataMembers.AddRange("OdenmisTutar");

			var odenmemisTutarSeri = new DevExpress.XtraCharts.Series("Ödenmemiş Tutar", DevExpress.XtraCharts.ViewType.Line);
			odenmemisTutarSeri.DataSource = aylikVeriler;
			odenmemisTutarSeri.ArgumentDataMember = "Ay";
			odenmemisTutarSeri.ValueDataMembers.AddRange("OdenmemisTutar");

			var kismiOdenmisTutarSeri = new DevExpress.XtraCharts.Series("Kısmi Ödenmiş Tutar", DevExpress.XtraCharts.ViewType.Line);
			kismiOdenmisTutarSeri.DataSource = aylikVeriler;
			kismiOdenmisTutarSeri.ArgumentDataMember = "Ay";
			kismiOdenmisTutarSeri.ValueDataMembers.AddRange("KismiOdenmisTutar");

			chartControl1.Series.AddRange(new[] { toplamTutarSeri, odenmisTutarSeri, odenmemisTutarSeri, kismiOdenmisTutarSeri });
		}

		private void MusteriBazliFinansalDurum()
		{
			var musteriAnaliz = db.Faturalar
				.Where(f => f.Musteriler != null) 
				.GroupBy(f => f.Musteriler.AdSoyad)
				.Select(g => new
				{
					MusteriAdi = g.Key ?? "Bilinmeyen Müşteri", 
					ToplamTutar = g.Sum(f => (decimal?)f.ToplamTutar) ?? 0, 
					OdenmemisTutar = g.Where(f => f.OdemeDurumu != "Ödendi")
									  .Sum(f => (decimal?)f.ToplamTutar) ?? 0 
				})
				.OrderByDescending(m => m.ToplamTutar)
				.Take(5)
				.ToList();

			gridControl2.DataSource = musteriAnaliz;
		}

		private void FaturaYaslanmaAnalizi()
		{
			var bugun = DateTime.Today;

			var faturaVeriler = db.Faturalar
				.Where(f => f.FaturaTarihi.HasValue && f.OdemeDurumu != "Ödenmiş")
				.AsEnumerable() 
				.Select(f => new
				{
					Fatura = f,
					GecikmeKategorisi = (bugun - f.FaturaTarihi.Value).Days <= 230 ? "0–30 Gün" :
										(bugun - f.FaturaTarihi.Value).Days <= 460 ? "31–60 Gün" : "61+ Gün"
				})
				.ToList();

			var yaslanmaAnaliz = faturaVeriler
				.GroupBy(f => f.GecikmeKategorisi)
				.Select(g => new
				{
					GecikmeKategorisi = g.Key,
					Tutar = g.Sum(f => f.Fatura.ToplamTutar ?? 0),
					FaturaSayisi = g.Count()
				})
				.ToList();

			chartControl2.Series.Clear();
			var seri = new DevExpress.XtraCharts.Series("Gecikme Analizi", DevExpress.XtraCharts.ViewType.Pie);
			seri.DataSource = yaslanmaAnaliz;
			seri.ArgumentDataMember = "GecikmeKategorisi";
			seri.ValueDataMembers.AddRange("Tutar");

			chartControl2.Series.Add(seri);
		}

		private void groupBox2_Enter(object sender, EventArgs e)
		{

		}
	}
}
