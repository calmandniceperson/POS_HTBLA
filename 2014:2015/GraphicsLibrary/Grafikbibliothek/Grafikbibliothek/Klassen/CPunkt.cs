/*
 * Michael Koeppl 3AHIF
 * Grafikbibliothek
 * 2014/2015
*/

using System;

namespace Grafikbibliothek
{
	public class CPunkt
	{
		double xcoord, ycoord;
		public CPunkt (double x, double y)
		{
			xcoord = x;
			ycoord = y;
		}

		#region get
		public double getXCoord(){
			return xcoord;
		}

		public double getYCoord(){
			return ycoord;
		}
		#endregion
		#region set
		public void setXCoord(double v){
			xcoord = v;
		}

		public void setYCoord(double v){
			ycoord = v;
		}
		#endregion
	}
}

