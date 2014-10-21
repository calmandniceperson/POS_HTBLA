using System;

namespace CS1_KOEPPL
{
	public class Nutzfahrzeug:Fahrzeug
	{

		protected double nutzlast{get;set;} /*nutzlast in tonnen*/

		public Nutzfahrzeug (int i, string kz, double anz_km, double nl):base(i, kz, anz_km)
		{
			nutzlast = nl;
		}

	 public override void ausgabe_daten(){
			base.ausgabe_daten();
			Console.WriteLine ("Die Nutzlast dieses Nutzfahrzeugs ist: " + nutzlast.ToString () + "t.");
		}
	}
}

