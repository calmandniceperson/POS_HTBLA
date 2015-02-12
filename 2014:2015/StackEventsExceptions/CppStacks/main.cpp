#include <QCoreApplication>
#include "cstack.h"
#include "menu.h"
#include <iostream>

int main(int argc, char *argv[])
{
    QCoreApplication a(argc, argv);

    menu m;
    string ant;
    do{
        string input;
        int i;
        std::cout << "How much would you like the vector's capacity to be?" <<  std::endl;
        std::cin >> i;
        cstack mystack = *new cstack(i);

        do{
            switch(m.show_menu()){
            case 1:
                std::cout << "What do you want to add to your vector? " << std::endl;
                std::cin >> input;
                try{
                    mystack.push(input);
                }catch(StackOverflowException){
                    std::cout << "STACK OVERFLOW" << std::endl;
                }
                break;
            case 2:
                std::cout << mystack.pop() << std::endl;
                break;
            case 3:
                mystack.clear();
                break;
            }
            std::cout << "Do you want to take another action? (y/n) " << std::endl;
            std::cin >> ant;
        }while(ant[0] == 'y' || ant[0] == 'Y');
        std::cout << "Do you want to restart? (y/n) " << std::endl;
        std::cin >> ant;
    }while(ant[0] == 'y' || ant[0] == 'Y');

    return a.exec();
}
