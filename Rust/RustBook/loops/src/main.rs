fn main() {
    // infinite loop
    //loop {
    //    println!("Loop forever!");
    //}

    let mut x = 5;
    let mut done = false;

    while !done {
        x += x - 3;

        println!("{}", x);

        if x % 5 == 0 {
            done = true;
        }
    }

    // for loop
    for x in 0..10 {
        println!("{}", x);
    }

    //for var in expression {
    //    code
    //}

    // enumerate
    for (i, j) in (5..10).enumerate() {
        println!("i = {} and j = {}", i, j);
    }

    //for (linenumber, line) in lines.enumerate() {
    //    println!("{}: {}", linenumber, line);
    //}

    // break; breaks out of the loop early
    // continue; goes to the next iteration

    // LOOP LABELS
    'outer: for x in 0..10 {
        'inner: for y in 0..10 {
            if x % 2 == 0 { continue 'outer; } // continues the loop over x
            if y % 2 == 0 { continue 'inner; } // continues the loop over y
            println!("x: {}, y: {}", x, y);
        }
    }
}
