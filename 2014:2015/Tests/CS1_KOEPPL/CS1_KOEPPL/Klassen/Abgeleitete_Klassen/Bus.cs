using System;

namespace CS1_KOEPPL
{
	public class Bus:Personenfahrzeug
	{
		public Bus (int i, string kz, double anz_km, int anz_sp):base(i, kz, anz_km, anz_sp)
		{
		}

		public override void ausgabe_daten(){
			base.ausgabe_daten ();
			if (anz_sitzplaetze <= 15) {
				Console.WriteLine ("Die Kosten von dieses Busses belaufen sich auf " + (anz_km * 6).ToString () + "€.");
				Console.WriteLine (anz_km.ToString () + "km * 6€ (pro km) = " + (anz_km * 6).ToString () + "€");
			} else if (anz_sitzplaetze <= 30) {
				Console.WriteLine ("Die Kosten dieses Busses belaufen sich auf " + (anz_km * 8).ToString () + "€.");
				Console.WriteLine (anz_km.ToString () + "km * 8€ (pro km) = " + (anz_km * 8).ToString () + "€");
			} else if (anz_sitzplaetze > 30) {
				Console.WriteLine ("Die Kosten dieses Busses belaufen sich auf " + (anz_km * 10).ToString () + "€.");
				Console.WriteLine (anz_km.ToString () + "km * 10€ (pro km) = " + (anz_km * 10).ToString () + "€");
			}
		}
	}
}

