using System;
using System.IO;

namespace SE2_KOEPPL
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			if (File.Exists ("Bestellungen.txt")) {
				File.Delete ("Bestellungen.txt");
			}

			string text;
			StreamReader sr = new StreamReader ("Lager.txt");

			while ((text = sr.ReadLine ()) != "") {
				if (text != null) {
					Verwaltung.addNewLagerBestand (new Lager (text.Substring (0, 19).Trim (), Convert.ToInt32 (text.Substring (20, 5).Trim ()), Convert.ToInt32 (text.Substring (30, (text.Length - 30)).Trim ())));
					//Console.WriteLine ("Name: " + l.artikel_bez + "\tMindestbestand: " + l.bestand_minimum + "\tAktueller Bestand" + l.bestand_aktuell);
				} else {
					sr.Close ();
					break;
				}
			}

			foreach(Lager l in Verwaltung.liste){
				Console.WriteLine (l.ToString());
			}

			Console.ReadKey ();
		}
	}
}
