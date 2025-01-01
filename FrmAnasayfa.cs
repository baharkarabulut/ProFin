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
	public partial class FrmAnasayfa : Form
	{
		public FrmAnasayfa()
		{
			InitializeComponent();
		}
		DbProFinEntities db = new DbProFinEntities();

		private decimal GetToplamGelir()
		{
			using (var dbContext = new DbProFinEntities())
			{
				var toplamGelir = dbContext.Faturalar
										   .Where(f => f.DurumBilgi == "Geçerli")
										   .Sum(f => (decimal?)f.ToplamTutar) ?? 0;

				return toplamGelir;
			}
		}
		private void FrmAnasayfa_Load(object sender, EventArgs e)
		{
			Series series = new Series("Gelir-Gider", ViewType.Pie3D);

			SeriesPoint gelirPoint = new SeriesPoint("Gelir", GetToplamGelir());
			gelirPoint.Color = Color.DarkGreen;

			SeriesPoint giderPoint = new SeriesPoint("Gider", 60000);
			giderPoint.Color = Color.Red;

			series.Points.Add(gelirPoint);
			series.Points.Add(giderPoint);

			chartToplamGelir.Series.Clear(); 
			chartToplamGelir.Series.Add(series);

			Pie3DSeriesView pieView = (Pie3DSeriesView)series.View;
			pieView.ExplodedPoints.Add(series.Points[0]); 
			pieView.ExplodeMode = PieExplodeMode.UsePoints;
			pieView.Depth = 20;

			ChartTitle chartTitle = new ChartTitle();
			chartTitle.Text = "Toplam Gelir/Gider";
			chartToplamGelir.Titles.Clear();  // Eski başlıkları temizle
			chartToplamGelir.Titles.Add(chartTitle);
		}
	}
}
