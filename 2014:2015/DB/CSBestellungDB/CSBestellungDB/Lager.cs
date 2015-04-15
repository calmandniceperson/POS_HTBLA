using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSBestellungDB
{
    class Lager
    {
        public int ID { get; set; }
        public int ProdID { get; set; }
        public double Lagerstand { get; set; }

        public Lager(int id, int pid, double ls)
        {
            ID = id;
            ProdID = pid;
            Lagerstand = ls;
        }
    }
}
