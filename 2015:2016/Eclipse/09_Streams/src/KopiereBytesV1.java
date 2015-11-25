import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;

public class KopiereBytesV1 {
	public static void main(String[] args) throws IOException {
		FileInputStream in = null;
		FileOutputStream out = null;
		int count = 0, lineCount = 1;
		try {
			in = new FileInputStream("Streamtestin.txt");
			out = new FileOutputStream("Streamtestout.txt");
			int c;
			while ((c = in.read()) != -1) { //lese ein Byte und lege es in c ab
				if(c == '\n') 
					lineCount ++;
				c += lineCount; // weil die Zeichen einzeln eingelesen werden, koennen sie auch so manipuliert werden --> kryptographie
				out.write(c);
				count++;
			}
		} finally {
			if (in != null) { // sicherheitsmassnahme gegen NullPointerException
				in.close();
			}
			if (out != null) {
				out.close();
			}
		}
		System.out.println("Zahl der Bytes " + count);
	}
}