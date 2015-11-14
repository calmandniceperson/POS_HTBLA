// Michael Köppl

package koeppl;

import java.text.DecimalFormat;

public class Strecke {
	private Punkt p1, p2;
	
	Strecke(Punkt p1, Punkt p2) {
		this.p1 = p1;
		this.p2 = p2;
	}
	
	public double length() {
		// a^2 + b^2 = c^2
		// return c^2
		return Math.sqrt((p2.getX() - p1.getX()^2) + (p2.getY() - p1.getY()^2));
	}
	
	public String toString() {
		return "Strecke [p1=" + p1.toString() + ", p2=" + p2.toString() + "], Länge: " + new DecimalFormat("#.00").format(this.length());
	}
}
