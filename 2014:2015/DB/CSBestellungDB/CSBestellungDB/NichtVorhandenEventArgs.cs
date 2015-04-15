using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSBestellungDB
{
    public class NichtVorhandenEventArgs:EventArgs
    {
        public int produkt_id;

        public NichtVorhandenEventArgs(int pid)
        {
            produkt_id = pid;
        }
    }
}
