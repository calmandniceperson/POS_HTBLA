public class SumTextArgsV2 {

	public static void main(String[] args) {
		// Führen Sie zum kopierten Quelltext der Aufgabe 1
		// eine geprüfte Ausnahme ein. Experimentieren Sie
		// mit der Methode printStackTrace();
		// Verarbeiten Sie die Ausnahme auf geeignete Art
		String arr0[] = { "3.0", "2", "3" };
		int sum0 = 0;
		for (String ele : arr0) {
			try {
				sum0 += Integer.parseInt(ele);
			} catch (NumberFormatException ex) {
				System.out.println("Ein Fehler bei der Konvertierung ist aufgetreten.\nFehlermeldung:");
				ex.printStackTrace();
			} finally {
				System.out.println("Element: " + ele);
			}
		}
		System.out.println("Summe: " + sum0);
	}

}
