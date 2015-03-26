using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSKlassensparbuch
{
    public class KontoEventArgs:EventArgs
    {
        public KontoEventArgs(string u = "", int k = 0)
        {
            uid = u;
            kontoID = k;
        }

        public string uid { get; set; }
        public int kontoID { get; set; }
    }
}
