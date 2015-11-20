import java.util.HashSet;

public class SetBeispiel {

	public static void main(String[] args) {
		// Aufgabe1: Erstellen Sie die Klasse SetBeispiel (soll auch ausführbar sein)
		// Erzeugen Sie ein Set (HashSet) und fügen sie verschiedene 
		// Objekte hinzu (z.B. Strings und div. Wrapperobjekte).
		// Beobachten Sie die Ausgabe des Sets auf der Konsole. Was passiert, 
		// wenn Duplikate hinzugefügt werden?
		//
		// A: Duplikate werden ignoriert, da es ja lediglich darum geht,
		//	  den Wert in dem Set zu haben. Es ist nicht relevant, welches Element
		//	  zurueckgegeben wird, solange es den richtigen Wert enthaelt.
		//	  Bei unterschiedlichen Datentypen werden allerdings beide Werte gespeichert.
		HashSet<Object> hs = new HashSet<Object>();
		hs.add("1. Element");
		hs.add(new Integer(2));
		hs.add(new Boolean(true));
		hs.add(new Integer(2));
		hs.add(new Double(3.0));
		hs.add(new Float(3.0));
		for(Object ele : hs) {
			System.out.println(ele);
		}
	}

}
