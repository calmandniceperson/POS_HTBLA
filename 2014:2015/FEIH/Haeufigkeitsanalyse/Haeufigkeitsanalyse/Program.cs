/*
 * MICHAEL KOEPPL
 * 3AHIF
 * 2014/2015
 * WORDCOUNT
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Haeufigkeitsanalyse
{
	class MainClass
	{
		Dictionary<string, int> d = new Dictionary<string, int> ();

		public static void Main (string[] args)
		{
			MainClass mc = new MainClass ();
			mc.CreateDictionary ("loremipsum.txt");
			mc.Print ();
			Console.ReadKey ();
		}

		private void CreateDictionary(string filePath)
		{
			d.Clear();

			string fileText = File.ReadAllText(filePath);
			string[] words = fileText.Split(new char[] { ' ', '\t', '\r', '\n', '.', ',', '?', ';', ':' }, StringSplitOptions.RemoveEmptyEntries);

			foreach (string word in words)
			{
				if (d.ContainsKey (word))
					d [word]++;
				else
				{
					d.Add(word, 1);
				}
			}
		}

		public void Print()
		{
			foreach (KeyValuePair<string, int> kvp /*um 2 werte in 1 variable zu haben*/ in d.OrderByDescending(k => k.Value))
			{
				Console.WriteLine("{0} - {1}", kvp.Key, kvp.Value);
			}
		}
	}
}
