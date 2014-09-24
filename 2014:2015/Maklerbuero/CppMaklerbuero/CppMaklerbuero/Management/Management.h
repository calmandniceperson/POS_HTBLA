//
//  Management.h
//  CppMaklerbuero
//
//  Created by Michael Köppl on 22/09/14.
//  Copyright (c) 2014 Michael Köppl. All rights reserved.
//

#ifndef __CppMaklerbuero__Management__
#define __CppMaklerbuero__Management__

#include <stdio.h>
#include <vector>
#include "Objekt.h"
#include "House.h"
#include "Flat.h"
#include "Estate.h"
#include "MenuClass.h"

class Management{
public:
    Management();
    
    /*create/edit/delete objects*/
    void createNewObjekt();
    void deleteObjekt(int objnr);
    void editObjekt(int objnr);
    /*create/edit/delete objects*/
    
    /*print/output*/
    void printResult(Objekt o);
    void printAll();
    void printSpecialSelection(int type);
    /*print/outputs*/
    
    /*get*/
    Objekt getObjektByObjNr(int v);
    /*get*/

private:
    std::vector<Objekt> objVector;
    
    /*TEMPORARIES*/
    double tempd;
    std::string temp;
    int tempint;
    /*TEMPORARIES*/
    
    /*OBJEKT*/
    int objnr; /*object's number/id*/
    std::string agents_name; /*agent's name*/
    bool typus_buyus_rentus; /*to buy (true) or to rent (false)*/
    double price;
    double area_size;
    /*OBJEKT*/
    
    /*HOUSE*/
    bool multifamily; /*multiple families (true/false)*/
    int floor_count; /*number of floors*/
    bool cellar; /*cellar (true/false)*/
    /*HOUSE*/

    
    /*FLAT*/
    int room_count; /*number of rooms*/
    bool bathtube_showerc; /*bathtube (true) or shower cabin (false)*/
    /*FLAT*/
    
    /*ESTATE*/
    int dedication; /*dedication*/
    double unit_value; /*unit value*/
    /*ESTATE*/
    
    /*private methods*/
    bool procTBR(int t);
};

#endif /* defined(__CppMaklerbuero__Management__) */
