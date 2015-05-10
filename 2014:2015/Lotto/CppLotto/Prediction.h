/* 
 * File:   Prediction.h
 * Author: mko
 *
 * Created on April 29, 2015, 9:54 PM
 */

#include <vector>
#include <string>

#ifndef PREDICTION_H
#define	PREDICTION_H

class Prediction {
public:
    Prediction(std::vector<int> p);
    std::string PrintAll();
private:
    std::vector<int> pred;

};

#endif	/* PREDICTION_H */

