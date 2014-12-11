using System;

namespace CSObst
{
	public class Obstprodukt:Produkt
	{
		public Obstprodukt (string id_hsl, string bez, int ppe, string ty /*typ*/, string einh, int eig):base(id_hsl, bez, ppe)
		{
			switch (ty.ToLower()) {
			case "konzentrat":
				t = typ.konzentrat;
				break;
			case "saft":
				t = typ.saft;
				break;
			case "gelee":
				t = typ.gelee;
				break;
			default:
				t = typ.saft;
				break;
			}

			switch (einh.ToLower()) {
			case "flasche":
				e = einheit.flasche;
				break;
			case "packung":
				e = einheit.packung;
				break;
			case "tetrapack":
				e = einheit.tetrapack;
				break;
			case "dose":
				e = einheit.dose;
				break;
			default:
				e = einheit.flasche;
				break;
			}

			if (eig == 0) {
				eigenerzeugnis = false;
			} else if (eig == 1) {
				eigenerzeugnis = true;
			}
		}

		enum typ{
			konzentrat = 1,
			saft = 2,
			gelee = 3
		}

		readonly typ t;

		enum einheit{
			flasche = 1,
			packung = 2,
			tetrapack = 3,
			dose = 4
		}

		readonly einheit e;

		bool eigenerzeugnis{get;set;}

		public override string ToString ()
		{
			return (base.ToString () + "Typ: " + t.ToString() + " Einheit: " + e.ToString () + " Eigenerzeugnis: " + eigenerzeugnis.ToString());
		}
	}
}

