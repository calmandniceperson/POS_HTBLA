package reihenfolgeb;
public class Reihenfolge {
	int dyna = Reihenfolge.get(1);

	static int stata = Reihenfolge.get(2);

	public Reihenfolge() {
		super();
		System.out.println("im default konstruktur");
	}
	
	private static int get(int i) {
		System.out.println("in der methode get " + i);
		return i;
	}

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		new Reihenfolge();
		System.out.println("in der main nach objekt");
	}
	
	static {
		System.out.println("im static block");
	}
	
	{
		System.out.println("Block");
	}

}
