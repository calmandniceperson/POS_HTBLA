package punkt3;

public class Punkt {
	private int x;
	private int y;
	private int limitXMax = 4;
	private int limitXMin = 1;
	private int limitYMax = 4;
	private int limitYMin = 1;
	public Punkt(int x, int y) {
		if(x > limitXMax) {
			System.out.println("Der Punkt befand sich auf der x-Achse ausserhalb des Rechtecks.");
			System.out.println("Er wurde in das Rechteck verschoben.");
			this.x = limitXMax;
		} else if(x < limitXMin) {
			System.out.println("Der Punkt befand sich auf der x-Achse ausserhalb des Rechtecks.");
			System.out.println("Er wurde in das Rechteck verschoben.");
			this.x = limitXMin;
		} else {
			this.x = x;
		}
		
		if(y > limitYMax) {
			System.out.println("Der Punkt befand sich auf der y-Achse ausserhalb des Rechtecks.");
			System.out.println("Er wurde in das Rechteck verschoben.");
			this.y = limitYMax;
		} else if(y < limitYMin) {
			System.out.println("Der Punkt befand sich auf der y-Achse ausserhalb des Rechtecks.");
			System.out.println("Er wurde in das Rechteck verschoben.");
			this.y = limitYMin;
		} else {
			this.y = y;
		}
	}
	public int getX() {
		return x;
	}
	public void setX(int x) {
		this.x = x;
	}
	public int getY() {
		return y;
	}
	public void setY(int y) {
		this.y = y;
	}
	public int getAbstand(Punkt p2) {
		if(this.x > p2.getX()) {
			if(this.y > p2.getY()) {
				return (this.x - p2.getX()) + (this.y - p2.getY());
			} else if(this.y < p2.getY()) {
				return (this.x - p2.getX()) + (p2.getY() - this.y);
			} else {
				return (this.x - p2.getX()) + 0;
			}
		} else if(this.x < p2.getX()) {
			if(this.y > p2.getY()) {
				return (p2.getX() - this.x) + (this.y - p2.getY());
			} else if(this.y < p2.getY()) {
				return (p2.getX() - this.x) + (p2.getY() - this.y);
			} else {
				return (p2.getX() - this.x) + 0;
			}
		} else if(this.x == p2.getX()) {
			if(this.y > p2.getY()) {
				return 0 + (this.y - p2.getY());
			} else if(this.y < p2.getY()) {
				return 0 + (p2.getY() - this.y);
			} else {
				return 0 + 0;
			}
		}
		return 0;
	}
}
