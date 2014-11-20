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
			bool repeat = false;
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
					do{
						try{
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
							repeat = false;
						}catch(Exception){
							repeat = true;
						}
					}while(repeat == true);
					break;
				case 3:
					do{
						try{
							Console.Write("Geben Sie die ID des Objekts ein, das Sie löschen wollen: ");
							v.deleteObject(int.Parse(Console.ReadLine()));
							repeat = false;
						}catch(Exception){
							repeat = true;
						}
					}while(repeat == true);
					break;
				case 4:
					do{
						try{
							Console.Write("Geben Sie die ID des Objekts ein, das Sie bearbeiten wollen: ");
							tempint = int.Parse(Console.ReadLine());
							v.printObject(tempint);
							repeat = false;
						}catch(Exception){
							repeat = true;
						}
					}while(repeat == true);
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
