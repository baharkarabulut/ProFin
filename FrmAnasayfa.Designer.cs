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
			this.chartToplamGelir = new DevExpress.XtraCharts.ChartControl();
			((System.ComponentModel.ISupportInitialize)(this.chartToplamGelir)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(simpleDiagram3D1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(pie3DSeriesView1)).BeginInit();
			this.SuspendLayout();
			// 
			// chartToplamGelir
			// 
			this.chartToplamGelir.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.True;
			simpleDiagram3D1.RotationMatrixSerializable = "0.406818065349275;-0.913509108681075;-0.000412385968336935;0;0.83809101302482;0.3" +
    "73411242764804;-0.397702775529513;0;0.36345909755089;0.161447056750991;0.9175142" +
    "13663168;0;0;0;0;1";
			this.chartToplamGelir.Diagram = simpleDiagram3D1;
			this.chartToplamGelir.Location = new System.Drawing.Point(12, 12);
			this.chartToplamGelir.Name = "chartToplamGelir";
			this.chartToplamGelir.PaletteBaseColorNumber = 2;
			this.chartToplamGelir.PaletteName = "Concourse";
			series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False;
			series1.Name = "Series";
			series1.SeriesID = 0;
			series1.View = pie3DSeriesView1;
			this.chartToplamGelir.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
			this.chartToplamGelir.Size = new System.Drawing.Size(505, 362);
			this.chartToplamGelir.TabIndex = 0;
			// 
			// FrmAnasayfa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(2008, 770);
			this.Controls.Add(this.chartToplamGelir);
			this.Name = "FrmAnasayfa";
			this.Text = "Anasayfa";
			this.Load += new System.EventHandler(this.FrmAnasayfa_Load);
			((System.ComponentModel.ISupportInitialize)(simpleDiagram3D1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(pie3DSeriesView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chartToplamGelir)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraCharts.ChartControl chartToplamGelir;
	}
}