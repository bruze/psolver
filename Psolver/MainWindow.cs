using System;
using Gtk;
using System.IO;
using Psolver;
public partial class MainWindow: Gtk.Window
{
	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected virtual void OnButton4Clicked(object sender, System.EventArgs e)
	{
		/*StreamWriter sw = new StreamWriter("Test.txt");
		sw.Write("Hello");
		sw.Close();*/
		Scheduler sched = new Scheduler();
		sched.Show();
		Destroy();
	}
}
