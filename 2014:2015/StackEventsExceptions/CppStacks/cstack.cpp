#include "cstack.h"

cstack::cstack(int c)
{
    cap = c;
}

void cstack::push(string element){
    //cout << stack.capacity() << " " << stack.size() << endl;
    if(cap < stack.size() + 1){
        throw new StackOverflowException("Reached capacity of vector.");
    }else{
        stack.push_back(element);
    }
}

string cstack::pop(){
    if(stack.size() == 0){
        OnNoElements();
    }else{
        return stack.back();
    }
    return "";
}

void cstack::clear(){
    stack.clear();
}


