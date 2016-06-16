// Michael Koeppl 4AHIF
// Queens puzzle
// 13 June
// 
// 12 combinations for 8 queens
// 92 possible combinations for 8 queens

const N: i32 = 8;

fn insert(field: &mut Vec<i32>, col: i32, row: i32) {
    field[col as usize] = row;
    println!("{}/{}", col, row);
}

fn test(field: &mut Vec<i32>, row: i32) {
    
}

fn test2(field: &mut Vec<i32>, row: i32) {
    if row >= N {
        return;
    }
    if row == 0 {
        insert(field, 0, row);
        test(field, row+1);
        return;
    }
    let mut capture = false;
    let mut col_ins = 0;
    'outer: for mut col in 0..N {
        col_ins = col;
        // skip first row (first queen doesn't need checking)
        if field[col as usize] != -1 && field[col as usize] < row {
            continue 'outer;
        }
        let mut index_up: i32 = col+1;
        'inner: loop {
            if index_up < field.len() as i32 {
                if field[index_up as usize] == row-(index_up-col) {
                    continue 'outer;
                }
            } else {
                break 'outer;
            }
            if (col-(index_up-col)) >= 0 {
                if field[index_up as usize] == row-(col-index_up) {
                    col = col+1;
                    continue 'outer;
                }
            } else {
                break 'outer;
            }
            index_up = index_up + 1;
        }
        //insert(field, col, row);
    }
    insert(field, col_ins, row);
    test(field, row+1);
}

fn main() {
    let mut field = &mut vec![-1; 10];
    test(field, 0);
}
