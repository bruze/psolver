using System;
using System.Collections;
namespace Psolver.Model
{
	public class PrSchedule
	{
		Queue appointments = new Queue();
		public PrSchedule()
		{
			loadAppointments();
		}
		private void loadAppointments()
		{
			
		}
		void addAppointment(SchAppointment appointment)
		{
			appointments.Enqueue(appointment);
		}
		void removeAppointment()
		{
			appointments.Dequeue();
		}
	}
}

