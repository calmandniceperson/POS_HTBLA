package beispiel_interface;

public class Karpfen extends GrundFisch {

	public Karpfen(int groessecm, int gewichtkg) {
		farbe = "goldbraun";
		anzahlschuppen = 3;
		this.grössecm = groessecm;
		this.gewichtkg = gewichtkg;
	}

	@Override
	public void blubbern() {
		System.out.println("ich bin ein Karpfen blubb im "+ID);
	}
}