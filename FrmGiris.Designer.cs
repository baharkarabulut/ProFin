namespace ProFin
{
	partial class FrmGiris
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
			this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
			this.txtSifre = new System.Windows.Forms.MaskedTextBox();
			this.btnGiris = new DevExpress.XtraEditors.SimpleButton();
			this.label1 = new System.Windows.Forms.Label();
			this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtKullaniciAdi
			// 
			this.txtKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtKullaniciAdi.Location = new System.Drawing.Point(121, 113);
			this.txtKullaniciAdi.Name = "txtKullaniciAdi";
			this.txtKullaniciAdi.Size = new System.Drawing.Size(208, 29);
			this.txtKullaniciAdi.TabIndex = 0;
			// 
			// txtSifre
			// 
			this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtSifre.Location = new System.Drawing.Point(121, 174);
			this.txtSifre.Name = "txtSifre";
			this.txtSifre.PasswordChar = '*';
			this.txtSifre.Size = new System.Drawing.Size(208, 29);
			this.txtSifre.TabIndex = 1;
			// 
			// btnGiris
			// 
			this.btnGiris.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnGiris.Appearance.Options.UseFont = true;
			this.btnGiris.Location = new System.Drawing.Point(121, 236);
			this.btnGiris.Name = "btnGiris";
			this.btnGiris.Size = new System.Drawing.Size(208, 44);
			this.btnGiris.TabIndex = 2;
			this.btnGiris.Text = "Giriş";
			this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Castellar", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(97, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(168, 42);
			this.label1.TabIndex = 3;
			this.label1.Text = "ProFin";
			// 
			// panelControl1
			// 
			this.panelControl1.Appearance.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.panelControl1.Appearance.BorderColor = System.Drawing.Color.Black;
			this.panelControl1.Appearance.Options.UseBackColor = true;
			this.panelControl1.Appearance.Options.UseBorderColor = true;
			this.panelControl1.Controls.Add(this.label3);
			this.panelControl1.Controls.Add(this.label2);
			this.panelControl1.Controls.Add(this.btnGiris);
			this.panelControl1.Controls.Add(this.label1);
			this.panelControl1.Controls.Add(this.txtKullaniciAdi);
			this.panelControl1.Controls.Add(this.txtSifre);
			this.panelControl1.Location = new System.Drawing.Point(192, 40);
			this.panelControl1.Name = "panelControl1";
			this.panelControl1.Size = new System.Drawing.Size(352, 320);
			this.panelControl1.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(19, 119);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(102, 19);
			this.label2.TabIndex = 4;
			this.label2.Text = "Kullanıcı Adı:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(74, 180);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(47, 19);
			this.label3.TabIndex = 5;
			this.label3.Text = "Şifre:";
			// 
			// FrmGiris
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.ClientSize = new System.Drawing.Size(778, 414);
			this.Controls.Add(this.panelControl1);
			this.Name = "FrmGiris";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Giriş Ekranı";
			this.Load += new System.EventHandler(this.FrmGiris_Load);
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			this.panelControl1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox txtKullaniciAdi;
		private System.Windows.Forms.MaskedTextBox txtSifre;
		private DevExpress.XtraEditors.SimpleButton btnGiris;
		private System.Windows.Forms.Label label1;
		private DevExpress.XtraEditors.PanelControl panelControl1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
	}
}