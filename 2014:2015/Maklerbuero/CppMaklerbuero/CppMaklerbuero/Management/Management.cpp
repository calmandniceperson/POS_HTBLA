//
//  Management.cpp
//  CppMaklerbuero
//
//  Created by Michael Köppl on 22/09/14.
//  Copyright (c) 2014 Michael Köppl. All rights reserved.
//

#include <iostream>
#include <cctype>
#include <typeinfo>
#include "Management.h"

Management::Management(){}

void Management::createNewObjekt(){
    if(objVector.empty()){
        objnr = 1;
    }else{
        objnr = objVector.back().getObjNr() + 1; /*increase the number for the new object*/
    }

    std::cout << "What's the responsible agent's first name?" << std::endl;
    std::string fname;
    std::cin >> fname;
    
    std::cout << "What's the responsible agent's last name? " << std::endl;
    std::string lname;
    std::cin >> lname;
    
    agents_name = fname + " " + lname; //connect first and last name to one string
    
    /*typus buyus rentus*/
    std::cout << "Is the object up for buying (1) or rental (2)? " << std::endl;
    std::cin >> tempint;
    
    if(procTBR(tempint)){
        if(tempint == 1){
            typus_buyus_rentus = true;
        }else{
            typus_buyus_rentus = false;
        }
    }
    
    /*price*/
    std::cout << "How much does your object cost? " << std::endl;
    std::cin >> price;
    
    /*area size*/
    std::cout << "What's the size of the area (m^2)? " << std::endl;
    std::cin >> area_size;
    
    /*CHECK FOR LETTERS HERE*/
    /*TO DO*/
    
    std::cout << "Is your object a house (1), a flat (2), or an estate (3)?";
    std::cin >> tempint;
    
    switch(tempint){
        case 1 /*house*/:
            std::cout << "Is your house a multifamily house? (y/n)" << std::endl;
            std::cin >> temp;
            std::transform(temp.begin(), temp.end(), temp.begin(), ::tolower);
            if(temp == "y"){
                multifamily = true;
            }else{
                multifamily = false;
            }
            
            std::cout << "How many floors does your house have?" << std::endl;
            std::cin >> floor_count;
            
            std::cout << "Does your house have a cellar? (y/n)" << std::endl;
            std::cin >> temp;
            std::transform(temp.begin(), temp.end(), temp.begin(), ::tolower);
            if(temp == "y"){
                cellar = true;
            }else{
                cellar = false;
            }
            
            /*add element at the end of the vector*/
            objVector.push_back(*new House(1, objnr, agents_name, typus_buyus_rentus, price, area_size, multifamily, floor_count, cellar));
            
            try{
                printResult(getObjektByObjNr(objnr));
            }catch(std::exception& e){
                std::cout << "Object creation failed. There is no object with the given objnr right after creating it." << std::endl;
            }
            
            break;
        case 2 /*flat*/:
            std::cout << "How many rooms does your flat have? " << std::endl;
            std::cin >> room_count;
            
            std::cout << "Does your flat have a bathtube (1) or a shower cabin (2)? " << std::endl;
            std::cin >> tempint;
            if(tempint == 1){
                bathtube_showerc = true;
            }else{
                bathtube_showerc = false;
            }
            
            objVector.push_back(*new Flat(2, objnr, agents_name, typus_buyus_rentus, price, area_size, room_count, bathtube_showerc));

            try{
                printResult(getObjektByObjNr(objnr));
            }catch(std::exception& e){
                std::cout << "Object creation failed. There is no object with the given objnr right after creating it." << std::endl;
            }
            break;
        case 3 /*estate*/:
            std::cout << "Is the estate a building area (1) or a business area (2)?" << std::endl;
            std::cin >> dedication;
            
            std::cout << "What's the unit value for this estate?" << std::endl;
            std::cin >> unit_value;
            
            objVector.push_back(*new Estate(3, objnr, agents_name, typus_buyus_rentus, price, area_size, dedication, unit_value));
            
            try{
                printResult(getObjektByObjNr(objnr));
            }catch(std::exception& e){
                std::cout << "Object creation failed. There is no object with the given objnr right after creating it." << std::endl;
            }
            break;
    }
}

void Management::printResult(Objekt o){
    std::cout << "Object ID : " << std::to_string(o.getObjNr()) << std::endl;
    std::cout << "Agent's name: " << o.getAgent() << std::endl;
    
    if(o.getTBR()){
        std::cout << "The object is up for buying." << std::endl;
    }else{
        std::cout << "The object is up for rental." << std::endl;
    }
    
    std::cout << "The total cost of this object are " << std::to_string(floorf((o.getPrice()*100)/100)) << "€" << std::endl;
    
    std::cout << "The size of the object is " << std::to_string(floorf((o.getAreaSize()*100)/100)) << "m^2" << std::endl;
    
    switch(o.getId()){
        case 1 /*house*/:
            if(o.getMultiFam()){
                std::cout << "This house is designed for multiple families." << std::endl;
            }else{
                std::cout << "This house is designed for only one family." << std::endl;
            }
            
            std::cout << "This house has " << std::to_string(o.getFloorCount()) << "floors." << std::endl;
            
            if(o.getCellar()){
                std::cout << "This house has a cellar." << std::endl;
            }else{
                std::cout << "This house does not have a cellar." << std::endl;
            }
            break;
        case 2 /*flat*/:
            std::cout << "The flat has " << std::to_string(o.getRoomCount()) << "rooms." << std::endl;
            
            if(o.getBS()){
                std::cout << "The flat includes a bathtube." << std::endl;
            }else{
                std::cout << "The flat includes a shower cabin." << std::endl;
            }
            break;
        case 3 /*estate*/:
            switch(o.getDedication()){
                case 1:
                    std::cout << "This estate is a building area." << std::endl;
                    break;
                case 2:
                    std::cout << "This estate is a business area." << std::endl;
                    break;
            }
            std::cout << "The unit value is " << std::to_string(o.getUnitValue()) << "." << std::endl;
            break;
    }
}

void Management::printAll(){
    for(auto o: objVector){
        printResult(o);
    }
}

Objekt Management::getObjektByObjNr(int v){
    for(Objekt o: objVector){
        if(o.getObjNr() == v){
            return o;
        }
    }
    throw std::exception();
}

bool Management::procTBR(int t){
    if(t == 1){
        return true;
    }else if(t == 2){
        return false;
    }else{
        return false;
    }
}