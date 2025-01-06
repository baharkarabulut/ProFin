namespace ProFin
{
	partial class FrmFaturaListesi
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFaturaListesi));
			this.gridControl1 = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.BtnFaturaOlustur = new DevExpress.XtraEditors.SimpleButton();
			this.BtnYenile = new DevExpress.XtraEditors.SimpleButton();
			this.btnYazdir = new DevExpress.XtraEditors.SimpleButton();
			this.btnPdfAktar = new DevExpress.XtraEditors.SimpleButton();
			this.btnExcelAktar = new DevExpress.XtraEditors.SimpleButton();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// gridControl1
			// 
			this.gridControl1.Location = new System.Drawing.Point(4, 2);
			this.gridControl1.MainView = this.gridView1;
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.Size = new System.Drawing.Size(1525, 552);
			this.gridControl1.TabIndex = 0;
			this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// gridView1
			// 
			this.gridView1.GridControl = this.gridControl1;
			this.gridView1.Name = "gridView1";
			this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
			// 
			// BtnFaturaOlustur
			// 
			this.BtnFaturaOlustur.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.BtnFaturaOlustur.Appearance.Options.UseFont = true;
			this.BtnFaturaOlustur.Location = new System.Drawing.Point(4, 560);
			this.BtnFaturaOlustur.Name = "BtnFaturaOlustur";
			this.BtnFaturaOlustur.Size = new System.Drawing.Size(215, 49);
			this.BtnFaturaOlustur.TabIndex = 1;
			this.BtnFaturaOlustur.Text = "YENİ FATURA EKLE";
			this.BtnFaturaOlustur.Click += new System.EventHandler(this.simpleButton1_Click);
			// 
			// BtnYenile
			// 
			this.BtnYenile.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.BtnYenile.Appearance.Options.UseFont = true;
			this.BtnYenile.Location = new System.Drawing.Point(225, 560);
			this.BtnYenile.Name = "BtnYenile";
			this.BtnYenile.Size = new System.Drawing.Size(186, 49);
			this.BtnYenile.TabIndex = 3;
			this.BtnYenile.Text = "YENİLE";
			this.BtnYenile.Click += new System.EventHandler(this.BtnYenile_Click);
			// 
			// btnYazdir
			// 
			this.btnYazdir.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnYazdir.Appearance.Options.UseFont = true;
			this.btnYazdir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnYazdir.ImageOptions.Image")));
			this.btnYazdir.Location = new System.Drawing.Point(666, 560);
			this.btnYazdir.Name = "btnYazdir";
			this.btnYazdir.Size = new System.Drawing.Size(114, 49);
			this.btnYazdir.TabIndex = 9;
			this.btnYazdir.Text = "Yazdır";
			this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
			// 
			// btnPdfAktar
			// 
			this.btnPdfAktar.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnPdfAktar.Appearance.Options.UseFont = true;
			this.btnPdfAktar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPdfAktar.ImageOptions.Image")));
			this.btnPdfAktar.Location = new System.Drawing.Point(546, 560);
			this.btnPdfAktar.Name = "btnPdfAktar";
			this.btnPdfAktar.Size = new System.Drawing.Size(114, 49);
			this.btnPdfAktar.TabIndex = 8;
			this.btnPdfAktar.Text = "PDF\'e \r\nAktar";
			this.btnPdfAktar.Click += new System.EventHandler(this.btnPdfAktar_Click);
			// 
			// btnExcelAktar
			// 
			this.btnExcelAktar.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnExcelAktar.Appearance.Options.UseFont = true;
			this.btnExcelAktar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExcelAktar.ImageOptions.Image")));
			this.btnExcelAktar.Location = new System.Drawing.Point(426, 560);
			this.btnExcelAktar.Name = "btnExcelAktar";
			this.btnExcelAktar.Size = new System.Drawing.Size(114, 49);
			this.btnExcelAktar.TabIndex = 7;
			this.btnExcelAktar.Text = "Excel\'e \r\nAktar";
			this.btnExcelAktar.Click += new System.EventHandler(this.btnExcelAktar_Click);
			// 
			// FrmFaturaListesi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1529, 611);
			this.Controls.Add(this.btnYazdir);
			this.Controls.Add(this.btnPdfAktar);
			this.Controls.Add(this.btnExcelAktar);
			this.Controls.Add(this.BtnYenile);
			this.Controls.Add(this.BtnFaturaOlustur);
			this.Controls.Add(this.gridControl1);
			this.Name = "FrmFaturaListesi";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Fatura Listesi";
			this.Load += new System.EventHandler(this.FrmFaturaListesi_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraEditors.SimpleButton BtnFaturaOlustur;
		private DevExpress.XtraEditors.SimpleButton BtnYenile;
		private DevExpress.XtraEditors.SimpleButton btnYazdir;
		private DevExpress.XtraEditors.SimpleButton btnPdfAktar;
		private DevExpress.XtraEditors.SimpleButton btnExcelAktar;
	}
}