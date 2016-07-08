using System;
using System.Collections;
using Gtk;
using Psolver.Model;
namespace Psolver
{
	public partial class Scheduler : Gtk.Window
	{
		public Scheduler() :
				base(Gtk.WindowType.Toplevel)
		{
			this.Build();
			DeleteEvent += delegate { Application.Quit(); };
			Queue points = new Queue();
			var appoint = new SchAppointment();
			appoint.date = new DateTime(2016, 1, 8);
			points.Enqueue(appoint);
			appoint.date = new DateTime(2016, 1, 9);
			points.Enqueue(appoint);
			markAppointmentsOnCalendar(points);
		}

		void markAppointmentsOnCalendar(Queue appoints)
		{
			foreach (SchAppointment appoint in appoints)
			{
				calendar5.MarkDay(uint.Parse(appoint.date.Day.ToString()));
			}
			/*calendar5.MarkDay(8);
			calendar5.MarkDay(9);*/
		}
	}
}

