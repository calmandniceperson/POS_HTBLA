using System;

namespace CSDelegates
{
	public class Logger
	{
		public Logger ()
		{
		}

		/*
		 * logs the current time + a message
		 */
		public static string log(string text){
			return (DateTime.Now.ToShortTimeString()  + " " + text);
		}
	}
}

