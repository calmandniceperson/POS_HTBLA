// Author(s): Michael Koeppl

using System.Collections.Generic;
using System;

namespace _94ASim
{
    public class WalkWay
    {
        const int DURATION = 3;       

        private static WalkWay instance;

        private WalkWay()
        {
            listOfPeople = new List<WalkTime>();
        }

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

        // The list of people that are on their way with the time
        // it takes them to arrive and the time they've already been
        // walking stored as values.
        List<WalkTime> listOfPeople { get; set; }

        public void AddPeople(int count)
        {
            for (int i = 0; i < count; i++)
            {
                // Add people with walking times alternating
                // between 3 (fast-walking) and 7 minutes (slow-walking).
                listOfPeople.Add(new WalkTime(i % 2 == 0 ? 3 : 7));
            }
        }

        // Returns the number of people who arrived.
        public int GetNumberOfArrivers()
        {
            int count = 0;
            for (int i = 0; i < listOfPeople.Count; i++)
            {
                // If the time the person has already been walking
                // matches the time it takes them to arrive there,
                // we add them to the queue at the bus stop and remove
                // them from the list of people that are on their way.
                if (listOfPeople[i].PredictedTime == listOfPeople[i].TimeWalked)
                {
                    count++;
                    listOfPeople.Remove(listOfPeople[i]);
                }
            }
            return count;
        }

        public void IncreaseTicks()
        {
            foreach (WalkTime w in listOfPeople)
            {
                w.TimeWalked++;
            }
        }
    }
}