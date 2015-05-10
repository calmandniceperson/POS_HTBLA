/* 
 * File:   Prediction.cpp
 * Author: mko
 * 
 * Created on April 29, 2015, 9:54 PM
 */

#include "Prediction.h"

Prediction::Prediction(std::vector<int> p) {
	pred = p;
}

std::string Prediction::PrintAll(){
	return " lel ";//pred[0] << " " << pred[1] << " " << pred[2] << " " << pred[3] << " " << pred[4] << " " << pred[5];
}