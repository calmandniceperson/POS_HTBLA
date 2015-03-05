// /*
//  *	MICHAEL KOEPPL 3AHIF
//  * 	2014/2015
//  *   Nachtest am 5.3.2015
//  *   Messstationen Beispiel
//  */
using System;
using System.Collections.Generic;
using System.Linq;

namespace sn3_koeppl
{
	public class Verwaltung
	{
		Dictionary<int, Messstation> StationsListe;

		public Verwaltung ()
		{
			StationsListe = new Dictionary<int, Messstation>();
		}

		public void addWert(int sid, int w1, int w2 = 0){
			if(StationsListe.ContainsKey(sid)){
				if (w2 != 0) {
					StationsListe [sid].setGrenzwerte (w1, w2);
				} else {
					StationsListe [sid].setMessung (w1);
				}
			}else{
				StationsListe.Add (sid, new Messstation (sid));
				StationsListe [sid].setGrenzwerte (w1, w2);
				StationsListe [sid].G1UE += Verwaltung_OnG2Ueberschritten;
				StationsListe [sid].G2UE += Verwaltung_OnG1Ueberschritten;
			}
		}

		public void printAll(){
			foreach(KeyValuePair<int, Messstation> kvp in StationsListe){
				Console.WriteLine (kvp.Value.ToString());
			}
		}

		public void Verwaltung_OnG2Ueberschritten(object sender, GrenzwertUeberschrittenEventArgs e){
			Console.WriteLine ("ALARM: Grenzwert 2 ueberschritten bei Station {0} mit dem Grenzwert2 {1} bei der Messung {2}", e.StationsID, e.Grenzwert2, e.Messwert);
			Console.WriteLine ();
		}

		public void Verwaltung_OnG1Ueberschritten(object sender, GrenzwertUeberschrittenEventArgs e){
			Console.WriteLine ("WARNUNG: Grenzwert 1 zum zweiten Mal ueberschritten bei Station {0} mit dem Grenzwert1 {1} bei der Messung {2}", e.StationsID, e.Grenzwert1, e.Messwert);
			Console.WriteLine ();
		}
	}
}

