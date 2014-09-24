//
//  Objekt.h
//  CppMaklerbuero
//
//  Created by Michael Köppl on 22/09/14.
//  Copyright (c) 2014 Michael Köppl. All rights reserved.
//

#ifndef __CppMaklerbuero__Objekt__
#define __CppMaklerbuero__Objekt__

#include <stdio.h>
#include <string>
#include <Accelerate/Accelerate.h>

class Objekt{
//private variables
private:
    int objId; /*defines whether the Objekt is a house, a flat or an estate*/
    int objnr; //number of the object (house, flat, ...)
    std::string agentsname; //name of the respective agent
    bool typus_buyus_rentus; //buy(true) or rent(false)
    double price; /*price of the object*/
    double area_size; /*self-explanatory*/
    
public:
    Objekt(int i, int o, std::string an, bool tbr, double p, double as);
    
    /*get*/
    int getId();
    int getObjNr();
    std::string getAgent();
    bool getTBR();
    double getPrice();
    double getAreaSize();
    /*get*/
    
    /*set*/
    void setObjNr(int v);
    void setAgent(std::string v);
    void setTBR(bool v);
    void setPrice(double v);
    void setAreaSize(double v);
    /*set*/
    
    /*polymorphism*/
    
    /*HOUSE*/
    /*get*/
    virtual bool getMultiFam(){
        return false;
    }
    virtual int getFloorCount(){
        return 0;
    }
    virtual bool getCellar(){
        return false;
    }
    /*get*/
    
    /*set*/
    virtual void setMultiFam(bool v){}
    virtual void setFloorCount(int v){}
    virtual void setCellar(bool v){}
    /*set*/
    /*HOUSE*/
    
    /*FLAT*/
    /*get*/
    virtual int getRoomCount(){
        return 0;
    }
    virtual bool getBS(){
        return false;
    }
    /*get*/
    
    /*set*/
    virtual void setRoomCount(int v){}
    virtual void setBS(bool v){}
    /*set*/
    /*FLAT*/
    
    /*ESTATE*/
    /*get*/
    virtual int getDedication(){
        return 0;
    }
    virtual double getUnitValue(){
        return false;
    }
    /*get*/
    
    /*set*/
    virtual void setDedication(int v){}
    virtual void setUnitValue(double v){}
    /*set*/
    /*ESTATE*/
    
    /*polymorphism*/
};

#endif /* defined(__CppMaklerbuero__Objekt__) */
