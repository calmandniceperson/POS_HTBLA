using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    class WuerfelSettings
    {
        public int Min { get; private set; }
        public int Max { get; private set; }
        public int Anz { get; private set; }

        public List<int> Werte { get; private set; }

        public double Durchschnitt { get; private set; }

        public WuerfelSettings(int min, int max, int anz)
        {
            this.Min= min;
            this.Max = max;
            this.Anz = anz;

            // Ruft sich selbst auf, um Ergebnisse zu generieren.
            wuerfeln();
        }

        private void wuerfeln()
        {
            Werte = new List<int>();
            int sum = 0;
            for (int i = 0; i < Anz; i++)
            {
                int num = new Random(DateTime.Now.Millisecond).Next(Min, Max+1);
                Console.WriteLine(num);
                Werte.Add(num);
                sum += num;
            }
            Durchschnitt = sum/Anz;
        }
    }
}