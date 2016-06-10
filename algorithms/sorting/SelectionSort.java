class SelectionSort {
    public static int [] field = {7, 3, 4, 5, 3, 8, 1};

    public static void main(String[] args) {
        if(args.length < 1) {
            return;
        }
        
        int count = 0;

        int[] sort_arr = create(0, Integer.parseInt(args[0]));
        int[] back_arr = create(1, Integer.parseInt(args[0]));
        int[] rand_arr = create(2, Integer.parseInt(args[0]));

        count += sort(sort_arr);
        System.out.println("Sorted sort count: " + count);
        count = 0;

        count += sort(back_arr);
        System.out.println("Backwards sort count: " + count);
        count = 0;

        //for(int i = 0; i <= 9999; i++) {
            int[] clone = rand_arr;
            count += sort(clone);
        //}
        System.out.println("Random sort count: " + count);
    }

    private static int sort(int[] f) {
        int min, temp, count = 0;
        for (int i = 0; i < f.length; i++) {
            min = i;
            for (int j = i + 1; j < f.length; j++) {
                if (f[j] < f[min]) {
                    min = j;
                }
            }
            if (min != i) {
                temp = f[i];
                f[i] = f[min];
                f[min] = temp;
                count++;
            }
        }
        //System.out.println("Number of switches: " + count);
        return count;
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

    private static void out(int[] f) {
        for (int i = 0; i < f.length; i++) {
            System.out.print(f[i] + " ");
        }
        System.out.println();
    }
}

// Complexity: O(n^2)
// 
// Best case (everything already sorted): 0 actions taken
// Worst case (not a single number in the correct positions): size/2 actions taken
// Average case (random): sum(i=0; n)
