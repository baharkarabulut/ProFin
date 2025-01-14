using DevExpress.XtraScheduler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProFin
{
	public partial class FrmProjeTakvimi : Form
	{
		public FrmProjeTakvimi()
		{
			InitializeComponent();
		}
		DbProFinEntities db = new DbProFinEntities();
		private void schedulerControl1_Click(object sender, EventArgs e)
		{

		}

		private void FrmProjeTakvimi_Load(object sender, EventArgs e)
		{
			// Storage oluşturma ve SchedulerControl'e bağlama
			schedulerControl1.Storage = new DevExpress.XtraScheduler.SchedulerStorage();

			// Veritabanından projeleri çek
			var projeler = db.Projeler.ToList();

			foreach (var proje in projeler)
			{
				// Null kontrolü ve başlangıç tarihi için randevu oluşturma
				if (proje.BaslangicTarihi.HasValue)
				{
					var baslangicAppointment = schedulerControl1.Storage.CreateAppointment(DevExpress.XtraScheduler.AppointmentType.Normal);
					baslangicAppointment.Start = proje.BaslangicTarihi.Value; // Başlangıç tarihi
					
					baslangicAppointment.Subject = $"{proje.ProjeAdi} (Başlangıç)";
					schedulerControl1.Storage.Appointments.Add(baslangicAppointment);
				}

				// Null kontrolü ve bitiş tarihi için randevu oluşturma
				if (proje.BitisTarihi.HasValue)
				{
					var bitisAppointment = schedulerControl1.Storage.CreateAppointment(DevExpress.XtraScheduler.AppointmentType.Normal);
					bitisAppointment.Start = proje.BitisTarihi.Value; // Bitiş tarihi
					bitisAppointment.Subject = $"{proje.ProjeAdi} (Bitiş)";
					schedulerControl1.Storage.Appointments.Add(bitisAppointment);
				}
			}

			schedulerControl1.Views.DayView.TimeRulers.Clear();
			schedulerControl1.Views.WorkWeekView.TimeRulers.Clear();
		}
	}
}
