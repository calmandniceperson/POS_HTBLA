using System;

namespace CS1_KOEPPL
{
	public class Anhaenger:Nutzfahrzeug
	{
		public Anhaenger (int i, string kz, double anz_km, double nl):base(i, kz, anz_km, nl)
		{
		}

		public override void ausgabe_daten(){
			base.ausgabe_daten ();
			Console.WriteLine ("Die Kosten dieses PKWs belaufen sich auf " + ((anz_km * nutzlast)/2).ToString () + "€.");
			Console.WriteLine ("(" + anz_km.ToString () + "km * " + nutzlast.ToString() + "t) / 2 = " + (anz_km * nutzlast).ToString());
		}
	}
}

