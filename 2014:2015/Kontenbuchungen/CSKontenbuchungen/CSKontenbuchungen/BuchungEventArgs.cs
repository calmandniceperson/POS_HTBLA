// /*
//  *	MICHAEL KOEPPL 3AHIF
//  * 	2014/2015
//  */
using System;

namespace CSKontenbuchungen
{
	public class BuchungEventArgs:EventArgs
	{
		public string KNr;
		public double betrag;

		public BuchungEventArgs (string k, double b)
		{
			KNr = k;
			betrag = b;
		}
	}
}

