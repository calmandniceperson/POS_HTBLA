library stack;

import 'dart:core';

class Stack{
  List<String> stack;
  int cap;

  Stack(int c){
    stack = new List();
    cap = c;
  }

  void push(String element){
    if(cap < stack.length + 1){
      throw new StackOverflowError('STACK OVERFLOW: You reached the limit of your list.');
    }else{
      stack.add(element);
    }
  }

  String pop(){
    if(stack.length == 0){
      throw new StackUnderflowError('There are no elements in your list');
    }else{
      return stack.last;
    }
  }

  void clear(){
    stack.clear();
  }
}

class StackOverflowError extends StateError{
  StackOverflowError(String msg):super(msg);
}

class StackUnderflowError extends StateError{
  StackUnderflowError(String msg):super(msg);
}