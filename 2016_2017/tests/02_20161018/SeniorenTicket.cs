using System;

namespace ConsoleApplication
{
    public class SeniorenTicket:Ticket
    {
        private static double fixedPreis = 4.00;
        
        public static void SetFixedPreis(double p)
        {
            fixedPreis = p;
        }
 
        public SeniorenTicket(DateTime kd):base(fixedPreis, kd){}
    }
}