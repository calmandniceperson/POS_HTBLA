import java.util.Arrays;

class ChessCombinations {
    private static int[] feld = {1, 2, 3, 4, 5, 6, 7, 8};
    private static String[] alph = {"A", "B", "C", "D", "E", "F", "G", "H"};
    private static int count = 0;

    private static void out() {
        for(int i = 0; i <= feld.length -1; i++) {
            System.out.print((i+1) + ". queen:" + alph[i] + feld[i] + " ");
        }
        System.out.println();
    }

    private static void perm(int begin) {
        if(begin >= feld.length) {
            //System.out.println(Arrays.toString(feld));
            out();
            count++;
            return;
        }
        perm(begin+1);

        int temp;
        for(int i = begin+1; i < feld.length; i++) {
            temp = feld[begin];
            feld[begin] = feld[i];
            feld[i] = temp;
            perm(begin+1);
            
            // Optimisation
            //temp = feld[i];
            feld[i] = feld[begin];
            feld[begin] = temp;
        }
    }

    public static void main(String[] args) {
        //long startTime = System.currentTimeMillis();
        perm(0);
        //long endTime = System.currentTimeMillis();
        System.out.println("There are " + count + 
                " possible combinations for how the queens may be organised.");
        //System.out.println("The calculation took " + (endTime-startTime) + "ms");
    }
}
