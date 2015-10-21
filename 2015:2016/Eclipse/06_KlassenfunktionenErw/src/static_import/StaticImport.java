package static_import;
//import static java.lang.Math.*;
import static java.lang.Math.sqrt; /* um den Namensraum nicht zu verkleinern */

public class StaticImport {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		double w = /*Math.*/sqrt(16.0);
		System.out.println("Wurzel aus 16 ist: " + w);
	}

}
