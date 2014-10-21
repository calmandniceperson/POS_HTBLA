using System;

namespace CS1_KOEPPL
{
	public class MenuClass
	{
		public MenuClass ()
		{
		}

		public int showMenu(){
			Console.Clear ();
			Console.WriteLine ("\tFuhrpark\t");
			Console.WriteLine ("1 ... Neues Fahrzeug anlegen");
			Console.WriteLine ("2 ... Fahrzeug bewegen (km hinzufügen)");
			Console.WriteLine ("3 ... Vorhandenes Fahrzeug löschen");
			Console.WriteLine ("4 ... Bestimmtes Fahrzeug ausgeben");
			Console.WriteLine ("5 ... Alle ausgeben");

			return int.Parse (Console.ReadLine ());
		}

		public int showCreationMenu(){
			Console.Clear ();
			Console.WriteLine ("\tWas möchten Sie erstellen?\t");
			Console.WriteLine ("1 ... PKW");
			Console.WriteLine ("2 ... Bus");
			Console.WriteLine ("3 ... LKW");
			Console.WriteLine ("4 ... Anhänger");

			return int.Parse (Console.ReadLine ());
		}
	}
}

