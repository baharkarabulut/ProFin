namespace ProFin
{
	partial class FrmGelirGider
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
			DevExpress.XtraCharts.SimpleDiagram3D simpleDiagram3D1 = new DevExpress.XtraCharts.SimpleDiagram3D();
			DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
			DevExpress.XtraCharts.Pie3DSeriesView pie3DSeriesView1 = new DevExpress.XtraCharts.Pie3DSeriesView();
			this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
			this.grpToplamGelir = new System.Windows.Forms.GroupBox();
			this.grpToplamGider = new System.Windows.Forms.GroupBox();
			this.grpKar = new System.Windows.Forms.GroupBox();
			this.lblToplamGelir = new System.Windows.Forms.Label();
			this.lblToplamGider = new System.Windows.Forms.Label();
			this.lblKar = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(simpleDiagram3D1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(pie3DSeriesView1)).BeginInit();
			this.grpToplamGelir.SuspendLayout();
			this.grpToplamGider.SuspendLayout();
			this.grpKar.SuspendLayout();
			this.SuspendLayout();
			// 
			// chartControl1
			// 
			this.chartControl1.AutoLayout = false;
			this.chartControl1.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.False;
			simpleDiagram3D1.RotationMatrixSerializable = "0.681875337036576;-0.655655505808987;0.324286728750396;0;0.724801518083673;0.5459" +
    "11677581962;-0.420289423687137;0;0.0985331625640603;0.521628505722244;0.84746381" +
    "5093672;0;0;0;0;1";
			this.chartControl1.Diagram = simpleDiagram3D1;
			this.chartControl1.Location = new System.Drawing.Point(12, 12);
			this.chartControl1.Name = "chartControl1";
			this.chartControl1.PaletteName = "Aspect";
			series1.Name = "pieSeries";
			series1.SeriesID = 0;
			series1.View = pie3DSeriesView1;
			this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
			this.chartControl1.Size = new System.Drawing.Size(454, 435);
			this.chartControl1.TabIndex = 0;
			// 
			// grpToplamGelir
			// 
			this.grpToplamGelir.Controls.Add(this.lblToplamGelir);
			this.grpToplamGelir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.grpToplamGelir.Location = new System.Drawing.Point(472, 12);
			this.grpToplamGelir.Name = "grpToplamGelir";
			this.grpToplamGelir.Size = new System.Drawing.Size(253, 141);
			this.grpToplamGelir.TabIndex = 1;
			this.grpToplamGelir.TabStop = false;
			this.grpToplamGelir.Text = "Toplam Gelir:";
			// 
			// grpToplamGider
			// 
			this.grpToplamGider.Controls.Add(this.lblToplamGider);
			this.grpToplamGider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.grpToplamGider.Location = new System.Drawing.Point(472, 159);
			this.grpToplamGider.Name = "grpToplamGider";
			this.grpToplamGider.Size = new System.Drawing.Size(253, 141);
			this.grpToplamGider.TabIndex = 2;
			this.grpToplamGider.TabStop = false;
			this.grpToplamGider.Text = "Toplam Gider:";
			// 
			// grpKar
			// 
			this.grpKar.Controls.Add(this.lblKar);
			this.grpKar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.grpKar.Location = new System.Drawing.Point(472, 306);
			this.grpKar.Name = "grpKar";
			this.grpKar.Size = new System.Drawing.Size(253, 141);
			this.grpKar.TabIndex = 3;
			this.grpKar.TabStop = false;
			this.grpKar.Text = "Kar:";
			// 
			// lblToplamGelir
			// 
			this.lblToplamGelir.AutoSize = true;
			this.lblToplamGelir.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblToplamGelir.Location = new System.Drawing.Point(15, 54);
			this.lblToplamGelir.Name = "lblToplamGelir";
			this.lblToplamGelir.Size = new System.Drawing.Size(118, 42);
			this.lblToplamGelir.TabIndex = 0;
			this.lblToplamGelir.Text = "label1";
			// 
			// lblToplamGider
			// 
			this.lblToplamGider.AutoSize = true;
			this.lblToplamGider.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblToplamGider.Location = new System.Drawing.Point(15, 55);
			this.lblToplamGider.Name = "lblToplamGider";
			this.lblToplamGider.Size = new System.Drawing.Size(118, 42);
			this.lblToplamGider.TabIndex = 1;
			this.lblToplamGider.Text = "label2";
			// 
			// lblKar
			// 
			this.lblKar.AutoSize = true;
			this.lblKar.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblKar.Location = new System.Drawing.Point(15, 56);
			this.lblKar.Name = "lblKar";
			this.lblKar.Size = new System.Drawing.Size(118, 42);
			this.lblKar.TabIndex = 2;
			this.lblKar.Text = "label3";
			// 
			// FrmGelirGider
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(737, 450);
			this.Controls.Add(this.grpKar);
			this.Controls.Add(this.grpToplamGider);
			this.Controls.Add(this.grpToplamGelir);
			this.Controls.Add(this.chartControl1);
			this.Name = "FrmGelirGider";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmGelirGider";
			this.Load += new System.EventHandler(this.FrmGelirGider_Load);
			((System.ComponentModel.ISupportInitialize)(simpleDiagram3D1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(pie3DSeriesView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
			this.grpToplamGelir.ResumeLayout(false);
			this.grpToplamGelir.PerformLayout();
			this.grpToplamGider.ResumeLayout(false);
			this.grpToplamGider.PerformLayout();
			this.grpKar.ResumeLayout(false);
			this.grpKar.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraCharts.ChartControl chartControl1;
		private System.Windows.Forms.GroupBox grpToplamGelir;
		private System.Windows.Forms.GroupBox grpToplamGider;
		private System.Windows.Forms.GroupBox grpKar;
		private System.Windows.Forms.Label lblToplamGelir;
		private System.Windows.Forms.Label lblToplamGider;
		private System.Windows.Forms.Label lblKar;
	}
}