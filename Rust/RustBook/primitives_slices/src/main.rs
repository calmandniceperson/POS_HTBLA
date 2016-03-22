fn main() {
    // Slices are references to (or views into) other data structures
    // They are useful for allowing safe, efficient access to a portion
    // of an array without copying.
    // For example, you might want to reference only one line of a file
    // read into memory. By nature, a slice is not created directly, but
    // from an existing variable binding. Slices have a defined length,
    // can be mutable or immutable.

    // You can use a combo of & and [] to create a slice from various
    // things. The & indicates that slices are similar to references
    // The [], with a range, let you define the length of the slice
    let a = [0, 1, 2, 3, 4];
    let complete = &a[..]; // slice containing all elements in a
    let middle = &a[1..4]; // slice containing elements 1, 2 and 3
    println!("{}", complete.len());
    println!("{}", middle.len());
}
