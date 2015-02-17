using System;
using System.Collections.Generic;

namespace CSLotto
{
	public class TippVerwaltung
	{
		List<Tipp> TippListe = new List<Tipp>();

		public TippVerwaltung ()
		{
		}

		public void add(Tipp t){
			TippListe.Add(t);
		}

		public List<Tipp> get(){
			return TippListe;
		}
	}
}

