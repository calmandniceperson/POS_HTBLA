using System;
using System.Collections.Generic;
using System.Text;

namespace st3b_koeppl_verbesserung
{
	public class CFirma
	{
		// dictionary, weil man darin ganz einfach suchen kann, ob der name des Mitarbeiters bereits enthalten ist
		Dictionary<string /*schluessel*/, Mitarbeiter /*wert*/> FirmenListe;

		public int cntTUE{ get; set; }
		public int cntWUE{ get; set; }

		public CFirma ()
		{
			FirmenListe = new Dictionary<string, Mitarbeiter>();
		}

		public void AddMitarbeiter(string n, double zeit){
			if (FirmenListe.ContainsKey (n)) { // wenn die Liste den Namen schon als Eintrag enthaelt
				FirmenListe [n].WAZ = zeit; //    wird sie bei diesem Mitarbeiter hinzugefuegt
			}else{
				FirmenListe.Add (n /*name als key*/, new Mitarbeiter (n, zeit) /*wert*/);
				//FirmenListe [n].UE += CFirma_TUE; --> ALT
				//FirmenListe [n].UE += CFirma_WUE; --> ALT
				FirmenListe [n].UE += CFirma_UE;
			}
		}

		public void TestWAZ(){
			foreach(KeyValuePair<string, Mitarbeiter> kvp /*die beiden elemente, key und wert, aus denen das Dictionary besteht, werden zusammengefuegt*/ in FirmenListe){
				kvp.Value.TestWAZ ();
			}
		}

		public override string ToString () // Ausgeben der Liste an Mitarbeitern als String
		{
			StringBuilder sb = new StringBuilder ();
			foreach(KeyValuePair<string, Mitarbeiter> kvp in FirmenListe){
				sb.Append (kvp.Value.ToString () + "\n");
			}

			sb.Append ("Anzahl Tagesueberschreitungen: " + cntTUE + "\n");
			sb.Append ("Anzahl Wochenueberschreitungen: " + cntWUE + "\n");

			return sb.ToString ();
		}

		/*void CFirma_TUE(object sender, EventArgs e){
			Console.WriteLine ("Tageszeit ueberschritten!");
			cntTUE++; // Anzahl an ueberschrittenen Tagesarbeitszeiten der Mitarbeiter erhoehen
		}

		void CFirma_WUE(object sender, EventArgs e){
			Console.WriteLine ("Wochenzeit ueberschritten!");
			cntWUE++; // Anzahl an ueberschrittenen Wochenarbeitszeiten der Mitarbeiter erhoehen
		}*/

		void CFirma_UE(object sender, CWTAZEventArgs e){
			if (e.W_T) {
				Console.WriteLine ("Wochenzeitueberschreitung von: {0} Stundenanzahl: {1}", e.Name, e.StdAnz);
				cntWUE++;
			} else {
				Console.WriteLine ("Tageszeitueberschreitung von: {0} Stundenanzahl: {1}", e.Name, e.StdAnz);
				cntTUE++;
			}
		}
	}
}

