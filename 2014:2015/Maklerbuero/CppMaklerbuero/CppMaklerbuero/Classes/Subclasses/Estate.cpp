//
//  Estate.cpp
//  CppMaklerbuero
//
//  Created by Michael Köppl on 22/09/14.
//  Copyright (c) 2014 Michael Köppl. All rights reserved.
//

#include "Estate.h"

Estate::Estate(int i,
               int o,
               std::string an,
               bool tbr,
               double p,
               double as,
               int d,
               double uv):Objekt(i, o, an, tbr, p, as){
    
    if(d == 1){
        ded = dedication::building_area;
    }else if(d == 2){
        ded = dedication::business_area;
    }
    unit_value = uv;
}

/*get*/
int Estate::getDedication(){
    if(ded == dedication::building_area){
        return 0;
    }else if(ded == dedication::business_area){
        return 1;
    }
    return 0;
}

double Estate::getUnitValue(){
    return unit_value;
}
/*get*/

/*set*/
void Estate::setDedication(int v){
    switch(v){
        case 1:
            ded = dedication::building_area;
            break;
        case 2:
            ded = dedication::business_area;
            break;
        default:
            ded = dedication::building_area;
            break;
    }
}

void Estate::setUnitValue(double v){
    unit_value = v;
}
/*set*/