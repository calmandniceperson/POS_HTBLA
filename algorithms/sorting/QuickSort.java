public class QuickSort {
    
    private static int counta = 0;

    public static void main(String[] args) {
        //int[] f_avg = {-1, 4, 7, 1, 5, 6, 3, 8, 2, 9};//create(2, 50);

        if(args.length < 1) {
            return;
        }

        /*for(int i = 0; i <= 2; i++) {
            int[] arr = create(i, Integer.parseInt(args[0]));
            count += quicksort(arr, 1, arr.length - 1);
        }*/
        int[] sort_arr = create(0, Integer.parseInt(args[0]));
        quicksort(sort_arr, 0, sort_arr.length - 1);
        System.out.println("Sorted sort count: " + counta);
        counta = 0;

        int[] back_arr = create(1, Integer.parseInt(args[0]));
        quicksort(back_arr, 0, back_arr.length - 1);
        System.out.println("Backwards sort count: " + counta);
        counta = 0;

        int[] rand_arr = create(2, Integer.parseInt(args[0]));
        //for (int i = 0; i <= 9999; i++) {
        int[] copy_arr = rand_arr;
        quicksort(copy_arr, 0, copy_arr.length - 1);
        //}
        System.out.println("Random sort count: " + counta);
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



    private static int quicksort(int[] feld, int ug, int og) {
        int count = 0;
        // Choose pivot, here: element in the middle

        if (ug >= og) return -1;

        swap(feld, ug, (og+ug)/2);

        int last = ug;

        for(int i = ug+1; i <= og; i++) {
            if (feld[i] <= feld[ug]) {
                swap(feld, ++last /*stores it in the var, too*/, i);
            }
        }
        swap(feld, ug, last);
        quicksort(feld, ug, last-1);
        quicksort(feld, last+1, og);
        return count;
    }

    private static void swap(int[] feld, int a, int b) {
        int temp;
        temp = feld[a];
        feld[a] = feld[b];
        feld[b] = temp;
        counta++;
    }

    private static void out(int[] f) {
        for (int i = 0; i < f.length; i++) {
            System.out.print(f[i] + " ");
        }
        System.out.println();
    }

}
