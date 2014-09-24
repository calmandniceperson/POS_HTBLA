//
//  House.h
//  CppMaklerbuero
//
//  Created by Michael Köppl on 22/09/14.
//  Copyright (c) 2014 Michael Köppl. All rights reserved.
//

#ifndef __CppMaklerbuero__House__
#define __CppMaklerbuero__House__

#include <stdio.h>
#include "Objekt.h" /*include Objekt header file to inherit from it*/

class House:public Objekt{
private:
    bool multifamily; /*is this house made for multiple families? (true/false)*/
    int floor_count; /*number of floors in this house*/
    bool cellar; /*does this house have a cellar? (true/false)*/
    
public:
    House(int i, int o, std::string an, bool tbr, double p, double as, bool mf, int fc, bool c);
    
    /*get*/
    bool getMultiFam();
    int getFloorCount();
    bool getCellar();
    /*get*/
    
    /*set*/
    void setMultiFam(bool v);
    void setFloorCount(int v);
    void setCellar(bool v);
    /*set*/
};
#endif /* defined(__CppMaklerbuero__House__) */
