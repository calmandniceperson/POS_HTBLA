// Michael Köppl

package koeppl;

public class StreckenTest {
	public static Strecke[] strecken = {
			new Strecke(new Punkt(3,5), new Punkt(7,6)),
			new Strecke(new Punkt(3,6), new Punkt(8,7)),
			new Strecke(new Punkt(4,7), new Punkt(9,7)),
			new Strecke(new Punkt(10,11), new Punkt(12,12))
	};
	
	public static void main(String[] args) {
		Strecke smallest = strecken[0];
		for(Strecke s: strecken) {
			System.out.println(s.toString());
			if (s.length() < smallest.length()) {
				smallest = s;
			}
		}
		
		System.out.println("Kuerzeste Strecke: " + smallest.toString());
	}

}
