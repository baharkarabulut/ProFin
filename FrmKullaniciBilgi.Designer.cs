﻿namespace ProFin
{
	partial class FrmKullaniciBilgi
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnKullaniciEkle = new DevExpress.XtraEditors.SimpleButton();
			this.btnDuzenle = new DevExpress.XtraEditors.SimpleButton();
			this.btnKullaniciSil = new DevExpress.XtraEditors.SimpleButton();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// gridControl1
			// 
			this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.gridControl1.Location = new System.Drawing.Point(8, 31);
			this.gridControl1.MainView = this.gridView1;
			this.gridControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.Size = new System.Drawing.Size(484, 486);
			this.gridControl1.TabIndex = 0;
			this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// gridView1
			// 
			this.gridView1.DetailHeight = 431;
			this.gridView1.GridControl = this.gridControl1;
			this.gridView1.Name = "gridView1";
			this.gridView1.OptionsEditForm.PopupEditFormWidth = 1067;
			this.gridView1.OptionsView.ShowGroupPanel = false;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.gridControl1);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox1.Location = new System.Drawing.Point(16, 15);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox1.Size = new System.Drawing.Size(503, 524);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Kullanıcılar";
			// 
			// btnKullaniciEkle
			// 
			this.btnKullaniciEkle.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnKullaniciEkle.Appearance.Options.UseFont = true;
			this.btnKullaniciEkle.Location = new System.Drawing.Point(16, 546);
			this.btnKullaniciEkle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnKullaniciEkle.Name = "btnKullaniciEkle";
			this.btnKullaniciEkle.Size = new System.Drawing.Size(155, 64);
			this.btnKullaniciEkle.TabIndex = 2;
			this.btnKullaniciEkle.Text = "Kullanıcı Ekle";
			this.btnKullaniciEkle.Click += new System.EventHandler(this.btnKullaniciEkle_Click);
			// 
			// btnDuzenle
			// 
			this.btnDuzenle.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnDuzenle.Appearance.Options.UseFont = true;
			this.btnDuzenle.Location = new System.Drawing.Point(191, 546);
			this.btnDuzenle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnDuzenle.Name = "btnDuzenle";
			this.btnDuzenle.Size = new System.Drawing.Size(155, 64);
			this.btnDuzenle.TabIndex = 3;
			this.btnDuzenle.Text = "Düzenle";
			// 
			// btnKullaniciSil
			// 
			this.btnKullaniciSil.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnKullaniciSil.Appearance.Options.UseFont = true;
			this.btnKullaniciSil.Location = new System.Drawing.Point(364, 546);
			this.btnKullaniciSil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnKullaniciSil.Name = "btnKullaniciSil";
			this.btnKullaniciSil.Size = new System.Drawing.Size(155, 64);
			this.btnKullaniciSil.TabIndex = 4;
			this.btnKullaniciSil.Text = "Kullanıcı Sil";
			// 
			// FrmKullaniciBilgi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(524, 622);
			this.Controls.Add(this.btnKullaniciSil);
			this.Controls.Add(this.btnDuzenle);
			this.Controls.Add(this.btnKullaniciEkle);
			this.Controls.Add(this.groupBox1);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "FrmKullaniciBilgi";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Kullanıcı Bilgileri";
			this.Load += new System.EventHandler(this.FrmKullaniciBilgi_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private System.Windows.Forms.GroupBox groupBox1;
		private DevExpress.XtraEditors.SimpleButton btnKullaniciEkle;
		private DevExpress.XtraEditors.SimpleButton btnDuzenle;
		private DevExpress.XtraEditors.SimpleButton btnKullaniciSil;
	}
}