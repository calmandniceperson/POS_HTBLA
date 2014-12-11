using System;

namespace CSObst
{
	public class Gemuese:Produkt
	{
		public Gemuese (string id_hsl, string bez, int ppe, string ha /*handelsart*/, string ald):base(id_hsl, bez, ppe)
		{
			switch (ha.ToLower()) {
			case "frisch":
				h = handelsart.frisch;
				break;
			case "tiefgekuehlt":
				h = handelsart.tiefgekuehlt;
				break;
			case "zimmertemperatur":
				h = handelsart.zimmertemperatur;
				break;
			case "vakuumverpackt":
				h = handelsart.vakuumverpackt;
				break;
			case "eingelegt":
				h = handelsart.eingelegt;
				break;
			default:
				h = handelsart.tiefgekuehlt;
				break;
			}


			ablaufdatum = Convert.ToDateTime (ald);

			ueberschritten += UeberschrittenHandler;
		}
			
		// frisch, tiefgekuehlt, ...
		enum handelsart{
			frisch = 1,
			tiefgekuehlt = 2,
			zimmertemperatur = 3,
			vakuumverpackt = 4,
			eingelegt = 5
		}

		readonly handelsart h;

		static DateTime ablaufdatum;

		public DateTime getAblaufDatum(){
			return ablaufdatum;
		}


		/* EVENT ZONE */
		public static void UeberschrittenHandler(/*object sender, EventArgs e*/)
		{
			foreach(Gemuese g in Verwaltung.getProduktListe()) {
				if (g.getAblaufDatum() == ablaufdatum) {
					Verwaltung.getProduktListe ().Remove (g);
				}
			}
		}

		public delegate void AbgelaufenHandler();

		public AbgelaufenHandler ueberschritten;
		//AbgelaufenHandler noch_gut;

		public virtual void OnDatumUeberschritten(EventArgs e){
			if (ueberschritten != null) {
				ueberschritten ();
			}
		}
		/* EVENT ZONE */

		public override string ToString ()
		{
			return (base.ToString () + "Handelsart: " + h.ToString() + " Ablaufdatum: " + ablaufdatum.ToString());
		}
	}
}

