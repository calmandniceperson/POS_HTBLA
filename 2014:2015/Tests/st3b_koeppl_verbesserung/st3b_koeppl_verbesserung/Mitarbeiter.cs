using System;
using System.Collections.Generic;
using System.Linq;

namespace st3b_koeppl_verbesserung
{
	public delegate void ArbZeit(object sender, EventArgs e);

	public class Mitarbeiter:IWTUE
	{
		public event ArbZeit TUE; // tagesueberstunden
		public event ArbZeit WUE; // wochenueberstunden

		public string Name { get; set; }
		double _waz; // interne waz
		public double WAZ{  // wochenarbeitszeit
			get{
				return _waz;
			}
			set{
				_waz += value; //   intern die wochenarbeitszeit speichern
				if (value > 7.8) // wenn die wochenarbeitszeit ueber 7.8 ist
					OnTUE (); //    --> Event ausloesen
			} 
		}

		// konstruktor
		public Mitarbeiter (string n, double zeit)
		{
			Name = n;
			WAZ = zeit;
		}

		public void TestWAZ(){
			/*foreach(KeyValuePair<string, Mitarbeiter> kvp /*die beiden elemente, key und wert, aus denen das Dictionary besteht, werden zusammengefuegt in FirmenListe){
				if(kvp.Value.WAZ < 38.5){
					kvp.Value.OnWUE ();
				}
			}*/

			if(WAZ > 38.5){
				OnWUE ();
			}
		}

		public void OnTUE(){ // eventhandler
			if (TUE != null)
				TUE (this, new EventArgs());
		}

		public void OnWUE(){ // eventhandler
			if (WUE != null)
				WUE (this, new EventArgs ());
		}

		public override string ToString () // ToString() des Mitarbeiters
		{
			return Name + " WAZ:" + WAZ.ToString ("0.0");
		}
	}
}

