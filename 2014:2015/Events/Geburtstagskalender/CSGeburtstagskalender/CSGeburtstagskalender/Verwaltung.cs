using System;
using System.Collections.Generic;

namespace CSGeburtstagskalender
{
	public class Verwaltung
	{

		public Verwaltung(){
		}

		Handler h = new Handler();
		List<Erinnerung> geburtstagsListe = new List<Erinnerung>();

		public void createNewErinnerung(DateTime gebdat,
		                         string name,
		                         int anz_t_z /*wie viele tage zuvor erinnert werden soll*/
		                         , int anz_e /*wie oft erinnert werden soll*/){

			geburtstagsListe.Add(new Erinnerung (gebdat, name, anz_t_z, anz_e));
		}

		public void printAll(){
			foreach (Erinnerung e in geburtstagsListe) {
				Console.WriteLine ("Datum: " + e.datum);
				Console.WriteLine ("Name:" + e.name_geburtstagskind);
				Console.WriteLine ("Erinnerung: " + e.erinnerung);
				Console.WriteLine ("Anz. Erinnerungen: " + e.anz_erinnerungen);
				Console.WriteLine ();
			}
		}

		public void checkDatum(DateTime now){
			foreach (Erinnerung e in geburtstagsListe) {
				h.HatGeburtstag += GeburtstagsEventHandler;
				h.KeinGeburtstag += KeinGeburtstagEventHandler;
				e.checkDatum (now, h);
			}
		}

		public void GeburtstagsEventHandler(Erinnerung e){
			if (e.anz_erinnerungen > 0) {
				Console.WriteLine (e.name_geburtstagskind + " hat Geburtstag!");
				e.anz_erinnerungen--;
			}
		}

		public void KeinGeburtstagEventHandler(Erinnerung e){
			if (e.anz_erinnerungen > 0) {
				//Console.WriteLine (e.name_geburtstagskind + " hat nicht Geburtstag!");
				e.anz_erinnerungen--;
			}
		}
	}
}

