using System;
using System.Collections.Generic;
using System.Linq;

namespace st3b_koeppl
{
	public class Verwaltung
	{
		List<Mitarbeiter> mitarbeiterListe = new List<Mitarbeiter>();

		public void add(Mitarbeiter m){
			mitarbeiterListe.Add (m);

		}

		public List<Mitarbeiter> getList(){
			return mitarbeiterListe;
		}
	}
}

