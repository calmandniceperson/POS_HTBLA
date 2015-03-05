// /*
//  *	MICHAEL KOEPPL 3AHIF
//  * 	2014/2015
//  */
using System;

namespace sn3_koeppl
{
	public class GrenzwertUeberschrittenEventArgs:EventArgs
	{
		public int StationsID{ get; set; }
		public int Messwert{ get; set; }
		public int Grenzwert1{ get; set; }
		public int Grenzwert2{ get; set; }

		public GrenzwertUeberschrittenEventArgs (int sid, int m, int g1 = 0, int g2 = 0)
		{
			StationsID = sid;
			Messwert = m;
			if(g1 != 0){
				Grenzwert1 = g1;
			}
			Grenzwert2 = g2;
		}
	}
}

