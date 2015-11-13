// Michael Köppl

package koeppl;

public class Punkt {
	private int x, y;
	
	Punkt(int x, int y) {
		this.x = x;
		this.y = y;
	}
	
	public String toString() {
		return "Punkt [x=" + x + ", y=" + y + "]";
	}
	
	public int getX() {
		return x;
	}
	
	public int getY() {
		return y;
	}
	
}
