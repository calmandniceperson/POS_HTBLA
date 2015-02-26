using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;

namespace st3b_koeppl_verbesserung
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			StreamReader sr = new StreamReader ("ZJournal.txt", Encoding.UTF7 /*weil die Datei noch im alten UTF ist*/);

			CFirma Firma = new CFirma ();
			string[] zs;

			while(!sr.EndOfStream){ // solange das ende der Datei nicht erreicht ist
				zs = sr.ReadLine ().Split (' '); // gesplittete Zeile zum Array hinzufuegen
				Firma.AddMitarbeiter (zs [0] /*name*/, double.Parse (zs [2].Replace(',', '.')) - double.Parse (zs [1].Replace(',', '.')) /*Arbeitszeit des Tages in der Zeile*/);
			}

			sr.Close ();

			Firma.TestWAZ (); // durchlaeuft die liste und schaut, ob es wochenzeitueberschreitungen gibt
			Console.WriteLine(Firma.ToString ()); // mitarbeiter und summe der tages- und wochenueberschreitungen ausgeben

			Console.ReadKey ();
		}
	}
}
