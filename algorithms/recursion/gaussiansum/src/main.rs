fn calc_rec(base: i32, n: i32) -> i32 {
    if n > base {
        return 0;
    }
    return n + calc_rec(base, n+1);
}

fn calc(n: i32) -> i32 {
    if n < 0 {
        return 0;
    }
    return (n*(n+1))/2;
}

fn main() {
    println!("{}", calc(20));
    println!("{}", calc_rec(20, 0));
}
