/*
 * MICHAEL KOEPPL 3AHIF
 * Stack Beispiel
 * 
 * Angabe:
 * Es soll ein Stack in einer Klasse gehalten werden (mit Methoden push & pop).
 * Der Klasse muss eine maximale Groesse fuer den Stack mitgegeben werden
 * Wenn die maximale Groesse ueberschritten wird, soll eine OverflowException geworfen werden,
 * wenn sie unterschritten wird, soll ein Event ausgeloest werden
 * 
 * Fertigstellung: 10.02.2015
 */
using System;

namespace CSStackEventsException
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string ant = string.Empty;
			do {
				try {
					Console.WriteLine ("Geben Sie die Kapazitaet der Liste ein: ");
					var cap = int.Parse (Console.ReadLine ());

					var myStack = new CStack (cap);
					myStack.underFlow += myStack_underflow;

					do {
						switch(menu()){
						case 1:
							Console.WriteLine("Geben Sie Ihre Nachricht ein, die angehaengt werden soll: ");
							myStack.push(Console.ReadLine());
							break;
						case 2:
							Console.WriteLine(myStack.pop());
							break;
						case 3:
							myStack.clear();
							break;
						}


						Console.WriteLine ("Wollen Sie noch eine Aktion ausfuehren? (j/n) ");
						ant = Console.ReadLine ();
					} while(ant.ToLower ().StartsWith ("j"));
					//myStack.push("Test");
					//myStack.push("lel");
					Console.WriteLine (myStack.pop ());
				} catch (CStackOverflowException) {
					Console.WriteLine ("Stack Overflow");
				} catch (Exception ex) {
					Console.WriteLine (ex.Message);
				}					

				Console.WriteLine("Wollen Sie das Programm neu starten? (j/n) ");
				ant = Console.ReadLine();
			} while(ant.ToLower ().StartsWith ("j"));
		}

		static void myStack_underflow(){
			throw new NotImplementedException ();
		}

		static int menu(){
			Console.Clear ();
			Console.WriteLine ("1 ... Push Element");
			Console.WriteLine ("2 ... Pop Element");
			Console.WriteLine ("3 ... Clear");

			return int.Parse (Console.ReadLine ());
		}
	}
}
