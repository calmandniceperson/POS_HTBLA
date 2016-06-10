public class SchnittPunkt {
    static final double EPSILON = 0.000000001; 
    static int count = 0;

    public static void main(String[] args) {
        System.out.println("Nullstelle bei Funktion (x^2)+7x+20: " + nullStelle(0, 100));    
        System.out.println("Rekursive Aufrufe: " + count);
    }

    private static double funktion(double x) {
        return (x*x+7*x-20);
    }

    private static double funktion4G(double x) {
        return (x*x*x*x-7*x*x*x+4*x*x+2*x-20);
    }

    private static double nullStelle(double a, double b) {
        count++;
        double m;
        m = (a+b)/2;
        if ((b-a) < 2*EPSILON) return m;
        if (funktion(m) < 0) {
            return nullStelle(m, b);
        } else {
            return nullStelle(a, m);
        }
    }
}
