package aufgabe2;

public class TestEnums {
	public static void main(String[] args) {
		// a) Erstelle ein FarbkarteOld Objekt mit einem Konstruktoraufruf
		// mit qualifizierter Referenz der statischen Konstante mit der
		// KFARBE_GELB.
		// klassischr Aufzaehlungstyp mit statischen Variablen
		FarbkarteOld fko1 = new FarbkarteOld(FarbkarteOld.KFARBE_GELB);
		System.out.println("Die Karte hat Nr.: " + fko1.getFarbe() + " Name: " + fko1.getFarbName());

		// b) Erstelle ein weiteres FarbkarteOld Objekt mit einem
		// Konstruktoraufruf
		// mit einer int-Zahl für die Farbe Rot
		FarbkarteOld fko2 = new FarbkarteOld(0);
		System.out.println("Die Karte hat Nr.: " + fko2.getFarbe() + " Name: " + fko2.getFarbName());

		// c) Erstelle ein weiteres FarbkarteOld Objekt mit einem
		// Konstruktoraufruf mit der int-Zahl 7.
		FarbkarteOld fko3 = new FarbkarteOld(7);
		System.out.println("Die Karte hat Nr.: " + fko3.getFarbe() + " Name: " + fko3.getFarbName());

		// d) Erstelle ein FarbkarteNeu Objekt mit einem Konstruktoraufruf mit
		// qualifizierter Referenz mittels der Enumeration Farbe.
		FarbkarteNew fkn1 = new FarbkarteNew(FarbkarteNew.Farbe.GELB);
		System.out.println("Die Karte hat Nr.: " + fkn1.getFarbe().ordinal() + " Name: " + fkn1.getFarbName());

		// e) Erstelle ein weiteres FarbkarteNeu Objekt mit einem Konstruktoraufruf mit einer Zahl.
		// GEHT NICHT!! (Das ist die Lehre dabei)
		//
		// FarbkarteNew fkn2 = new FarbkarteNew(1);
		// System.out.println("Die Karte hat Nr.: " + fkn2.getFarbe().ordinal()
		// + " Name: " + fkn2.getFarbName());

		// f) Erstelle einen Farbe2 Datentyp mit einer Zuweisung für Gelb. Beobachten Sie die Funktion.
		FarbkarteNew fkn3 = new FarbkarteNew(FarbkarteNew.Farbe2.ROT);
		System.out.println("Die Karte hat Nr.: " + fkn3.getFarbe2().getNum() + " Name: " + fkn3.getFarbe2().getFarbName());
	}
}
