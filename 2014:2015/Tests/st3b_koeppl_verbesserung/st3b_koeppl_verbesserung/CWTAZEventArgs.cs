using System;

namespace st3b_koeppl_verbesserung
{
	public class CWTAZEventArgs:EventArgs // wochentagesarbeitszeit event args
	{
		public bool W_T{ get; set; } // wochenzeit oder arbeitszeit schalter
		public string Name{ get; set; } // wer hat es uebertragen
		public double StdAnz{ get; set; } // stundenanzahl, um zu wissen, wie viel ueberschritten wurde

		public CWTAZEventArgs(string n /*name*/, double z /*zeit*/, bool wt){
			Name = n;
			StdAnz = z;
			W_T = wt;
		}
	}
}

