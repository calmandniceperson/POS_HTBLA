using System;
using System.Collections.Generic;
using System.Linq;

namespace CSStackEventsException
{
	public delegate void StackDelegate();

	public class CStack
	{
		List<String> Stack;

		public int capacity{ get; private set; }

		public CStack (int cap /*capacity*/)
		{
			capacity = cap;
			Stack = new List<String> (cap);
		}

		public void push(string element){
			// Abfrage: Kapazitaet erreicht?
			// ja: -> Exception ausloesen
			// nein: -> Element eintragen
			if(Stack.Capacity < Stack.Count + 1){
				throw new CStackOverflowException ();
			}else{
				Stack.Add (element);
			}
		}

		public string pop(){
			// Abfrage: noch ein Element in der Liste vorhanden?
			// ja: -> Element returnen
			// nein: -> Event ausloesen

			if(Stack.Count != 0){
				return Stack.Last();
			}else{
				underFlow ();
			}

			return string.Empty;
		}

		public void clear(){
			Stack.Clear ();
		}

		public event StackDelegate underFlow;
	}

	class CStackOverflowException:ApplicationException{
		// -> 3 Konstruktoren!

		public CStackOverflowException(){
		}

		public CStackOverflowException(string message):base(message){
		}

		public CStackOverflowException(string message, Exception inner):base(message, inner){
		}
	}
}

