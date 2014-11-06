/*
 * Michael Köppl 3AHIF
 * Telefonkosten (C# Windows Forms)
 * 2014/2015
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace CSTelefonkostenForms
{
    class Gespraech
    {
		EventClass events = new EventClass ();
        Form1 f { get; set; }
        public Timer gespraechsTimer { get; set; }
        public int interval { get; set; }
        public double kosten { get; set; }
        public double gesamtkosten { get; set; }

        

        public Gespraech(int i, double k, Form1 fval)
        {
            f = fval;
            interval = i;
            kosten = k;
			events.GespraechsBeginn += gespraech_beginn;
			events.GespraechImGang += gespraech_laeuft;
			events.GespraechsEnde += gespraech_ende;
        }

        public void abheben()
        {
			events.onAbheben (new EventArgs());
        }

        public void auflegen()
        {
			events.onAuflegen (new EventArgs ());
        }

        public void gespraechstimer_Tick(object sender, EventArgs e)
        {
			events.onImGang (new EventArgs ());
        }

        public void gespraech_beginn()
        {
            gespraechsTimer = new Timer();
            gespraechsTimer.Elapsed += new ElapsedEventHandler(gespraechstimer_Tick);
            gespraechsTimer.Interval = interval;
            gespraechsTimer.Start();
        }

        public void gespraech_laeuft()
        {
            gesamtkosten += kosten;
            //f.printKosten(gesamtkosten.ToString()); 
        }

        public void gespraech_ende()
        {
            gespraechsTimer.Stop();
        }
    }
}
