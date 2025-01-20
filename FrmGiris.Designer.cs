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
			this.SuspendLayout();
			// 
			// txtKullaniciAdi
			// 
			this.txtKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtKullaniciAdi.Location = new System.Drawing.Point(280, 114);
			this.txtKullaniciAdi.Name = "txtKullaniciAdi";
			this.txtKullaniciAdi.Size = new System.Drawing.Size(208, 29);
			this.txtKullaniciAdi.TabIndex = 0;
			// 
			// txtSifre
			// 
			this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtSifre.Location = new System.Drawing.Point(280, 170);
			this.txtSifre.Name = "txtSifre";
			this.txtSifre.Size = new System.Drawing.Size(208, 29);
			this.txtSifre.TabIndex = 1;
			// 
			// btnGiris
			// 
			this.btnGiris.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnGiris.Appearance.Options.UseFont = true;
			this.btnGiris.Location = new System.Drawing.Point(280, 228);
			this.btnGiris.Name = "btnGiris";
			this.btnGiris.Size = new System.Drawing.Size(208, 44);
			this.btnGiris.TabIndex = 2;
			this.btnGiris.Text = "Giriş";
			this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(346, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 24);
			this.label1.TabIndex = 3;
			this.label1.Text = "ProFin";
			// 
			// FrmGiris
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnGiris);
			this.Controls.Add(this.txtSifre);
			this.Controls.Add(this.txtKullaniciAdi);
			this.Name = "FrmGiris";
			this.Text = "Giriş Ekranı";
			this.Load += new System.EventHandler(this.FrmGiris_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtKullaniciAdi;
		private System.Windows.Forms.MaskedTextBox txtSifre;
		private DevExpress.XtraEditors.SimpleButton btnGiris;
		private System.Windows.Forms.Label label1;
	}
}