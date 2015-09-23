#include <iostream>
#include <stdio.h>
#include <stdlib.h>
#include <vector>

int main() {
  int num, highest;
  std::vector<int>nums(10);
  std::cout << "Enter a number: ";
  std::cin >> num;
  for(int i = 0; i < num; i++) {
    int rnum = (rand()%10)+0;
    nums[rnum]++;
    if(nums[rnum] > highest) {
      highest = nums[rnum];
    }
  }
  if(highest > 50) {
    highest = highest/50;
  } else {
    highest = 1;
  }
  for(int i = 0; i <= 9; i++) {
    std::cout << i << ":";
    int limit;
    if(nums[i] != highest) {
      limit = nums[i]/highest;
    } else {
      limit = highest;
    }
    for(int j = 0; j < limit; j++) {
      if(nums[i] > 0) {
        std::cout << "X";
      }
    }
    std::cout << std::endl;
  }
  std::cout << "Legend: 1 X corresponds to " << highest << " hits" << std::endl;
  return 0;
}
