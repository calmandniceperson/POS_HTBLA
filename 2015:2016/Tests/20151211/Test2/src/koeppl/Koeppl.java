// MICHAEL KOEPPL
// 4AHIF
// 2. TEST

package koeppl;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.util.ArrayList;
import java.util.Collections;

public class Koeppl {

	public static void main(String[] args) throws IOException {
		BufferedReader br = new BufferedReader(new FileReader("./src/AngabeTest2.txt"));
		BufferedWriter bw = new BufferedWriter(new FileWriter("./src/Ausgabe.txt"));
		ArrayList<String> linesList = new ArrayList<>();
		
	    try {
	        String s;
	        while((s = br.readLine()) != null) {
	        	linesList.add(s);
	        }
	        Collections.shuffle(linesList);
	        for(String se: linesList) {
	        	System.out.println(se);
	        	bw.write(se);
	        	bw.newLine();
	        }
	    } catch (Exception ex) {
	    	ex.printStackTrace();
	    } finally {
	    	if(br != null ) {
	    		br.close();
	    	}
	    	if(bw != null) {
	    		bw.close();
	    	}
	    }
 	}

}
