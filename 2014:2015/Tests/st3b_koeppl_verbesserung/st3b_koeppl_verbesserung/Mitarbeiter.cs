using System;
using System.Collections.Generic;
using System.Linq;

namespace st3b_koeppl_verbesserung
{
	public delegate void ArbZeit(object sender, CWTAZEventArgs e);

	public class Mitarbeiter:IWTUE
	{
		//public event ArbZeit TUE; // tagesueberstunden --> nicht mehr benutzt
		//public event ArbZeit WUE; // wochenueberstunden --> nicht mehr benutzt
		public event ArbZeit UE; // ueberschreitung, ersetzt beide events darueber

		public string Name { get; set; }
		double _waz; // interne waz
		double _taz; //interne tagesarbeitszeit
		public double WAZ{  // wochenarbeitszeit
			get{
				return _waz;
			}
			set{
				_taz = value;
				_waz += value; //   intern die wochenarbeitszeit speichern
				if (value > 7.8) // wenn die wochenarbeitszeit ueber 7.8 ist
					OnUE (false); //    --> Event ausloesen
			} 
		}

		// konstruktor
		public Mitarbeiter (string n, double zeit)
		{
			Name = n;
			WAZ = zeit;
		}

		public void TestWAZ(){
			if(WAZ > 38.5){
				OnUE (true);
			}
		}

		/*public void OnTUE(){ // eventhandler
			if (TUE != null)
				TUE (this, new CWTAZEventArgs());
		}
													NICHT MEHR IN BENUTZUNG, OnUE ersetzt
		public void OnWUE(){ // eventhandler
			if (WUE != null)
				WUE (this, new CWTAZEventArgs ());
		}*/

		public void OnUE(bool wt /*wochen oder tage*/){
			if(UE != null){
				if(wt) // true = woche, false = tag
					UE (this, new CWTAZEventArgs (Name, _waz, wt));
				else
					UE (this, new CWTAZEventArgs (Name, _taz, wt));
			}
		}

		public override string ToString () // ToString() des Mitarbeiters
		{
			return Name + " WAZ:" + WAZ.ToString ("0.0");
		}
	}
}

