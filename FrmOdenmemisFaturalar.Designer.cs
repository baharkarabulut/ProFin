namespace ProFin
{
	partial class FrmOdenmemisFaturalar
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnOdemeYap = new DevExpress.XtraEditors.SimpleButton();
			this.txtFaturaID = new System.Windows.Forms.TextBox();
			this.txtFaturaNumarasi = new System.Windows.Forms.TextBox();
			this.txtToplamTutar = new System.Windows.Forms.TextBox();
			this.txtOdemeDurumu = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// gridControl1
			// 
			this.gridControl1.Location = new System.Drawing.Point(3, 3);
			this.gridControl1.MainView = this.gridView1;
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.Size = new System.Drawing.Size(428, 400);
			this.gridControl1.TabIndex = 0;
			this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// gridView1
			// 
			this.gridView1.GridControl = this.gridControl1;
			this.gridView1.Name = "gridView1";
			this.gridView1.OptionsView.ShowGroupPanel = false;
			this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
			this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtOdemeDurumu);
			this.groupBox1.Controls.Add(this.txtToplamTutar);
			this.groupBox1.Controls.Add(this.txtFaturaNumarasi);
			this.groupBox1.Controls.Add(this.txtFaturaID);
			this.groupBox1.Controls.Add(this.btnOdemeYap);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox1.Location = new System.Drawing.Point(437, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(336, 400);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Fatura";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(51, 59);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(81, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Fatura ID:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(1, 112);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(131, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Fatura Numarası:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 223);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(126, 20);
			this.label3.TabIndex = 3;
			this.label3.Text = "Ödeme Durumu:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(26, 167);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(106, 20);
			this.label4.TabIndex = 2;
			this.label4.Text = "Toplam Tutar:";
			// 
			// btnOdemeYap
			// 
			this.btnOdemeYap.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnOdemeYap.Appearance.Options.UseFont = true;
			this.btnOdemeYap.Location = new System.Drawing.Point(138, 347);
			this.btnOdemeYap.Name = "btnOdemeYap";
			this.btnOdemeYap.Size = new System.Drawing.Size(188, 47);
			this.btnOdemeYap.TabIndex = 4;
			this.btnOdemeYap.Text = "ÖDEME YAP";
			this.btnOdemeYap.Click += new System.EventHandler(this.btnOdemeYap_Click);
			// 
			// txtFaturaID
			// 
			this.txtFaturaID.Location = new System.Drawing.Point(138, 56);
			this.txtFaturaID.Name = "txtFaturaID";
			this.txtFaturaID.Size = new System.Drawing.Size(188, 26);
			this.txtFaturaID.TabIndex = 5;
			// 
			// txtFaturaNumarasi
			// 
			this.txtFaturaNumarasi.Location = new System.Drawing.Point(138, 109);
			this.txtFaturaNumarasi.Name = "txtFaturaNumarasi";
			this.txtFaturaNumarasi.Size = new System.Drawing.Size(188, 26);
			this.txtFaturaNumarasi.TabIndex = 6;
			// 
			// txtToplamTutar
			// 
			this.txtToplamTutar.Location = new System.Drawing.Point(138, 164);
			this.txtToplamTutar.Name = "txtToplamTutar";
			this.txtToplamTutar.Size = new System.Drawing.Size(188, 26);
			this.txtToplamTutar.TabIndex = 7;
			// 
			// txtOdemeDurumu
			// 
			this.txtOdemeDurumu.Location = new System.Drawing.Point(138, 220);
			this.txtOdemeDurumu.Name = "txtOdemeDurumu";
			this.txtOdemeDurumu.Size = new System.Drawing.Size(188, 26);
			this.txtOdemeDurumu.TabIndex = 8;
			// 
			// FrmOdenmemisFaturalar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(778, 405);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.gridControl1);
			this.Name = "FrmOdenmemisFaturalar";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Ödemesi Alınmamış Faturalar";
			this.Load += new System.EventHandler(this.FrmOdenmemisFaturalar_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtOdemeDurumu;
		private System.Windows.Forms.TextBox txtToplamTutar;
		private System.Windows.Forms.TextBox txtFaturaNumarasi;
		private System.Windows.Forms.TextBox txtFaturaID;
		private DevExpress.XtraEditors.SimpleButton btnOdemeYap;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}