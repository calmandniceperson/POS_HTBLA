using System;

namespace CSObst
{
	public class Produkt
	{
		public Produkt (string id_hsl, string bez, double ppe)
		{
			id_herstellungsland = id_hsl;
			bezeichnung = bez;
			preis_pro_einheit = ppe;
		}

		string id_herstellungsland{get;set;}
		string bezeichnung{get;set;}
		double preis_pro_einheit{get;set;}

		public override string ToString ()
		{
			return ("ID_Herstellungsland:" + id_herstellungsland + " " + "Bezeichnung:" + bezeichnung + " " + "Preis: " + preis_pro_einheit.ToString() + "€" + " ");
		}
	}
}

