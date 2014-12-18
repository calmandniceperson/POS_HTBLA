using System;
using System.Collections.Generic;

namespace ST2_Koeppl
{
	public class Verwaltung
	{
		public Verwaltung ()
		{
		}

		List<Kunde> kundenListe = new List<Kunde> ();

		public bool addKunde(Kunde k){
			try{
				kundenListe.Add (k);
				return true;
			}catch(ArgumentException){
				Console.WriteLine ("Falsches Argument.");
				return false;
			}
		}

		public void printSelObject(string num, bool all = false){
			if (all) {
				foreach (Kunde k in kundenListe) {
					Console.WriteLine ();
					Console.WriteLine (k.ToString ());
				}
			} else {
				switch (num.Substring (0, 1).ToLower ()) {
				// kontonummer beginnen mit k
				case "k":
					foreach (Bankkunde k in kundenListe) {
						if (k.kontonummer == num) {
							Console.WriteLine ();
							Console.WriteLine (k.ToString ());
						}
					}
					break;
				// polizzennummern beginnen mit p
				case "p":
					foreach (Versicherungskunde k in kundenListe) {
						if (k.polizzennummer == num) {
							Console.WriteLine ();
							Console.WriteLine (k.ToString ());
						}
					}
					break;
				}

			}
		}

		public Kunde queryAccount(string num){
			switch (num.Substring (0, 1).ToLower ()) {
			// kontonummer beginnen mit k
			case "k":
				foreach (Bankkunde k in kundenListe) {
					if (k.kontonummer == num) {
						return k;
					}
				}
				break;
				// polizzennummern beginnen mit p
			case "p":
				foreach (Versicherungskunde k in kundenListe) {
					if (k.polizzennummer == num) {
						return k;
					}
				}
				break;
			}

			return null;
		}
	}
}

