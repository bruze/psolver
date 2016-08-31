using System;
using System.Collections;
using System.Collections.Generic;
using Gtk;
using Psolver.Model;
using System.IO;
using KNFoundation;
using static Psolver.Extensions;
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

			for (int i = 0; i < 10; i++)
			{
				TreeViewColumn hourColumn = new TreeViewColumn();
				hourColumn.Title = i.ToString();
				treeview2.AppendColumn(hourColumn);
				CellRendererText planCell = new CellRendererText();
				hourColumn.PackStart(planCell, true);
				hourColumn.AddAttribute(planCell, "text", 0);
			}

			// Create a model that will hold two strings - Artist Name and Song Title
			ListStore diaryPlanListStore = new ListStore(typeof(string));
			diaryPlanListStore.AppendValues("Pr1");
			// Assign the model to the TreeView
			treeview2.Model = diaryPlanListStore;

			Project pro = new Project("Zatrapa");
			pro.añadeRestriccion("valor", "valoreeeee");
			var gerente = Gerente.instancia();
			/*PrConstraint constr = new PrConstraint();
			constr.valor = 2;*/

			var xs = new System.Xml.Serialization.XmlSerializer(typeof(List<int>));
			List<int> ints = new List<int> { 1, 2, 3 };

			using (FileStream fs = new FileStream(@"store.xml", FileMode.OpenOrCreate))
			{
				xs.Serialize(fs, ints);
			}
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

