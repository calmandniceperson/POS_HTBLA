using System;

namespace ST2_Koeppl
{
	public class Bankkunde:Kunde
	{
		public string kontonummer{get;private set;}
		public double kontostand{get;set;}
		public double kreditrahmen{get;set;}
		public int pin{get;set;}

		public Bankkunde (string vname, string nname, string knum, int p, double ks, double kr):base(vname, nname)
		{
			kontonummer = knum;
			pin = p;
			kontostand = ks;
			kreditrahmen = kr;

			unterschritten += GueteGradUnterschritten;
		}

		public override string ToString ()
		{
			if (((kontostand / kreditrahmen)*100) < 10) {
				OnGueteGradUnterschritten (new EventArgs ());
			}
			return string.Format (base.ToString() + "\n[Bankkunde: kontonummer={0}, kontostand={1}, kreditrahmen={2}, pin={3}]", kontonummer, kontostand, kreditrahmen, pin);
		}

		/* EVENT ZONE */
		public static void GueteGradUnterschritten(/*object sender, EventArgs e*/)
		{
			Console.WriteLine ("WARNUNG: KONTOSTAND/KREDITRAHMEN*100 < 10");
		}

		public delegate void GueteGradUnterschrittenHandler();

		public event GueteGradUnterschrittenHandler unterschritten;
		//AbgelaufenHandler noch_gut;

		public virtual void OnGueteGradUnterschritten(EventArgs e){
			if (unterschritten != null) {
				unterschritten ();
			}
		}
		/* EVENT ZONE */
	}
}

