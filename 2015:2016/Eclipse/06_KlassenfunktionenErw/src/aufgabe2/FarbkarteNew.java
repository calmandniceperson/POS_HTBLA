package aufgabe2;

public class FarbkarteNew {
	public enum Farbe {
		ROT, SCHWARZ, GELB, WEISS
	}

	public enum Farbe2 {
		ROT("ROT", 0), SCHWARZ("SCHWARZ", 1), GELB("GELB", 2), WEISS("WEISS",3);
		private final String farbe;
		private final int num;

		private Farbe2(String farbe, int num) {
			this.farbe = farbe;
			this.num = num;
		}

		public String getFarbName() {
			return this.farbe;
		}
		
		public int getNum() {
			return this.num;
		}
	}

	private Farbe farbe;
	private String name;

	FarbkarteNew(Farbe farbe) {
		this.farbe = farbe;
		this.name = this.farbe.toString();
	}

	public Farbe getFarbe() {
		return this.farbe;
	}

	public String getFarbName() {
		return this.name;
	}

	// f)
	private Farbe2 farbe2;
	FarbkarteNew(Farbe2 farbe) {
		this.farbe2 = farbe;
	}
	public Farbe2 getFarbe2() {
		return this.farbe2;
	}
}
