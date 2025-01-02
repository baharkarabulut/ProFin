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
		private int GetTamamlananProjeSayisi()
		{
			using (var dbContext = new DbProFinEntities())
			{
				return dbContext.Projeler.Count(p => p.Durum == "Tamamlandı");
			}
		}

		private int GetDevamEdenProjeSayisi()
		{
			using (var dbContext = new DbProFinEntities())
			{
				return dbContext.Projeler.Count(p => p.Durum == "Devam Ediyor");
			}
		}


		private void FrmAnasayfa_Load(object sender, EventArgs e)
		{
			// Gelir-Gider Grafiği
			Series series = new Series("Gelir-Gider", ViewType.Pie3D);

			SeriesPoint gelirPoint = new SeriesPoint("Gelir", GetToplamGelir());
			gelirPoint.Color = ColorTranslator.FromHtml("#9bcd9b");

			SeriesPoint giderPoint = new SeriesPoint("Gider", 60000);
			giderPoint.Color = ColorTranslator.FromHtml("#ee5c42");

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
			chartToplamGelir.Titles.Clear(); 
			chartToplamGelir.Titles.Add(chartTitle);

			// Proje Durumu Grafiği
			Series projeDurumSeries = new Series("Proje Durumu", ViewType.Bar);
			projeDurumSeries.Points.Add(new SeriesPoint("Tamamlanan Projeler", GetTamamlananProjeSayisi()));
			projeDurumSeries.Points.Add(new SeriesPoint("Devam Eden Projeler", GetDevamEdenProjeSayisi()));
			projeDurumSeries.Points[0].Color = ColorTranslator.FromHtml("#519fdb");
			projeDurumSeries.Points[1].Color = ColorTranslator.FromHtml("#f9f995"); 


			chartProjeDurumu.Series.Clear();
			chartProjeDurumu.Series.Add(projeDurumSeries);

			SideBySideBarSeriesView barView = (SideBySideBarSeriesView)projeDurumSeries.View;
			barView.ColorEach = true;

			ChartTitle projeDurumTitle = new ChartTitle { Text = "Proje Durumu Grafiği" };
			chartProjeDurumu.Titles.Clear();
			chartProjeDurumu.Titles.Add(projeDurumTitle);

		}
	}
}
