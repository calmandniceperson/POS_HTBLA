// use the io library from the
// standard library
use std::io;

fn main() {
    // println! is a macro
    println!("Guess the number!");
    println!("Please input your guess: ");

    // let creates a new binding
    //
    // mut makes the binding mutable
    // http://doc.rust-lang.org/book/mutability.html
    // a binding being mutable means you're allowed
    // to change what it points to
    // Bindings are immutable by default
    //
    // String is a string type, provided by the standard library.
    // A String is a growable, UTF-8 encoded bit of text.
    // ::new() uses :: because this is an 'associated function'
    // of a particular type
    // It's associated with String itself, rather than a particular
    // instance of String --> most languages call it a static method
    // new() creates a new, empty string. Many types provide a new()
    // function to make a new value of some kind
    let mut guess = String::new();

    // Calling an associated function stdin() of the io library
    // std::io::stdin() is also possible
    // stdin() returns a handle to the standard input
    // for the terminal --> std::io::Stdin
    //
    // std::io::Stdin's read_line(&self, buf: &mut String)
    // is a function (like an associated function, but only available
    // on a particular instance of a type, rather than the type itself)
    // read_line() doesn't take String as an argument, it takes &mut String,
    // which is a reference. References allow to have multiple references to
    // one piece of data, which can reduce copying.
    // References are, like let bindings, immutable by default, which is why
    // we need to write &mut guess, rather than &guess
    // Why does read_line() take a mutable reference to a string?
    // Its job is to take what the user types into standard input,
    // and place that into a string. In order to add the input
    // to guess, it needs to be mutable.
    // Not only does read_line() take &mut String as an argument,
    // it also returns an io::Result.
    // Result has a method called except() defined
    // that takes a value it's called on, and if it isn't a
    // successful one, it panic!s with the message we passed.
    // panic! will make the program crash.
    io::stdin().read_line(&mut guess)
        .expect("Failed to read line");

    // {} is a placeholder.
    // We can also pass multiple arguments like:
    // println!("x and y: {} and {}", x, y);
    println!("You guessed: {}", guess);
}
