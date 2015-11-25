import java.io.ByteArrayInputStream;
import java.io.CharArrayReader;
import java.io.FileWriter;
import java.io.IOException;
import java.io.StringWriter;

public class KopiereBytesV2 {
	// Aufgabe2: 
	// Erstellen Sie die Klasse KopiereBytesV2 indem 
	// Sie andere Streamklassen (CharArrayReader, StringWriter, 
	// ByteArrayInputStream etc.)verwenden. Machen Sie sich mit 
	// der Funktionalität vertraut.

	public static void main(String[] args) throws IOException {
		//
		//
		// CharArrayReader
		//
		System.out.println("CharArrayReader:");
		CharArrayReader r = null;
		String text = "hello";
		char[] cArray = text.toCharArray();
		char[] newCArray = new char[5];
		int newCIndex = 0;

		try {
			r = new CharArrayReader(cArray);
			int c /*character*/;
			while((c = r.read()) != -1) {
				newCArray[newCIndex] = (char) c;
				newCIndex++;
			}
			System.out.println(newCArray);
		} finally {
			if(r != null) {
				r.close();
			}
		}
		
		//
		//
		// StringWriter
		//
		System.out.println("\nStringWriter:");
		String text1 = "World";
		StringWriter writer = new StringWriter();
		writer.write(text);
		System.out.println(writer.toString());
		writer.append('c');
		System.out.println(writer.toString());
		writer.write(text1);
		System.out.println(writer.toString());
		writer.append(" " + text);
		System.out.println(writer.toString());
		
		FileWriter fw = null;
		
		try{
			fw = new FileWriter("test.txt");
			fw.write(writer.toString());
		} finally  {
			if(fw != null) {
				fw.close();
			}
			if(writer != null) {
				writer.close();
			}
		}
		
		//
		//
		// ByteArrayInputStream
		//
		System.out.println("\nByteArrayInputStream:");
		String ts = "Test string";
		byte[] bArray = ts.getBytes();
		ByteArrayInputStream bais = new ByteArrayInputStream(bArray);
		System.out.println(bais.available());
		while(bais.available() > 0) {
			System.out.println(bais.read());
		}
		bais.close();
	}
}