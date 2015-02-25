/*
 * MICHAEL KOEPPL 3AHIF
 * TEST 24.02.2015
 * ZEITVERWALTUNG
 * ST3B_KOEPPL
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace st3b_koeppl
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string text = string.Empty, ant = string.Empty;
			StreamReader sr = new StreamReader ("ZJournal.txt");
			Verwaltung v = new Verwaltung ();

			do {
				Console.WriteLine("Willkommen im Zeitverwaltungsprogramm!");
				string[] strArray = new string[30];
				if(File.Exists("ZJournal.txt")){
					text = sr.ReadToEnd();
					strArray = text.Split('\n');

					int i = 0;
					for(i = 0; i <= strArray.Length - 1; i++){
						if(v.getList().Any()){
							bool foundandadded = false;
							for(int j = 0; j <= v.getList().Count() -1; j++){
								//Console.WriteLine (m.name + " " + strArray[i].Split(' ')[0]);
								if(v.getList()[j].name == strArray[i].Split(' ')[0]){ // name kommt vor
									v.getList()[j].addSzEz(Convert.ToDouble(strArray[i].Split(' ')[1].Replace(",", ".")), Convert.ToDouble(strArray[i].Split(' ')[2].Replace(",", ".")));
									foundandadded = true;
								}
							}

							if(foundandadded){
								continue;
							}else{
								v.add(new Mitarbeiter(strArray[i].Split(' ')[0], Convert.ToDouble(strArray[i].Split(' ')[1].Replace(",", ".")), Convert.ToDouble(strArray[i].Split(' ')[2].Replace(",", "."))));
							}
						}else{
							if(strArray[i] != string.Empty){
								v.add(new Mitarbeiter(strArray[i].Split(' ')[0], Convert.ToDouble(strArray[i].Split(' ')[1].Replace(",", ".")), Convert.ToDouble(strArray[i].Split(' ')[2].Replace(",", "."))));
							}
						}
					}
				}else{
					Console.WriteLine ("No File found!");
				}

				foreach(Mitarbeiter m in v.getList()){
					Console.WriteLine (m.ToString());
				}

				Console.Write ("Wollen Sie neu starten? (j/n) ");
				ant = Console.ReadLine ();
			} while(ant.ToLower ().StartsWith ("j"));
		}
	}
}
