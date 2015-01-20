using System;
using System.Collections.Generic;

namespace SE2_KOEPPL
{
	public class Verwaltung
	{
		public Verwaltung ()
		{
		}

		public static List<Lager> liste = new List<Lager>();

		public static void addNewLagerBestand(Lager bestand){
			liste.Add (bestand);
		}
	}
}

