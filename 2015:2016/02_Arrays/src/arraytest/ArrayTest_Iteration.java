package arraytest;

public class ArrayTest_Iteration {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		char[] alph = Felder.erzeugeCharFeld();
		int i = 0;
		while(i != alph.length) {
			System.out.println(alph[i++]);
		}
	}

}
