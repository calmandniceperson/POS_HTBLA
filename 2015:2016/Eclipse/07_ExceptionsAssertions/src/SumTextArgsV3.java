
public class SumTextArgsV3 {

	// Für diese Aufgabe erzeugen Sie die Klasse SumTextArgsV3 
	// (soll auch ausführbar sein). Lagern Sie dabei die Schleife 
	// in eine statische Methode public static int sumIt(String [] s) 
	// aus und werfen Sie eine selbst hergestellte Ausnahme 
	// MyException in die aufrufende main-Methode.
	// Beobachten Sie die Fehlermeldungen und schaffen Sie Abhilfe.
	public static void main(String[] args) {
		String arr0[] = { "3.0", "2", "3" };
		try {
			System.out.println("Summe:" + sumInt(arr0));
		} catch (MyException ex) {
			//System.out.println(ex.getMessage());
			ex.printStackTrace();
		}
	}

	public static int sumInt(String[] s) throws MyException {
		int sum0 = 0;
		for (String ele : s) {
			try {
				sum0 += Integer.parseInt(ele);
				// assertion
				// diese wird nicht ausgegeben,
				// solange bei den VM variablen nicht -ea
				// gesetzt wird
				assert sum0 > 2: "Summe groesser 2";
			} catch (NumberFormatException ex) {
				throw new MyException("Fehler beim Konvertieren von \"" + ele + "\"");
			}
		}
		return sum0;
	}

}
