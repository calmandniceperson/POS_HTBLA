/*
 * Michael Köppl 3AHIF
 * Telefonkosten (C# Windows Forms)
 * 2014/2015
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSTelefonkostenForms
{
    class EventClass
    {
        public delegate void GespraechHandler();

		public event GespraechHandler GespraechsBeginn;
		public event GespraechHandler GespraechImGang;
		public event GespraechHandler GespraechsEnde;

		public virtual void onAbheben(EventArgs e){
			if (GespraechsBeginn != null) {
				GespraechsBeginn ();
			}
		}

		public virtual void onImGang(EventArgs e){
			if (GespraechImGang != null) {
				GespraechImGang ();
			}
		}

		public virtual void onAuflegen(EventArgs e){
			if (GespraechsEnde != null) {
				GespraechsEnde ();
			}
		}
    }
}
