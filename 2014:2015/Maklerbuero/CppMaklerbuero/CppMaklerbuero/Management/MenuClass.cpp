//
//  MenuClass.cpp
//  CppMaklerbuero
//
//  Created by Michael Köppl on 22/09/14.
//  Copyright (c) 2014 Michael Köppl. All rights reserved.
//

#include "MenuClass.h"
#include <iostream>

Management m;

int MenuClass::showMenu(){
    //m = *new Management();
    int input;
    std::cout << "\tLISTING OFFICE\t\n\r" ;
    std::cout << "1 ... Create new object\n\r";
    std::cout << "2 ... Delete object\n\r";
    std::cout << "3 ... Edit object\n\r";
    std::cout << "4 ... Print all\n\r";
    
    std::cin >> input;
    switch(input){
        case 1:
            m.createNewObjekt();
            break;
        case 2:
            break;
        case 3:
            break;
        case 4:
            m.printAll();
            break;
        default:
            break;
    }
    
    return 0;
}

MenuClass::MenuClass(){
    
}