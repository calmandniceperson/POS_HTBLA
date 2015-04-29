/* 
 * File:   main.cpp
 * Author: mko
 *
 * Created on April 29, 2015, 9:49 PM
 */

#include <cstdlib>
#include <iostream>
#include <iomanip>
#include <map>
#include <random>
#include <cmath>
#include <string>
#include <vector>
#include "Prediction.h"

using namespace std;

/*
 * 
 */
int main(int argc, char** argv) {

	char ans;
	/*
	 * minimum and maximum for every prediction
	 */
	int max = 64;
	int min = 0;

	do{
		std::vector<int> pred;

		for(int i = 0; i < 6; i++){
			// generate random number
			// Seed with a real random value, if available
		    std::random_device rd;
		 
		    // Choose a random mean between 1 and 6
		    std::default_random_engine e1(rd());
		    std::uniform_int_distribution<int> uniform_dist(min, max);
		    int output = uniform_dist(e1);

			pred.push_back(output);
		}

		for(int j = 0; j < 6; j++){
			std::cout << pred[j] << std::endl;
		}

		std::cout << "Do you want to try again? (y/n) ";
		std::cin >> ans;
	}while(ans == 'y' || ans == 'Y');

    return 0;
}

