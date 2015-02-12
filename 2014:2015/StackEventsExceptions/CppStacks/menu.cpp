#include "menu.h"
#include <iostream>

menu::menu()
{
}

int menu::show_menu(){
    std::cout << "\x1B[2J\x1B[H";
    std::cout << "1 ... push" << std::endl;
    std::cout << "2 ... pop" << std::endl;
    std::cout << "3 ... clear" << std::endl;

    int input;
    std::cin >> input;
    return input;
}
