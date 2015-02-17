using System;

namespace CSLotto
{
	public class Tipp
	{
		int[] zahlen = new int[6];

		public Tipp (int[] arr)
		{
			zahlen = arr;

			// events
			drei_richtig += dreiRichtigHandler;
			vier_richtig += vierRichtigHandler;
			fuenf_richtig += fuenfRichtigHandler;
			sechs_richtig_hallelujah += sechsRichtigHandler;
		}

		public override string ToString ()
		{
			int anz_corr_nums = 0; // anzahl der korrekten zahlen

			string output_tipp = string.Empty;
			foreach(int z in zahlen){
				output_tipp += (z.ToString () + " ");
				foreach(int num in MainClass.corr_nums){
					if(z == num){
						anz_corr_nums++;
					}
				}
			}

			switch(anz_corr_nums){
			case 3:
				if(drei_richtig != null){
					drei_richtig ();
				}
				break;
			case 4:
				if(vier_richtig != null){
					vier_richtig ();
				}
				break;
			case 5:
				if(fuenf_richtig != null){
					fuenf_richtig ();
				}
				break;
			case 6:
				if(sechs_richtig_hallelujah != null){
					sechs_richtig_hallelujah ();
				}
				break;
			default:
				Console.WriteLine ("Leider keine oder nicht genuegend richtige Zahlen.");
				break;
			}
			return output_tipp;
		}

		// EVENT ZONE
		// die 4 events sind beabsichtigt, da wir sonst nur 1 - 2 verwenden
		// so kommen mehr zum einsatz
		delegate void RichtigerTipp();

		event RichtigerTipp drei_richtig;
		event RichtigerTipp vier_richtig;
		event RichtigerTipp fuenf_richtig;
		event RichtigerTipp sechs_richtig_hallelujah;

		void dreiRichtigHandler(){
			Console.WriteLine ("3 RICHTIGE ZAHLEN!");
		}

		void vierRichtigHandler(){
			Console.WriteLine ("4 RICHTIGE ZAHLEN!");
		}

		void fuenfRichtigHandler(){
			Console.WriteLine ("5 RICHTIGE ZAHLEN!");
		}

		void sechsRichtigHandler(){
			Console.WriteLine ("6 RICHTIGE ZAHLEN!");
		} 
	}
}

