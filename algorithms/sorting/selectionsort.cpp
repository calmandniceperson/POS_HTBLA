#include <iostream>
#include <vector>
#include <random>

int sort(std::vector<int> f) {
	int min, temp, count = 0;
	for (int i = 0; i < f.size(); i++) {
		min = i;
		for (int j = i + 1; j < f.size(); j++) {
			if (f[j] < f[min]) {
				min = j;
			}
		}
		if (min != i) {
			temp = f[i];
			f[i] = f[min];
			f[min] = temp;
			count++;
		}
	}
	return count;
}

std::vector<int> create(int s_method, int size) {
	std::vector<int> f (size);
	switch (s_method) {
		case 0:
			for (int i = 0; i < size; i++) {
				f[i] = i;	
			}
			break;
		case 1:
			for (int i = 0; i < size; i++) {
				f[i] = size - i;
			}
			break;
		default:
			for (int i = 0; i < size; i++) {
				std::random_device rd;
				std::mt19937 rng(rd());
				std::uniform_int_distribution<int> uni(0, 10);
				f[i] = uni(rng);
			}
			break;
	}
	return f;
}

int main(int argc, char **argv) {
	/*std::vector<int> field = create(2, 10);
	for (int i = 0; i < field.size(); i++) {
		std::cout << field[i] << std::endl;
	}
	return 0;*/

	int best = 0, worst = 0, avg = 0;
	for (int  i = 0; i < 200; i++) {
		std::vector<int> f_best = create(0, 10);
		std::vector<int> f_avg = create(1, 10);
		std::vector<int> f_worst = create(2, 10);

		best += sort(f_best);
		worst += sort(f_worst);
		avg += sort(f_avg);
	}

	std::cout << "Best best: " << best/200 << std::endl;
	std::cout << "Best avg.: " << avg/200 << std::endl;
	std::cout << "Best worst: " << worst/200 << std::endl;
	return 0;
}
