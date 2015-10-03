package meinhandykonstruktor;

public class MeinHandy {
	private int aufloesungHorizontal;
	private int aufloesungVertikal;
	private String modellBezeichnung;
	private int speicher;
	private int ramSpeicher;
	
	public MeinHandy(int aufloesungHorizontal, int aufloesungVertikal, String modellBezeichnung, int speicher,
			int ramSpeicher) {
		this.aufloesungHorizontal = aufloesungHorizontal;
		this.aufloesungVertikal = aufloesungVertikal;
		this.modellBezeichnung = modellBezeichnung;
		this.speicher = speicher;
		this.ramSpeicher = ramSpeicher;
	}

	public int getAufloesungHorizontal() {
		return aufloesungHorizontal;
	}

	public void setAufloesungHorizontal(int aufloesungHorizontal) {
		this.aufloesungHorizontal = aufloesungHorizontal;
	}

	public int getAufloesungVertikal() {
		return aufloesungVertikal;
	}

	public void setAufloesungVertikal(int aufloesungVertikal) {
		this.aufloesungVertikal = aufloesungVertikal;
	}

	public String getModellBezeichnung() {
		return modellBezeichnung;
	}

	public void setModellBezeichnung(String modellBezeichnung) {
		this.modellBezeichnung = modellBezeichnung;
	}

	public int getSpeicher() {
		return speicher;
	}

	public void setSpeicher(int speicher) {
		this.speicher = speicher;
	}

	public int getRamSpeicher() {
		return ramSpeicher;
	}

	public void setRamSpeicher(int ramSpeicher) {
		this.ramSpeicher = ramSpeicher;
	}
}
