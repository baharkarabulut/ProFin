namespace ProFin
{
	partial class FrmTeslimTarihiYaklasan
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
			this.gridControlTeslimTarihiYaklasan = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			((System.ComponentModel.ISupportInitialize)(this.gridControlTeslimTarihiYaklasan)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// gridControlTeslimTarihiYaklasan
			// 
			this.gridControlTeslimTarihiYaklasan.Location = new System.Drawing.Point(3, 1);
			this.gridControlTeslimTarihiYaklasan.MainView = this.gridView1;
			this.gridControlTeslimTarihiYaklasan.Name = "gridControlTeslimTarihiYaklasan";
			this.gridControlTeslimTarihiYaklasan.Size = new System.Drawing.Size(537, 383);
			this.gridControlTeslimTarihiYaklasan.TabIndex = 0;
			this.gridControlTeslimTarihiYaklasan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// gridView1
			// 
			this.gridView1.GridControl = this.gridControlTeslimTarihiYaklasan;
			this.gridView1.Name = "gridView1";
			this.gridView1.OptionsView.ShowGroupPanel = false;
			// 
			// FrmTeslimTarihiYaklasan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(541, 387);
			this.Controls.Add(this.gridControlTeslimTarihiYaklasan);
			this.Name = "FrmTeslimTarihiYaklasan";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Teslim Tarihi Yaklaşan Projeler";
			this.Load += new System.EventHandler(this.FrmTeslimTarihiYaklasan_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridControlTeslimTarihiYaklasan)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraGrid.GridControl gridControlTeslimTarihiYaklasan;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
	}
}