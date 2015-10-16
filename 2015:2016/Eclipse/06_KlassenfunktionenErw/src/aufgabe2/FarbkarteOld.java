package aufgabe2;

public class FarbkarteOld {
	public final static int KFARBE_ROT = 0;
	public final static int KFARBE_SCHWARZ = 1;
	public final static int KFARBE_GELB = 2;
	public final static int KFARBE_WEISS = 3;
	
	private int farbe;
	
	FarbkarteOld(int farbe) {
		this.farbe = farbe;
	}

	public int getFarbe() {
		return farbe;
	}
	
	public String getFarbName() {
		switch(this.farbe) {
		case 0:
			return "ROT";
		case 1:
			return "SCHWARZ";
		case 2:
			return "GELB";
		case 3:
			return "WEISS";
		default:
			return "UNGUELTIGE FARBE";
		}
	}
}
