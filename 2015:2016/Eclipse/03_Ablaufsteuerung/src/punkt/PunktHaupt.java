package punkt;

public class PunktHaupt {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Punkt p1 = new Punkt(2, 3);
		Punkt p2 = new Punkt(2,4);
		System.out.println(getAbstand(p1, p2));
	}
	public static int getAbstand(Punkt p1, Punkt p2) {
		if(p1.getX() > p2.getX()) {
			if(p1.getY() > p2.getY()) {
				return (p1.getX() - p2.getX()) + (p1.getY() - p2.getY());
			} else if(p1.getY() < p2.getY()) {
				return (p1.getX() - p2.getX()) + (p2.getY() - p1.getY());
			} else {
				return (p1.getX() - p2.getX()) + 0;
			}
		} else if(p1.getX() < p2.getX()) {
			if(p1.getY() > p2.getY()) {
				return (p2.getX() - p1.getX()) + (p1.getY() - p2.getY());
			} else if(p1.getY() < p2.getY()) {
				return (p2.getX() - p1.getX()) + (p2.getY() - p1.getY());
			} else {
				return (p2.getX() - p1.getX()) + 0;
			}
		} else if(p1.getX() == p2.getX()) {
			if(p1.getY() > p2.getY()) {
				return 0 + (p1.getY() - p2.getY());
			} else if(p1.getY() < p2.getY()) {
				return 0 + (p2.getY() - p1.getY());
			} else {
				return 0 + 0;
			}
		}
		return 0;
	}
}
