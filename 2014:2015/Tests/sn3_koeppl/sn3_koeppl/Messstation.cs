// /*
//  *	MICHAEL KOEPPL 3AHIF
//  * 	2014/2015
//  */
using System;
using System.Text;

namespace sn3_koeppl
{
	public delegate void GrenzwertUeberschritten(object sender, GrenzwertUeberschrittenEventArgs e);

	public class Messstation:IMessung
	{
		public event GrenzwertUeberschritten G1UE;
		public event GrenzwertUeberschritten G2UE;
		public void OnG1Ueberschritten(int sid, int m, int g2){
			if(G1UE != null){
				G1UE (this, new GrenzwertUeberschrittenEventArgs (sid, m, 0, g2));
			}
		}

		public void OnG2Ueberschritten (int sid, int m, int g1){
			if(G2UE != null){
				G2UE (this, new GrenzwertUeberschrittenEventArgs (sid, m, g1));
			}
		}

		int count_g1_ueberschritten = 0;
		int count_g2_ueberschritten = 0;
		int count_messungen = 0;
		int count_g1 = 0;

		public int StationsID{ get; private set; }
		public int Grenzwert1{ get; set; }
		public int Grenzwert2{ get; set; }

		public Messstation (int sid)
		{
			StationsID = sid;
		}

		public override string ToString ()
		{
			StringBuilder sb = new StringBuilder ();
			sb.Append ("Messstation " + StationsID + "\n");
			sb.Append ("Grenzwert 1: " + Grenzwert1 + "\n");
			sb.Append ("Grenzwert 2: " + Grenzwert2 + "\n");
			sb.Append ("Anzahl der Messungen: " + count_messungen + "\n");
			sb.Append ("Anzahl der Ueberschreitungen G1: " + count_g1_ueberschritten + "\n");
			sb.Append ("Anzahl der Ueberschreitungen G2: " + count_g2_ueberschritten + "\n");

			return sb.ToString ();
		}
			
		public void setMessung(int val){
			MessungGueltig (val);
			count_messungen++;
		}

		public void MessungGueltig(int val){
			if(val > Grenzwert2){
				OnG1Ueberschritten (StationsID, val, Grenzwert2);
				count_g2_ueberschritten++;
			}

			if(val > Grenzwert1){
				count_g1_ueberschritten++;
				if(count_g1 <= 1){
					count_g1++;
				}else{
					OnG2Ueberschritten (StationsID, val, Grenzwert1);
					count_g1 = 0;
				}
			}else{
				if (count_g1 <= 1) {
					count_g1 = 0;
				}
			}
		}

		public void setGrenzwerte(int g1, int g2){
			Grenzwert1 = g1;
			Grenzwert2 = g2;
		}
	}
}

