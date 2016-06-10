#include <iostream>
#include <vector>
#include <string>

std::vector<int> field = {1, 2, 3, 4, 5, 6, 7, 8};
std::vector<std::string> alph = {"A", "B", "C", "D", "E", "F", "G", "H"};
int count = 0;

void out() {
	for(int i = 0; i <= field.size() - 1; i++) {
		std::cout << (i+1) << ". queen:" << alph[i] << field[i] << " "
			<< std::endl;
	}
	std::cout << "\n" << std::endl;
}

void perm(int begin) {
	if(begin >= field.size()) {
		out();
		count++;
		return;
	}
	perm(begin+1);

	int temp;
	for(int i = begin+1; i < field.size(); i++) {
		temp = field[begin];
		field[begin] = field[i];
		field[i] = temp;

		perm(begin+1);

		field[i] = field[begin];
		field[begin] = temp;
	}
}

int main(int argc, char **argv) {
	perm(0);
	std::cout << "There are " <<
		count <<
		" possible combinations for how the queens may be organised." <<
		std::endl;
	return 0;
}

