// inet
// written with emacs

import java.io.FileReader;
import java.io.BufferedReader;
import java.io.IOException;

public class ReadTest {
    public static void main(String[] args)  throws IOException {
        BufferedReader br = null;
        try {
            br = new BufferedReader(new FileReader("test.txt"));
            String txt;
            while((txt = br.readLine()) != null) {
                System.out.println(txt);
            }
        } catch (Exception ex) {
            ex.printStackTrace();
        } finally {
            if(br != null) {
                br.close();
            }
        }
    }
}
