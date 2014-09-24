//
//  Flat.h
//  CppMaklerbuero
//
//  Created by Michael Köppl on 22/09/14.
//  Copyright (c) 2014 Michael Köppl. All rights reserved.
//

#ifndef __CppMaklerbuero__Flat__
#define __CppMaklerbuero__Flat__

#include <stdio.h>
#include "Objekt.h"

class Flat:public Objekt{
private:
    int count_rooms; /*number of rooms*/
    bool bathtube_showerc; /*bathtube (true) or a shower cabin (false)*/
    
public:
    Flat(int i, int o, std::string an, bool tbr, double p, double as, int cr, bool btsc);
    
    /*get*/
    int getRoomCount();
    bool getBS();
    /*get*/
    
    /*set*/
    void setRoomCount(int v);
    void setBS(bool v);
    /*set*/
    
};

#endif /* defined(__CppMaklerbuero__Flat__) */
