using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSBestellungDB
{
    public class UnterschrittenEventArgs:EventArgs
    {
        public int produkt_id;

        public UnterschrittenEventArgs(int pid)
        {
            produkt_id = pid;
        }
    }
}
