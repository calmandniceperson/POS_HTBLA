using System;
using System.Collections.Generic;
using System.Linq;

namespace st3b_koeppl
{
	public class Mitarbeiter:IMitarbeiter
	{
		List<Zeiten> zeitL;

		public string name{ get; private set; }

		public Mitarbeiter (string n, double sz_s, double ez_s)
		{
			zeitL = new List<Zeiten> ();
			tageskernzeit_unterschritten += tgkz_u;
			wochenkernzeit_unterschritten += wkz_u;

			name = n;
			zeitL.Add (new Zeiten(sz_s, ez_s));
		}

		public void addSzEz(double sz, double ez){
			zeitL.Add (new Zeiten (sz, ez));
		}

		public void pruefe_tageskernzeit(List<Zeiten> zeit){
			foreach(Zeiten z in zeit){
				if((z.ez - z.sz) < 6){
					if(tageskernzeit_unterschritten != null){
						tageskernzeit_unterschritten();
					}
				}
			}
		}

		public void pruefe_wochenkernzeit(List<Zeiten> zeit){
			double wochenzeit = 0;

			foreach(Zeiten z in zeit){
				wochenzeit += (z.ez - z.sz);
			}

			if(wochenzeit < 24){
				if(wochenkernzeit_unterschritten != null){
					wochenkernzeit_unterschritten();
				}
			}
		}

		delegate void kernzeit();

		event kernzeit tageskernzeit_unterschritten;
		event kernzeit wochenkernzeit_unterschritten;

		void tgkz_u(){ // tageskernzeit unterschritten
			Console.WriteLine ("ZU WENIG TAGESKERNZEIT!");
		}

		void wkz_u(){ // wochenkernzeit unterschritten
			Console.WriteLine ("ZU WENIG WOCHENKERNZEIT");
		}

		public override string ToString ()
		{
			Console.WriteLine ();
			pruefe_tageskernzeit (zeitL);
			pruefe_wochenkernzeit (zeitL);
			string t= "";
			foreach(Zeiten z in zeitL){
				t += "\n" + z.sz + " " + z.ez;
			}
			return ("Name: " + name + " " + t);
		}
	}
}

