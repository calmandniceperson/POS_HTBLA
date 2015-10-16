package aufgabe1;

public class Zaehler {
	static int zaehler = 0;
	private int serienNummer;
	
	Zaehler() {
		zaehler++;
	}
	
	Zaehler(int sn) {
		zaehler++;
		this.serienNummer = sn;
	}
	
	static int getZaehler() {
		return zaehler;
		// serienNummer kann nicht zurueckgegeben
		// werden, da die methode static ist,
		// die variable serienNummer aber nicht
	}
	
	int getSN() {
		return serienNummer;
	}
}
