namespace ProFin
{
	partial class FrmMusteriAnalizi
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
			this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.lblToplamMusteri = new System.Windows.Forms.Label();
			this.lblEnCokProje = new System.Windows.Forms.Label();
			this.lblEnYuksekGelir = new System.Windows.Forms.Label();
			this.gridControlMusteriAnalizi = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.gridControl1 = new DevExpress.XtraGrid.GridControl();
			this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.gridControl2 = new DevExpress.XtraGrid.GridControl();
			this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridControlMusteriAnalizi)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
			this.SuspendLayout();
			// 
			// panelControl1
			// 
			this.panelControl1.Controls.Add(this.lblEnYuksekGelir);
			this.panelControl1.Controls.Add(this.lblEnCokProje);
			this.panelControl1.Controls.Add(this.lblToplamMusteri);
			this.panelControl1.Location = new System.Drawing.Point(3, 3);
			this.panelControl1.Name = "panelControl1";
			this.panelControl1.Size = new System.Drawing.Size(464, 265);
			this.panelControl1.TabIndex = 0;
			// 
			// lblToplamMusteri
			// 
			this.lblToplamMusteri.AutoSize = true;
			this.lblToplamMusteri.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblToplamMusteri.Location = new System.Drawing.Point(13, 18);
			this.lblToplamMusteri.Name = "lblToplamMusteri";
			this.lblToplamMusteri.Size = new System.Drawing.Size(146, 23);
			this.lblToplamMusteri.TabIndex = 0;
			this.lblToplamMusteri.Text = "Toplam Musteri:";
			// 
			// lblEnCokProje
			// 
			this.lblEnCokProje.AutoSize = true;
			this.lblEnCokProje.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblEnCokProje.Location = new System.Drawing.Point(13, 93);
			this.lblEnCokProje.Name = "lblEnCokProje";
			this.lblEnCokProje.Size = new System.Drawing.Size(123, 23);
			this.lblEnCokProje.TabIndex = 3;
			this.lblEnCokProje.Text = "En Çok Proje:";
			// 
			// lblEnYuksekGelir
			// 
			this.lblEnYuksekGelir.AutoSize = true;
			this.lblEnYuksekGelir.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblEnYuksekGelir.Location = new System.Drawing.Point(13, 173);
			this.lblEnYuksekGelir.Name = "lblEnYuksekGelir";
			this.lblEnYuksekGelir.Size = new System.Drawing.Size(147, 23);
			this.lblEnYuksekGelir.TabIndex = 4;
			this.lblEnYuksekGelir.Text = "En Yüksek Gelir:";
			// 
			// gridControlMusteriAnalizi
			// 
			this.gridControlMusteriAnalizi.Location = new System.Drawing.Point(3, 274);
			this.gridControlMusteriAnalizi.MainView = this.gridView1;
			this.gridControlMusteriAnalizi.Name = "gridControlMusteriAnalizi";
			this.gridControlMusteriAnalizi.Size = new System.Drawing.Size(464, 295);
			this.gridControlMusteriAnalizi.TabIndex = 1;
			this.gridControlMusteriAnalizi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// gridView1
			// 
			this.gridView1.GridControl = this.gridControlMusteriAnalizi;
			this.gridView1.Name = "gridView1";
			this.gridView1.OptionsView.ShowGroupPanel = false;
			// 
			// gridControl1
			// 
			this.gridControl1.Location = new System.Drawing.Point(473, 3);
			this.gridControl1.MainView = this.gridView2;
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.Size = new System.Drawing.Size(464, 265);
			this.gridControl1.TabIndex = 2;
			this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
			// 
			// gridView2
			// 
			this.gridView2.GridControl = this.gridControl1;
			this.gridView2.Name = "gridView2";
			this.gridView2.OptionsView.ShowGroupPanel = false;
			// 
			// gridControl2
			// 
			this.gridControl2.Location = new System.Drawing.Point(473, 274);
			this.gridControl2.MainView = this.gridView3;
			this.gridControl2.Name = "gridControl2";
			this.gridControl2.Size = new System.Drawing.Size(464, 295);
			this.gridControl2.TabIndex = 3;
			this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
			// 
			// gridView3
			// 
			this.gridView3.GridControl = this.gridControl2;
			this.gridView3.Name = "gridView3";
			this.gridView3.OptionsView.ShowGroupPanel = false;
			// 
			// FrmMusteriAnalizi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(943, 571);
			this.Controls.Add(this.gridControl2);
			this.Controls.Add(this.gridControl1);
			this.Controls.Add(this.gridControlMusteriAnalizi);
			this.Controls.Add(this.panelControl1);
			this.Name = "FrmMusteriAnalizi";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Müşterilerin Genel Durum Analizi";
			this.Load += new System.EventHandler(this.FrmMusteriAnalizi_Load);
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			this.panelControl1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridControlMusteriAnalizi)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.PanelControl panelControl1;
		private System.Windows.Forms.Label lblToplamMusteri;
		private System.Windows.Forms.Label lblEnYuksekGelir;
		private System.Windows.Forms.Label lblEnCokProje;
		private DevExpress.XtraGrid.GridControl gridControlMusteriAnalizi;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
		private DevExpress.XtraGrid.GridControl gridControl2;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
	}
}