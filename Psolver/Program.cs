using System;
using Gtk;

namespace Psolver
{
	public static class Extensions
	{
		public static void print(String t)
		{
			Console.WriteLine(t);
		}
	}

	class MainClass
	{
		public static void Main (string[] args)
		{
			Application.Init ();
			MainWindow win = new MainWindow ();
			win.Show ();
			Application.Run ();
		}
	}
}
