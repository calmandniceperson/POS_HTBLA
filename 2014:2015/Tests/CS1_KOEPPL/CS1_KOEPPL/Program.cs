/*
 * MICHAEL KOEPPL 
 * 3AHIF
 * 21.10.2014
 */
using System;

namespace CS1_KOEPPL
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Fuhrpark fp = new Fuhrpark();
			MenuClass mc = new MenuClass();
			string ant;
			int temp;

			do {
				Console.Clear();
				Console.WriteLine ("Wollen Sie selbst Fahrzeuge anlegen (1)\n\roder soll das Programm automatisch Fahrzeuge generieren (2)? "); 
				if ((temp = int.Parse (Console.ReadLine ())) == 1) {
					do {
						Console.Clear();
						switch (mc.showMenu ()) {
						case 1:
							switch (mc.showCreationMenu ()) {
							case 1:
								fp.addFahrzeug (1);
								break;
							case 2:
								fp.addFahrzeug (2);
								break;
							case 3:
								fp.addFahrzeug (3);
								break;
							case 4:
								fp.addFahrzeug (4);
								break;
							}
							break;
						case 2:
							fp.addKmToFahrzeug ();
							break;
						case 3:
							fp.deleteFahrzeug ();
							break;
						case 4:
							fp.printFahrzeug ();
							break;
						case 5:
							fp.printAll ();
							break;
						}

						Console.WriteLine ("Wollen Sie noch eine Aktion ausführen? (j/n) ");
						ant = Console.ReadLine ();
					} while(ant.ToLower ().StartsWith ("j"));
				} else if (temp == 2) {
					fp.getList ().Add (new PKW (1, "FEWEW4", 5000, 4));
					fp.getList ().Add (new LKW (2, "3543A", 52300, 50));
					fp.getList ().Add (new Anhaenger (3, "325322", 5, 1));
					fp.getList ().Add (new Bus (4, "52AA4G", 53453, 30));

					do{
						Console.Clear();
						switch (mc.showMenu ()) {
						case 1:
							switch (mc.showCreationMenu ()) {
							case 1:
								fp.addFahrzeug (1);
								break;
							case 2:
								fp.addFahrzeug (2);
								break;
							case 3:
								fp.addFahrzeug (3);
								break;
							case 4:
								fp.addFahrzeug (4);
								break;
							}
							break;
						case 2:
							fp.addKmToFahrzeug ();
							break;
						case 3:
							fp.deleteFahrzeug ();
							break;
						case 4:
							fp.printFahrzeug ();
							break;
						case 5:
							fp.printAll ();
							break;
						}

						Console.WriteLine ("Wollen Sie noch eine Aktion ausführen? (j/n) ");
						ant = Console.ReadLine ();
					}while(ant.ToLower().StartsWith("j"));
				}




				

				Console.WriteLine ("Wollen Sie das Programm neu starten? (j/n) ");
				ant = Console.ReadLine ();
			} while(ant.ToLower ().StartsWith ("j"));
		}
	}
}
