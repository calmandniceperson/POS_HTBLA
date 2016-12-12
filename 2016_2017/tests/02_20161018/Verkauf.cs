using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Verkauf
    {
        public static List<Ticket> TicketListe = new List<Ticket>();
        
        public static void PrintDay(DateTime day)
        {
            double sum = 0;
            int n = 0;
            foreach (Ticket t in TicketListe)
            {
                if (t.KaufDatum.Date == day.Date)
                {
                    sum += t.Preis;
                    n++;
                }
            }
            Console.WriteLine($"Day {day.Day}\nEinnahmen: {sum} Euro\nVerkaufte Tickets: {n}");
        }

        public static void PrintThisMonth()
        {
            double sum = 0;
            int n = 0;
            foreach (Ticket t in TicketListe)
            {
                if (t.KaufDatum.Month == DateTime.Now.Month)
                {
                    sum += t.Preis;
                    n++;
                }
            }
            Console.WriteLine($"Month {DateTime.Now.Month}\nEinnahmen: {sum} Euro\nVerkaufte Tickets: {n}");
        }
    }
}