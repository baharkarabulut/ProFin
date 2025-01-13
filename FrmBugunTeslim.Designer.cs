namespace ProFin
{
	partial class FrmBugunTeslim
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
			this.gridControlBugunTeslim = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			((System.ComponentModel.ISupportInitialize)(this.gridControlBugunTeslim)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// gridControlBugunTeslim
			// 
			this.gridControlBugunTeslim.Location = new System.Drawing.Point(2, 1);
			this.gridControlBugunTeslim.MainView = this.gridView1;
			this.gridControlBugunTeslim.Name = "gridControlBugunTeslim";
			this.gridControlBugunTeslim.Size = new System.Drawing.Size(482, 222);
			this.gridControlBugunTeslim.TabIndex = 0;
			this.gridControlBugunTeslim.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// gridView1
			// 
			this.gridView1.GridControl = this.gridControlBugunTeslim;
			this.gridView1.Name = "gridView1";
			this.gridView1.OptionsView.ShowGroupPanel = false;
			// 
			// FrmBugunTeslim
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(487, 226);
			this.Controls.Add(this.gridControlBugunTeslim);
			this.Name = "FrmBugunTeslim";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Bugün Teslim Tarihi Gelen Proje";
			this.Load += new System.EventHandler(this.FrmBugunTeslim_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridControlBugunTeslim)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraGrid.GridControl gridControlBugunTeslim;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
	}
}