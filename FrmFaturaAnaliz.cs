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
	public partial class FrmFaturaAnaliz : Form
	{
		public FrmFaturaAnaliz()
		{
			InitializeComponent();
		}
		DbProFinEntities db = new DbProFinEntities();
		private void GenelFaturaBilgileri()
		{
			var faturalar = db.Faturalar.ToList();

			int toplamFaturaSayisi = faturalar.Count;
			decimal toplamTutar = faturalar.Sum(f => f.ToplamTutar ?? 0);
			decimal odenmisTutar = faturalar.Where(f => f.OdemeDurumu == "Ödendi").Sum(f => f.ToplamTutar ?? 0);
			decimal odenmemisTutar = faturalar.Where(f => f.OdemeDurumu == "Ödenmedi").Sum(f => f.ToplamTutar ?? 0);
			decimal ortalamaTutar = toplamFaturaSayisi > 0 ? toplamTutar / toplamFaturaSayisi : 0;
			decimal enYuksekTutar = faturalar.Max(f => f.ToplamTutar ?? 0);
			decimal enDusukTutar = faturalar.Min(f => f.ToplamTutar ?? 0);

			lblGenelBilgi.Text = $"Toplam Fatura Sayısı: {toplamFaturaSayisi}\n\n" +
								 $"Toplam Tutar: {toplamTutar:C2}\n\n" +
								 $"Ödenmiş Tutar: {odenmisTutar:C2}\n\n" +
								 $"Ödenmemiş Tutar: {odenmemisTutar:C2}\n\n" +
								 $"Ortalama Tutar: {ortalamaTutar:C2}\n\n" +
								 $"En Yüksek Tutar: {enYuksekTutar:C2}\n\n" +
								 $"En Düşük Tutar: {enDusukTutar:C2}";
		}

		private void ZamanBazliAnaliz()
		{
			var aylikAnaliz = db.Faturalar
								.Where(f => f.FaturaTarihi.HasValue)
								.GroupBy(f => f.FaturaTarihi.Value.Month)
								.Select(g => new
								{
									Ay = g.Key,
									ToplamTutar = g.Sum(f => f.ToplamTutar ?? 0),
									FaturaSayisi = g.Count()
								}).ToList();

			chartControl1.Series.Clear();
			DevExpress.XtraCharts.Series seri = new DevExpress.XtraCharts.Series("Fatura Tutarları", DevExpress.XtraCharts.ViewType.Bar);

			seri.DataSource = aylikAnaliz;
			seri.ArgumentDataMember = "Ay";
			seri.ValueDataMembers.AddRange("ToplamTutar");

			chartControl1.Series.Add(seri);

			gridControl1.DataSource = aylikAnaliz;
		}


		private void MusteriBazliAnaliz()
		{
			var musteriAnaliz = db.Faturalar
								  .GroupBy(f => f.Musteriler.AdSoyad)
								  .Select(g => new
								  {
									  MusteriAdi = g.Key,
									  ToplamFaturaSayisi = g.Count(),
									  ToplamTutar = g.Sum(f => f.ToplamTutar)
								  })
								  .OrderByDescending(g => g.ToplamFaturaSayisi)
								  .ToList();

			gridControl2.DataSource = musteriAnaliz;
		}

		private void FrmFaturaAnaliz_Load(object sender, EventArgs e)
		{
			GenelFaturaBilgileri();
			ZamanBazliAnaliz();
			MusteriBazliAnaliz();
		}
	}
}
