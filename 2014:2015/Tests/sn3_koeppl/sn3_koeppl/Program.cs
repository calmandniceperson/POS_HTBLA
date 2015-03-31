// /*
//  *	MICHAEL KOEPPL 3AHIF
//  * 	2014/2015
//  */
using System;
using System.IO;

namespace sn3_koeppl
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			StreamReader Reader = new StreamReader ("../../../Messwerte.txt");
			Verwaltung v = new Verwaltung ();

			while(!Reader.EndOfStream){
				string txt = Reader.ReadLine ();

				string[] txtarr = txt.Split (';');

				if (txtarr.Length == 3) {
					v.addWert (int.Parse (txtarr [0]), int.Parse (txtarr [1]), int.Parse (txtarr [2]));
				} else if (txtarr.Length == 2) {
					v.addWert (int.Parse (txtarr [0]), int.Parse (txtarr [1]));
				}

			}
			Reader.Close ();
		
			v.printAll ();
			
			Console.ReadLine ();
		}
	}
}
