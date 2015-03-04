// /*
//  *	MICHAEL KOEPPL 3AHIF
//  * 	2014/2015
//  */
using System;
using System.IO;
using System.Text;

namespace CSKontenbuchungen
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string ant = string.Empty;
			KontenVerwaltung kv = new KontenVerwaltung ();

			do {
				if (File.Exists ("../../../../Kontobuchungen.txt")) {
					StreamReader Reader = new StreamReader ("../../../../Kontobuchungen.txt");

					while(!Reader.EndOfStream){
						string Line = Reader.ReadLine();

						kv.addValue(Line.Substring(0,10), Line.Substring(10, (Line.Length - 10)).Trim());
					}

					Reader.Close();

					kv.printAll();

				} else {
					Console.WriteLine ("Keine Datei gefunden, die die Buchungen enthaelt.");
				}
				Console.WriteLine ("Wollen Sie das Programm neu starten? (j/n) ");
				ant = Console.ReadLine ();
			} while(ant.ToLower ().StartsWith ("j"));
		}

		public static int menu(){
			Console.WriteLine ("BUCHUNG HINZUFUEGEN ... 1");
			Console.WriteLine ("KONTEN AUSGEBEN ... 2");

			return int.Parse (Console.ReadLine ());
		}
	}
}
