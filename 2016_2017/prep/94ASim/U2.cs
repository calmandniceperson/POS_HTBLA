// Author(s): Michael Koeppl

using System;

namespace _94ASim
{
    public class U2
    {  
        // This represents the amount of passengers leaving the train.
        private static int[] passengerCount = {20, 25, 30, 70, 90, 100, 110, 80, 60, 60, 50};

        private static U2 instance;

        private U2() {}

        public static U2 Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new U2();
                }
                return instance;
            }
        }

        // Makes a train arrive and sends a number of people
        // on their way.
        // Returns the number of people that are sent on their
        // way to the bus station.
        public int Arrive(int minuteCount)
        {
            Console.WriteLine($"U2 arrived with {passengerCount[minuteCount/3]} people.");
            return passengerCount[minuteCount/3];
        }
    }
}