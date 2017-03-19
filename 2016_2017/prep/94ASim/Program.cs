// Author(s): Michael Koeppl

using System;

namespace _94ASim
{
    class Program
    {
        const int MAX_TIME = 30;

        static void Main(string[] args)
        {
            Console.Clear();
            int u2PeopleCount;
            DateTime currentTime = DateTime.Now;
            DateTime time = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day, 7, 30, 0);

            for (int timePassed = 0; timePassed < MAX_TIME; timePassed++)
            {
                Console.WriteLine($"{time.Hour}:{time.Minute}");
                if (timePassed % 3 == 0) // Every 3 minutes
                {
                    u2PeopleCount = U2.Instance.Arrive(timePassed);
                    
                    // Add the people who were on their way to the bus station.
                    // We can just ignore the fact that on minute 0 this happens as well
                    // since the number of people is 0 in the beginning anyway, so we're
                    // basically adding 0 people to a queue length of 0 at the bus station.
                    // Math game is on fleek.
                    BusStop.Instance.QueueLength += WalkWay.Instance.PeopleCount;
                    Console.WriteLine($"{WalkWay.Instance.PeopleCount} students arrived at the bus stop.");

                    // Send the number of people that just left the subway on their way to
                    // the bus station.
                    WalkWay.Instance.PeopleCount = u2PeopleCount;
                }

                if (timePassed % 5 == 0 && timePassed != 0) // Every 5 minutes, but without minute 0
                {
                    // Takes 90 people from the bus stop and puts them in the bus.
                    // They arrive in 3 minutes. The counter for that ticks every minute at the end of this
                    // loop.
                    Bus.Instance.PickUp();
                }

                if (timePassed % 10 == 0 && timePassed != 0)
                {
                    Console.WriteLine(BusStop.Instance.ToString());
                }

                // The bus arrived at the school after 3 minutes.
                if (Bus.Instance.TimeSinceDeparture == 3)
                {
                    // Drops off the students.
                    Bus.Instance.DropOff();
                }

                time = time.AddMinutes(1);
            }
        }
    }
}
