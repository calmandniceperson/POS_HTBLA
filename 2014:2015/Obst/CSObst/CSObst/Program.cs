using System;
using System.IO;

namespace CSObst
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Verwaltung v = new Verwaltung ();

			string ant = "";
			StreamReader sr;

			do{

				Console.WriteLine ("Time started: " + DateTime.Now);

				initializeProductList(sr = initializeStreamReader ("../../obstliste.txt"));
					
				/*for (i = 0; i <= Verwaltung.getProduktListe().Count - 1; i++) {
					Console.WriteLine ();
					Console.WriteLine (Verwaltung.getProduktListe()[i]);
				}*/


				Menu.showMenu ();

				Console.Write ("Wollen Sie noch eine Aktion durchfuehren? (J/N)");
				ant = Console.ReadLine();
			}while(ant.ToLower().StartsWith("j"));
		}

		public static StreamReader initializeStreamReader(string path){
			try{
				return new StreamReader (path);
			}catch(FileLoadException ex){
				Console.WriteLine (ex.ToString ());
				initializeStreamReader (path);
			}catch(FileNotFoundException ex){
				Console.WriteLine (ex.ToString ());
				initializeStreamReader (path);
			}

			return null;
		}

		public static void initializeProductList(StreamReader sr){
			string[] txt;

			txt = sr.ReadToEnd ().Trim().Split ('#');

			int i = 0;

			for (i = 0; i <= txt.Length - 1; i++) {
				switch (txt[i].Split ('_') [0].ToLower()/*.Remove(0, 2)*/) {
				case "obs":
					Verwaltung.addToProduktListe(new Obst(txt[i].Split('_')[1],
						txt[i].Split('_')[2],
						Convert.ToDouble(txt[i].Split('_')[3]), 
						txt[i].Split('_')[4], 
						txt[i].Split('_')[5], 
						Convert.ToInt32(txt[i].Split('_')[6])));
					break;
				case "gem":
					Verwaltung.addToProduktListe(new Gemuese(txt[i].Split('_')[1],
						txt[i].Split('_')[2],
						Convert.ToInt32(txt[i].Split('_')[3]), 
						txt[i].Split('_')[4], 
						txt[i].Split('_')[5]));
					break;
				case "obp":
					Verwaltung.addToProduktListe(new Obstprodukt(txt[i].Split('_')[1],
						txt[i].Split('_')[2],
						Convert.ToInt32(txt[i].Split('_')[3]), 
						txt[i].Split('_')[4], 
						txt[i].Split('_')[5], 
						Convert.ToInt32(txt[i].Split('_')[6])));
					break;
				}
			}
		}
	}
}
