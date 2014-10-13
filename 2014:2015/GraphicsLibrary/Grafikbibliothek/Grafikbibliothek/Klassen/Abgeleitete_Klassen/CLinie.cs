using System;

namespace Grafikbibliothek
{
	public class CLinie:CGraphObj
	{
		double xd, yd;
		public CLinie (int i, double x, double y, double xdvalue, double ydvalue):base(i, x, y)
		{
			xd = xdvalue;
			yd = ydvalue;
		}

		new public void draw(){
			base.draw ();
			Console.WriteLine ("Der Anfangspunkt der Linie hat die Koordinaten (" + (getPunkt().getXCoord() - xd).ToString() + "," + (getPunkt().getYCoord() + yd).ToString() + ")");
			Console.WriteLine ("Der Endpunkt der Linie hat die Koordinaten (" + (getPunkt ().getXCoord () + xd).ToString () + "," + (getPunkt ().getYCoord () - yd).ToString () + ")");
		}
	}
}

