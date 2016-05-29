public class InsertionSort {

    public static int [] feld = {4, 7, 1, 7, 1, 5, 3, 6, 8, 2};

    public static void main(String[] args) {
        System.out.println("Insertion sorting algorithm");   

        out(feld);
        insort(feld);
        out(feld);
    }

    private static void insort(int[] f) {
        int j, temp;
        for (int i = 2; i < f.length; i++) {
            j = i - 1;
            temp = f[i]; // aktuelles Element "retten"

            while (j > 0 && f[j] > temp) { // Elemente vorhanden? Vorelement kleiner?
                f[j + 1] = f[j]; // verheriges Element um eine Stelle weiterschieben
                j--;
            }
            f[j + 1] = temp;
        }
    }

    private static void out(int[] f) {
        System.out.println();
        for (int i = 1; i < f.length; i++) {
            System.out.println(feld[i] + " ");
        }
    }

    // A(min) = n - 1 = O(n)
    // Rechenzeit steigt mit Anzahl der Zahlen linear mit an
    // A(max) = sum(n, i=2) (i - 1)
}
