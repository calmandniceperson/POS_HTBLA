import java.util.*;

public class Statistik {
  public static void main(String[]args) {
    Scanner s = new Scanner(System.in);
    System.out.print("Geben Sie ein: ");
    int eingabe = s.nextInt();

    int numArray[] = new int[10];
    int highest = -1;
    for(int i = 0; i < eingabe; i++) {
      int rand = getZufall();
      numArray[rand]++;
      if(numArray[rand] > highest) {
        highest = numArray[rand];
      }
    }
    if(highest > 50) {
      highest = highest / 50;
    } else {
      highest = 1;
    }
    for(int i = 0; i <= 9; i++) {
      System.out.print(i+":");
      int limit;
      if(numArray[i] != highest) {
        limit = numArray[i]/highest;
      } else {
        limit = highest;
      }
      for(int j = 0; j < limit; j++) {
        if(numArray[i] > 0) {
          System.out.print("X");
        }
      }
      System.out.println();
    }
    System.out.println("Legende: ein X entspricht " + highest + " Treffer(n).");
    s.close();
  }

  static int getZufall() {
    Random r = new Random();
    return r.nextInt(10 - 0) + 0;
  }
}
