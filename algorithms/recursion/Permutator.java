import java.util.Arrays;

class Permutator {
    private static int[] feld = {1, 2, 3};
    private static int count = 0, permCallCount = 0;

    private static void perm(int begin) {
        permCallCount++;
        if(begin >= feld.length) {
            System.out.println(Arrays.toString(feld));
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
        perm(0); 
        System.out.println(count + " possible combinations.");
        System.out.println("\nperm() called " + permCallCount + " times.");
    }
}
