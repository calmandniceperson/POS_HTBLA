using System;
using System.Threading;

namespace CSObst
{
	public class Menu
	{
		public static void showMenu(){
			Console.Clear ();

			int inp, i;

			Console.WriteLine ("\tWas wollen Sie tun?\t");
			Console.WriteLine ("1 ... Alle Produkte ausgeben");
			Console.WriteLine ("2 ... Warenkorb ausgeben");
			Console.WriteLine ("3 ... Produkt kaufen");

			try{
				switch ((inp = int.Parse(Console.ReadLine ()))) {
				case 1:
					Verwaltung.print_products ();
					break;
				case 2:
					Verwaltung.print_warenkorb ();
					break;
				case 3:
					Console.WriteLine ("\tWas wollen Sie kaufen?\t");
					//Console.WriteLine (Verwaltung.getProduktListe().Count);
					for(i = 0; i <= Verwaltung.getProduktListe().Count - 1; i++){
						Console.WriteLine ((i+1).ToString() + " ... " + Verwaltung.getProduktListe()[i].ToString() + "\n");
					}

					switch(int.Parse(Console.ReadLine())){
					case 1:
						Verwaltung.addToWarenkorb(Verwaltung.getProduktListe()[0]);
						break;
					case 2:
						Verwaltung.addToWarenkorb(Verwaltung.getProduktListe()[1]);
						break;
					case 3:
						Verwaltung.addToWarenkorb(Verwaltung.getProduktListe()[2]);
						break;
					}
					break;
				}
			}catch(FormatException){
				Console.WriteLine ("Ihre Eingabe hatte ein falsches Format. Sie werden in 2 Sekunden weitergeleitet.");
				int milliseconds = 2000;
				Thread.Sleep (milliseconds);
				showMenu ();
			}catch(Exception){
				Console.WriteLine ("Oops! Ein Fehler ist aufgetreten. Sie werden in 2 Sekunden weitergeleitet.");
				int milliseconds = 2000;
				Thread.Sleep (milliseconds);
				showMenu ();
			}
		}


	}
}

