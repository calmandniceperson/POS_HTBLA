package aufgabe1;

public class TestZaehler {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		System.out.println("Zaehler vor Objekterstellung: " + Zaehler.getZaehler());
		
		// 1. objekt
		// zaehler wird um 1 erhoeht
		// zaehler = 1
		Zaehler z1 = new Zaehler();
		System.out.println("Zaehler nach 1. Objekt: " + Zaehler.getZaehler());
		
		// 2. objekt
		// zaehler wird um 1 erhoeht
		// zaehler = 2
		Zaehler z2 = new Zaehler(25);
		System.out.println("Zaehler nach 2. Objekt: " + Zaehler.getZaehler());
		// seriennummer = 2
		System.out.println("Seriennummer z2: " + z2.getSN());
	}

}
