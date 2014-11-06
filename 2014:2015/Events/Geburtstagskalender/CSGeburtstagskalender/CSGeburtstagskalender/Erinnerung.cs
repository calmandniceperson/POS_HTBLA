using System;

namespace CSGeburtstagskalender
{
	public class Erinnerung
	{
		public DateTime datum{ get; set; }
		public string name_geburtstagskind{ get; set; }
		public DateTime erinnerung{ get; set; }
		public int anz_erinnerungen{ get; set; }

		public Erinnerung (DateTime d, string n, int anz_t_z, int anz_e)
		{
			datum = d;
			name_geburtstagskind = n;
			erinnerung = datum.AddDays (Convert.ToInt32 ("-" + anz_t_z));
			anz_erinnerungen = anz_e;
		}

		public Erinnerung(){

		}
			
		public void checkDatum(DateTime now, Handler h){
			if (now >= datum) {
				h.onGeburtstag (new EventArgs(), this);
			} else {
				h.onKeinGeburtstag (new EventArgs(), this);
			}
		}
	}
}

