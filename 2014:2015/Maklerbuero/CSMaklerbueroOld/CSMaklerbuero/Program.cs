/*
	MICHAEL KÖPPL 3AHIF
	2014/2015
	CSMaklerbuero

	MAIN CLASS
*/

using System;

namespace CSMaklerbuero
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string ant;
			MenuClass mc = new MenuClass ();
			Verwaltung v = new Verwaltung ();
			do {
				Console.Clear();
				switch (mc.showMenu ()) {
				case 1:
					v.newObjekt ();
					break;
				case 2:
					Console.Write("Welches Objekt wollen Sie löschen? (Geben Sie die Objektnummer ein)");
					v.deleteObjekt(int.Parse(Console.ReadLine()));
					break;
				case 3:
					Console.Write("Welches Objekt wollen Sie bearbeiten (Geben Sie die Objektnummer ein)? ");
					v.editObjekt(int.Parse(Console.ReadLine()));
					break;
				case 4:
					v.printAll();
					break;
				case 5:
					do{
						switch(mc.showSpecificSelectionMenu()){
						case 1:
							Console.WriteLine("Welches Objekt (Nr.) wollen Sie bearbeiten? ");
							int temp = int.Parse(Console.ReadLine());
							v.printSelection(1, temp);
							break;
						case 2: /*alle ausgeben, die zu kaufen sind*/
							v.printSelection(2);
							break;
						case 3: /*alle ausgeben, die zu mieten sind*/
							v.printSelection(3);
							break;
						case 4: /*alle Häuser ausgeben*/
							v.printSelection(4);
							break;
						case 5: /*alle Wohnungen ausgeben*/
							v.printSelection(5);
							break;
						case 6: /*alle Grundstuecke ausgeben*/
							v.printSelection(6);
							break;
						}
					Console.WriteLine("Wollen Sie noch etwas spezifisches Ausgeben (J)");
					Console.Write("oder wollen Sie in das Hauptmenü zurückkehren (N)? ");
					}while(Console.ReadLine().ToLower().StartsWith("j"));
					break;
				case 6:
					mc.showBTDMenu();
					break;
				}
				Console.WriteLine ();
				Console.WriteLine ("Wollen Sie noch eine Aktion ausführen? (J/N) ");
				ant = Console.ReadLine ();
			} while(ant.ToLower ().StartsWith ("j"));
		}
	}
}
