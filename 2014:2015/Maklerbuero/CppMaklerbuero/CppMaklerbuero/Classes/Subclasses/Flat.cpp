//
//  Flat.cpp
//  CppMaklerbuero
//
//  Created by Michael Köppl on 22/09/14.
//  Copyright (c) 2014 Michael Köppl. All rights reserved.
//

#include "Flat.h"

Flat::Flat(int i,
           int o,
           std::string an,
           bool tbr,
           double p,
           double as,
           int cr,
           bool btsc):Objekt(i, o, an, tbr, p, as){
    
    count_rooms = cr;
    bathtube_showerc = btsc;
}

/*get*/
int Flat::getRoomCount(){
    return count_rooms;
}

bool Flat::getBS(){
    return bathtube_showerc;
}
/*get*/

/*set*/
void Flat::setRoomCount(int v){
    count_rooms = v;
}

void Flat::setBS(bool v){
    bathtube_showerc = v;
}
/*set*/