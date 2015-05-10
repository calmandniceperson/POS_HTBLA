// /*
//  *	MICHAEL KOEPPL 3AHIF
//  * 	2014/2015
//  */
using System;
using Eto.Forms;

namespace EtoHelloWorld.Desktop
{
	public class Program
	{
		[STAThread]
		public static void Main (string[] args)
		{
			new Application (Eto.Platform.Detect).Run (new MainForm ());
		}
	}
}

