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
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelControl1
			// 
			this.panelControl1.Controls.Add(this.lblToplamMusteri);
			this.panelControl1.Location = new System.Drawing.Point(3, 3);
			this.panelControl1.Name = "panelControl1";
			this.panelControl1.Size = new System.Drawing.Size(314, 265);
			this.panelControl1.TabIndex = 0;
			// 
			// lblToplamMusteri
			// 
			this.lblToplamMusteri.AutoSize = true;
			this.lblToplamMusteri.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblToplamMusteri.Location = new System.Drawing.Point(9, 16);
			this.lblToplamMusteri.Name = "lblToplamMusteri";
			this.lblToplamMusteri.Size = new System.Drawing.Size(125, 19);
			this.lblToplamMusteri.TabIndex = 0;
			this.lblToplamMusteri.Text = "Toplam Musteri:";
			// 
			// FrmMusteriAnalizi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.panelControl1);
			this.Name = "FrmMusteriAnalizi";
			this.Text = "Müşterilerin Genel Durum Analizi";
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			this.panelControl1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.PanelControl panelControl1;
		private System.Windows.Forms.Label lblToplamMusteri;
	}
}