package aufgabe2_alternative;

public class FarbkarteOld {
	public final static int KFARBE_ROT = 0;
	public final static int KFARBE_SCHWARZ = 1;
	public final static int KFARBE_GELB = 2;
	public final static int KFARBE_WEISS = 3;
	
	private final static String[] n = {"Rot", "Schwarz", "Gelb", "Weiss"};
	
	private int farbe;
	
	FarbkarteOld(int farbe) {
		this.farbe = farbe;
	}

	public int getFarbe() {
		return farbe;
	}
	
	public String getFarbName() {
		if(this.farbe <= n.length) {
			return n[this.farbe];
		} else {
			return "Ungueltiger Farbindex";
		}
	}
}
