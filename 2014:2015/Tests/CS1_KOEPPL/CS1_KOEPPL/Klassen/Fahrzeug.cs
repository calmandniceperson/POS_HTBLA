using System;

namespace CS1_KOEPPL
{
	public class Fahrzeug:IFahrzeug
	{

		int id; /*zur identifikation beim loeschen oder bearbeiten*/
		string kennzeichen;
		public double anz_km{get;set;} /*anzahl der gefahrenen km*/

		public Fahrzeug (int i, string kz, double akm)
		{
			id = i;
			kennzeichen = kz;
			anz_km = akm;
		}

		public virtual void ausgabe_daten(){
			Console.WriteLine ();
			Console.WriteLine ();
			Console.WriteLine ("ID: " + id.ToString ());
			Console.WriteLine ("Das Kennzeichen des Fahrzeugs ist: " + kennzeichen + ".");
			Console.WriteLine ("Das Fahrzeug ist bereits " + anz_km.ToString () + "km gefahren.");
		}

		public int getId(){
			return id;
		}
	}
}

