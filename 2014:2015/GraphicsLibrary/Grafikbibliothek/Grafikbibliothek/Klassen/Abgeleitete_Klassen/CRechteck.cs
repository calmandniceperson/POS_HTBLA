using System;

namespace Grafikbibliothek
{
	public class CRechteck:CGraphObj
	{
		double xd, yd;
		public CRechteck (int i, double x, double y, double xdvalue, double ydvalue) : base (i, x, y)
		{
			xd = xdvalue/2;
			yd = ydvalue/2;
		}

		new public void draw(){
			base.draw ();
			Console.WriteLine ("Das Objekt ist ein Rechteck.");
			Console.WriteLine ("Höhe: " + (xd*2));
			Console.WriteLine ("Breite: " + (yd*2));
			Console.WriteLine ("Obere linke Ecke Koordinaten: (" + (getPunkt ().getXCoord () - xd).ToString () + "," + (getPunkt ().getYCoord () + yd).ToString () + ")");
			Console.WriteLine ("Obere rechte Ecke Koordinaten: (" + (getPunkt ().getXCoord () + xd).ToString () + "," + (getPunkt ().getYCoord () + yd).ToString () + ")");
			Console.WriteLine ("Untere linke Ecke Koordinaten: (" + (getPunkt ().getXCoord () - xd).ToString () + "," + (getPunkt ().getYCoord () - yd).ToString () + ")");
			Console.WriteLine ("Unter rechte Ecke Koordinaten: (" + (getPunkt ().getXCoord () + xd).ToString () + "," + (getPunkt ().getYCoord () - yd).ToString () + ")");
		}
	}
}

