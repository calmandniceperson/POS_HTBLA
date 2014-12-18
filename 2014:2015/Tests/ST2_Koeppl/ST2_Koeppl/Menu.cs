using System;
using System.Threading;

namespace ST2_Koeppl
{
	public class Menu
	{
		public Menu ()
		{
		}

		public int showMenu(){
			Console.Clear ();
			Console.WriteLine ("\tVERSICHERUNSMAKLER\t");
			Console.WriteLine ("1 ... Alle Kunden ausgeben");
			Console.WriteLine ("2 ... Bestimmten Kunden ausgeben");
			Console.WriteLine ("3 ... Daten ändern");

			try{
				return int.Parse(Console.ReadLine());
			}catch(FormatException){
				cooldown ();
				showMenu ();
			}
			return 0;
		}

		// menue um spezifische konten auszugeben
		// kontonummer wird abgefragt
		public string showSpecAccMenu(){
			Console.Clear ();
			Console.Write ("Geben Sie die Kontonummer/Polizzennummer des jeweiligen Kontos jetzt ein: ");
			try{
				return Console.ReadLine();
			}catch(FormatException){
				cooldown ();
				showSpecAccMenu ();
			}
			return string.Empty;
		}

		public void changeDataMenu(Verwaltung v){
			Console.Clear ();
			Console.WriteLine ("\tWAS WOLLEN SIE ÄNDERN?\t");
			Console.WriteLine ("1 ... Kontostand");
			Console.WriteLine ("2 ... Prämienaufkommen");
			Console.WriteLine ("3 ... Versicherungsaufwand");
			Console.WriteLine ("4 ... Kreditrahmen");

			Versicherungskunde vk;
			Bankkunde b;

			try{
				switch(int.Parse(Console.ReadLine())){
				case 1:
					Console.Write("Geben Sie die Kontonummer ein: ");
					b = (Bankkunde)v.queryAccount(Console.ReadLine());
					Console.Write("Geben Sie den neuen Kontostand an: ");
					b.kontostand = double.Parse(Console.ReadLine());
					break;
				case 2:
					Console.Write("Geben Sie die Polizzennummer ein: ");
					vk = (Versicherungskunde)v.queryAccount(Console.ReadLine());
					Console.Write("Geben Sie das neue Prämienaufkommen ein: ");
					vk.praemienaufkommen = double.Parse(Console.ReadLine());
					break;
				case 3:
					Console.Write("Geben Sie die Polizzennummer ein: ");
					vk = (Versicherungskunde)v.queryAccount(Console.ReadLine());
					Console.Write("Geben Sie das neue Prämienaufkommen ein: ");
					vk.versicherungsaufwand = double.Parse(Console.ReadLine());
					break;
				case 4:
					Console.Write("Geben Sie die Kontonummer ein: ");
					b = (Bankkunde)v.queryAccount(Console.ReadLine());
					Console.Write("PIN-Code: ");
					if(int.Parse(Console.ReadLine()) == b.pin){
						Console.Write("Geben Sie den neuen Kontostand an: ");
						b.kreditrahmen = double.Parse(Console.ReadLine());
					}else{
						cooldown();
						changeDataMenu(v);
					}
					break;
				}
			}catch(FormatException){
				cooldown ();
				changeDataMenu (v);
			}
		}

		private void cooldown(){
			Console.WriteLine ("Falsche Eingabe! Sie werden gleich weitergeleitet.");
			Thread.Sleep (2000);
		}
	}
}

