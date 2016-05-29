// Michael Koeppl
// Selection sort
// 27 May 2016

extern crate chrono;

use chrono::{UTC, DateTime};

fn out_prt(f: &Vec<i32>) {
    for x in 0..f.len() {
        println!("{}", f[x]);
    }
    println!("\n");
}

fn sort(mut f: &mut Vec<i32>) {
    let mut min;
    let mut temp;
    for i in 0..f.len() {
        min = i;
        for j in i+1..f.len() {
            if f[j] < f[min] {
                min = j;
            }
        }
        if min != i {
            temp = f[i];
            f[i] = f[min];
            f[min] = temp;
        }
    }
}

fn main() {
    let mut field = vec![7, 3, 4, 7, 2, 1, 8];
    let localt_1: DateTime<UTC> = UTC::now();
    sort(&mut field);
    let localt_2: DateTime<UTC> = UTC::now();
    println!("{}", localt_2 - localt_1);
    out_prt(&mut field);
}

// Rechenaufwand O-Notation: O(n^2), weil zwei ineinander verschachtelte
// Schleifen vorhanden sind. Das bedeutet, dass die innere Schleife
// einen maximalen Aufwand von N hat, wodurch allerdings die aeussere
// Schleife einen maximalen Aufwand von N*N hat.
