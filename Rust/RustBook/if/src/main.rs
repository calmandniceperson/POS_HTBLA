fn main() {
    // We can also do this:
    let x = 5;
    let y = if x == 5 {
        10
    } else {
        15
    }; // y: i32

    // which we can (and probably should) write like this:
    let z = 5;
    let a = if z == 5 { 10 } else { 15 }; // z: i32

    println!("{}", y);
    println!("{}", a);
}
