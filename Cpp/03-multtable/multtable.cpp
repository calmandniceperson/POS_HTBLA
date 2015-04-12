// basic multiplication table
// cpp training
// 12 April 2015

#include <iostream>

using namespace std;

int main(){
	int num;

	cout << "Enter a number: ";
	cin >> num;

	for(int i = 1; i <= 10; i++){
		cout << num << " X " << i << " = " << num*i << "\n";

	}

	return 0;
}