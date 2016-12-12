using System;

namespace ConsoleApplication
{
    public class Ticket
    {            
        public double Preis { get; set; }
        public DateTime KaufDatum { get; set; }
        
        public Ticket (double preis, DateTime kd)
        {
            Preis = preis;
            KaufDatum = kd;
        }
    }
}