using System;

namespace Grafikbibliothek
{
	public class CRechteck:CGraphObj
	{
		double xd, yd;
		public CRechteck (int i, double x, double y) : base (i)
		{
			xd = x/2;
			yd = y/2;
		}

		public void draw(){
			base.draw ();
			Console.WriteLine ("Das Objekt ist ein Rechteckt.");
			Console.WriteLine ("Höhe: " + (xd*2));
			Console.WriteLine ("Breite: " + (yd*2));
			Console.WriteLine ("Obere linke Ecke Koordinaten: (" + (getPunkt ().getXCoord () - xd).ToString () + "," + (getPunkt ().getYCoord () + yd).ToString () + ")");
			Console.WriteLine ("Obere rechte Ecke Koordinaten: (" + (getPunkt ().getXCoord () + xd).ToString () + "," + (getPunkt ().getYCoord () + yd).ToString () + ")");
			Console.WriteLine ("Untere linke Ecke Koordinaten: (" + (getPunkt ().getXCoord () - xd).ToString () + "," + (getPunkt ().getYCoord () - yd).ToString () + ")");
			Console.WriteLine ("Unter rechte Ecke Koordinaten: (" + (getPunkt ().getXCoord () + xd).ToString () + "," + (getPunkt ().getYCoord () - yd).ToString () + ")");
		}
	}
}

