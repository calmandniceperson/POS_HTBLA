using System;

namespace Grafikbibliothek
{
	public class CGraphObj:IGraphObj
	{
		int id;
		CPunkt punkt;
		public CGraphObj (int i)
		{
			id = i;
			setPos (punkt);
		}

		public void setPos(CPunkt p){
			Console.Write ("Geben Sie die x-Koordinate ein: ");
			double x = double.Parse (Console.ReadLine ());
			Console.Write ("Geben Sie die y-Koordinate ein: ");
			double y = double.Parse (Console.ReadLine ());
			punkt = new CPunkt (x, y);
		}

		public void move(double x = 0, double y = 0){
			if (x != 0) {
				punkt.setXCoord (punkt.getXCoord() + x);
			}

			if (y != 0) {
				punkt.setYCoord (punkt.getYCoord() + y);
			}
		}

		public void draw(){
			Console.WriteLine ("Mittelpunkt Koordinaten: " + punkt.getXCoord ().ToString() + ", " + punkt.getYCoord ().ToString());
		}

		public CPunkt getPunkt(){
			return punkt;
		}

		public int getId(){
			return id;
		}
	}
}

