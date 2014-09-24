//
//  Estate.h
//  CppMaklerbuero
//
//  Created by Michael Köppl on 22/09/14.
//  Copyright (c) 2014 Michael Köppl. All rights reserved.
//

#ifndef __CppMaklerbuero__Estate__
#define __CppMaklerbuero__Estate__

#include <stdio.h>
#include "Objekt.h"

class Estate:public Objekt{
private:
    enum dedication{
        building_area,
        business_area
    };
    
    dedication ded;
    double unit_value;
    
public:
    Estate(int i, int o, std::string an, bool tbr, double p, double as, int d, double uv);
    
    /*get*/
    int getDedication();
    double getUnitValue();
    /*get*/
    
    /*set*/
    void setDedication(int v);
    void setUnitValue(double v);
    /*set*/
};

#endif /* defined(__CppMaklerbuero__Estate__) */
