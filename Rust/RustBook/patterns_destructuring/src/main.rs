fn main() {
    struct Point {
        x: i32,
        y: i32,
    }

    let origin = Point { x: 0, y: 0 };

    match origin {
        // destructuring
        Point { x, y } => println!("({}, {})", x, y),
    }

    // use : to give a value a different name
    match origin {
        Point { x: x1, y: y1 } => println!("({}, {})", x1, y1),
    }

    // don't have to give every value a name
    // if we only care about some of them
    match origin {
        Point { x, .. } => println!("x is {}", x),
    }

    // ‘destructuring’ behavior works on any compound data type, like tuples or enums.
}
