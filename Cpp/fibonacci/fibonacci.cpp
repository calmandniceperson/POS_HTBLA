#import <iostream>
#import <vector>

int main(int argc, char* argv[]) {
  int index = 0;
  int firstN = 0, secondN = 1, newN;
  std::cout << firstN << "\n" << secondN << std::endl;
  while(index < 35) {
    newN = firstN + secondN;
    std::cout << newN << std::endl;
    firstN = secondN;
    secondN = newN;
    index++;
  }
  return 0;
}
