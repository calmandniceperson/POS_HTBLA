using System;
using System.Collections.Generic;

namespace CSMaklerbuero
{
	public class ObjektComparer:IComparer<Objekt>
	{
		//vergleicht die Namen der Objekttypen zweier Objekte (Haus, Wohnung, Grundstueck) miteinander
		//um sie zu ordnen
		//wird in objListe.Sort (new ObjektComparer ()); verwendet, um die Liste nach den Namen zu sortieren
		public int Compare(Objekt a, Objekt b){
			return a.GetType ().Name.CompareTo (b.GetType ().Name);
		}
	}
}

