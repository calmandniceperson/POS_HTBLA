using System;

namespace CS1_KOEPPL
{
	public class PKW:Personenfahrzeug
	{
		public PKW (int i, string kz, double anz_km, int anz_sp):base(i, kz, anz_km, anz_sp)
		{
		}

		public override void ausgabe_daten(){
			base.ausgabe_daten ();
			Console.WriteLine ("Die Kosten dieses PKWs belaufen sich auf " + (anz_km * 5).ToString () + "€.");
			Console.WriteLine (anz_km.ToString () + "km * 5€ (pro km) = " + (anz_km * 5).ToString () + "€");
		}
	}
}

