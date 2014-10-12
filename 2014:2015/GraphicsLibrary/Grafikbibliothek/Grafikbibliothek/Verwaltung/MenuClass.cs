using System;

namespace Grafikbibliothek
{
	public class MenuClass
	{
		public MenuClass ()
		{
		}

		public int showMenu(){
			Console.Clear ();
			Console.WriteLine ("\tGraphikbibliothek\t");
			Console.WriteLine ("0 ... Ende");
			Console.WriteLine ("1 ... Neues Objekt anlegen");
			Console.WriteLine ("2 ... Vorhandenes Objekt bearbeiten");
			Console.WriteLine ("3 ... Vorhandenes Objekt löschen");
			Console.WriteLine ("4 ... Bestimmtes Objekt ausgeben");
			Console.WriteLine ("5 ... Alle ausgeben");

			return int.Parse (Console.ReadLine ());
		}

		public int showCreationMenu(){
			Console.Clear ();
			Console.WriteLine ("\tWas möchten Sie erstellen?\t");
			Console.WriteLine ("1 ... Linie");
			Console.WriteLine ("2 ... Rechteck");
			Console.WriteLine ("3 ... Kreis");
			Console.WriteLine ("4 ... Quadrat");

			return int.Parse (Console.ReadLine ());
		}

		public int showEditMenu(){
			Console.Clear ();
			Console.WriteLine ("\tWas möchten Sie editieren?\t");
			Console.WriteLine ("1 ... Form ändern");
			Console.WriteLine ("2 ... Koordinaten verändern (bewegen)");

			return int.Parse (Console.ReadLine ());
		}

		public int showMorphMenu(){
			Console.Clear ();
			Console.WriteLine ("\tWas möchten Sie aus dem Objekt machen?\t");
			Console.WriteLine ("1 ... Linie");
			Console.WriteLine ("2 ... Rechteck");
			Console.WriteLine ("3 ... Kreis");
			Console.WriteLine ("4 ... Quadrat");

			return int.Parse (Console.ReadLine ());
		}
	}
}

