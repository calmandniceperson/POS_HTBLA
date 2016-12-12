using System;

namespace ConsoleApplication
{
    public class ErwachsenTicket:Ticket
    {
        private static double fixedPreis = 9.00;
        
        public static void SetFixedPreis(double p)
        {
            fixedPreis = p;
        }
 
        public ErwachsenTicket(DateTime kd):base(fixedPreis, kd){}
    }
}