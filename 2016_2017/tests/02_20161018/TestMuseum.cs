using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class TestMuseum
    {
        public static void Test()
        {
            List<Besucher> TestList = new List<Besucher>();
            TestList.Add(new Besucher(Convert.ToDateTime("07.03.1998"), DateTime.Now));
            KinderTicket.SetFixedPreis(2.00);
            TestList.Add(new Besucher(Convert.ToDateTime("02.02.2001"), DateTime.Now));
            TestList.Add(new Besucher(Convert.ToDateTime("06.04.1989"), DateTime.Now));
            TestList.Add(new Besucher(Convert.ToDateTime("02.03.1934"), DateTime.Now));
            foreach (Besucher b in TestList)
            {
                b.KaufTicket();
            }
            Verkauf.PrintDay(DateTime.Now);
            Verkauf.PrintThisMonth();
        }
    }
}