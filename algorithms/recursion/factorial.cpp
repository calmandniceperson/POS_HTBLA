#include <iostream>

using namespace std;

int fact(int num) {
	if(num <= 1) {
		return 1;
	}
	return num * fact(num-1);
}

int main(int argc, char **argv) {
	std::cout << fact(7) << std::endl;
	return 0;
}
