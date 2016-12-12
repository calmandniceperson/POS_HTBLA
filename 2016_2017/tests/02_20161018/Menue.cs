using System;

namespace ConsoleApplication
{
    public class Menue
    {
        public static void Show()
        {
            Console.WriteLine("1...Kauf ticket");
            int inp = int.Parse(Console.ReadLine());
            switch (inp)
            {
                case 1:
                Console.WriteLine("Enter date:");
                DateTime date = Convert.ToDateTime(Console.ReadLine());
                Besucher b = new Besucher(date, DateTime.Now);
                b.KaufTicket();
                break;
            }
        }
    }
}