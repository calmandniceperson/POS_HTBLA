/*
 * Michael Köppl 3AHIF
 * Events/CSGeburtstagskalender
 * 2014/2015
 */

using System;
using System.Timers;
using System.IO;
using System.Globalization;

namespace CSGeburtstagskalender
{
	class MainClass
	{

		public Timer lelTimer;
		StreamReader sr = new StreamReader ("../../geburtstage.txt");
		static MainClass mc = new MainClass ();
		static Verwaltung v = new Verwaltung ();

		public static void Main (string[] args)
		{
			string s;

			Console.WriteLine ("Started: " + DateTime.Now.ToString ());

			if(File.Exists("../../geburtstage.txt")){
				while((s = mc.sr.ReadLine()) != null){
					v.createNewErinnerung(
						new DateTime(Convert.ToInt32(s.Split('_')[0].Split('/')[2]),
					             Convert.ToInt32(s.Split('_')[0].Split('/')[1]),
					             Convert.ToInt32(s.Split('_')[0].Split('/')[0]), 
					             Convert.ToInt32(s.Split('_')[1].Split(':')[0]), 
					             Convert.ToInt32(s.Split('_')[1].Split(':')[1]), 
					             Convert.ToInt32(s.Split('_')[1].Split(':')[2])),
						//DateTime.ParseExact(s.Split('_')[0] + " " + s.Split('_')[1], "dd/MM/yyyy hh:mm:ss tt", CultureInfo.InvariantCulture),
						s.Split('_')[2], /*name des geburtstagskinds*/
						Convert.ToInt32(s.Split('_')[3]), /*wie viele tage zuvor erinnert werden soll*/
						Convert.ToInt32(s.Split('_')[4])); /*anzahl erinnerungen*/
				}
			}

			Console.Clear ();

			v.printAll();

			InitTimer(mc);

			Console.ReadLine ();

		}

		public static void InitTimer(MainClass m)
		{
			m.lelTimer = new Timer();
			m.lelTimer.Elapsed += new ElapsedEventHandler(lelTimer_Tick);
			m.lelTimer.Interval = 3000; // in miliseconds
			m.lelTimer.Start();
		}

		private static void lelTimer_Tick(object sender, EventArgs e)
		{
			Console.WriteLine ("...");
			v.checkDatum (DateTime.Now);
		}
	}
}
