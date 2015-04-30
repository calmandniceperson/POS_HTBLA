/* 
 * File:   Prediction.h
 * Author: mko
 *
 * Created on April 29, 2015, 9:54 PM
 */

#ifndef PREDICTION_H
#define	PREDICTION_H

class Prediction {
public:
    Prediction();
    Prediction(const Prediction& orig);
    virtual ~Prediction();
private:
        int digits[6];

};

#endif	/* PREDICTION_H */

