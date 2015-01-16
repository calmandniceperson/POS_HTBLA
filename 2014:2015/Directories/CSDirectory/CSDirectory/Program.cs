/*
 * 
 * MICHAEL KOEPPL
 * 3AHIF
 * 2014/2015
 * 
 * AUFGABENSTELLUNG:
 * Verschiedene Uebungen mit Directories
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace CSDirectory
{
	class MainClass
	{
		public static string path = String.Empty, ant = String.Empty, tempdirname = String.Empty;
		public static string[] folders = { "" };

		public static void Main (string[] args)
		{
			do {
				switch (menu ()) {
				case 1: /*Alle Directories ausgeben*/
					print_all();
					break;
				case 2: /*Anzahl der Directories*/
					Console.Clear ();
					Console.Write ("Geben Sie den Pfad ein, dessen Directories Sie sehen wollen: ");
					path = Console.ReadLine ();
					Console.WriteLine ("ANZAHL DIRECTORIES IN " + path);
					int directory_count = 0;
					if (folders.Length > 0) {
						for (int i = 0; i < folders.Length; i++) {
							folders [i] = "";
						}
					}
					try{
						folders = Directory.GetDirectories (path, "*", SearchOption.AllDirectories);
					}catch(Exception ex){
						Console.WriteLine ("FEHLER \n\r" + ex.ToString());
						break;
					}
					foreach (string d in folders) {
						directory_count++;
					}
					Console.WriteLine ("\n\r/User/Shared/ enthaelt " + directory_count.ToString () + " directories.");
					break;
				case 3: /*Startargumente ausgeben*/
					Console.Clear ();
					Console.WriteLine ("ARGUMENTS");
					string[] tempargs;
					try{
						tempargs = Environment.GetCommandLineArgs ();
					}catch(Exception ex){
						Console.WriteLine ("FEHLER \n\r" + ex.ToString());
						break;
					}
					foreach (string t in tempargs) {
						Console.WriteLine (t);
					}
					break;
				case 4: /*directory erstellen*/
					Console.Clear ();
					Console.Write ("Geben Sie den Pfad ein: ");
					path = Console.ReadLine ();
					Console.Write ("Geben Sie den Namen Ihrer Directory an: ");
					tempdirname = Console.ReadLine ();
					try{
						if(!Directory.Exists(path + "/" + tempdirname)){
							Directory.CreateDirectory (path + "/" + tempdirname);
						}else{
							Console.WriteLine ("D1RECT0RY EXISTIERT BEREITS!");
						}
					}catch(Exception ex){
						Console.WriteLine ("FEHLER \n\r" + ex.ToString());
						break;
					}
					print_all(path);
					break;
				case 5: /*directory loeschen*/
					Console.Clear ();
					Console.Write ("Geben Sie den Pfad ein: ");
					path = Console.ReadLine ();
					print_all(path);
					Console.Write ("Geben Sie den Namen Ihrer Directory an: ");
					tempdirname = Console.ReadLine ();

					Console.Write("Sind Sie sicher? (j/n)");
					ant = Console.ReadLine();
					if(ant.ToLower().StartsWith("j")){
						try{
							Directory.Delete(path + "/" + tempdirname);
						}catch(Exception ex){
							Console.WriteLine ("FEHLER \n\r" + ex.ToString());
							break;
						}
					}
					print_all(path);
					break;
				case 6: /*directory verschieben*/
					Console.Clear ();
					Console.Write ("Geben Sie den Pfad zum zu verschiebenden Directory ein: ");
					path = Console.ReadLine ();
					Console.Write ("Geben Sie den Namen der zu verschiebenden Directory an: ");
					tempdirname = Console.ReadLine();
					if(!Directory.Exists(path + "/" + tempdirname)){
						Console.WriteLine("Diese Directory existiert nicht.");
					}else{
						Console.Write("Wohin wollen Sie den Ordner verschieben? ");
						string pathtomoveto = Console.ReadLine();

						try{
							Directory.Move((path + "/" + tempdirname), pathtomoveto);
						}catch(Exception ex){
							Console.WriteLine("FEHLER:\n\r" + ex.ToString());
							break;
						}
					}
					break;
				}

				Console.Write ("Wollen Sie noch eine Aktion ausfuehren? (j/n) ");
				try{
					ant = Console.ReadLine ();
				}catch(InvalidDataException ide){
					Console.WriteLine ("FEHLER \n\r" + ide.ToString());
					break;
				}catch(Exception ex){
					Console.WriteLine ("FEHLER \n\r" + ex.ToString());
				}
			} while(ant.ToLower ().StartsWith ("j"));
		}

		static int menu(){
			Console.Clear();
			Console.WriteLine ("Sie befinden Sich in " + Directory.GetCurrentDirectory());
			Console.WriteLine ();
			Console.WriteLine ("\tDIRECTORIES\t");
			Console.WriteLine("1 ... Alle Directories eines Pfads ausgeben");
			Console.WriteLine("2 ... Directories eines Pfads zaehlen");
			Console.WriteLine("3 ... Startargumente ausgeben");
			Console.WriteLine ("4 ... Directory erstellen");
			Console.WriteLine ("5 ... Directory loeschen");
			Console.WriteLine ("6 ... Directory verschieben");
			return int.Parse (Console.ReadLine ());
		}

		static void print_all(string p = ""){
			Console.Clear ();
			Console.WriteLine ("INHALT");
			if (p == "") {
				Console.Write ("Geben Sie den Pfad ein: ");
				path = Console.ReadLine ();
				Console.WriteLine ("DIRECTORIES IN " + path);
			} else {
				path = p;
			}
			if (folders.Length > 0) {
				for (int i = 0; i < folders.Length; i++) {
					folders [i] = "";
				}
			}

			try {
				folders = Directory.GetDirectories (path, "*", SearchOption.AllDirectories);
			} catch (Exception) {
				Console.WriteLine ("FEHLER: DIRECTORY NICHT GEFUNDEN");
			}
			foreach (string d in folders) {
				try {
					Console.WriteLine ("/" + d.Split ('/') [3]);
				} catch (IndexOutOfRangeException) {
					Console.WriteLine ("FEHLER: DIRECTORY NICHT GEFUNDEN");
					break;
				} catch (Exception) {
					Console.WriteLine ("FEHLER: DIRECTORY NICHT GEFUNDEN");
					break;
				}
			}
		}
	}
}
