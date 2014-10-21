using System;

namespace CS1_KOEPPL
{
	public class Personenfahrzeug:Fahrzeug
	{

		protected int anz_sitzplaetze{ get; set;} /*anzahl der sitzplaetze*/

		public Personenfahrzeug (int i, string kz, double anz_km, int anz_s):base(i, kz, anz_km)
		{
			anz_sitzplaetze = anz_s;
		}

		public override void ausgabe_daten(){
			base.ausgabe_daten();
			Console.WriteLine ("Dieses Fahrzeug hat " + anz_sitzplaetze.ToString () + " Sitzplätze.");
		}
	}
}

