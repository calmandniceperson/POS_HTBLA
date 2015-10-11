package poly3_varargs;

public class Statistik {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Statistik s = new Statistik();
		System.out.println("1 Parameter:");
		s.tuWas("1");
		System.out.println("\n4 Parameter:");
		s.tuWas("1", "5", "3", "25");
		System.out.println("\n0 Parameter (s mit Laenge 0):");
		s.tuWas();
	}
	
	/*
	 * 1. Aufruf: tuWas("1"); --> s -> "1"
	 * 2. Aufruf: tuWas("1", "2", "3"); --> s[] der Laenge 3 mit content 1,2,3
	 * 
	 * Varargs ermoeglichen es, hier beliebig viele Strings einzufuegen.
	 * 1, 15, gar keine, etc. 
	 */
	public void tuWas(String ... s) {
		int sum = 0;
		for(String ele : s) {
			sum += Integer.parseInt(ele);
		}
		if(s.length > 0) {
			System.out.println(sum / s.length);
		}
	}
}
