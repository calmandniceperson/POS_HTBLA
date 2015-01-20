using System;
using System.IO;

namespace SE2_KOEPPL
{
	public class Lager
	{
		public string artikel_bez{ get; private set; }
		public int bestand_minimum{ get; private set; }
		public int bestand_aktuell{ get; private set; }

		public Lager (string ab, int bm, int ba)
		{
			artikel_bez = ab;
			bestand_minimum = bm;
			bestand_aktuell = ba;

			Unterschritten += UnterschrittenHandler;

			if (bestand_aktuell < bestand_minimum) {
				OnUnterschritten (new EventArgs ());
			}
		}

		public delegate void UnterschrittenEventHandler (/*object sender, EventArgs e*/);

		/*EVENTS*/
		private void UnterschrittenHandler(/*object sender, EventArgs e*/)
		{
			Console.WriteLine ("LAGERBESTAND UNTER MINDESTLAGERBESTAND!");
			Console.WriteLine ("Name: " + artikel_bez + "\tMindestbestand: " + bestand_minimum + "\tAktueller Bestand: " + bestand_aktuell);
			using (StreamWriter sr = new StreamWriter("Bestellungen.txt", true)){
				sr.Write ("BESTELLUNG\nName: " + artikel_bez + "\tMindestbestand: " + bestand_minimum + "\tAktueller Bestand: " + bestand_aktuell + "\n\r");
			}
		}

		public virtual void OnUnterschritten(EventArgs e)
		{
			if (Unterschritten != null)
				Unterschritten(/*this, e*/);
		}

		public event UnterschrittenEventHandler Unterschritten;

		public override string ToString ()
		{
			return string.Format ("[Lager: artikel_bez={0}, bestand_minimum={1}, bestand_aktuell={2}]", artikel_bez, bestand_minimum, bestand_aktuell);
		}
	}
}

