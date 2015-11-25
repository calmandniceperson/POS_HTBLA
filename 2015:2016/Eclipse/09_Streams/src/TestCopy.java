import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;

public class TestCopy {

	public static void main(String[] args) throws IOException {
		FileInputStream in = null;
		FileOutputStream out = null;
		File source = new File(args[0]);
		File dest = new File(args[1]);
		int byteCount = 0;
		String defaultString = "Hello, World!";
		char[] defaultText = defaultString.toCharArray();
		try{
			if(!source.exists()) {
				// create new file source.txt
				source.createNewFile();
				// write the default string into source.txt
				FileOutputStream dfTextStream = new FileOutputStream(args[0]);
				for(char t:defaultText) {
					dfTextStream.write(t);
				}
				dfTextStream.close();
			}
			if(!dest.exists()) {
				dest.createNewFile();
			}
			in = new FileInputStream(args[0]);
			out = new FileOutputStream(args[1]);
			int c;
			while((c = in.read()) != -1) {
				out.write(c);
				byteCount++;
			}
		} catch (IOException ex) {
			ex.printStackTrace();
		} finally {
			if(in != null) {
				in.close(); // main throws IOException
			}
			if(out != null) {
				out.close();
			}
		}
		System.out.println(byteCount + " Bytes copied");
	}

}
