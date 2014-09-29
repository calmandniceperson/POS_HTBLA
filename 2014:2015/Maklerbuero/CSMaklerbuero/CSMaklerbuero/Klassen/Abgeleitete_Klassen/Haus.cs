/*
	MICHAEL KÖPPL 3AHIF
	2014/2015
	CSMaklerbuero

	Haus (erbt von Objekt)
*/

using System;

namespace CSMaklerbuero
{
    public class Haus : Objekt
    {
        bool mehrf_haus;
        int anz_etagen;
        bool keller;

        public Haus(
            int objnr /*Nummer des Objekts*/,
            string m /*Name des Maklers*/,
            bool tkm /*kaufen(true) oder mieten(false)*/,
            double k /*Preis/Kosten*/,
            double f /*Flaeche*/,
            bool mfh /*Mehrfamilienhaus true/false*/,
            int anzeta /*Anzahl d. Etagen*/,
            bool c /*cellar*/)
            : base(objnr, m, tkm, k, f)
        {
            mehrf_haus = mfh;
            anz_etagen = anzeta;
            keller = c;
        }

		#region PROVISION
		public override double getProvision(){
			if (getTKM ()) {
				return (getKosten () / 100) * 3;
			} else if (!getTKM ()) {
				return getKosten () * 5;
			}
			return 0;
		}
		#endregion

        #region GET
        public bool getMehrFHaus()
        {
            return mehrf_haus;
        }

        public int getAnzEtagen()
        {
            return anz_etagen;
        }

        public bool getKeller()
        {
            return keller;
        }
        #endregion
        #region SET
        public void setMehrFHaus(bool v)
        {
            mehrf_haus = v;
        }

        public void setAnzEtagen(int v)
        {
            anz_etagen = v;
        }

        public void setKeller(bool v)
        {
            keller = v;
        }
        #endregion
    }
}

