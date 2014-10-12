using System;

namespace Grafikbibliothek
{
	public class CKreis:CGraphObj
	{
		double radius;
		public CKreis (int i, double r):base(i)
		{
			radius = r;
		}

		new public void draw(){
			base.draw ();
			Console.WriteLine ("Das gezeichnete Objekt ist ein Kreis mit dem Radius " + radius.ToString() + ".");
		}
	}
}

