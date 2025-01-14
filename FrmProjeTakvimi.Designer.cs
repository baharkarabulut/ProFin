namespace ProFin
{
	partial class FrmProjeTakvimi
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
			this.components = new System.ComponentModel.Container();
			DevExpress.XtraScheduler.TimeRuler timeRuler1 = new DevExpress.XtraScheduler.TimeRuler();
			DevExpress.XtraScheduler.TimeRuler timeRuler2 = new DevExpress.XtraScheduler.TimeRuler();
			DevExpress.XtraScheduler.TimeRuler timeRuler3 = new DevExpress.XtraScheduler.TimeRuler();
			this.schedulerDataStorage1 = new DevExpress.XtraScheduler.SchedulerDataStorage(this.components);
			this.schedulerControl1 = new DevExpress.XtraScheduler.SchedulerControl();
			this.schedulerBarController1 = new DevExpress.XtraScheduler.UI.SchedulerBarController(this.components);
			((System.ComponentModel.ISupportInitialize)(this.schedulerDataStorage1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.schedulerBarController1)).BeginInit();
			this.SuspendLayout();
			// 
			// schedulerDataStorage1
			// 
			// 
			// 
			// 
			this.schedulerDataStorage1.AppointmentDependencies.AutoReload = false;
			// 
			// 
			// 
			this.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(0, "None", "&None", System.Drawing.SystemColors.Window);
			this.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(1, "Important", "&Important", System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(190))))));
			this.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(2, "Business", "&Business", System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(213)))), ((int)(((byte)(255))))));
			this.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(3, "Personal", "&Personal", System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(244)))), ((int)(((byte)(156))))));
			this.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(4, "Vacation", "&Vacation", System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(228)))), ((int)(((byte)(199))))));
			this.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(5, "Must Attend", "Must &Attend", System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(206)))), ((int)(((byte)(147))))));
			this.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(6, "Travel Required", "&Travel Required", System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(244)))), ((int)(((byte)(255))))));
			this.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(7, "Needs Preparation", "&Needs Preparation", System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(219)))), ((int)(((byte)(152))))));
			this.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(8, "Birthday", "&Birthday", System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(207)))), ((int)(((byte)(233))))));
			this.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(9, "Anniversary", "&Anniversary", System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(233)))), ((int)(((byte)(223))))));
			this.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(10, "Phone Call", "Phone &Call", System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(165))))));
			// 
			// schedulerControl1
			// 
			this.schedulerControl1.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Month;
			this.schedulerControl1.DataStorage = this.schedulerDataStorage1;
			this.schedulerControl1.Location = new System.Drawing.Point(0, 0);
			this.schedulerControl1.Name = "schedulerControl1";
			this.schedulerControl1.OptionsFlyout.HtmlTemplate.Styles = "body {\n  padding: 11px;\n}";
			this.schedulerControl1.Size = new System.Drawing.Size(1057, 605);
			this.schedulerControl1.Start = new System.DateTime(2025, 1, 13, 0, 0, 0, 0);
			this.schedulerControl1.TabIndex = 0;
			this.schedulerControl1.Text = "schedulerControl1";
			this.schedulerControl1.Views.AgendaView.Enabled = false;
			this.schedulerControl1.Views.DayView.DateTimeScrollbarVisible = false;
			this.schedulerControl1.Views.DayView.Enabled = false;
			timeRuler1.AdjustForDaylightSavingTime = false;
			timeRuler1.ShowCurrentTime = DevExpress.XtraScheduler.CurrentTimeVisibility.Never;
			timeRuler1.TimeMarkerVisibility = DevExpress.XtraScheduler.TimeMarkerVisibility.Never;
			timeRuler1.TimeZoneId = "Turkey Standard Time";
			timeRuler1.UseClientTimeZone = false;
			timeRuler1.Visible = false;
			this.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1);
			this.schedulerControl1.Views.FullWeekView.TimeRulers.Add(timeRuler2);
			this.schedulerControl1.Views.GanttView.Enabled = false;
			this.schedulerControl1.Views.MonthView.AppointmentDisplayOptions.EndTimeVisibility = DevExpress.XtraScheduler.AppointmentTimeVisibility.Never;
			this.schedulerControl1.Views.MonthView.AppointmentDisplayOptions.StartTimeVisibility = DevExpress.XtraScheduler.AppointmentTimeVisibility.Never;
			this.schedulerControl1.Views.MonthView.DateTimeScrollbarVisible = false;
			this.schedulerControl1.Views.MonthView.ShowWeekend = false;
			this.schedulerControl1.Views.TimelineView.Enabled = false;
			this.schedulerControl1.Views.WeekView.AppointmentDisplayOptions.EndTimeVisibility = DevExpress.XtraScheduler.AppointmentTimeVisibility.Never;
			this.schedulerControl1.Views.WeekView.AppointmentDisplayOptions.StartTimeVisibility = DevExpress.XtraScheduler.AppointmentTimeVisibility.Never;
			this.schedulerControl1.Views.WeekView.DateTimeScrollbarVisible = false;
			this.schedulerControl1.Views.WorkWeekView.Enabled = false;
			this.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler3);
			this.schedulerControl1.Views.YearView.UseOptimizedScrolling = false;
			// 
			// schedulerBarController1
			// 
			this.schedulerBarController1.Control = this.schedulerControl1;
			// 
			// FrmProjeTakvimi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1057, 607);
			this.Controls.Add(this.schedulerControl1);
			this.Name = "FrmProjeTakvimi";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Proje Takvimi";
			this.Load += new System.EventHandler(this.FrmProjeTakvimi_Load);
			((System.ComponentModel.ISupportInitialize)(this.schedulerDataStorage1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.schedulerBarController1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private DevExpress.XtraScheduler.SchedulerDataStorage schedulerDataStorage1;
		private DevExpress.XtraScheduler.SchedulerControl schedulerControl1;
		private DevExpress.XtraScheduler.UI.SchedulerBarController schedulerBarController1;
	}
}