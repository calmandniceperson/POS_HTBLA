/*
	MICHAEL KÖPPL 3AHIF
	2014/2015
	CSMaklerbuero

	Objekt (Basisklasse)
*/

using System;

namespace CSMaklerbuero
{
    public class Objekt
    {
        int objNr; /*ID-Nummer des Objekts (Grund oder Gebaeude)*/
        string makler; /*Name des zustaendigen Maklers*/
        bool typus_kaufus_mietus; /*gibt an, ob das Objekt zu Kaufen oder zu Mieten ist (kaufen=true   mieten=false*/
        double kosten; /*Preis des Gebaeudes*/
        double flaeche; /*selbsterklaerend*/

        public Objekt(
            int objnr /*Nummer des Objekts*/,
            string m /*Name des Maklers*/,
            bool tkm /*kaufen(true) oder mieten(false)*/,
            double k /*Preis/Kosten*/,
            double f /*Flaeche*/)
        {
            objNr = objnr;
            makler = m;
            typus_kaufus_mietus = tkm;
            kosten = k;
            flaeche = f;
        }

		#region PROVISION
		public virtual double getProvision(){
			return getKosten ();
		}
		#endregion

        #region GET
        public int getObjNr()
        {
            return objNr;
        }

        public string getMakler()
        {
            return makler;
        }

        public bool getTKM()
        {
            return typus_kaufus_mietus;
        }

        public double getKosten()
        {
            return kosten;
        }

        public double getFlaeche()
        {
            return flaeche;
        }
        #endregion
        #region SET
        public void setObjNr(int v)
        {
            objNr = v;
        }

        public void setMakler(string v)
        {
            makler = v;
        }

        public void setTKM(bool v)
        {
            typus_kaufus_mietus = v;
        }

        public void setKosten(double v)
        {
            kosten = v;
        }

        public void setFlaeche(double v)
        {
            flaeche = v;
        }
        #endregion
    }
}

