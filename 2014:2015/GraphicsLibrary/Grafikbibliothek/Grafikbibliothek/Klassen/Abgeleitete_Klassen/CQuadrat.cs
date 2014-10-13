using System;

namespace Grafikbibliothek
{
	public class CQuadrat:CGraphObj
	{
		double hslaenge; /*halbe seitenlaenge*/
		public CQuadrat (int i, double x, double y, double hs):base(i, x, y)
		{
			hslaenge = hs/2;
		}

		new public void draw(){
			base.draw ();
			Console.WriteLine ("Das Objekt ist ein Quadrat und die Seitenlänge beträgt " + (hslaenge * 2).ToString () + ".");
			Console.WriteLine ("Obere linke Ecke Koordinaten: (" + (getPunkt ().getXCoord () - hslaenge).ToString () + "," + (getPunkt ().getYCoord () + hslaenge).ToString () + ")");
			Console.WriteLine ("Obere rechte Ecke Koordinaten: (" + (getPunkt ().getXCoord () + hslaenge).ToString () + "," + (getPunkt ().getYCoord () + hslaenge).ToString () + ")");
			Console.WriteLine ("Untere linke Ecke Koordinaten: (" + (getPunkt ().getXCoord () - hslaenge).ToString () + "," + (getPunkt ().getYCoord () - hslaenge).ToString () + ")");
			Console.WriteLine ("Untere rechte Ecke Koordinaten: (" + (getPunkt ().getXCoord () + hslaenge).ToString () + "," + (getPunkt ().getYCoord () - hslaenge).ToString () + ")");
		}
	}
}

