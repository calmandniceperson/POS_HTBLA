
public class SumTextArgsV4 {

	// Bauen Sie die Klasse SumTextArgsV4 (soll auch ausführbar sein)
	// so um, dass Sie die Anwendung mehrerer catch Klauseln zeigen können.
	// Fügen Sie eine eigene Ausnahme ein, die bei einer bestimmten Zahl 
	// des Schleifenindex anschlägt.
	// Fügen Sie eine geeignete Assertion ein und aktivieren Sie 
	// die Zusicherungen in Ihrer IDE.
	public static void main(String[] args) {
		String arr0[] = { "1", "2", "3" };
		try {
			System.out.println("Summe:" + sumInt(arr0));
		} catch (MyException ex) {
			// System.out.println(ex.getMessage());
			ex.printStackTrace();
		} catch (TwoIsIndexException ex) {
			System.out.println(ex.getMessage());
		}
	}

	public static int sumInt(String[] s) throws MyException, TwoIsIndexException {
		int sum0 = 0;
		for (int i = 0; i <= s.length - 1; i++) {
			if(i == 2) {
				throw new TwoIsIndexException("TwoIsIndexException: Index ist 2.");
			}
			try {
				sum0 += Integer.parseInt(s[i]);
			} catch (NullPointerException ex) {
				ex.printStackTrace();
			} catch (NumberFormatException ex) {
				throw new MyException("Fehler beim Konvertieren von \"" + s[i] + "\"");
			} finally {
				System.out.println("Im finally Block!!");
			}
		}
		return sum0;
	}

}
