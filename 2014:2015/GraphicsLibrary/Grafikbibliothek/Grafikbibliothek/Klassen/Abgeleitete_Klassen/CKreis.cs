using System;

namespace Grafikbibliothek
{
	public class CKreis:CGraphObj
	{
		double radius;
		public CKreis (int i, double x, double y, double r):base(i, x, y)
		{
			radius = r;
		}

		new public void draw(){
			base.draw ();
			Console.WriteLine ("Das gezeichnete Objekt ist ein Kreis mit dem Radius " + radius.ToString() + ".");
		}
	}
}

