public class InsertionSort {

    //public static int [] feld = {4, 7, 1, 7, 1, 5, 3, 6, 8, 2};

    public static void main(String[] args) {
        System.out.println("Insertion sorting algorithm");   

        /*out(feld);
        insort(feld);
        out(feld);*/

        if(args.length < 1) {
            return;
        }

        int count = 0;

        int[] sort_arr = create(0, Integer.parseInt(args[0]));
        count += insort(sort_arr);
        System.out.println("Sorted sort count: " + count);
        count = 0;

        int[] back_arr = create(1, Integer.parseInt(args[0]));
        count += insort(back_arr);
        System.out.println("Backwards sort count: " + count);
        count = 0;

        int[] rand_arr = create(2, Integer.parseInt(args[0]));
        //for(int i = 0; i <= 9999; i++) {
            int[] clone = rand_arr;
            count += insort(clone);
        //}
        //System.out.println(count);
        System.out.println("Random sort count: " + count);
    }

    private static int insort(int[] f) {
        int j, temp, count = 0;
        for (int i = 2; i < f.length; i++) {
            j = i - 1;
            temp = f[i]; // aktuelles Element "retten"

            while (j > 0 && f[j] > temp) { // Elemente vorhanden? Vorelement kleiner?
                f[j + 1] = f[j]; // verheriges Element um eine Stelle weiterschieben
                j--;
                count++;
            }
            f[j + 1] = temp;
        }
        return count;
    }

    private static void out(int[] f) {
        System.out.println();
        for (int i = 1; i < f.length; i++) {
            System.out.println(f[i] + " ");
        }
    }
    
    private static int[] create(int sMethod, int size) {
        int [] f = new int[size];
        switch (sMethod) {
            case 0: for (int i = 0; i < size; i++) {
                    f[i] = i;
                }; return f;
            case 1: for (int i = 0; i < size; i++) {
                    f[i] = size - i;
                }; return f;
            default: for (int i = 0; i < size; i++) {
                    f[i] = (int)(size*Math.random());
                }; return f;
        }
    }
    // A(min) = n - 1 = O(n)
    // Rechenzeit steigt mit Anzahl der Zahlen linear mit an
    // A(max) = sum(n, i=2) (i - 1)
}
