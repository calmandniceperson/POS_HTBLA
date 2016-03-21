fn main() {
    let x = 1;
    let c = 'c';

    // There’s one pitfall with patterns: like anything
    // that introduces a new binding, they introduce
    // shadowing. For example:
    match c {
        x => println!("x: {} c: {}", x, c),
    }

    println!("x: {}", x);

    // x => matches the pattern and introduces a new binding
    // named x. This new binding is in scope for the match
    // arm and takes on the value of c. Notice that the value
    // of x outside the scope of the match has no bearing on
    // the value of x within it. Because we already have a
    // binding named x, this new x shadows it.
}
