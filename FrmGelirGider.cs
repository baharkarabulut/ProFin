using DevExpress.XtraCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProFin
{
	public partial class FrmGelirGider : Form
	{
		public FrmGelirGider()
		{
			InitializeComponent();
		}
		DbProFinEntities db = new DbProFinEntities();
		private void GelirGiderOranlari()
		{
			using (var db = new DbProFinEntities())
			{
				decimal toplamGelir = db.Faturalar
										.Where(f => f.DurumBilgi == "Geçerli")
										.Sum(f => (decimal?)f.ToplamTutar) ?? 0;

				decimal toplamGider = db.Giderler
										.Sum(g => (decimal?)g.Tutar) ?? 0;

				decimal toplam = toplamGelir + toplamGider;
				decimal gelirOrani = toplam > 0 ? (toplamGelir / toplam) * 100 : 0;
				decimal giderOrani = toplam > 0 ? (toplamGider / toplam) * 100 : 0;

				GelirGiderPieChart(gelirOrani, giderOrani);
			}
		}
		private void GelirGiderPieChart(decimal gelirOrani, decimal giderOrani)
		{
			chartControl1.Series.Clear();

			Series pieSeries = new Series("Gelir/Gider Dağılımı", ViewType.Pie3D);

			SeriesPoint gelirPoint = new SeriesPoint("Gelir", gelirOrani);
			gelirPoint.Color = ColorTranslator.FromHtml("#9bcd9b");

			SeriesPoint giderPoint = new SeriesPoint("Gider", giderOrani);
			giderPoint.Color = ColorTranslator.FromHtml("#ee5c42");

			pieSeries.Points.Add(gelirPoint);
			pieSeries.Points.Add(giderPoint);

			chartControl1.Series.Add(pieSeries);

			Pie3DSeriesView view = pieSeries.View as Pie3DSeriesView;
			if (view != null)
			{
				view.ExplodedDistancePercentage = 10;
				view.Depth = 25;
				view.ExplodeMode = PieExplodeMode.All;
			}

			pieSeries.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
			pieSeries.Label.TextPattern = "{A}: {V:F2}%";

			chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
			chartControl1.Legend.AlignmentHorizontal = LegendAlignmentHorizontal.Center;
			chartControl1.Legend.AlignmentVertical = LegendAlignmentVertical.Bottom;
		}


		private void FrmGelirGider_Load(object sender, EventArgs e)
		{
			GelirGiderOranlari();
			GelirGiderOranlari1();
		}

		private void GelirGiderOranlari1()
		{
			using (var db = new DbProFinEntities())
			{
				decimal toplamGelir = db.Faturalar
										.Where(f => f.DurumBilgi == "Geçerli")
										.Sum(f => (decimal?)f.ToplamTutar) ?? 0;

				decimal toplamGider = db.Giderler
										.Sum(g => (decimal?)g.Tutar) ?? 0;

				decimal toplamKar = toplamGelir - toplamGider;

				lblToplamGelir.Text = $"{toplamGelir:C}";
				lblToplamGider.Text = $"{toplamGider:C}";
				lblKar.Text = toplamKar >= 0
					? $"{toplamKar:C}"
					: $"Zarar: {Math.Abs(toplamKar):C}";

				decimal toplam = toplamGelir + toplamGider;
				decimal gelirOrani = toplam > 0 ? (toplamGelir / toplam) * 100 : 0;
				decimal giderOrani = toplam > 0 ? (toplamGider / toplam) * 100 : 0;

				GelirGiderPieChart(gelirOrani, giderOrani);
			}
		}

	}
}
