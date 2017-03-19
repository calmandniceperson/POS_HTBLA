// Author(s): Michael Koeppl

namespace _94ASim
{
    public class BusStop
    {
        private static BusStop instance;

        private BusStop() {}

        public static BusStop Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BusStop();
                }
                return instance;
            }
        }

        public int QueueLength { get; set; }

        override public string ToString()
        {
            return $"Number of people at the bus stop: {QueueLength}";
        }
    }
}