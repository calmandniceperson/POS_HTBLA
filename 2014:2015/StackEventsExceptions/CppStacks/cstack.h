#ifndef CSTACK_H
#define CSTACK_H
#include "vector"
#include "string"
#include <iostream>
#include <stdexcept>
using namespace std;

class cstack
{
    private:
        vector<string> stack;
        int cap; /*capacity*/

        // event
        virtual void OnNoElements()
        {
            cout << "EVENT NO ELEMENTS " << endl;
        }
    public:
        cstack(int c);

        //int (*stack_delegate)(int);
        //typedef int(*StackDelegate)(int);
        //StackDelegate stack_delegate;

        void push(string element);
        string pop();
        void clear();

        // getters
        int getCap();
};

// exception
class StackOverflowException: public std::runtime_error{
    public:
            StackOverflowException(string const& msg):runtime_error(msg){

            }
};

#endif // CSTACK_H
