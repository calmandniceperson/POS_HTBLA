import java.util.HashMap;

public class MapBeispiel {

	public static void main(String[] args) {
		// Aufgabe1: Erstellen Sie die Klasse MapBeispiel (soll auch ausführbar sein)
		// Erzeugen Sie ein Map-Objekt (HashMap) und fügen sie verschiedene 
		// Objekte hinzu (z.B.
		// Strings und div. Wrapperobjekte).
		// Verwenden Sie die Methoden keySet, values und entrySet der Map Schnittstelle.
		// Beobachten Sie die Ausgabe der jeweiligen zurückgegebenen Objekte 
		// auf der Konsole. Wie werden Hinzufügungen von Duplikaten von Schlüsseln 
		// behandelt?
		//
		// Antwort: Duplikate werden ignoriert
		HashMap<String, Object> hm = new HashMap<String, Object>();
		hm.put("1. Objekt", new Integer(2));
		hm.put("2. Objekt", new Boolean(true));
		
		// duplikate werden ignoriert
		hm.put("1. Objekt", new String("helo"));
		
		System.out.println(hm.entrySet());
		System.out.println(hm.keySet());
		System.out.println(hm.values());
	}

}
