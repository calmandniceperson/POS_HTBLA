class GaussscheSummenFormel {
    public static void main(String[] args) {
        System.out.println(calc(10));
        System.out.println(calcRec(10, 0));
    }

    private static int calcRec(int base, int n) {
        if(n > base) {
            return 0;
        }
        return n += calcRec(base, n+1);
    }

    private static int calc(int n) {
        if(n < 0) {
            return 0;
        }
        int res = (n*(n+1))/2;
        return res;
    }
}
