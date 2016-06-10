#include <iostream>
#include <vector>
#include <random>

int count = 0;

std::vector<int> create_vec(int sorting_method, int size) {
	std::vector<int> f (size);
	for(int i = 0; i < size; i++) {
		switch(sorting_method) {
			case 0:
				f[i] = i;
				break;
			case 1:
				f[i] = size-i;
				break;
			default:
				std::random_device rd;
				std::mt19937 rng(rd());
				std::uniform_int_distribution<int> uni(0, 10);
				f[i] = uni(rng);
				break;
		}
	}
}

void swap(std::vector<int> f, int a, int b) {
	int temp;
	temp = f[a];
	f[a] = f[b];
	f[b] = temp;
	count++;
}

void quicksort(std::vector<int> f, int lower_limit, int upper_limit) {
	if(lower_limit >= upper_limit) {
		return -1;
	}
	swap(f, lower_limit, (upper_limit+lower_limit)/2);

	int last = lower_limit;
	for(int i = lower_limit + 1; i <= upper_limit; i++) {
		if(f[i] <= f[lower_limit]) {
			swap(f, ++last, i);
		}
	}
	swap(f, lower_limit, last);
	quicksort(f, lower_limit, last-1);
	quicksort(f, last+1; upper_limit);
}

int main(int argc, char **argv) {
	if(args < 1) {
		return -1;
	}
	return 0;
}
