using System;

namespace CS1_KOEPPL
{
	public class LKW:Nutzfahrzeug
	{
		public LKW (int i, string kz, double anz_km, double nl) : base (i, kz, anz_km, nl)
		{
		}

		public override void ausgabe_daten(){
			base.ausgabe_daten ();
			Console.WriteLine ("Die Kosten dieses LKWs belaufen sich auf " + (anz_km * nutzlast).ToString () + "€.");
			Console.WriteLine (anz_km.ToString () + "km * " + nutzlast.ToString() + "t = " + (anz_km * nutzlast).ToString());
		}
	}
}

