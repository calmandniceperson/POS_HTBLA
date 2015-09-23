import java.util.*;

public class Zahlenraten {
  public static void main(String[]args) {
    Scanner s = new Scanner(System.in);
    Random r = new Random();
    int repeat = 2, guess, rnum;
    do {
      // header
      System.out.println("\t=====ZAHLENRATEN=====");
      System.out.println("Sie muessen eine zufaellige Zahl\nzwischen 1 und 1000 erraten");
      System.out.println("Sie haben 10 Versuche.");
      // generate random number
      rnum = r.nextInt(1000 - 1) + 0;
      System.out.println(rnum);
      for(int i = 1; i <= 10; i++) {
        System.out.print(i + ". Versuch: ");
        guess = s.nextInt();
        if(guess == rnum) {
          System.out.println("Glueckwunsch! Sie haben richtig geraten!");
          break;
        } else if(guess > rnum) {
          System.out.println("Ihr Wert zu hoch. Sie haben noch " + (10-i) + " Versuche.");
        } else if(guess < rnum) {
          System.out.println("Ihr Wert zu niedrig. Sie haben noch " + (10-i) + " Versuche.");
        }
      }
      // repeat?
      System.out.print("Wollen Sie neu starten? (Ja:1/Nein:2): ");
      try {
        repeat = s.nextInt();
      } catch(InputMismatchException ex) {
        // avoid output
      }
    } while(repeat == 1);
  }
}
