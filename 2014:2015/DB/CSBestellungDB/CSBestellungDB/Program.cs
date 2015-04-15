using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb; // ole --> object linking embedding

namespace CSBestellungDB
{
    class Program
    {
        static void Main(string[] args)
        {
            Verwaltung vo = new Verwaltung();
            vo.Lesen();
            vo.LagerWert();
            Console.ReadKey();
        }
    }
}
