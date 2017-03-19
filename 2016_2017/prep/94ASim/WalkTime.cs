// Author(s): Michael Koeppl

namespace _94ASim
{
    public class WalkTime
    {
        public int PredictedTime { get; set; }
        public int TimeWalked { get; set; }

        public WalkTime(int predictedTime)
        {
            PredictedTime = predictedTime;
        }
    }
}