#include <iostream>
#include <vector>
using namespace std;
void displayPathtoPrincess(int n, vector <string> grid){
	//your logic her
	short mpos[2]/*bot position*/, ppos[2]/*princess position*/;
	for(int i = 0; i < n; i++) {
		for(int j = 0; j < n; j++) {
			if(grid[i][j] == 'm') {
				mpos[0] = i;
				mpos[1] = j;
			} else if(grid[i][j] == 'p') {
				ppos[0] = i;
				ppos[1] = j;
			}
		}
	}

	int up, left;
	if((up = ppos[0] - mpos[0]) < 0) {
		for(; up < 0; ++up) {
			cout << "UP\n";
		}
	} else {
		for(; up > 0; --up) {
			cout << "DOWN\n";
		}
	}
	if((left = ppos[1] - mpos[1]) < 0) {
		for(; left < 0; ++left) {
			cout << "LEFT\n";
		}
	} else {
		for(; left > 0; --left) {
			cout << "RIGHT\n";
		}
	}
}

int main(void) {

	int m;
	vector <string> grid;

	cin >> m;

	for(int i=0; i<m; i++) {
		string s; cin >> s;
		grid.push_back(s);
	}
	displayPathtoPrincess(m,grid);

	return 0;
}
