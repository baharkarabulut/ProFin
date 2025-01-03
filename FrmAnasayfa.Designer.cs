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
			DevExpress.XtraCharts.SimpleDiagram3D simpleDiagram3D3 = new DevExpress.XtraCharts.SimpleDiagram3D();
			DevExpress.XtraCharts.Series series5 = new DevExpress.XtraCharts.Series();
			DevExpress.XtraCharts.Pie3DSeriesView pie3DSeriesView3 = new DevExpress.XtraCharts.Pie3DSeriesView();
			DevExpress.XtraCharts.XYDiagram3D xyDiagram3D3 = new DevExpress.XtraCharts.XYDiagram3D();
			DevExpress.XtraCharts.Series series6 = new DevExpress.XtraCharts.Series();
			DevExpress.XtraCharts.SideBySideBar3DSeriesView sideBySideBar3DSeriesView3 = new DevExpress.XtraCharts.SideBySideBar3DSeriesView();
			this.chartToplamGelir = new DevExpress.XtraCharts.ChartControl();
			this.chartProjeDurumu = new DevExpress.XtraCharts.ChartControl();
			this.gridControl1 = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.gridControl2 = new DevExpress.XtraGrid.GridControl();
			this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
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
			this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
			this.progressProje = new DevExpress.XtraEditors.ProgressBarControl();
			this.progressGelir = new DevExpress.XtraEditors.ProgressBarControl();
			this.lblProjeHedefi = new DevExpress.XtraEditors.LabelControl();
			this.lblGelirHedefi = new DevExpress.XtraEditors.LabelControl();
			this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
			this.listViewEtkinlikler = new System.Windows.Forms.ListView();
			((System.ComponentModel.ISupportInitialize)(this.chartToplamGelir)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(simpleDiagram3D3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(series5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(pie3DSeriesView3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chartProjeDurumu)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(xyDiagram3D3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(series6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(sideBySideBar3DSeriesView3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.progressTamamlandi.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.progressDevamEdiyor.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.progressIptalEdildi.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
			this.groupControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.progressProje.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.progressGelir.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
			this.groupControl2.SuspendLayout();
			this.SuspendLayout();
			// 
			// chartToplamGelir
			// 
			this.chartToplamGelir.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.True;
			simpleDiagram3D3.RotationMatrixSerializable = "0.406818065349275;-0.913509108681075;-0.000412385968336935;0;0.83809101302482;0.3" +
    "73411242764804;-0.397702775529513;0;0.36345909755089;0.161447056750991;0.9175142" +
    "13663168;0;0;0;0;1";
			this.chartToplamGelir.Diagram = simpleDiagram3D3;
			this.chartToplamGelir.Location = new System.Drawing.Point(9, 10);
			this.chartToplamGelir.Margin = new System.Windows.Forms.Padding(2);
			this.chartToplamGelir.Name = "chartToplamGelir";
			this.chartToplamGelir.PaletteBaseColorNumber = 2;
			this.chartToplamGelir.PaletteName = "Concourse";
			series5.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False;
			series5.Name = "Series";
			series5.SeriesID = 0;
			series5.View = pie3DSeriesView3;
			this.chartToplamGelir.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series5};
			this.chartToplamGelir.Size = new System.Drawing.Size(379, 279);
			this.chartToplamGelir.TabIndex = 0;
			// 
			// chartProjeDurumu
			// 
			xyDiagram3D3.RotationMatrixSerializable = "-0.964051479177289;0.243979518882632;-0.10525559301981;0;0.226692368403619;0.9618" +
    "40478757345;0.153210520302815;0;0.138619319013292;0.123842189054065;-0.982572031" +
    "256068;0;0;0;0;1";
			this.chartProjeDurumu.Diagram = xyDiagram3D3;
			this.chartProjeDurumu.Location = new System.Drawing.Point(393, 10);
			this.chartProjeDurumu.Name = "chartProjeDurumu";
			series6.Name = "Series2";
			series6.SeriesID = 1;
			series6.View = sideBySideBar3DSeriesView3;
			this.chartProjeDurumu.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series6};
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
			this.gridControl2.Size = new System.Drawing.Size(241, 615);
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
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lblSonFaturaMusteri);
			this.groupBox1.Controls.Add(this.lblSonFaturaTutar);
			this.groupBox1.Controls.Add(this.lblSonFaturaTarih);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox1.Location = new System.Drawing.Point(1025, 10);
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
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox2.Location = new System.Drawing.Point(1273, 10);
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
			this.progressTamamlandi.Location = new System.Drawing.Point(1025, 125);
			this.progressTamamlandi.Name = "progressTamamlandi";
			this.progressTamamlandi.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
			this.progressTamamlandi.Properties.Appearance.BorderColor = System.Drawing.Color.Transparent;
			this.progressTamamlandi.Properties.Appearance.ForeColor = System.Drawing.Color.Transparent;
			this.progressTamamlandi.Size = new System.Drawing.Size(160, 36);
			this.progressTamamlandi.TabIndex = 6;
			// 
			// progressDevamEdiyor
			// 
			this.progressDevamEdiyor.Location = new System.Drawing.Point(1191, 125);
			this.progressDevamEdiyor.Name = "progressDevamEdiyor";
			this.progressDevamEdiyor.Size = new System.Drawing.Size(160, 36);
			this.progressDevamEdiyor.TabIndex = 7;
			// 
			// progressIptalEdildi
			// 
			this.progressIptalEdildi.Location = new System.Drawing.Point(1355, 125);
			this.progressIptalEdildi.Name = "progressIptalEdildi";
			this.progressIptalEdildi.Size = new System.Drawing.Size(160, 36);
			this.progressIptalEdildi.TabIndex = 8;
			// 
			// lblTamamlandi
			// 
			this.lblTamamlandi.AutoSize = true;
			this.lblTamamlandi.Location = new System.Drawing.Point(1052, 164);
			this.lblTamamlandi.Name = "lblTamamlandi";
			this.lblTamamlandi.Size = new System.Drawing.Size(35, 13);
			this.lblTamamlandi.TabIndex = 9;
			this.lblTamamlandi.Text = "label1";
			// 
			// lblDevamEdiyor
			// 
			this.lblDevamEdiyor.AutoSize = true;
			this.lblDevamEdiyor.Location = new System.Drawing.Point(1219, 164);
			this.lblDevamEdiyor.Name = "lblDevamEdiyor";
			this.lblDevamEdiyor.Size = new System.Drawing.Size(35, 13);
			this.lblDevamEdiyor.TabIndex = 10;
			this.lblDevamEdiyor.Text = "label1";
			// 
			// lblIptalEdildi
			// 
			this.lblIptalEdildi.AutoSize = true;
			this.lblIptalEdildi.Location = new System.Drawing.Point(1383, 164);
			this.lblIptalEdildi.Name = "lblIptalEdildi";
			this.lblIptalEdildi.Size = new System.Drawing.Size(35, 13);
			this.lblIptalEdildi.TabIndex = 11;
			this.lblIptalEdildi.Text = "label1";
			// 
			// listView1
			// 
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(1024, 189);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(491, 162);
			this.listView1.TabIndex = 12;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// groupControl1
			// 
			this.groupControl1.Controls.Add(this.progressProje);
			this.groupControl1.Controls.Add(this.progressGelir);
			this.groupControl1.Controls.Add(this.lblProjeHedefi);
			this.groupControl1.Controls.Add(this.lblGelirHedefi);
			this.groupControl1.Location = new System.Drawing.Point(1025, 357);
			this.groupControl1.Name = "groupControl1";
			this.groupControl1.Size = new System.Drawing.Size(242, 268);
			this.groupControl1.TabIndex = 13;
			this.groupControl1.Text = "Aylık Hedefler";
			// 
			// progressProje
			// 
			this.progressProje.Location = new System.Drawing.Point(11, 214);
			this.progressProje.Name = "progressProje";
			this.progressProje.Size = new System.Drawing.Size(215, 40);
			this.progressProje.TabIndex = 3;
			// 
			// progressGelir
			// 
			this.progressGelir.Location = new System.Drawing.Point(11, 98);
			this.progressGelir.Name = "progressGelir";
			this.progressGelir.Size = new System.Drawing.Size(215, 40);
			this.progressGelir.TabIndex = 2;
			// 
			// lblProjeHedefi
			// 
			this.lblProjeHedefi.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblProjeHedefi.Appearance.Options.UseFont = true;
			this.lblProjeHedefi.Location = new System.Drawing.Point(11, 154);
			this.lblProjeHedefi.Name = "lblProjeHedefi";
			this.lblProjeHedefi.Size = new System.Drawing.Size(122, 54);
			this.lblProjeHedefi.TabIndex = 1;
			this.lblProjeHedefi.Text = "Proje Hedefi:\r\nGüncel Proje:\r\nKalan Hedef Proje:";
			// 
			// lblGelirHedefi
			// 
			this.lblGelirHedefi.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblGelirHedefi.Appearance.Options.UseFont = true;
			this.lblGelirHedefi.Location = new System.Drawing.Point(11, 38);
			this.lblGelirHedefi.Name = "lblGelirHedefi";
			this.lblGelirHedefi.Size = new System.Drawing.Size(116, 54);
			this.lblGelirHedefi.TabIndex = 0;
			this.lblGelirHedefi.Text = "Gelir Hedefi:\r\nGüncel Gelir: \r\nKalan Hedef Gelir:";
			// 
			// groupControl2
			// 
			this.groupControl2.Controls.Add(this.listViewEtkinlikler);
			this.groupControl2.Location = new System.Drawing.Point(1273, 357);
			this.groupControl2.Name = "groupControl2";
			this.groupControl2.Size = new System.Drawing.Size(242, 268);
			this.groupControl2.TabIndex = 14;
			this.groupControl2.Text = "Yaklaşan Etkinlikler";
			// 
			// listViewEtkinlikler
			// 
			this.listViewEtkinlikler.HideSelection = false;
			this.listViewEtkinlikler.Location = new System.Drawing.Point(5, 38);
			this.listViewEtkinlikler.Name = "listViewEtkinlikler";
			this.listViewEtkinlikler.Size = new System.Drawing.Size(232, 216);
			this.listViewEtkinlikler.TabIndex = 0;
			this.listViewEtkinlikler.UseCompatibleStateImageBehavior = false;
			this.listViewEtkinlikler.View = System.Windows.Forms.View.Details;
			// 
			// FrmAnasayfa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1525, 626);
			this.Controls.Add(this.groupControl2);
			this.Controls.Add(this.groupControl1);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.lblIptalEdildi);
			this.Controls.Add(this.lblDevamEdiyor);
			this.Controls.Add(this.lblTamamlandi);
			this.Controls.Add(this.progressIptalEdildi);
			this.Controls.Add(this.progressDevamEdiyor);
			this.Controls.Add(this.progressTamamlandi);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.gridControl2);
			this.Controls.Add(this.gridControl1);
			this.Controls.Add(this.chartProjeDurumu);
			this.Controls.Add(this.chartToplamGelir);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "FrmAnasayfa";
			this.Text = "Anasayfa";
			this.Load += new System.EventHandler(this.FrmAnasayfa_Load);
			((System.ComponentModel.ISupportInitialize)(simpleDiagram3D3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(pie3DSeriesView3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(series5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chartToplamGelir)).EndInit();
			((System.ComponentModel.ISupportInitialize)(xyDiagram3D3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(sideBySideBar3DSeriesView3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(series6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chartProjeDurumu)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.progressTamamlandi.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.progressDevamEdiyor.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.progressIptalEdildi.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
			this.groupControl1.ResumeLayout(false);
			this.groupControl1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.progressProje.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.progressGelir.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
			this.groupControl2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraCharts.ChartControl chartToplamGelir;
		private DevExpress.XtraCharts.ChartControl chartProjeDurumu;
		private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraGrid.GridControl gridControl2;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
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
		private DevExpress.XtraEditors.GroupControl groupControl1;
		private DevExpress.XtraEditors.LabelControl lblProjeHedefi;
		private DevExpress.XtraEditors.LabelControl lblGelirHedefi;
		private DevExpress.XtraEditors.ProgressBarControl progressProje;
		private DevExpress.XtraEditors.ProgressBarControl progressGelir;
		private DevExpress.XtraEditors.GroupControl groupControl2;
		private System.Windows.Forms.ListView listViewEtkinlikler;
	}
}