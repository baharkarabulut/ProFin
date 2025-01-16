namespace ProFin
{
	partial class FrmFaturaAnaliz
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
			DevExpress.XtraCharts.XYDiagram3D xyDiagram3D2 = new DevExpress.XtraCharts.XYDiagram3D();
			DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
			DevExpress.XtraCharts.SideBySideBar3DSeriesView sideBySideBar3DSeriesView2 = new DevExpress.XtraCharts.SideBySideBar3DSeriesView();
			this.lblGenelBilgi = new System.Windows.Forms.Label();
			this.gridControl1 = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
			this.gridControl2 = new DevExpress.XtraGrid.GridControl();
			this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(xyDiagram3D2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(sideBySideBar3DSeriesView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
			this.SuspendLayout();
			// 
			// lblGenelBilgi
			// 
			this.lblGenelBilgi.AutoSize = true;
			this.lblGenelBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblGenelBilgi.Location = new System.Drawing.Point(12, 290);
			this.lblGenelBilgi.Name = "lblGenelBilgi";
			this.lblGenelBilgi.Size = new System.Drawing.Size(51, 20);
			this.lblGenelBilgi.TabIndex = 0;
			this.lblGenelBilgi.Text = "label1";
			// 
			// gridControl1
			// 
			this.gridControl1.Location = new System.Drawing.Point(2, 1);
			this.gridControl1.MainView = this.gridView1;
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.Size = new System.Drawing.Size(386, 274);
			this.gridControl1.TabIndex = 1;
			this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// gridView1
			// 
			this.gridView1.GridControl = this.gridControl1;
			this.gridView1.Name = "gridView1";
			this.gridView1.OptionsView.ShowGroupPanel = false;
			// 
			// chartControl1
			// 
			xyDiagram3D2.RotationMatrixSerializable = "-0.996504396816297;-0.0522451867482444;-0.0651876337003233;0;-0.0571897676688358;" +
    "0.995432265241514;0.0764456394449843;0;0.0608959571711558;0.0799064814505636;-0." +
    "994940519137914;0;0;0;0;1";
			this.chartControl1.Diagram = xyDiagram3D2;
			this.chartControl1.Location = new System.Drawing.Point(392, 1);
			this.chartControl1.Name = "chartControl1";
			series2.Name = "Series";
			series2.SeriesID = 0;
			series2.View = sideBySideBar3DSeriesView2;
			this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
			this.chartControl1.Size = new System.Drawing.Size(438, 274);
			this.chartControl1.TabIndex = 2;
			// 
			// gridControl2
			// 
			this.gridControl2.Location = new System.Drawing.Point(392, 281);
			this.gridControl2.MainView = this.gridView2;
			this.gridControl2.Name = "gridControl2";
			this.gridControl2.Size = new System.Drawing.Size(438, 274);
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
			// FrmFaturaAnaliz
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(832, 561);
			this.Controls.Add(this.gridControl2);
			this.Controls.Add(this.chartControl1);
			this.Controls.Add(this.gridControl1);
			this.Controls.Add(this.lblGenelBilgi);
			this.Name = "FrmFaturaAnaliz";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Fatura Analiz Raporları";
			this.Load += new System.EventHandler(this.FrmFaturaAnaliz_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(xyDiagram3D2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(sideBySideBar3DSeriesView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblGenelBilgi;
		private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraCharts.ChartControl chartControl1;
		private DevExpress.XtraGrid.GridControl gridControl2;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
	}
}