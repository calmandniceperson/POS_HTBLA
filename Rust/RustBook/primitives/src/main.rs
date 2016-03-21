fn main() {
    // BOOLEAN
    let x: bool = false;

    // NUMERIC TYPES
    //
    // --- fixed length ---
    // i8    --> signed 8 bit integer
    // i16   --> signed 16 bit integer
    // i32   --> signed 32 bit integer
    // i64   --> signed 64 bit integer
    // u8    --> unsigned 8 bit integer
    // u16   --> unsigned 16 bit integer
    // u32   --> unsigned 32 bit integer
    // u64   --> unsigned 64 bit integer
    // f32   --> 32 bit floating point number
    // f64   --> 64 bit floating point number
    // --- !fixed length -->
    //
    // isize --> signed variable length (depends on underlying machine)
    // usize --> unsigned variable length
    let y: i8 = 2;

    // ARRAYS
    let a = [1, 2, 3]; // a: [i32, 3]
    let mut m = [1, 2, 3]; // m: [i32, 3]

    // shorthand for initializing each element of an array
    // to the same value
    let a = [0; 20]; // each element of a is 0    a: [i32, 20]
    println!("a has {} elements", a.len());

    let names = ["John", "Karl", "Niko"]; // names: [&str; 3]
    println!("The second name is: {}", names[1]);
}
