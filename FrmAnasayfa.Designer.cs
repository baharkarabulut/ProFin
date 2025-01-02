namespace ProFin
{
	partial class FrmAnasayfa
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			DevExpress.XtraCharts.SimpleDiagram3D simpleDiagram3D1 = new DevExpress.XtraCharts.SimpleDiagram3D();
			DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
			DevExpress.XtraCharts.Pie3DSeriesView pie3DSeriesView1 = new DevExpress.XtraCharts.Pie3DSeriesView();
			DevExpress.XtraCharts.XYDiagram3D xyDiagram3D1 = new DevExpress.XtraCharts.XYDiagram3D();
			DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
			DevExpress.XtraCharts.SideBySideBar3DSeriesView sideBySideBar3DSeriesView1 = new DevExpress.XtraCharts.SideBySideBar3DSeriesView();
			this.chartToplamGelir = new DevExpress.XtraCharts.ChartControl();
			this.chartProjeDurumu = new DevExpress.XtraCharts.ChartControl();
			((System.ComponentModel.ISupportInitialize)(this.chartToplamGelir)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(simpleDiagram3D1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(pie3DSeriesView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chartProjeDurumu)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(xyDiagram3D1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(sideBySideBar3DSeriesView1)).BeginInit();
			this.SuspendLayout();
			// 
			// chartToplamGelir
			// 
			this.chartToplamGelir.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.True;
			simpleDiagram3D1.RotationMatrixSerializable = "0.406818065349275;-0.913509108681075;-0.000412385968336935;0;0.83809101302482;0.3" +
    "73411242764804;-0.397702775529513;0;0.36345909755089;0.161447056750991;0.9175142" +
    "13663168;0;0;0;0;1";
			this.chartToplamGelir.Diagram = simpleDiagram3D1;
			this.chartToplamGelir.Location = new System.Drawing.Point(9, 10);
			this.chartToplamGelir.Margin = new System.Windows.Forms.Padding(2);
			this.chartToplamGelir.Name = "chartToplamGelir";
			this.chartToplamGelir.PaletteBaseColorNumber = 2;
			this.chartToplamGelir.PaletteName = "Concourse";
			series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False;
			series1.Name = "Series";
			series1.SeriesID = 0;
			series1.View = pie3DSeriesView1;
			this.chartToplamGelir.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
			this.chartToplamGelir.Size = new System.Drawing.Size(379, 294);
			this.chartToplamGelir.TabIndex = 0;
			// 
			// chartProjeDurumu
			// 
			xyDiagram3D1.RotationMatrixSerializable = "-0.964051479177289;0.243979518882632;-0.10525559301981;0;0.226692368403619;0.9618" +
    "40478757345;0.153210520302815;0;0.138619319013292;0.123842189054065;-0.982572031" +
    "256068;0;0;0;0;1";
			this.chartProjeDurumu.Diagram = xyDiagram3D1;
			this.chartProjeDurumu.Location = new System.Drawing.Point(393, 10);
			this.chartProjeDurumu.Name = "chartProjeDurumu";
			series2.Name = "Series2";
			series2.SeriesID = 1;
			series2.View = sideBySideBar3DSeriesView1;
			this.chartProjeDurumu.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
			this.chartProjeDurumu.Size = new System.Drawing.Size(379, 294);
			this.chartProjeDurumu.TabIndex = 1;
			// 
			// FrmAnasayfa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1506, 626);
			this.Controls.Add(this.chartProjeDurumu);
			this.Controls.Add(this.chartToplamGelir);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "FrmAnasayfa";
			this.Text = "Anasayfa";
			this.Load += new System.EventHandler(this.FrmAnasayfa_Load);
			((System.ComponentModel.ISupportInitialize)(simpleDiagram3D1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(pie3DSeriesView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chartToplamGelir)).EndInit();
			((System.ComponentModel.ISupportInitialize)(xyDiagram3D1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(sideBySideBar3DSeriesView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chartProjeDurumu)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraCharts.ChartControl chartToplamGelir;
		private DevExpress.XtraCharts.ChartControl chartProjeDurumu;
	}
}