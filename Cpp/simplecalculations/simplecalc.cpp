// simple calculations
// cpp training
// 12 April 2015

#include <iostream>

using namespace std;

int main(){
	int fn, sn;

	cout << "Enter your first number: ";
	cin >> fn;

	cout << "Enter the second number: ";
	cin >> sn;

	cout << "Sum: " << fn+sn << "\n";
	cout << "Subtract: " << fn-sn << "\n";
	cout << "Multiplication: " << fn*sn << "\n";

	if(fn%sn != 0){ /*just a little extra*/
		cout << "Division: " << fn/sn << " (rounded)\n";
	}else{
		cout << "Division: " << fn/sn << "\n";
	}
	cout << "Modulo: " << fn%sn << "\n";

	return 0;
}