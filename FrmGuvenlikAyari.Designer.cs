namespace ProFin
{
	partial class FrmGuvenlikAyari
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
			this.txtMevcutSifre = new System.Windows.Forms.TextBox();
			this.txtYeniSifre = new System.Windows.Forms.TextBox();
			this.txtYeniSifreTekrar = new System.Windows.Forms.TextBox();
			this.btnSifreDegistir = new DevExpress.XtraEditors.SimpleButton();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtMevcutSifre
			// 
			this.txtMevcutSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtMevcutSifre.Location = new System.Drawing.Point(238, 123);
			this.txtMevcutSifre.Name = "txtMevcutSifre";
			this.txtMevcutSifre.PasswordChar = '*';
			this.txtMevcutSifre.Size = new System.Drawing.Size(209, 30);
			this.txtMevcutSifre.TabIndex = 0;
			// 
			// txtYeniSifre
			// 
			this.txtYeniSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtYeniSifre.Location = new System.Drawing.Point(238, 173);
			this.txtYeniSifre.Name = "txtYeniSifre";
			this.txtYeniSifre.PasswordChar = '*';
			this.txtYeniSifre.Size = new System.Drawing.Size(209, 30);
			this.txtYeniSifre.TabIndex = 1;
			// 
			// txtYeniSifreTekrar
			// 
			this.txtYeniSifreTekrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtYeniSifreTekrar.Location = new System.Drawing.Point(238, 225);
			this.txtYeniSifreTekrar.Name = "txtYeniSifreTekrar";
			this.txtYeniSifreTekrar.PasswordChar = '*';
			this.txtYeniSifreTekrar.Size = new System.Drawing.Size(209, 30);
			this.txtYeniSifreTekrar.TabIndex = 2;
			// 
			// btnSifreDegistir
			// 
			this.btnSifreDegistir.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnSifreDegistir.Appearance.Options.UseFont = true;
			this.btnSifreDegistir.Location = new System.Drawing.Point(238, 288);
			this.btnSifreDegistir.Name = "btnSifreDegistir";
			this.btnSifreDegistir.Size = new System.Drawing.Size(209, 47);
			this.btnSifreDegistir.TabIndex = 3;
			this.btnSifreDegistir.Text = "Şifre Değiştir";
			this.btnSifreDegistir.Click += new System.EventHandler(this.btnSifreDegistir_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(105, 128);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(127, 25);
			this.label1.TabIndex = 4;
			this.label1.Text = "Mevcut Şifre:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(130, 176);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(102, 25);
			this.label2.TabIndex = 5;
			this.label2.Text = "Yeni Şifre:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(68, 230);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(164, 25);
			this.label3.TabIndex = 6;
			this.label3.Text = "Yeni Şifre Tekrar:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.Location = new System.Drawing.Point(12, 25);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(528, 25);
			this.label4.TabIndex = 7;
			this.label4.Text = "Sistem güvenliği için şifrenizi kimseyle paylaşmayınız!";
			// 
			// FrmGuvenlikAyari
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(552, 386);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnSifreDegistir);
			this.Controls.Add(this.txtYeniSifreTekrar);
			this.Controls.Add(this.txtYeniSifre);
			this.Controls.Add(this.txtMevcutSifre);
			this.Name = "FrmGuvenlikAyari";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Güvenlik Ayarları";
			this.Load += new System.EventHandler(this.FrmGuvenlikAyari_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtMevcutSifre;
		private System.Windows.Forms.TextBox txtYeniSifre;
		private System.Windows.Forms.TextBox txtYeniSifreTekrar;
		private DevExpress.XtraEditors.SimpleButton btnSifreDegistir;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
	}
}