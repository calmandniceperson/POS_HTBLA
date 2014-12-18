using System;

namespace ST2_Koeppl
{
	public class Kunde
	{
		public string vorname{get;set;}
		public string nachname{get;set;}

		public Kunde (string vname, string nname)
		{
			vorname = vname;
			nachname = nname;
		}

		public override string ToString ()
		{
			return string.Format ("[Kunde: vorname={0}, nachname={1}]", vorname, nachname);
		}
	}
}

