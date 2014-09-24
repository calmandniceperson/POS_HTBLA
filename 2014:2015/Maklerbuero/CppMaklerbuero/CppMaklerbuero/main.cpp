//
//  main.cpp
//  CppMaklerbuero
//
//  Created by Michael Köppl on 22/09/14.
//  Copyright (c) 2014 Michael Köppl. All rights reserved.
//

#include <iostream>
#include "MenuClass.h"

MenuClass mc;

int main(int argc, const char * argv[]) {
    std::string ant;
    do{
        mc.showMenu();
        std::cout << "Do you want to do one more action? (y/n)";
        std::cin >> ant;
    }while(ant[0] == 'y' || ant[0] == 'Y');
    return 0;
}
