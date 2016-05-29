class SelectionSort {
    public static int [] field = {7, 3, 4, 5, 3, 8, 1};

    public static void main(String[] args) {
        out(field);
        sort(field);
        out(field);
    }

    private static void sort(int[] f) {
        int min, temp;
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
            }
        }
    }

    private static void out(int[] f) {
        for (int i = 0; i < f.length; i++) {
            System.out.print(f[i] + " ");
        }
        System.out.println();
    }
}
