using System;
using System.Collections.Generic;
using System.Linq;

namespace CS1_KOEPPL
{
	public class Fuhrpark
	{
		public Fuhrpark ()
		{
		}


		/*TEMPORARIES*/
		int id;
		string kennzeichen;
		double anz_km;

		/*Personenfahrzeug*/
		int anz_sitzplaetze;
		/*Personenfahrzeug*/

		/*Nutzfahrzeug*/
		double nutzlast;
		/*Nutzfahrzeug*/

		int tempint;
		string temp;
		double tempd;
		/*TEMPORARIES*/

		List<Fahrzeug> fahrzeugList = new List<Fahrzeug>(); /*liste fuer die fahrzeuge*/

		public void addFahrzeug(int type){

			if (!fahrzeugList.Any ()) {
				id = 1;
			} else {
				id = fahrzeugList.Last().getId() + 1; 
			}

			Console.WriteLine ("Geben Sie das Kennzeichen des Fahrzeugs ein: ");
			kennzeichen = Console.ReadLine ();

			Console.WriteLine ("Geben Sie die bisher gefahrenen km ein (auch Dezimalzahlen erlaubt): ");
			anz_km = double.Parse (Console.ReadLine ());

			switch (type) {
			case 1: /*PKW*/
				Console.WriteLine ("Geben Sie die Anzahl der Sitzplätze ein: ");
				anz_sitzplaetze = int.Parse (Console.ReadLine ());

				fahrzeugList.Add (new PKW (id, kennzeichen, anz_km, anz_sitzplaetze));

				printFahrzeug(getFahrzeugById(id).getId());
				break;
			case 2: /*Bus*/
				Console.WriteLine ("Geben Sie die Anzahl der Sitzplätze ein: ");
				anz_sitzplaetze = int.Parse (Console.ReadLine ());

				fahrzeugList.Add (new Bus (id, kennzeichen, anz_km, anz_sitzplaetze));

				printFahrzeug(getFahrzeugById(id).getId());
				break;
			case 3: /*LKW*/
				Console.WriteLine ("Geben Sie die Nutzlast des LKWs in t ein: ");
				nutzlast = double.Parse (Console.ReadLine ());

				fahrzeugList.Add (new LKW (id, kennzeichen, anz_km, nutzlast));

				printFahrzeug(getFahrzeugById(id).getId());
				break;
			case 4: /*Anhaenger*/
				Console.WriteLine ("Geben Sie die Nutzlast des Anhängers in t ein: ");
				nutzlast = double.Parse (Console.ReadLine ());

				fahrzeugList.Add (new Anhaenger (id, kennzeichen, anz_km, nutzlast));

				printFahrzeug(getFahrzeugById(id).getId());
				break;
			}
		}

		public void deleteFahrzeug(){
			Console.WriteLine ("Geben Sie die ID des zu löschenden Fahrzeugs ein: ");
			tempint = int.Parse (Console.ReadLine ());
			fahrzeugList.Remove (getFahrzeugById (tempint));
		}

		public void addKmToFahrzeug(){
			Console.WriteLine("Geben Sie die ID des Fahrzeugs an: ");
			tempint = int.Parse(Console.ReadLine());

			Console.WriteLine("Geben Sie an, wie weit sich das Fahrzeug seit dem letzten Eintrag (" + getFahrzeugById(tempint).anz_km.ToString() + "km) bewegt hat: ");
			tempd = double.Parse(Console.ReadLine());

			getFahrzeugById(tempint).anz_km = getFahrzeugById(tempint).anz_km + tempd;

			Console.WriteLine ("Der Kilometerstand des Fahrzeugs beträgt jetzt: " + getFahrzeugById (tempint).anz_km.ToString ());
		}

		public void printFahrzeug(int i = 0 /*id*/){
			if (i == 0) {
				Console.WriteLine ("Geben Sie die ID des Fahrzeugs ein: ");
				getFahrzeugById (int.Parse (Console.ReadLine ())).ausgabe_daten ();
			} else {
				getFahrzeugById (i).ausgabe_daten ();
			}
		}

		public void printAll(){
			Console.Clear ();
			foreach (Fahrzeug f in fahrzeugList) {
				printFahrzeug (f.getId ());
			}
		}

		Fahrzeug getFahrzeugById(int i /*id*/){
			foreach (Fahrzeug f in fahrzeugList) {
				if (f.getId () == i) {
					return f;
				}
			}
			return null;
		}

		public List<Fahrzeug> getList(){
			return fahrzeugList;
		}
	}
}

