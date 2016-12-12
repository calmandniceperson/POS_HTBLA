using System;

namespace ConsoleApplication
{
    public class KinderTicket: Ticket
    {
        private static double fixedPreis = 0.00;
        
        public static void SetFixedPreis(double p)
        {
            fixedPreis = p;
        }
        
        public KinderTicket (DateTime kd):base(fixedPreis, kd){}
    }
}