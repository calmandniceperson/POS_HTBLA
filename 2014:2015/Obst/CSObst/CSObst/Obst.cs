using System;

namespace CSObst
{
	public class Obst:Produkt
	{
		public Obst (string id_hsl, string bez, double ppe, string typ, string eh, int verp_eh):base(id_hsl, bez, ppe)
		{
			obst_typ = typ;

			switch (eh) {
			case "kg":
				e = einheit.kg;
				break;
			case "stk":
				e = einheit.stk;
				break;
			default:
				e = einheit.stk;
				break;
			}

			verpackung_einheit = verp_eh;
		}



		// steinobst, kernobst,...
		readonly string obst_typ;

		// in welcher einheit das obst gezählt wird
		enum einheit{
			kg,
			stk
		}

		// objekt des enums erstellen
		einheit e{get;set;}

		// wie viele in einer packung enthalten sind
		int verpackung_einheit;

		public override string ToString ()
		{
			return (base.ToString () + "Typ: " + obst_typ + " Einheit: " + e.ToString () + " Stk. pro Verpackung: " + verpackung_einheit.ToString ());
		}
	}
}

