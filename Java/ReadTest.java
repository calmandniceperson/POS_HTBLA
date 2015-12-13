// inet
// written with emacs

import java.io.FileReader;
import java.io.FileWriter;
import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.IOException;

public class ReadTest {
    public static void main(String[] args)  throws IOException {
        BufferedReader br = null;
        BufferedWriter bw = null;
        try {
            br = new BufferedReader(new FileReader("test.txt"));
            bw = new BufferedWriter(new FileWriter("output.txt"));
            String txt;
            while((txt = br.readLine()) != null) {
                System.out.println(txt);
                bw.write(txt+"\n");
            }
        } catch (Exception ex) {
            ex.printStackTrace();
        } finally {
            if(br != null) {
                br.close();
            }
            if(bw != null) {
                bw.close();
            }
        }
    }
}
