// Michael Koeppl
// Selection sort
// 27 May 2016

extern crate rand;

use rand::Rng;

fn out_prt(f: &Vec<i32>) {
    for x in 0..f.len() {
        println!("{}", f[x]);
    }
    println!("\n");
}

fn sort(mut f: &mut Vec<i32>) -> i32 {
    let mut min;
    let mut temp;
    let mut count: i32 = 0;
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
            count = count + 1;
        }
    }
    return count;
}

fn create(s_method: i32, size: i32) -> Vec<i32> {
    let mut field: Vec<i32> = vec![0; 10];
    match s_method {
        0 => {
            for i in 0..size {
                field[i as usize] = i; 
            }
        },
        1 => {
            for i in 0..size {
                field[i as usize] = size - i;
            }
        },
        _ => {
            for i in 0..size {
                //field[i] = 
                let mut rng = rand::thread_rng();
                if rng.gen() {
                    field[i as usize] = rng.gen::<i32>();
                }
            }
        }
    }
    return field;
}

fn main() {
    let mut field = vec![7, 3, 4, 7, 2, 1, 8];
    sort(&mut field);
    out_prt(&mut field);

    let mut best: i32 = 0;
    let mut worst: i32 = 0;
    let mut avg: i32 = 0;
    for _ in 0..200 {
        let mut f_best = &mut create(0, 10);
        let mut f_worst = &mut create(1, 10);
        let mut f_avg = &mut create(2, 10);

        best = best + sort(f_best);
        worst = worst + sort(f_worst);
        avg = avg + sort(f_avg);
    }

    println!("Avg. best: {}", best/200);
    println!("Avg. avg: {}", worst/200);
    println!("Avg. worst: {}", avg/200);
}

// Rechenaufwand O-Notation: O(n^2), weil zwei ineinander verschachtelte
// Schleifen vorhanden sind. Das bedeutet, dass die innere Schleife
// einen maximalen Aufwand von N hat, wodurch allerdings die aeussere
// Schleife einen maximalen Aufwand von N*N hat.
