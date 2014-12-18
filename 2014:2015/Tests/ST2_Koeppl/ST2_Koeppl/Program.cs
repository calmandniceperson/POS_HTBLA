// TEST
// Versicherungsmakler
// 18.12.2014
// MICHAEL KOEPPL

using System;
using System.Threading;

namespace ST2_Koeppl
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string ant;
			Verwaltung v = new Verwaltung ();
			Menu m = new Menu ();

			v.addKunde (new Bankkunde ("Herbert", "Loose", "K001", 2054, 1, 2000));
			v.addKunde(new Versicherungskunde("Hansi", "Hinterseer", "P002", 2500.50, 1500.20));
			do{
				v.printSelObject ("K001", true);

				switch(m.showMenu()){
				case 1:
					v.printSelObject(string.Empty, true);
					break;
				case 2:
					v.printSelObject(m.showSpecAccMenu());
					break;
				case 3:
					m.changeDataMenu(v);
					break;
				default:
					Console.WriteLine ("Falsche Eingabe. Sie werden gleich weitergeleitet.");
					Thread.Sleep(2000);
					//continue;
					break;
				}

				Console.Write("Wollen Sie noch eine Aktion durchführen? (J/N) ");
				ant = Console.ReadLine();

			}while(ant.ToLower().StartsWith("j"));
		}
	}
}
