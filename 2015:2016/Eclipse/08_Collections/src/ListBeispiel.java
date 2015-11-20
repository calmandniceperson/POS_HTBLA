import java.util.ArrayList;

public class ListBeispiel {

	public static void main(String[] args) {
		// Aufgabe2: Erstellen Sie die Klasse ListBeispiel (soll auch ausführbar sein) 
		// Erzeugen Sie ein List-Objekt (ArrayList) und fügen sie verschiedene 
		// Objekte hinzu. (z.B.
		// Strings und div. Wrapperobjekte).
		// Beobachten Sie die Ausgabe. Was passiert, wenn Duplikate hinzugefügt werden?
		//
		// A: Duplikate werden nicht ignoriert.
		ArrayList<Object> al = new ArrayList<Object>();
		al.add("1. Element");
		al.add(new Integer(3));
		al.add(new Boolean(false));
		al.add(new Integer(3));
		System.out.println(al);
	}

}
