package beispiel_interface;

public class Forelle extends GrundFisch implements IFisch {
	public Forelle(int groessecm, int gewichtkg) {
		farbe = "grau";
		anzahlschuppen = 1000;
		this.grössecm = groessecm;
		this.gewichtkg = gewichtkg;
	}

	@Override
	public void blubbern() {
		System.out.println("ich bin eine Forelle blubb im " + ID);
	}
}
