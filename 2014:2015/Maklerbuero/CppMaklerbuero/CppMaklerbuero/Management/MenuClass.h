//
//  MenuClass.h
//  CppMaklerbuero
//
//  Created by Michael Köppl on 22/09/14.
//  Copyright (c) 2014 Michael Köppl. All rights reserved.
//

#ifndef __CppMaklerbuero__MenuClass__
#define __CppMaklerbuero__MenuClass__

#include <stdio.h>
#include "Management.h"

class MenuClass{
public:
    MenuClass();
    
    static int showMenu(); //base menu
    //int showSpecificSelectionMenu(); /*for attribute-oriented output*/
    //int showEditMenu(std::string type);
};

#endif /* defined(__CppMaklerbuero__MenuClass__) */
