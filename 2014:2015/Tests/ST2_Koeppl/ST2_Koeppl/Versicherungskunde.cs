using System;

namespace ST2_Koeppl
{
	public class Versicherungskunde:Kunde
	{
		public string polizzennummer{get;private set;}
		public double praemienaufkommen{get;set;}
		public double versicherungsaufwand{get;set;}

		public Versicherungskunde (string vname, string nname, string pn, double pa, double va):base(vname, nname)
		{
			polizzennummer = pn;
			praemienaufkommen = pa;
			versicherungsaufwand = va;
		}

		public override string ToString ()
		{
			if (((versicherungsaufwand / praemienaufkommen)*100) > 150) {
				OnGueteGradUnterschritten (new EventArgs ());
			}
			return string.Format (base.ToString() + "\n[[Versicherungskunde: polizzennummer={0}, praemienaufkommen={1}, versicherungsaufwand={2}]", polizzennummer, praemienaufkommen, versicherungsaufwand);
		}

		/* EVENT ZONE */
		public static void GueteGradUnterschritten(/*object sender, EventArgs e*/)
		{
			Console.WriteLine ("WARNUNG: VERSICHERUNGSAUFWAND/PRÄMIENAUFKOMMEN*100 > 150");
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

