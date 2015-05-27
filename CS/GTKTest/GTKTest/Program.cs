// /*
//  *	MICHAEL KOEPPL 3AHIF
//  * 	2014/2015
//  */
using System;
using Gtk;

namespace GTKTest
{
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
