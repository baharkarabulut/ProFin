namespace ProFin
{
	partial class FrmFaturaFinansal
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
			DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
			DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
			DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
			DevExpress.XtraCharts.PieSeriesView pieSeriesView1 = new DevExpress.XtraCharts.PieSeriesView();
			this.lblToplamTutar = new System.Windows.Forms.Label();
			this.LblOdenmisTutar = new System.Windows.Forms.Label();
			this.LblOdenmemisTutar = new System.Windows.Forms.Label();
			this.lblOdemeOrani = new System.Windows.Forms.Label();
			this.lblOdenmemeOrani = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
			this.gridControl2 = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.chartControl2 = new DevExpress.XtraCharts.ChartControl();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chartControl2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).BeginInit();
			this.SuspendLayout();
			// 
			// lblToplamTutar
			// 
			this.lblToplamTutar.AutoSize = true;
			this.lblToplamTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblToplamTutar.Location = new System.Drawing.Point(17, 65);
			this.lblToplamTutar.Name = "lblToplamTutar";
			this.lblToplamTutar.Size = new System.Drawing.Size(64, 25);
			this.lblToplamTutar.TabIndex = 0;
			this.lblToplamTutar.Text = "label1";
			// 
			// LblOdenmisTutar
			// 
			this.LblOdenmisTutar.AutoSize = true;
			this.LblOdenmisTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.LblOdenmisTutar.Location = new System.Drawing.Point(17, 119);
			this.LblOdenmisTutar.Name = "LblOdenmisTutar";
			this.LblOdenmisTutar.Size = new System.Drawing.Size(64, 25);
			this.LblOdenmisTutar.TabIndex = 1;
			this.LblOdenmisTutar.Text = "label2";
			// 
			// LblOdenmemisTutar
			// 
			this.LblOdenmemisTutar.AutoSize = true;
			this.LblOdenmemisTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.LblOdenmemisTutar.Location = new System.Drawing.Point(17, 174);
			this.LblOdenmemisTutar.Name = "LblOdenmemisTutar";
			this.LblOdenmemisTutar.Size = new System.Drawing.Size(64, 25);
			this.LblOdenmemisTutar.TabIndex = 3;
			this.LblOdenmemisTutar.Text = "label3";
			// 
			// lblOdemeOrani
			// 
			this.lblOdemeOrani.AutoSize = true;
			this.lblOdemeOrani.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblOdemeOrani.Location = new System.Drawing.Point(17, 223);
			this.lblOdemeOrani.Name = "lblOdemeOrani";
			this.lblOdemeOrani.Size = new System.Drawing.Size(64, 25);
			this.lblOdemeOrani.TabIndex = 2;
			this.lblOdemeOrani.Text = "label4";
			// 
			// lblOdenmemeOrani
			// 
			this.lblOdenmemeOrani.AutoSize = true;
			this.lblOdenmemeOrani.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblOdenmemeOrani.Location = new System.Drawing.Point(17, 270);
			this.lblOdenmemeOrani.Name = "lblOdenmemeOrani";
			this.lblOdenmemeOrani.Size = new System.Drawing.Size(64, 25);
			this.lblOdenmemeOrani.TabIndex = 4;
			this.lblOdenmemeOrani.Text = "label4";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lblToplamTutar);
			this.groupBox1.Controls.Add(this.lblOdenmemeOrani);
			this.groupBox1.Controls.Add(this.LblOdenmisTutar);
			this.groupBox1.Controls.Add(this.LblOdenmemisTutar);
			this.groupBox1.Controls.Add(this.lblOdemeOrani);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(436, 350);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Genel Finansal Durum";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.chartControl1);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox2.Location = new System.Drawing.Point(474, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(436, 350);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Aylık Finansal Durum";
			// 
			// chartControl1
			// 
			xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
			xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
			this.chartControl1.Diagram = xyDiagram1;
			this.chartControl1.Location = new System.Drawing.Point(6, 27);
			this.chartControl1.Name = "chartControl1";
			series1.Name = "Series";
			series1.SeriesID = 0;
			this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
			this.chartControl1.Size = new System.Drawing.Size(424, 317);
			this.chartControl1.TabIndex = 0;
			// 
			// gridControl2
			// 
			this.gridControl2.Location = new System.Drawing.Point(6, 27);
			this.gridControl2.MainView = this.gridView1;
			this.gridControl2.Name = "gridControl2";
			this.gridControl2.Size = new System.Drawing.Size(424, 317);
			this.gridControl2.TabIndex = 7;
			this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// gridView1
			// 
			this.gridView1.GridControl = this.gridControl2;
			this.gridView1.Name = "gridView1";
			this.gridView1.OptionsView.ShowGroupPanel = false;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.gridControl2);
			this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox3.Location = new System.Drawing.Point(12, 378);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(436, 350);
			this.groupBox3.TabIndex = 8;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Müşteri Bazlı Finansal Analiz";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.chartControl2);
			this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox4.Location = new System.Drawing.Point(474, 378);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(436, 350);
			this.groupBox4.TabIndex = 9;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Fatura Yaşlanma Analizi";
			// 
			// chartControl2
			// 
			this.chartControl2.Location = new System.Drawing.Point(6, 27);
			this.chartControl2.Name = "chartControl2";
			series2.Name = "Series";
			series2.SeriesID = 0;
			series2.View = pieSeriesView1;
			this.chartControl2.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
			this.chartControl2.Size = new System.Drawing.Size(424, 317);
			this.chartControl2.TabIndex = 0;
			// 
			// FrmFaturaFinansal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(963, 768);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "FrmFaturaFinansal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Faturaların Finansal Durum Raporları";
			this.Load += new System.EventHandler(this.FrmFaturaFinansal_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chartControl2)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lblToplamTutar;
		private System.Windows.Forms.Label LblOdenmisTutar;
		private System.Windows.Forms.Label LblOdenmemisTutar;
		private System.Windows.Forms.Label lblOdemeOrani;
		private System.Windows.Forms.Label lblOdenmemeOrani;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private DevExpress.XtraCharts.ChartControl chartControl1;
		private DevExpress.XtraGrid.GridControl gridControl2;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox4;
		private DevExpress.XtraCharts.ChartControl chartControl2;
	}
}