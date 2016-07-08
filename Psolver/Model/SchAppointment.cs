using System;
using Gtk;
namespace Psolver.Model
{
	public struct SchAppointment
	{
		public DateTime date;
		String description;
		TimeSpan duration;
		Image icon;
	}
}

