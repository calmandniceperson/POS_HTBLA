package beispiel_interface;

public class AquariumHaupt {
	public static void main(String[] args) {
		GrundFisch aq[] = { new Karpfen(40, 4), new Forelle(20, 2), new Karpfen(10, 1) };
		for (GrundFisch g : aq)
			g.blubbern();
		
		// geht auch
		// polymorphie ist auch mit interfaces moeglich
		IFisch aqI[] = { new Karpfen(40, 4), new Forelle(20, 2), new Karpfen(10, 1) };
		for (IFisch g : aqI)
			g.blubbern();
	}
}