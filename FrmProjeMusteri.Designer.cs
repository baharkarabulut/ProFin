namespace ProFin
{
	partial class FrmProjeMusteri
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
			this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
			this.treeList1 = new DevExpress.XtraTreeList.TreeList();
			this.coltreeListColumn0 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
			this.coltreeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
			this.coltreeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
			this.coltreeListColumn3 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
			this.coltreeListColumn4 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
			this.Toll = new DevExpress.XtraTreeList.Columns.TreeListColumn();
			this.coltreeListColumn6 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
			this.coltreeListColumn7 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
			this.lblBilgi = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
			this.splitContainerControl1.Panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
			this.splitContainerControl1.Panel2.SuspendLayout();
			this.splitContainerControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
			this.SuspendLayout();
			// 
			// splitContainerControl1
			// 
			this.splitContainerControl1.Location = new System.Drawing.Point(1, 2);
			this.splitContainerControl1.Name = "splitContainerControl1";
			// 
			// splitContainerControl1.Panel1
			// 
			this.splitContainerControl1.Panel1.Controls.Add(this.treeList1);
			this.splitContainerControl1.Panel1.Text = "Panel1";
			// 
			// splitContainerControl1.Panel2
			// 
			this.splitContainerControl1.Panel2.Controls.Add(this.lblBilgi);
			this.splitContainerControl1.Panel2.Text = "Panel2";
			this.splitContainerControl1.Size = new System.Drawing.Size(1161, 461);
			this.splitContainerControl1.SplitterPosition = 799;
			this.splitContainerControl1.TabIndex = 0;
			// 
			// treeList1
			// 
			this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.coltreeListColumn0,
            this.coltreeListColumn1,
            this.coltreeListColumn2,
            this.coltreeListColumn3,
            this.coltreeListColumn4,
            this.Toll,
            this.coltreeListColumn6,
            this.coltreeListColumn7});
			this.treeList1.Location = new System.Drawing.Point(0, 0);
			this.treeList1.Name = "treeList1";
			this.treeList1.Size = new System.Drawing.Size(797, 461);
			this.treeList1.TabIndex = 0;
			this.treeList1.CustomUnboundColumnData += new DevExpress.XtraTreeList.CustomColumnDataEventHandler(this.treeList1_CustomUnboundColumnData);
			this.treeList1.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.treeList1_FocusedNodeChanged);
			// 
			// coltreeListColumn0
			// 
			this.coltreeListColumn0.Caption = "Proje Adı";
			this.coltreeListColumn0.FieldName = "treeListColumn0";
			this.coltreeListColumn0.Name = "coltreeListColumn0";
			this.coltreeListColumn0.Visible = true;
			this.coltreeListColumn0.VisibleIndex = 0;
			// 
			// coltreeListColumn1
			// 
			this.coltreeListColumn1.Caption = "Müşteri Adı:";
			this.coltreeListColumn1.FieldName = "treeListColumn1";
			this.coltreeListColumn1.Name = "coltreeListColumn1";
			this.coltreeListColumn1.Visible = true;
			this.coltreeListColumn1.VisibleIndex = 1;
			// 
			// coltreeListColumn2
			// 
			this.coltreeListColumn2.Caption = "Başlangıç Tarihi:";
			this.coltreeListColumn2.FieldName = "treeListColumn2";
			this.coltreeListColumn2.Name = "coltreeListColumn2";
			this.coltreeListColumn2.Visible = true;
			this.coltreeListColumn2.VisibleIndex = 2;
			// 
			// coltreeListColumn3
			// 
			this.coltreeListColumn3.Caption = "Bitiş Tarihi:";
			this.coltreeListColumn3.FieldName = "treeListColumn3";
			this.coltreeListColumn3.Name = "coltreeListColumn3";
			this.coltreeListColumn3.Visible = true;
			this.coltreeListColumn3.VisibleIndex = 3;
			// 
			// coltreeListColumn4
			// 
			this.coltreeListColumn4.Caption = "Durum:";
			this.coltreeListColumn4.FieldName = "treeListColumn4";
			this.coltreeListColumn4.Name = "coltreeListColumn4";
			this.coltreeListColumn4.Visible = true;
			this.coltreeListColumn4.VisibleIndex = 4;
			// 
			// Toll
			// 
			this.Toll.Caption = "Toplam Tutar:";
			this.Toll.FieldName = "treeListColumn5";
			this.Toll.Name = "Toll";
			this.Toll.Visible = true;
			this.Toll.VisibleIndex = 5;
			// 
			// coltreeListColumn6
			// 
			this.coltreeListColumn6.Caption = "Teslim Tarihi:";
			this.coltreeListColumn6.FieldName = "treeListColumn6";
			this.coltreeListColumn6.Name = "coltreeListColumn6";
			this.coltreeListColumn6.Visible = true;
			this.coltreeListColumn6.VisibleIndex = 6;
			// 
			// coltreeListColumn7
			// 
			this.coltreeListColumn7.Caption = "Not:";
			this.coltreeListColumn7.FieldName = "treeListColumn7";
			this.coltreeListColumn7.Name = "coltreeListColumn7";
			this.coltreeListColumn7.Visible = true;
			this.coltreeListColumn7.VisibleIndex = 7;
			// 
			// lblBilgi
			// 
			this.lblBilgi.AutoSize = true;
			this.lblBilgi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblBilgi.Location = new System.Drawing.Point(10, 52);
			this.lblBilgi.Name = "lblBilgi";
			this.lblBilgi.Size = new System.Drawing.Size(51, 19);
			this.lblBilgi.TabIndex = 10;
			this.lblBilgi.Text = "label1";
			// 
			// FrmProjeMusteri
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1167, 465);
			this.Controls.Add(this.splitContainerControl1);
			this.Name = "FrmProjeMusteri";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Projeye Bağlı Müşteri Bilgileri";
			this.Load += new System.EventHandler(this.FrmProjeMusteri_Load);
			((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
			this.splitContainerControl1.Panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
			this.splitContainerControl1.Panel2.ResumeLayout(false);
			this.splitContainerControl1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
			this.splitContainerControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
		private DevExpress.XtraTreeList.TreeList treeList1;
		private DevExpress.XtraTreeList.Columns.TreeListColumn coltreeListColumn0;
		private DevExpress.XtraTreeList.Columns.TreeListColumn coltreeListColumn1;
		private DevExpress.XtraTreeList.Columns.TreeListColumn coltreeListColumn2;
		private DevExpress.XtraTreeList.Columns.TreeListColumn coltreeListColumn3;
		private DevExpress.XtraTreeList.Columns.TreeListColumn coltreeListColumn4;
		private DevExpress.XtraTreeList.Columns.TreeListColumn Toll;
		private DevExpress.XtraTreeList.Columns.TreeListColumn coltreeListColumn6;
		private DevExpress.XtraTreeList.Columns.TreeListColumn coltreeListColumn7;
		private System.Windows.Forms.Label lblBilgi;
	}
}