public class TannenBaum {
  public static void main(String[]args) {
    if(args.length > 0) {
      int c = Integer.parseInt(args[0]);
      int sc = 1;
      for(int i = 0; i < c; i++) {
        for(int j = 0; j < (c-i); j++) {
          System.out.print(" ");
        }
        for(int j = 0; j < sc; j++) {
          System.out.print("*");
        }
        sc = sc + 2;
        System.out.println();
      }
      for(int i = 0; i < (sc/2); i++) {
        System.out.print(" ");
      }
      System.out.println("I");
    } else {
      System.out.println("Zu wenige Argumente.");
    }
  }
}
