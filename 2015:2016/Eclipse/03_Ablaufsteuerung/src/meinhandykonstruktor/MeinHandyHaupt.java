package meinhandykonstruktor;

public class MeinHandyHaupt {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		MeinHandy h1 = new MeinHandy(1440, 1440, "Nexus 6", 3, 64);
		System.out.println(h1.getModellBezeichnung() + ":\n" + 
				"Aufloesung:" + h1.getAufloesungVertikal() + "x" + h1.getAufloesungHorizontal() +
				"\nRAM: " + h1.getRamSpeicher() + "GB" +
				"\nSpeicher: " + h1.getSpeicher() + "GB");
		MeinHandy h2 = new MeinHandy(1080, 1920, "HTC One M8", 2, 32);
		h2.setAufloesungHorizontal(1080);
		h2.setAufloesungVertikal(1920);
		h2.setModellBezeichnung("HTC One M8");
		h2.setRamSpeicher(2);
		h2.setSpeicher(32);
		System.out.println("\n" + h2.getModellBezeichnung() + ":\n" + 
				"Aufloesung:" + h2.getAufloesungVertikal() + "x" + h2.getAufloesungHorizontal() +
				"\nRAM: " + h2.getRamSpeicher() + "GB" +
				"\nSpeicher: " + h2.getSpeicher() + "GB");
	}

}
