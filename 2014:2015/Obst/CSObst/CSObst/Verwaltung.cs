using System;
using System.Collections.Generic;
using System.Linq;

namespace CSObst
{
	public class Verwaltung
	{
		static List<Produkt> produktListe = new List<Produkt>();

		public static void addToProduktListe(Produkt p){
			produktListe.Add (p);
			//p.ToString ();
		}

		public static List<Produkt> getProduktListe(){
			return produktListe;
		}

		public static void print_products(){
			foreach (Produkt p in produktListe) {
				Console.WriteLine (p.ToString() + "\n");
			}
		}


		static List<Produkt> warenKorb = new List<Produkt> ();

		public static void addToWarenkorb(Produkt p){
			if (p.GetType ().Name == "Gemuese") {
				Gemuese g = (Gemuese)p;
				Console.WriteLine (g.getAblaufDatum());
				if (g.getAblaufDatum() < DateTime.Now) {
					Console.WriteLine ("Ablaufdatum ist ueberschritten.");
					g.OnDatumUeberschritten (new EventArgs());
				}
			}
			warenKorb.Add (p);
		}

		public static List<Produkt> getWarenkorb(){
			return warenKorb;
		}

		public static void print_warenkorb(){
			if(!warenKorb.Any()){
				Console.WriteLine ("Ihr Warenkorb ist leer.");
			}else{
				foreach (Produkt p in warenKorb) {
					Console.WriteLine (p.ToString() + "\n");
				}
			}
		}
	}
}

