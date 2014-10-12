/*
 * Michael Koeppl 3AHIF
 * Grafikbibliothek
 * 2014/2015 
*/

using System;

namespace Grafikbibliothek
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			MenuClass mc = new MenuClass ();
			Verwaltung v = new Verwaltung ();
			string ant = string.Empty;
			int tempint;

			do {
				switch(mc.showMenu()){
				case 1:
					switch(mc.showCreationMenu()){
					case 1:
						v.newObjekt(1);
						break;
					case 2:
						v.newObjekt(2);
						break;
					case 3:
						v.newObjekt(3);
						break;
					case 4:
						v.newObjekt(4);
						break;
					}
					break;
				case 2:
					Console.Write("Geben Sie die ID des Objekts ein, das Sie bearbeiten wollen: ");
					tempint = int.Parse(Console.ReadLine());
					switch(mc.showEditMenu()){
					case 1:
						v.editObject(1, tempint, mc);
						break;
					case 2:
						v.editObject(2, tempint);
						break;
					}
					break;
				case 3:
					Console.Write("Geben Sie die ID des Objekts ein, das Sie löschen wollen: ");
					v.deleteObject(int.Parse(Console.ReadLine()));
					break;
				case 4:
					Console.Write("Geben Sie die ID des Objekts ein, das Sie bearbeiten wollen: ");
					tempint = int.Parse(Console.ReadLine());
					v.printObject(tempint);
					break;
				case 5:
					v.printAll();
					break;
				}
				Console.Write("Wollen Sie noch eine Aktion ausführen? (j/n) ");
				ant = Console.ReadLine();
			} while(ant.ToLower ().StartsWith ("j"));
		}
	}
}
