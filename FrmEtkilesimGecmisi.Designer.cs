namespace ProFin
{
	partial class FrmEtkilesimGecmisi
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
			this.gridControlEtkilesim = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cmbEtkilesimTuru = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.cmbMusteri = new System.Windows.Forms.ComboBox();
			this.cmbProje = new System.Windows.Forms.ComboBox();
			this.dateEtkilesimTarihi = new DevExpress.XtraEditors.DateEdit();
			this.txtDetay = new System.Windows.Forms.TextBox();
			this.btnEtkilesimEkle = new DevExpress.XtraEditors.SimpleButton();
			this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
			this.btnSil = new DevExpress.XtraEditors.SimpleButton();
			((System.ComponentModel.ISupportInitialize)(this.gridControlEtkilesim)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dateEtkilesimTarihi.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dateEtkilesimTarihi.Properties.CalendarTimeProperties)).BeginInit();
			this.SuspendLayout();
			// 
			// gridControlEtkilesim
			// 
			this.gridControlEtkilesim.Location = new System.Drawing.Point(4, 273);
			this.gridControlEtkilesim.MainView = this.gridView1;
			this.gridControlEtkilesim.Name = "gridControlEtkilesim";
			this.gridControlEtkilesim.Size = new System.Drawing.Size(624, 333);
			this.gridControlEtkilesim.TabIndex = 0;
			this.gridControlEtkilesim.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// gridView1
			// 
			this.gridView1.GridControl = this.gridControlEtkilesim;
			this.gridView1.Name = "gridView1";
			this.gridView1.OptionsView.ShowGroupPanel = false;
			this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnSil);
			this.groupBox1.Controls.Add(this.btnGuncelle);
			this.groupBox1.Controls.Add(this.btnEtkilesimEkle);
			this.groupBox1.Controls.Add(this.txtDetay);
			this.groupBox1.Controls.Add(this.dateEtkilesimTarihi);
			this.groupBox1.Controls.Add(this.cmbProje);
			this.groupBox1.Controls.Add(this.cmbMusteri);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.cmbEtkilesimTuru);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox1.Location = new System.Drawing.Point(4, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(624, 264);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Etkileşim Ekle";
			// 
			// cmbEtkilesimTuru
			// 
			this.cmbEtkilesimTuru.FormattingEnabled = true;
			this.cmbEtkilesimTuru.Location = new System.Drawing.Point(161, 37);
			this.cmbEtkilesimTuru.Name = "cmbEtkilesimTuru";
			this.cmbEtkilesimTuru.Size = new System.Drawing.Size(194, 28);
			this.cmbEtkilesimTuru.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(43, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(112, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Etkileşim Türü:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(37, 166);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(118, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Etkileşim Tarihi:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(39, 82);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(116, 20);
			this.label3.TabIndex = 3;
			this.label3.Text = "Müşteri Seçimi:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(55, 124);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 20);
			this.label4.TabIndex = 4;
			this.label4.Text = "Proje Seçimi:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(83, 208);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(72, 20);
			this.label5.TabIndex = 5;
			this.label5.Text = "Detaylar:";
			// 
			// cmbMusteri
			// 
			this.cmbMusteri.FormattingEnabled = true;
			this.cmbMusteri.Location = new System.Drawing.Point(161, 79);
			this.cmbMusteri.Name = "cmbMusteri";
			this.cmbMusteri.Size = new System.Drawing.Size(194, 28);
			this.cmbMusteri.TabIndex = 6;
			// 
			// cmbProje
			// 
			this.cmbProje.FormattingEnabled = true;
			this.cmbProje.Location = new System.Drawing.Point(161, 121);
			this.cmbProje.Name = "cmbProje";
			this.cmbProje.Size = new System.Drawing.Size(194, 28);
			this.cmbProje.TabIndex = 7;
			// 
			// dateEtkilesimTarihi
			// 
			this.dateEtkilesimTarihi.EditValue = null;
			this.dateEtkilesimTarihi.Location = new System.Drawing.Point(161, 163);
			this.dateEtkilesimTarihi.Name = "dateEtkilesimTarihi";
			this.dateEtkilesimTarihi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.dateEtkilesimTarihi.Properties.Appearance.Options.UseFont = true;
			this.dateEtkilesimTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dateEtkilesimTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dateEtkilesimTarihi.Size = new System.Drawing.Size(194, 26);
			this.dateEtkilesimTarihi.TabIndex = 8;
			// 
			// txtDetay
			// 
			this.txtDetay.Location = new System.Drawing.Point(161, 205);
			this.txtDetay.Name = "txtDetay";
			this.txtDetay.Size = new System.Drawing.Size(194, 26);
			this.txtDetay.TabIndex = 9;
			// 
			// btnEtkilesimEkle
			// 
			this.btnEtkilesimEkle.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnEtkilesimEkle.Appearance.Options.UseFont = true;
			this.btnEtkilesimEkle.Location = new System.Drawing.Point(439, 51);
			this.btnEtkilesimEkle.Name = "btnEtkilesimEkle";
			this.btnEtkilesimEkle.Size = new System.Drawing.Size(179, 51);
			this.btnEtkilesimEkle.TabIndex = 10;
			this.btnEtkilesimEkle.Text = "EKLE";
			this.btnEtkilesimEkle.Click += new System.EventHandler(this.btnEtkilesimEkle_Click);
			// 
			// btnGuncelle
			// 
			this.btnGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnGuncelle.Appearance.Options.UseFont = true;
			this.btnGuncelle.Location = new System.Drawing.Point(439, 109);
			this.btnGuncelle.Name = "btnGuncelle";
			this.btnGuncelle.Size = new System.Drawing.Size(179, 51);
			this.btnGuncelle.TabIndex = 11;
			this.btnGuncelle.Text = "GÜNCELLE";
			this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
			// 
			// btnSil
			// 
			this.btnSil.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnSil.Appearance.Options.UseFont = true;
			this.btnSil.Location = new System.Drawing.Point(439, 166);
			this.btnSil.Name = "btnSil";
			this.btnSil.Size = new System.Drawing.Size(179, 51);
			this.btnSil.TabIndex = 12;
			this.btnSil.Text = "SİL";
			this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
			// 
			// FrmEtkilesimGecmisi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(632, 608);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.gridControlEtkilesim);
			this.Name = "FrmEtkilesimGecmisi";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Etkileşim Geçmişi";
			this.Load += new System.EventHandler(this.FrmEtkilesimGecmisi_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridControlEtkilesim)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dateEtkilesimTarihi.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dateEtkilesimTarihi.Properties)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraGrid.GridControl gridControlEtkilesim;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtDetay;
		private DevExpress.XtraEditors.DateEdit dateEtkilesimTarihi;
		private System.Windows.Forms.ComboBox cmbProje;
		private System.Windows.Forms.ComboBox cmbMusteri;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmbEtkilesimTuru;
		private DevExpress.XtraEditors.SimpleButton btnSil;
		private DevExpress.XtraEditors.SimpleButton btnGuncelle;
		private DevExpress.XtraEditors.SimpleButton btnEtkilesimEkle;
	}
}