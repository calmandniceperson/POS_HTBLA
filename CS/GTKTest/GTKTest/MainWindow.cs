// /*
//  *	MICHAEL KOEPPL 3AHIF
//  * 	2014/2015
//  */
using System;
using Gtk;

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

	protected void OnButton2Clicked (object sender, EventArgs e)
	{
		label1.Visible = true;
	}
}
