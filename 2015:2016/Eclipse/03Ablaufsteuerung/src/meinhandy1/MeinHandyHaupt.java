package meinhandy1;

public class MeinHandyHaupt {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		MeinHandy h1 = new MeinHandy();
		h1.aufloesungHorizontal = 1440;
		h1.aufloesungVertikal = 2560;
		h1.modellBezeichnung = "Nexus 6";
		h1.ramSpeicher = 3;
		h1.speicher = 64;
		
		MeinHandy h2 = new MeinHandy();
		h2.aufloesungHorizontal = 1080;
		h2.aufloesungVertikal = 1920;
		h2.modellBezeichnung = "HTC One M8";
		h2.ramSpeicher = 2;
		h2.speicher = 32;
		
		System.out.println("Handy1:\n" + 
				"Aufloesung:" + h1.aufloesungVertikal + "x" + h1.aufloesungHorizontal +
				"\nBezeichnung: " + h1.modellBezeichnung +
				"\nRAM: " + h1.ramSpeicher + "GB" +
				"\nSpeicher: " + h1.speicher + "GB");
		System.out.println("\nHandy2:\n" + 
				"Aufloesung:" + h2.aufloesungVertikal + "x" + h2.aufloesungHorizontal +
				"\nBezeichnung: " + h2.modellBezeichnung +
				"\nRAM: " + h2.ramSpeicher + "GB" +
				"\nSpeicher: " + h2.speicher + "GB");
	}

}
