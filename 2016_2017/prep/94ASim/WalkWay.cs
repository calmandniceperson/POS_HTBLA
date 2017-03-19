// Author(s): Michael Koeppl

namespace _94ASim
{
    public class WalkWay
    {
        const int DURATION = 3;       

        private static WalkWay instance;

        private WalkWay() {}

        public static WalkWay Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new WalkWay();
                }
                return instance;
            }
        }

        public int TimeSinceU2Exit { get; set; }

        // The number of people that are on their way
        public int PeopleCount { get; set; }
    }
}