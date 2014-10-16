/*
 * MICHAEL KOEPPL
 * 2013/2014
 * CSDelegates
 */

using System;

namespace CSDelegates
{
	class MainClass
	{
		/*
		 * delegate
		 */
		public delegate string LogDel(string txt);

		public static void Main (string[] args)
		{
			string ant = string.Empty, ant1;

			/*
			 * set LogDel to null for now
			 */
			LogDel l = null;

			do {
				Console.Clear();

				Console.Write("Wollen Sie loggen? (j/n) ");
				ant1 = Console.ReadLine();

				switch(ant1.ToLower()){
					
				case "j":
					/*
					 * calls the method Logger.log(); with the delegate
					 * and prints the returned string
					 */
					l = Logger.log;
					Console.WriteLine(l("Hier ist Ihr Log."));
					break;

				case "n":
					l = null;
					break;

				}

				Console.Write("Wollen Sie das Programm neu starten? (j/n) ");
				ant = Console.ReadLine();
			} while(ant.ToLower ().StartsWith ("j"));
		}
	}
}
