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
			DevExpress.XtraCharts.SimpleDiagram3D simpleDiagram3D2 = new DevExpress.XtraCharts.SimpleDiagram3D();
			DevExpress.XtraCharts.Series series4 = new DevExpress.XtraCharts.Series();
			DevExpress.XtraCharts.Pie3DSeriesView pie3DSeriesView2 = new DevExpress.XtraCharts.Pie3DSeriesView();
			DevExpress.XtraCharts.XYDiagram3D xyDiagram3D2 = new DevExpress.XtraCharts.XYDiagram3D();
			DevExpress.XtraCharts.Series series5 = new DevExpress.XtraCharts.Series();
			DevExpress.XtraCharts.SideBySideBar3DSeriesView sideBySideBar3DSeriesView2 = new DevExpress.XtraCharts.SideBySideBar3DSeriesView();
			DevExpress.XtraCharts.XYDiagram xyDiagram2 = new DevExpress.XtraCharts.XYDiagram();
			DevExpress.XtraCharts.Series series6 = new DevExpress.XtraCharts.Series();
			this.chartToplamGelir = new DevExpress.XtraCharts.ChartControl();
			this.chartProjeDurumu = new DevExpress.XtraCharts.ChartControl();
			this.gridControl1 = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lblSonFaturaMusteri = new System.Windows.Forms.Label();
			this.lblSonFaturaTutar = new System.Windows.Forms.Label();
			this.lblSonFaturaTarih = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.lblMusteriSayisi = new System.Windows.Forms.Label();
			this.progressTamamlandi = new DevExpress.XtraEditors.ProgressBarControl();
			this.progressDevamEdiyor = new DevExpress.XtraEditors.ProgressBarControl();
			this.progressIptalEdildi = new DevExpress.XtraEditors.ProgressBarControl();
			this.lblTamamlandi = new System.Windows.Forms.Label();
			this.lblDevamEdiyor = new System.Windows.Forms.Label();
			this.lblIptalEdildi = new System.Windows.Forms.Label();
			this.listView1 = new System.Windows.Forms.ListView();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
			this.gridControl3 = new DevExpress.XtraGrid.GridControl();
			this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this.chartToplamGelir)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(simpleDiagram3D2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(series4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(pie3DSeriesView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chartProjeDurumu)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(xyDiagram3D2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(series5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(sideBySideBar3DSeriesView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.progressTamamlandi.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.progressDevamEdiyor.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.progressIptalEdildi.Properties)).BeginInit();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(xyDiagram2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(series6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
			this.groupBox4.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.SuspendLayout();
			// 
			// chartToplamGelir
			// 
			this.chartToplamGelir.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.True;
			simpleDiagram3D2.RotationMatrixSerializable = "0.410646639761334;-0.909853449005455;-0.0594645994319973;0;0.861375924349295;0.40" +
    "849989846299;-0.301926066955353;0;0.298999756194092;0.0727635505497716;0.9514749" +
    "66306141;0;0;0;0;1";
			this.chartToplamGelir.Diagram = simpleDiagram3D2;
			this.chartToplamGelir.Location = new System.Drawing.Point(4, 22);
			this.chartToplamGelir.Margin = new System.Windows.Forms.Padding(2);
			this.chartToplamGelir.Name = "chartToplamGelir";
			this.chartToplamGelir.PaletteBaseColorNumber = 2;
			this.chartToplamGelir.PaletteName = "Concourse";
			series4.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False;
			series4.Name = "Series";
			series4.SeriesID = 0;
			series4.View = pie3DSeriesView2;
			this.chartToplamGelir.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series4};
			this.chartToplamGelir.Size = new System.Drawing.Size(347, 256);
			this.chartToplamGelir.TabIndex = 0;
			// 
			// chartProjeDurumu
			// 
			xyDiagram3D2.RotationMatrixSerializable = "-0.964051479177289;0.242513821179342;-0.108590018110076;0;0.226692368403619;0.963" +
    "85022463786;0.140011837260875;0;0.138619319013292;0.110362090423314;-0.984177267" +
    "261226;0;0;0;0;1";
			this.chartProjeDurumu.Diagram = xyDiagram3D2;
			this.chartProjeDurumu.Location = new System.Drawing.Point(5, 22);
			this.chartProjeDurumu.Name = "chartProjeDurumu";
			series5.Name = "Series2";
			series5.SeriesID = 1;
			series5.View = sideBySideBar3DSeriesView2;
			this.chartProjeDurumu.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series5};
			this.chartProjeDurumu.Size = new System.Drawing.Size(346, 289);
			this.chartProjeDurumu.TabIndex = 1;
			// 
			// gridControl1
			// 
			this.gridControl1.Location = new System.Drawing.Point(9, 299);
			this.gridControl1.MainView = this.gridView1;
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.Size = new System.Drawing.Size(714, 316);
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
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lblSonFaturaMusteri);
			this.groupBox1.Controls.Add(this.lblSonFaturaTutar);
			this.groupBox1.Controls.Add(this.lblSonFaturaTarih);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox1.Location = new System.Drawing.Point(733, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(242, 109);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Son Ödenen Fatura Bilgisi";
			// 
			// lblSonFaturaMusteri
			// 
			this.lblSonFaturaMusteri.AutoSize = true;
			this.lblSonFaturaMusteri.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblSonFaturaMusteri.Location = new System.Drawing.Point(16, 78);
			this.lblSonFaturaMusteri.Name = "lblSonFaturaMusteri";
			this.lblSonFaturaMusteri.Size = new System.Drawing.Size(61, 18);
			this.lblSonFaturaMusteri.TabIndex = 2;
			this.lblSonFaturaMusteri.Text = "Müşteri:";
			// 
			// lblSonFaturaTutar
			// 
			this.lblSonFaturaTutar.AutoSize = true;
			this.lblSonFaturaTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblSonFaturaTutar.Location = new System.Drawing.Point(16, 54);
			this.lblSonFaturaTutar.Name = "lblSonFaturaTutar";
			this.lblSonFaturaTutar.Size = new System.Drawing.Size(46, 18);
			this.lblSonFaturaTutar.TabIndex = 1;
			this.lblSonFaturaTutar.Text = "Tutar:";
			// 
			// lblSonFaturaTarih
			// 
			this.lblSonFaturaTarih.AutoSize = true;
			this.lblSonFaturaTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblSonFaturaTarih.Location = new System.Drawing.Point(16, 31);
			this.lblSonFaturaTarih.Name = "lblSonFaturaTarih";
			this.lblSonFaturaTarih.Size = new System.Drawing.Size(45, 18);
			this.lblSonFaturaTarih.TabIndex = 0;
			this.lblSonFaturaTarih.Text = "Tarih:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.lblMusteriSayisi);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox2.Location = new System.Drawing.Point(981, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(242, 109);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Toplam Müşteri Sayısı";
			// 
			// lblMusteriSayisi
			// 
			this.lblMusteriSayisi.AutoSize = true;
			this.lblMusteriSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblMusteriSayisi.Location = new System.Drawing.Point(67, 31);
			this.lblMusteriSayisi.Name = "lblMusteriSayisi";
			this.lblMusteriSayisi.Size = new System.Drawing.Size(78, 55);
			this.lblMusteriSayisi.TabIndex = 0;
			this.lblMusteriSayisi.Text = "10";
			// 
			// progressTamamlandi
			// 
			this.progressTamamlandi.Location = new System.Drawing.Point(1244, 44);
			this.progressTamamlandi.Name = "progressTamamlandi";
			this.progressTamamlandi.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
			this.progressTamamlandi.Properties.Appearance.BorderColor = System.Drawing.Color.Transparent;
			this.progressTamamlandi.Properties.Appearance.ForeColor = System.Drawing.Color.Transparent;
			this.progressTamamlandi.Size = new System.Drawing.Size(269, 36);
			this.progressTamamlandi.TabIndex = 6;
			// 
			// progressDevamEdiyor
			// 
			this.progressDevamEdiyor.Location = new System.Drawing.Point(1244, 123);
			this.progressDevamEdiyor.Name = "progressDevamEdiyor";
			this.progressDevamEdiyor.Size = new System.Drawing.Size(269, 36);
			this.progressDevamEdiyor.TabIndex = 7;
			// 
			// progressIptalEdildi
			// 
			this.progressIptalEdildi.Location = new System.Drawing.Point(1244, 202);
			this.progressIptalEdildi.Name = "progressIptalEdildi";
			this.progressIptalEdildi.Size = new System.Drawing.Size(269, 36);
			this.progressIptalEdildi.TabIndex = 8;
			// 
			// lblTamamlandi
			// 
			this.lblTamamlandi.AutoSize = true;
			this.lblTamamlandi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblTamamlandi.Location = new System.Drawing.Point(1250, 89);
			this.lblTamamlandi.Name = "lblTamamlandi";
			this.lblTamamlandi.Size = new System.Drawing.Size(51, 20);
			this.lblTamamlandi.TabIndex = 9;
			this.lblTamamlandi.Text = "label1";
			// 
			// lblDevamEdiyor
			// 
			this.lblDevamEdiyor.AutoSize = true;
			this.lblDevamEdiyor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblDevamEdiyor.Location = new System.Drawing.Point(1250, 171);
			this.lblDevamEdiyor.Name = "lblDevamEdiyor";
			this.lblDevamEdiyor.Size = new System.Drawing.Size(51, 20);
			this.lblDevamEdiyor.TabIndex = 10;
			this.lblDevamEdiyor.Text = "label1";
			// 
			// lblIptalEdildi
			// 
			this.lblIptalEdildi.AutoSize = true;
			this.lblIptalEdildi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblIptalEdildi.Location = new System.Drawing.Point(1250, 254);
			this.lblIptalEdildi.Name = "lblIptalEdildi";
			this.lblIptalEdildi.Size = new System.Drawing.Size(51, 20);
			this.lblIptalEdildi.TabIndex = 11;
			this.lblIptalEdildi.Text = "label1";
			// 
			// listView1
			// 
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(733, 127);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(491, 162);
			this.listView1.TabIndex = 12;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.chartControl1);
			this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox3.Location = new System.Drawing.Point(368, 11);
			this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox3.Size = new System.Drawing.Size(355, 282);
			this.groupBox3.TabIndex = 13;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Aylık Finansal Durum";
			// 
			// chartControl1
			// 
			xyDiagram2.AxisX.VisibleInPanesSerializable = "-1";
			xyDiagram2.AxisY.VisibleInPanesSerializable = "-1";
			this.chartControl1.Diagram = xyDiagram2;
			this.chartControl1.Location = new System.Drawing.Point(5, 24);
			this.chartControl1.Margin = new System.Windows.Forms.Padding(2);
			this.chartControl1.Name = "chartControl1";
			series6.Name = "Series";
			series6.SeriesID = 0;
			this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series6};
			this.chartControl1.Size = new System.Drawing.Size(346, 254);
			this.chartControl1.TabIndex = 0;
			// 
			// gridControl3
			// 
			this.gridControl3.Location = new System.Drawing.Point(1088, 299);
			this.gridControl3.MainView = this.gridView3;
			this.gridControl3.Name = "gridControl3";
			this.gridControl3.Size = new System.Drawing.Size(434, 311);
			this.gridControl3.TabIndex = 14;
			this.gridControl3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
			// 
			// gridView3
			// 
			this.gridView3.GridControl = this.gridControl3;
			this.gridView3.Name = "gridView3";
			this.gridView3.OptionsView.ShowGroupPanel = false;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.chartToplamGelir);
			this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox4.Location = new System.Drawing.Point(9, 12);
			this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox4.Size = new System.Drawing.Size(355, 282);
			this.groupBox4.TabIndex = 15;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Toplam Gelir/Gider Oranı";
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.chartProjeDurumu);
			this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox5.Location = new System.Drawing.Point(728, 299);
			this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox5.Size = new System.Drawing.Size(355, 316);
			this.groupBox5.TabIndex = 16;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Projelerin Durumu";
			// 
			// FrmAnasayfa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1525, 626);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.gridControl3);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.lblIptalEdildi);
			this.Controls.Add(this.lblDevamEdiyor);
			this.Controls.Add(this.lblTamamlandi);
			this.Controls.Add(this.progressIptalEdildi);
			this.Controls.Add(this.progressDevamEdiyor);
			this.Controls.Add(this.progressTamamlandi);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.gridControl1);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "FrmAnasayfa";
			this.Text = "Anasayfa";
			this.Load += new System.EventHandler(this.FrmAnasayfa_Load);
			((System.ComponentModel.ISupportInitialize)(simpleDiagram3D2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(pie3DSeriesView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(series4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chartToplamGelir)).EndInit();
			((System.ComponentModel.ISupportInitialize)(xyDiagram3D2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(sideBySideBar3DSeriesView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(series5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chartProjeDurumu)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.progressTamamlandi.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.progressDevamEdiyor.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.progressIptalEdildi.Properties)).EndInit();
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(xyDiagram2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(series6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
			this.groupBox4.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraCharts.ChartControl chartToplamGelir;
		private DevExpress.XtraCharts.ChartControl chartProjeDurumu;
		private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lblSonFaturaMusteri;
		private System.Windows.Forms.Label lblSonFaturaTutar;
		private System.Windows.Forms.Label lblSonFaturaTarih;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label lblMusteriSayisi;
		private DevExpress.XtraEditors.ProgressBarControl progressTamamlandi;
		private DevExpress.XtraEditors.ProgressBarControl progressDevamEdiyor;
		private DevExpress.XtraEditors.ProgressBarControl progressIptalEdildi;
		private System.Windows.Forms.Label lblTamamlandi;
		private System.Windows.Forms.Label lblDevamEdiyor;
		private System.Windows.Forms.Label lblIptalEdildi;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.GroupBox groupBox3;
		private DevExpress.XtraCharts.ChartControl chartControl1;
		private DevExpress.XtraGrid.GridControl gridControl3;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.GroupBox groupBox5;
	}
}