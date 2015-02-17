// Michael Koeppl 3AHIF
// LOTTO Beispiel
// 
// Aufgabenstellung:
// Es soll eine zufaellige Zahl generiert werden. Danach soll der Nutzer beliebig viele Tipps abgeben koennen.
// Am Ziehungstag werden die Tipps ueberprueft. Mittels Events werden ab 4 richtigen Tipps Preise vergeben.

using System;
using System.Linq;

namespace CSLotto
{
	class MainClass
	{
		public static int[] corr_nums { get; set; } // das ist die korrekte zahl

		public static void Main (string[] args)
		{
			TippVerwaltung tv = new TippVerwaltung();
			string ant = string.Empty;

			do{
				// generiere zufaellige richtige Zahl
				Random random = new Random();
				corr_nums = new int[6]; 

				int numruns = 0;

				while(numruns != 6){
					int rnum = random.Next(1, 45);
					if(!corr_nums.Contains(rnum)){
						corr_nums[numruns] = rnum;
						numruns++;
					}
				}

				foreach(int num in corr_nums){
					Console.WriteLine (num.ToString());
				}

				try{
				do{
					switch(menu()){
					case 1:
						int[] tipp = new int[6];
						Console.WriteLine("Geben Sie Ihren Tipp ein (Format: 22 1 14 32 2 3): ");
						string tippinput = Console.ReadLine().Trim();
						for(int j = 0; j <= 5; j++){
							if(Convert.ToInt32(tippinput.Split(' ')[j]) > 45){
								throw new NumberTooHighException();
							}
							if(tippinput.Split(' ')[j] != ""){
								tipp[j] = Convert.ToInt32(tippinput.Split(' ')[j]);
							}
						}
						tv.add(new Tipp(tipp));
						break;
					case 2:
						string output = string.Empty;
						foreach(int n in corr_nums){
							output += (n.ToString() + " ");
						}
						Console.WriteLine ("Korrekte Zahl: " + output);
						foreach(Tipp t in tv.get()){
							Console.WriteLine ();
							Console.WriteLine(t.ToString());
						}
						break;
					}
					Console.Write("Wollen Sie noch eine Aktion durchfuehren? (j/n) ");
					ant = Console.ReadLine();
				}while(ant.ToLower().StartsWith("j"));
				}catch(NumberTooHighException){
					Console.WriteLine ("Sie haben eine zu hohe Zahl in Ihrem Tipp. (max. 45)!");
				}catch(Exception ex){
					Console.WriteLine (ex.ToString());
				}


				Console.Write("Wollen Sie das Programm neu starten? (j/n) ");
				ant = Console.ReadLine();
			}while(ant.ToLower().StartsWith("j"));
		}

		public static int menu(){
			Console.Clear ();
			Console.WriteLine ("1 ... Neuen Tipp abgeben");
			Console.WriteLine ("2 ... Ziehungstag ausloesen");
			return int.Parse (Console.ReadLine ());
		}
	}

	public class NumberTooHighException:Exception{
		public NumberTooHighException(){}

		public NumberTooHighException(string message):base(message){}

		public NumberTooHighException(string message, Exception inner):base(message, inner){}
	}
}
