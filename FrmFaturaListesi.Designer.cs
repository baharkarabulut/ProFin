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
			this.gridControl1 = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.BtnFaturaOlustur = new DevExpress.XtraEditors.SimpleButton();
			this.BtnYenile = new DevExpress.XtraEditors.SimpleButton();
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
			// FrmFaturaListesi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1529, 611);
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
	}
}