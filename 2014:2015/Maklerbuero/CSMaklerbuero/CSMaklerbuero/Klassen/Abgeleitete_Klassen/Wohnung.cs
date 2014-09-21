/*
	MICHAEL KÖPPL 3AHIF
	2014/2015
	CSMaklerbuero

	Wohnung (erbt von Objekt)
*/

using System;

namespace CSMaklerbuero
{
    public class Wohnung : Objekt
    {
        int anz_zimmer; /*Anzahl Zimmer*/
        bool bad_dusche; /*gibt an, ob eine badewanne (true) oder eine dusche (false) verbaut ist*/

        public Wohnung(
            int objnr /*Nummer des Objekts*/,
            string m /*Name des Maklers*/,
            bool tkm /*kaufen(true) oder mieten(false)*/,
            double k /*Preis/Kosten*/,
            double f /*Flaeche*/,
            int anzz /*Anzahl der Zimmer*/,
            bool bd /*Badewanne(true) oder Dusche(false)*/)
            : base(objnr, m, tkm, k, f)
        {
            anz_zimmer = anzz;
            bad_dusche = bd;
        }

        /*GET*/
        public int getAnzZimmer()
        {
            return anz_zimmer;
        }

        public bool getBD()
        {
            return bad_dusche;
        }
        /*GET*/

        /*SET*/
        public void setBD(bool v)
        {
            bad_dusche = v;
        }

        public void setAnzZimmer(int v)
        {
            anz_zimmer = v;
        }
        /*SET*/
    }
}

