// Author(s): Michael Koeppl

using System;

namespace _94ASim
{
    public class Bus
    {
        const int PICKUP_COUNT = 90;

        private static Bus instance;

        private Bus() {}

        public static Bus Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Bus();
                }
                return instance;
            }
        }

        public int TimeSinceDeparture { get; set; }

        private int passengerCount;

        // The bus picks up 90 people.
        public void PickUp()
        {
            passengerCount = BusStop.Instance.QueueLength < 90 ? BusStop.Instance.QueueLength : 90;
            BusStop.Instance.QueueLength -= passengerCount;
            TimeSinceDeparture = 0;
            Console.WriteLine($"94A picked up {passengerCount} students. Will arrive in 3 minutes.");
        }

        public void DropOff()
        {
            Console.WriteLine($"Dropped {passengerCount} students off at school!");
        }
    }
}