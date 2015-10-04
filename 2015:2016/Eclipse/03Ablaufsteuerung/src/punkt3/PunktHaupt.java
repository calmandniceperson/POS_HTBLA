package punkt3;

public class PunktHaupt {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Punkt p = new Punkt(2, 6);
		Punkt p2 = new Punkt(2,3);
		System.out.println("P1\nx: " + p.getX() + "\ny: " + p.getY());
		System.out.println("\nP2\nx: " + p2.getX() + "\ny: " + p2.getY());
		System.out.println("\nAbstand: " + p.getAbstand(p2));
	}
}
