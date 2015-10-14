#import <iostream>
#import <vector>

int main(int argc, char* argv[]) {
  std::vector<unsigned long long> nums;
  nums.push_back(0);
  nums.push_back(1);
  nums.push_back(1);
  std::cout << 0 << "\n" << 1 <<  "\n" << 1 << std::endl;
  int index = nums.size();
  while(index < 100) {
    try {
      //std::cout << index << std::endl;
      nums.push_back(nums.at(index-1) + nums.at(index-2));
    } catch(std::out_of_range o){
      std::cout<<o.what()<<std::endl;
    }
    std::cout << nums.at(index) << std::endl;
    index++;
  }
  return 0;
}
