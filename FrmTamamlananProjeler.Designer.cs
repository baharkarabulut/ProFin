namespace ProFin
{
	partial class FrmTamamlananProjeler
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
			DevExpress.XtraCharts.XYDiagram xyDiagram4 = new DevExpress.XtraCharts.XYDiagram();
			DevExpress.XtraCharts.Series series4 = new DevExpress.XtraCharts.Series();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTamamlananProjeler));
			this.gridControl1 = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.lblToplamTutar = new DevExpress.XtraEditors.LabelControl();
			this.lblBitisTarihi = new DevExpress.XtraEditors.LabelControl();
			this.lblBaslangicTarihi = new DevExpress.XtraEditors.LabelControl();
			this.lblMusteriAdi = new DevExpress.XtraEditors.LabelControl();
			this.lblProjeAdi = new DevExpress.XtraEditors.LabelControl();
			this.grpIstatistikler = new System.Windows.Forms.GroupBox();
			this.lblToplamKazanc = new System.Windows.Forms.Label();
			this.lblToplamProjeSayisi = new System.Windows.Forms.Label();
			this.chartProjeKazanc = new DevExpress.XtraCharts.ChartControl();
			this.btnExcelAktar = new DevExpress.XtraEditors.SimpleButton();
			this.btnPdfAktar = new DevExpress.XtraEditors.SimpleButton();
			this.btnYazdir = new DevExpress.XtraEditors.SimpleButton();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			this.grpIstatistikler.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chartProjeKazanc)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(xyDiagram4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(series4)).BeginInit();
			this.SuspendLayout();
			// 
			// gridControl1
			// 
			this.gridControl1.Location = new System.Drawing.Point(3, 2);
			this.gridControl1.MainView = this.gridView1;
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.Size = new System.Drawing.Size(460, 302);
			this.gridControl1.TabIndex = 0;
			this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// gridView1
			// 
			this.gridView1.GridControl = this.gridControl1;
			this.gridView1.Name = "gridView1";
			this.gridView1.OptionsView.ShowGroupPanel = false;
			this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
			this.gridView1.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gridView1_CustomColumnDisplayText);
			// 
			// panelControl1
			// 
			this.panelControl1.Controls.Add(this.lblToplamTutar);
			this.panelControl1.Controls.Add(this.lblBitisTarihi);
			this.panelControl1.Controls.Add(this.lblBaslangicTarihi);
			this.panelControl1.Controls.Add(this.lblMusteriAdi);
			this.panelControl1.Controls.Add(this.lblProjeAdi);
			this.panelControl1.Location = new System.Drawing.Point(469, 2);
			this.panelControl1.Name = "panelControl1";
			this.panelControl1.Size = new System.Drawing.Size(331, 188);
			this.panelControl1.TabIndex = 1;
			// 
			// lblToplamTutar
			// 
			this.lblToplamTutar.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblToplamTutar.Appearance.Options.UseFont = true;
			this.lblToplamTutar.Location = new System.Drawing.Point(15, 153);
			this.lblToplamTutar.Name = "lblToplamTutar";
			this.lblToplamTutar.Size = new System.Drawing.Size(94, 19);
			this.lblToplamTutar.TabIndex = 4;
			this.lblToplamTutar.Text = "labelControl5";
			// 
			// lblBitisTarihi
			// 
			this.lblBitisTarihi.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblBitisTarihi.Appearance.Options.UseFont = true;
			this.lblBitisTarihi.Location = new System.Drawing.Point(15, 119);
			this.lblBitisTarihi.Name = "lblBitisTarihi";
			this.lblBitisTarihi.Size = new System.Drawing.Size(94, 19);
			this.lblBitisTarihi.TabIndex = 3;
			this.lblBitisTarihi.Text = "labelControl4";
			// 
			// lblBaslangicTarihi
			// 
			this.lblBaslangicTarihi.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblBaslangicTarihi.Appearance.Options.UseFont = true;
			this.lblBaslangicTarihi.Location = new System.Drawing.Point(15, 85);
			this.lblBaslangicTarihi.Name = "lblBaslangicTarihi";
			this.lblBaslangicTarihi.Size = new System.Drawing.Size(94, 19);
			this.lblBaslangicTarihi.TabIndex = 2;
			this.lblBaslangicTarihi.Text = "labelControl3";
			// 
			// lblMusteriAdi
			// 
			this.lblMusteriAdi.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblMusteriAdi.Appearance.Options.UseFont = true;
			this.lblMusteriAdi.Location = new System.Drawing.Point(15, 48);
			this.lblMusteriAdi.Name = "lblMusteriAdi";
			this.lblMusteriAdi.Size = new System.Drawing.Size(94, 19);
			this.lblMusteriAdi.TabIndex = 1;
			this.lblMusteriAdi.Text = "labelControl2";
			// 
			// lblProjeAdi
			// 
			this.lblProjeAdi.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblProjeAdi.Appearance.Options.UseFont = true;
			this.lblProjeAdi.Location = new System.Drawing.Point(15, 10);
			this.lblProjeAdi.Name = "lblProjeAdi";
			this.lblProjeAdi.Size = new System.Drawing.Size(94, 19);
			this.lblProjeAdi.TabIndex = 0;
			this.lblProjeAdi.Text = "labelControl1";
			// 
			// grpIstatistikler
			// 
			this.grpIstatistikler.Controls.Add(this.lblToplamKazanc);
			this.grpIstatistikler.Controls.Add(this.lblToplamProjeSayisi);
			this.grpIstatistikler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.grpIstatistikler.Location = new System.Drawing.Point(469, 196);
			this.grpIstatistikler.Name = "grpIstatistikler";
			this.grpIstatistikler.Size = new System.Drawing.Size(331, 108);
			this.grpIstatistikler.TabIndex = 2;
			this.grpIstatistikler.TabStop = false;
			this.grpIstatistikler.Text = "İstatistikler";
			// 
			// lblToplamKazanc
			// 
			this.lblToplamKazanc.AutoSize = true;
			this.lblToplamKazanc.Location = new System.Drawing.Point(11, 74);
			this.lblToplamKazanc.Name = "lblToplamKazanc";
			this.lblToplamKazanc.Size = new System.Drawing.Size(51, 20);
			this.lblToplamKazanc.TabIndex = 1;
			this.lblToplamKazanc.Text = "label2";
			// 
			// lblToplamProjeSayisi
			// 
			this.lblToplamProjeSayisi.AutoSize = true;
			this.lblToplamProjeSayisi.Location = new System.Drawing.Point(11, 39);
			this.lblToplamProjeSayisi.Name = "lblToplamProjeSayisi";
			this.lblToplamProjeSayisi.Size = new System.Drawing.Size(51, 20);
			this.lblToplamProjeSayisi.TabIndex = 0;
			this.lblToplamProjeSayisi.Text = "label1";
			// 
			// chartProjeKazanc
			// 
			xyDiagram4.AxisX.VisibleInPanesSerializable = "-1";
			xyDiagram4.AxisY.VisibleInPanesSerializable = "-1";
			this.chartProjeKazanc.Diagram = xyDiagram4;
			this.chartProjeKazanc.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
			this.chartProjeKazanc.Location = new System.Drawing.Point(2, 310);
			this.chartProjeKazanc.Name = "chartProjeKazanc";
			series4.Name = "barSeries";
			series4.SeriesID = 0;
			this.chartProjeKazanc.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series4};
			this.chartProjeKazanc.Size = new System.Drawing.Size(677, 288);
			this.chartProjeKazanc.TabIndex = 3;
			// 
			// btnExcelAktar
			// 
			this.btnExcelAktar.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnExcelAktar.Appearance.Options.UseFont = true;
			this.btnExcelAktar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
			this.btnExcelAktar.Location = new System.Drawing.Point(686, 310);
			this.btnExcelAktar.Name = "btnExcelAktar";
			this.btnExcelAktar.Size = new System.Drawing.Size(114, 92);
			this.btnExcelAktar.TabIndex = 4;
			this.btnExcelAktar.Text = "Excel\'e \r\nAktar";
			this.btnExcelAktar.Click += new System.EventHandler(this.btnExcelAktar_Click);
			// 
			// btnPdfAktar
			// 
			this.btnPdfAktar.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnPdfAktar.Appearance.Options.UseFont = true;
			this.btnPdfAktar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
			this.btnPdfAktar.Location = new System.Drawing.Point(686, 408);
			this.btnPdfAktar.Name = "btnPdfAktar";
			this.btnPdfAktar.Size = new System.Drawing.Size(114, 92);
			this.btnPdfAktar.TabIndex = 5;
			this.btnPdfAktar.Text = "PDF\'e \r\nAktar";
			this.btnPdfAktar.Click += new System.EventHandler(this.btnPdfAktar_Click);
			// 
			// btnYazdir
			// 
			this.btnYazdir.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnYazdir.Appearance.Options.UseFont = true;
			this.btnYazdir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
			this.btnYazdir.Location = new System.Drawing.Point(686, 506);
			this.btnYazdir.Name = "btnYazdir";
			this.btnYazdir.Size = new System.Drawing.Size(114, 92);
			this.btnYazdir.TabIndex = 6;
			this.btnYazdir.Text = "Yazdır";
			this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
			// 
			// FrmTamamlananProjeler
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(804, 605);
			this.Controls.Add(this.btnYazdir);
			this.Controls.Add(this.btnPdfAktar);
			this.Controls.Add(this.btnExcelAktar);
			this.Controls.Add(this.chartProjeKazanc);
			this.Controls.Add(this.grpIstatistikler);
			this.Controls.Add(this.panelControl1);
			this.Controls.Add(this.gridControl1);
			this.Name = "FrmTamamlananProjeler";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Tamamlanan Projeler";
			this.Load += new System.EventHandler(this.FrmTamamlananProjeler_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			this.panelControl1.PerformLayout();
			this.grpIstatistikler.ResumeLayout(false);
			this.grpIstatistikler.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(xyDiagram4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(series4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chartProjeKazanc)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraEditors.PanelControl panelControl1;
		private DevExpress.XtraEditors.LabelControl lblToplamTutar;
		private DevExpress.XtraEditors.LabelControl lblBitisTarihi;
		private DevExpress.XtraEditors.LabelControl lblBaslangicTarihi;
		private DevExpress.XtraEditors.LabelControl lblMusteriAdi;
		private DevExpress.XtraEditors.LabelControl lblProjeAdi;
		private System.Windows.Forms.GroupBox grpIstatistikler;
		private System.Windows.Forms.Label lblToplamKazanc;
		private System.Windows.Forms.Label lblToplamProjeSayisi;
		private DevExpress.XtraCharts.ChartControl chartProjeKazanc;
		private DevExpress.XtraEditors.SimpleButton btnExcelAktar;
		private DevExpress.XtraEditors.SimpleButton btnPdfAktar;
		private DevExpress.XtraEditors.SimpleButton btnYazdir;
	}
}