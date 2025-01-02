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
			DevExpress.XtraCharts.SimpleDiagram3D simpleDiagram3D4 = new DevExpress.XtraCharts.SimpleDiagram3D();
			DevExpress.XtraCharts.Series series7 = new DevExpress.XtraCharts.Series();
			DevExpress.XtraCharts.Pie3DSeriesView pie3DSeriesView4 = new DevExpress.XtraCharts.Pie3DSeriesView();
			DevExpress.XtraCharts.XYDiagram3D xyDiagram3D4 = new DevExpress.XtraCharts.XYDiagram3D();
			DevExpress.XtraCharts.Series series8 = new DevExpress.XtraCharts.Series();
			DevExpress.XtraCharts.SideBySideBar3DSeriesView sideBySideBar3DSeriesView4 = new DevExpress.XtraCharts.SideBySideBar3DSeriesView();
			this.chartToplamGelir = new DevExpress.XtraCharts.ChartControl();
			this.chartProjeDurumu = new DevExpress.XtraCharts.ChartControl();
			this.gridControl1 = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.gridControl2 = new DevExpress.XtraGrid.GridControl();
			this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
			((System.ComponentModel.ISupportInitialize)(this.chartToplamGelir)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(simpleDiagram3D4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(series7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(pie3DSeriesView4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chartProjeDurumu)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(xyDiagram3D4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(series8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(sideBySideBar3DSeriesView4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
			this.SuspendLayout();
			// 
			// chartToplamGelir
			// 
			this.chartToplamGelir.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.True;
			simpleDiagram3D4.RotationMatrixSerializable = "0.406818065349275;-0.913509108681075;-0.000412385968336935;0;0.83809101302482;0.3" +
    "73411242764804;-0.397702775529513;0;0.36345909755089;0.161447056750991;0.9175142" +
    "13663168;0;0;0;0;1";
			this.chartToplamGelir.Diagram = simpleDiagram3D4;
			this.chartToplamGelir.Location = new System.Drawing.Point(9, 10);
			this.chartToplamGelir.Margin = new System.Windows.Forms.Padding(2);
			this.chartToplamGelir.Name = "chartToplamGelir";
			this.chartToplamGelir.PaletteBaseColorNumber = 2;
			this.chartToplamGelir.PaletteName = "Concourse";
			series7.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False;
			series7.Name = "Series";
			series7.SeriesID = 0;
			series7.View = pie3DSeriesView4;
			this.chartToplamGelir.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series7};
			this.chartToplamGelir.Size = new System.Drawing.Size(379, 279);
			this.chartToplamGelir.TabIndex = 0;
			// 
			// chartProjeDurumu
			// 
			xyDiagram3D4.RotationMatrixSerializable = "-0.964051479177289;0.243979518882632;-0.10525559301981;0;0.226692368403619;0.9618" +
    "40478757345;0.153210520302815;0;0.138619319013292;0.123842189054065;-0.982572031" +
    "256068;0;0;0;0;1";
			this.chartProjeDurumu.Diagram = xyDiagram3D4;
			this.chartProjeDurumu.Location = new System.Drawing.Point(393, 10);
			this.chartProjeDurumu.Name = "chartProjeDurumu";
			series8.Name = "Series2";
			series8.SeriesID = 1;
			series8.View = sideBySideBar3DSeriesView4;
			this.chartProjeDurumu.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series8};
			this.chartProjeDurumu.Size = new System.Drawing.Size(379, 279);
			this.chartProjeDurumu.TabIndex = 1;
			// 
			// gridControl1
			// 
			this.gridControl1.Location = new System.Drawing.Point(9, 295);
			this.gridControl1.MainView = this.gridView1;
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.Size = new System.Drawing.Size(763, 330);
			this.gridControl1.TabIndex = 2;
			this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// gridView1
			// 
			this.gridView1.GridControl = this.gridControl1;
			this.gridView1.Name = "gridView1";
			this.gridView1.OptionsView.ShowGroupPanel = false;
			// 
			// gridControl2
			// 
			this.gridControl2.Location = new System.Drawing.Point(778, 10);
			this.gridControl2.MainView = this.gridView2;
			this.gridControl2.Name = "gridControl2";
			this.gridControl2.Size = new System.Drawing.Size(245, 615);
			this.gridControl2.TabIndex = 3;
			this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
			// 
			// gridView2
			// 
			this.gridView2.GridControl = this.gridControl2;
			this.gridView2.Name = "gridView2";
			this.gridView2.OptionsView.ShowGroupPanel = false;
			// 
			// FrmAnasayfa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1506, 626);
			this.Controls.Add(this.gridControl2);
			this.Controls.Add(this.gridControl1);
			this.Controls.Add(this.chartProjeDurumu);
			this.Controls.Add(this.chartToplamGelir);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "FrmAnasayfa";
			this.Text = "Anasayfa";
			this.Load += new System.EventHandler(this.FrmAnasayfa_Load);
			((System.ComponentModel.ISupportInitialize)(simpleDiagram3D4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(pie3DSeriesView4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(series7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chartToplamGelir)).EndInit();
			((System.ComponentModel.ISupportInitialize)(xyDiagram3D4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(sideBySideBar3DSeriesView4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(series8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chartProjeDurumu)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraCharts.ChartControl chartToplamGelir;
		private DevExpress.XtraCharts.ChartControl chartProjeDurumu;
		private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraGrid.GridControl gridControl2;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
	}
}