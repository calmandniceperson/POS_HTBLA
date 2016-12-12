using System;

namespace ConsoleApplication
{
    public class Besucher
    {
        public DateTime GeburtsDatum { get; }
        public DateTime BesuchsTag { get; }
        
        public Besucher(DateTime geb, DateTime bes)
        {
            GeburtsDatum = geb;
            BesuchsTag = bes;
        }
        
        public void KaufTicket()
        {
            Ticket ticket = null;
            int days = (BesuchsTag - GeburtsDatum).Days;
            int years = days / 365;
            if (years <= 19)
            {
                ticket = new KinderTicket(BesuchsTag);
            }
            else if (years > 19 && years <= 65)
            {                    
                ticket = new ErwachsenTicket(BesuchsTag);
            }
            else
            {
                ticket  = new SeniorenTicket(BesuchsTag);
            }
            Verkauf.TicketListe.Add(ticket);
        }
    }
}