//
//  House.cpp
//  CppMaklerbuero
//
//  Created by Michael Köppl on 22/09/14.
//  Copyright (c) 2014 Michael Köppl. All rights reserved.
//

#include "House.h"

House::House(int i,
             int o,
             std::string an,
             bool tbr,
             double p,
             double as,
             bool mf,
             int fc,
             bool c):Objekt(i, o, an, tbr, p, as){
    
    multifamily = mf;
    floor_count = fc;
    cellar = c;
}

/*get*/
bool House::getMultiFam(){
    return multifamily;
}

int House::getFloorCount(){
    return floor_count;
}

bool House::getCellar(){
    return cellar;
}
/*get*/

/*set*/
void House::setMultiFam(bool v){
    multifamily = v;
}

void House::setFloorCount(int v){
    floor_count = v;
}

void House::setCellar(bool v){
    cellar = v;
}
/*set*/