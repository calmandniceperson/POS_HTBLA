package poly1_classes;

public class PolyHaupt {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		PolyPerson pp0 = new PolyPerson();
		PolyPerson pp1 = new PolyVater();
		PolyPerson pp2 = new PolyKind();
		PolyPerson pp3 = new PolyEnkel();
		System.out.println("Person sagt:");
		pp0.sagMeinung();
		System.out.println("\nVater sagt:");
		pp1.sagMeinung();
		System.out.println("\nKind sagt:");
		pp2.sagMeinung();
		System.out.println("\nEnkel sagt:");
		pp3.sagMeinung();
		System.out.println("\nEnde der Vorstellung, jetzt experimentieren wir");
		pp0 = pp2;
		pp0.sagMeinung();
		
		System.out.println("\nUm ein Objekt von PolyPerson in ein Objekt der Klasse");
		System.out.println("PolyEnkel muss man typecasten, da zwar nicht jede Person");
		System.out.println("ein Enkel ist, aber alle Enkel eine Person. Somit hat jeder Enkel");
		System.out.println("auf jeden Fall die Eigenschaften der Person, aber nicht jede");
		System.out.println("Person die Eigenschaften eines Enkels.");
		PolyEnkel ppx;
		ppx = (PolyEnkel)pp3;
		ppx.sagMeinung();
	}

}
