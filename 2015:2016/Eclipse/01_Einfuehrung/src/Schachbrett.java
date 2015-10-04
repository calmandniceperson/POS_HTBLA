public class Schachbrett {
  public static void main(String[]args){
    for(int i = 1; i <= 8; i++){
      for(int j = 0; j <= 7; j++){
        int out = i+j;
        if((out + 1) > 9) {
          System.out.print(out+" ");
        } else {
          System.out.print(out+"  ");
        }
      }
      System.out.println();
    }
  }
}
