fn main() {
    let (x, y) = (2, 5);

    print_number(x);
    print_sum(x, y);
    println!("{}", add_one(27));
}

fn print_number(x: i32) {
    println!("x is: {}", x);
}

fn print_sum(x: i32, y: i32) {
    println!("x + y = {}", x + y);
}

fn add_one(x: i32) -> i32 {
    // last line of a function determines
    // what it returns
    x + 1

    // early returns also work
    // with keyword return.
    // Using a return as the last line of
    // a function works, but is considered
    // poor style.
}
