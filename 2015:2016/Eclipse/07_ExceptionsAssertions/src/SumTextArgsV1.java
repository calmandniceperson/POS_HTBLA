
public class SumTextArgsV1 {

	public static void main(String[] args) {
		// Initialisieren Sie direkt im Quelltext ein
		// Array vom Typ String mit einigen Elementen.
		// Diese Elemente sollen ganze Zahlen als Text enthalten.
		// Programmieren Sie eine Schleife, die alle Elemente
		// jeweils in eine int primitive wandelt und aufsummiert.
		// Das Ergebnis soll auf der Konsole ausgegeben werden.
		//
		//
		// a) 
		// Ändern Sie ein Element in „drei“ statt „3“ ab.
		// Beobachten und beschreiben Sie die Auswirkungen.:
		// Programm wirft eine NumberFormatException, welche nicht
		// abgefangen wird. Somit endet das Programm.
		// 
		// 
		// b)
		// Ändern Sie ein Element in „3.0“ statt „3“ ab.
		// Beobachten und beschreiben Sie die Auswirkungen.:
		// Programm wirft eine NumberFormatException, welche nicht
		// abgefangen wird. Somit endet das Programm.
		String arr0[] = { "3.0", "2", "3" };
		int sum0 = 0;
		for (String ele : arr0) {
			sum0 += Integer.parseInt(ele);
		}
		System.out.println("Summe: " + sum0);
	}

}
