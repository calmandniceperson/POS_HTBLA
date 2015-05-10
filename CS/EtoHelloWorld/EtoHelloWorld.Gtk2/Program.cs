// /*
//  *	MICHAEL KOEPPL 3AHIF
//  * 	2014/2015
//  */
using System;
using Eto.Forms;

namespace EtoHelloWorld.Gtk2
{
	public class Program
	{
		[STAThread]
		public static void Main (string[] args)
		{
			new Application (Eto.Platforms.Gtk2).Run (new MainForm ());
		}
	}
}

