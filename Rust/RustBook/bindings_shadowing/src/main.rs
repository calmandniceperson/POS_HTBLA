fn main() {
    let x: i32 = 8;

    {
        println!("{}", x); // prints 8
        let x = 12;
        println!("{}", x); // prints 12
    }

    println!("{}", x); // prints 8
    let x = 42;
    println!("{}", x); // prints 42

    // It is also possible to change the mutability of a binding
    let mut x2: i32 = 1;
    x2 = 7;
    let x2 = x2; // x is not immutable and bound to value 7

    let y = 4;
    let y = "I can also be bound to text!"; // y is now of a different type
}
