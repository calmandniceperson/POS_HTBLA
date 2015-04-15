using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSBestellungDB
{
    class Stamm
    {
        public int ID { get; set; }
        public string Bezeichnung { get; set; }
        public double MinLagerstand { get; set; }
        public double Preis { get; set; }

        public Stamm(int id, string b, double mls, double p)
        {
            ID = id;
            Bezeichnung = b;
            MinLagerstand = mls;
            Preis = p;
        }
    }
}
