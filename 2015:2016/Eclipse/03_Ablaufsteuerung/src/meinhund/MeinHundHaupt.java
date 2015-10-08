package meinhund;

public class MeinHundHaupt {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		MeinHund h1 = new MeinHund("Bello", "Deutscher Schaeferhund", 5, "hellbraun");
		System.out.println("Name: " + h1.getName() +
				"\nRasse: " + h1.getRasse() +
				"\nAlter:" + h1.getAlter() + 
				"\nFellfarbe: " + h1.getFellfarbe());
	}

}
