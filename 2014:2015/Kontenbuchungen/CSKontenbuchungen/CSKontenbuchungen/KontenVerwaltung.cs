// /*
//  *	MICHAEL KOEPPL 3AHIF
//  * 	2014/2015
//  */
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSKontenbuchungen
{
	public delegate void Buchung(object sender, BuchungEventArgs e);

	public class KontenVerwaltung
	{
		// EVENT ZONE
		public event Buchung bu;

		public void OnBuchung(string k, double w){
			if(bu != null){
				bu (this, new BuchungEventArgs (k, w));
			}
		}

		public void BuchungsHandler(object sender, BuchungEventArgs e){
			Console.WriteLine ("Buchung an " + e.KNr + " ueber " + e.betrag + " Euro");
			Console.WriteLine ();
		}
		// EVENT ZONE ENDE

		int count_ueberzogen, count_verdaechtig;
		public Dictionary<string, Konto> KontenListe;

		public KontenVerwaltung ()
		{
			bu += BuchungsHandler;
			KontenListe = new Dictionary<string, Konto>();
		}

		public void addValue(string k, string wert /*kontostand*/){
			if (KontenListe.ContainsKey (k)) {
				KontenListe [k].Kontostand += double.Parse(wert.Replace(',', '.')); // buchung zu bestehendem konto hinzufuegen
				OnBuchung (k, double.Parse (wert.Replace(',', '.')));
			} else { //neues konto
				if (int.Parse (k.Substring (0, 1)) >= 1 && int.Parse (k.Substring (0, 1)) <= 5) { //KontoA
					KontoA a = new KontoA (k, double.Parse (wert.Replace (',', '.')));
					a.ue += Verwaltung_UeberzogenHandler;
					a.vb += Verwaltung_VerdaechtigHandler;
					KontenListe.Add (k, a);
				} else if (int.Parse (k.Substring (0, 1)) >= 6 && int.Parse (k.Substring (0, 1)) <= 9) { //KontoB
					KontoB b = new KontoB (k, double.Parse (wert.Replace (',', '.')));
					b.ue += Verwaltung_UeberzogenHandler;
					b.vb += Verwaltung_VerdaechtigHandler;
					KontenListe.Add (k, b);
				}
			}
		}

		public void printAll(){
			foreach(KeyValuePair<string, Konto> kvp in KontenListe){
				Console.WriteLine (kvp.Value.ToString());
				Console.WriteLine ();
			}
			Console.WriteLine ("Anzahl ueberzogen: {0}", count_ueberzogen);
			Console.WriteLine ("Anzahl verdaechtig: {0}", count_verdaechtig);

		}

		void Verwaltung_UeberzogenHandler(object sender, EventArgs e){
			Console.WriteLine ("UEBERZOGEN");
			count_ueberzogen++;
		}

		void Verwaltung_VerdaechtigHandler(object sender, EventArgs e){
			Console.WriteLine ("VERDAECHTIGER BETRAG");
			count_verdaechtig++;
		}
	}
}

