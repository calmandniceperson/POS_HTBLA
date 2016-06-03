class SelectionSort {
    public static int [] field = {7, 3, 4, 5, 3, 8, 1};

    public static void main(String[] args) {
        //out(field);
        //sort(field);
        //out(field);

        //out(create(0, 10));
        //out(create(1, 10));
        //out(create(2, 10));
        
        //sort(create(0, 10));
        //sort(create(1, 10));
        //sort(create(2, 10));
        
        int best = 0, worst = 0, avg = 0;

        for (int i = 0; i < 200; i++) {
            int [] bestCase = create(0, 10);
            int [] worstCase = create(1, 10);
            int [] avgCase = create(2, 10);

            //out(bestCase);
            best += sort(bestCase);

            //out(worstCase);
            worst += sort(worstCase);

            //out(avgCase);
            avg += sort(avgCase);
        }

        // Generate analysis table
        System.out.println("Avg. best: " + best/200);
        System.out.println("Avg. worst: " + worst/200);
        System.out.println("Avg. avg.: " + avg/200);
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
