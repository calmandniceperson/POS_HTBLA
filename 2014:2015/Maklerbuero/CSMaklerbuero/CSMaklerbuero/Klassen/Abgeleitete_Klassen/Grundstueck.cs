using System;

namespace CSMaklerbuero
{
    public class Grundstueck : Objekt
    {
        public enum widmung
        {
            Baugrund, /*1*/
            Geschaeftsflaeche /*2*/
            /*etc*/
        };

        widmung widm; /*Widmung*/
        double einheitswert; /*Faktor, mit dem die Steuer berechnet wird*/

        public Grundstueck(
            int objnr /*Nummer des Objekts*/,
            string m /*Name des Maklers*/,
            bool tkm /*kaufen(true) oder mieten(false)*/,
            double k /*Preis/Kosten*/,
            double f /*Flaeche*/,
            string w, /*widmung*/
            double e /*Einheitswert*/)
            : base(objnr, m, tkm, k, f)
        {
            /*switch um den mitgegebenen Integer-wert in einen enum Wert umzuwandeln*/
            switch (w)
            {
                case "1":
                    widm = widmung.Baugrund;
                    break;
                case "2":
                    widm = widmung.Geschaeftsflaeche;
                    break;
                default:
                    widm = widmung.Baugrund;
                    break;
            }

            einheitswert = e;
        }

        /*GET*/
        public string getWidmung()
        {
            return widm.ToString();
        }

        public double getEW()
        {
            return einheitswert;
        }
        /*GET*/

        /*SET*/
        public void setWidmung(int v)
        {
            switch (v)
            {
                case 1:
                    widm = widmung.Baugrund;
                    break;
                case 2:
                    widm = widmung.Geschaeftsflaeche;
                    break;
                default:
                    widm = widmung.Baugrund;
                    break;
            }
        }

        public void setEW(double v)
        {
            einheitswert = v;
        }
        /*SET*/
    }
}

