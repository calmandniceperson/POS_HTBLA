fn main() {
    // A tuple is an ordered list of fixed size
    let x1 = (1, "hello");
    // or
    let x2: (i32, &str) = (1, "hello");

    // You can assign one tuple into another, if they have
    // the same contained types and arity (arity refers to the number
    // of arguments a function or operation takes). Tuples have
    // the same arity when they have the same length.
    let mut x = (1, 2); // x: (i32, i32)
    let y = (2, 3); // y: (i32, i32)
    x = y;

    // You can access the fields in a tuple through destructuring let
    // The left-hand side of a let statement is more powerful than
    // assigning a binding. We can put a pattern on the left-hand
    // side of the let, and if it matches up to the right-hand side,
    // we can assign multiple bindings at once. In this case, let
    // “destructures” or “breaks up” the tuple, and assigns the bits
    // to three bindings.
    let (x, y, z) = (1, 2, 3);
    println!("x is {}", x);

    // Tuple Indexing
    let tuple = (1, 2, 3);
    let zero = tuple.0;
    let one = tuple.1;
    let two = tuple.2;

    println!("{}", zero);
}
