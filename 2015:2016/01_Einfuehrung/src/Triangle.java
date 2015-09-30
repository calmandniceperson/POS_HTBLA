import java.util.Scanner;

public class Triangle {
  public static void main(String[]args){
    System.out.println("Hallo 4AHIF - Eingabedemo");
    Scanner s = new Scanner(System.in /*Tastatur buffer*/);
    System.out.print("Geben Sie ein: ");
    int eingabe = s.nextInt(); // blocking method call until ENTER is pressed
    // nextLine() returns a string instead of int
    System.out.println("Ihr Text: " + eingabe);

    if(eingabe <= 60) {
      for(int i = 0; i < eingabe; i++){
        for(int j = 0; j <= i; j++){
          System.out.print(".");
        }
        System.out.print("\n");
      }
    } else {
      System.out.println("Sie haben einen zu hohen Wert eingegeben.");
    }
    s.close();
  }
}
