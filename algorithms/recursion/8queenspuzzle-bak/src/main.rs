// Michael Koeppl 4AHIF
// Queens puzzle
// 13 June 2016
//
// 12 fundamentally different solutions
// 92 distinct solutions

static mut count: i32 = 0;
const NUM_OF_QUEENS: i8 = 8;

fn insert(field: &mut Vec<i32>, curr_col: i32, curr_row: i32) {
    field[curr_col as usize] = curr_row;
}

fn search(queen_count: i8, field: &mut Vec<i32>, curr_col: i32, 
          curr_row: i32) -> i32 {
    if curr_col >= field.len() as i32 && curr_row >= 7 {
        return -1;
    }
    if queen_count > NUM_OF_QUEENS - 1 {
        return 0;
    }
    if field[curr_col as usize] != -1 {
        return search(queen_count, field, curr_col+1, curr_row);
    } else {
        for i in 0..field.len() {
            if field[i as usize] == curr_row {
                return search(queen_count, field, curr_col, curr_row+1);
            }
        }

        // diagonal search
        let mut index_forw = curr_col+1;
        let mut index_back = curr_col-1;
        let mut index_bd_forw = curr_col-1;
        let mut index_bd_back = curr_col+1;
        loop {
            if index_forw >= field.len() as i32 ||
                index_back < 0 {
                break;
            }
            
            // check for diagonal (right lower)
            if field[index_forw as usize] == curr_row+(index_forw-curr_col) ||
                field[index_back as usize] == curr_row-(curr_col-index_back) {
                return search(queen_count, field, curr_col+1, curr_row);
            }
            //if field[index_bd_forw as usize] == curr_row-(index-curr_col) ||

            //if field[index_forw as usize] == curr_row-
            index_forw = index_forw+1;
            index_back = index_back-1;
        }
        insert(field, curr_col, curr_row);
        println!("{}|{}", curr_col, curr_row);
        return search(queen_count+1, field, 0, 0);
    }
}

unsafe fn find_comb_8queens(c: i8) {
    let mut field = &mut vec![-1; 10]; 
    let res = search(c, field, 0, 0);
    if res == -1 {
        return;
    } else if res == 0 {
        count = count + 1;
    }
    find_comb_8queens(c+1);
}

fn main() {
    /*search(field, 0, 0);
    unsafe {
        println!("{} combinations...", count);
    }*/
    unsafe {
        find_comb_8queens(0);
        println!("{} combinations", count);
    }
}
