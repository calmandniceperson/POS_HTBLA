//
//  Objekt.cpp
//  CppMaklerbuero
//
//  Created by Michael Köppl on 22/09/14.
//  Copyright (c) 2014 Michael Köppl. All rights reserved.
//

#include "Objekt.h"

Objekt::Objekt(int i, int o, std::string an, bool tbr, double p, double as){
    objId = i;
    objnr = o;
    agentsname = an;
    typus_buyus_rentus = tbr;
    price = p;
    area_size = as;
}

/*get*/
int Objekt::getId(){
    return objId;
}

int Objekt::getObjNr(){
    return objnr;
}

std::string Objekt::getAgent(){
    return agentsname;
}

bool Objekt::getTBR(){
    return typus_buyus_rentus;
}

double Objekt::getPrice(){
    return price;
}

double Objekt::getAreaSize(){
    return area_size;
}
/*get*/

/*set*/
void Objekt::setObjNr(int v){
    objnr = v;
}

void Objekt::setAgent(std::string v){
    agentsname = v;
}

void Objekt::setTBR(bool v){
    typus_buyus_rentus = v;
}

void Objekt::setPrice(double v){
    price = v;
}

void Objekt::setAreaSize(double v){
    area_size = v;
}
/*set*/