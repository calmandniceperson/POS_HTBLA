/*
 * MICHAEL KOEPPL
 * 3AHIF
 * STACK EXAMPLE
 */

import 'dart:io';
import 'dart:core';
import 'stack.dart';

void main(){
  print("Time started " + new DateTime.now().toString() + "\n\r");
  print(Directory.current);

  String answer;

  print('What capacity do you want your list to have? ');
  var cap = int.parse(stdin.readLineSync());
  var myStack = new Stack(cap);

  do{
    switch(menu()){
      case 1:
        try{
          print('What do you want to add? ');
          var input = stdin.readLineSync();
          myStack.push(input);
        }catch(exception, stackTrace){
          print(exception);
        }
        break;
      case 2:
        try{
          print(myStack.pop());
        }catch(exception){
          print(exception);
        }
        break;
      case 3:
        myStack.clear();
        break;
    }

    print('Do you want to take another action? (y/n) ');
    answer = stdin.readLineSync();
  }while(answer.toLowerCase().startsWith('y'));
}

int menu(){
  print("\x1B[2J\x1B[0;0H"); // clear entire screen, move cursor to 0;0
    // http://en.wikipedia.org/wiki/ANSI_escape_code#CSI_codes
  print('1 ... push');
  print('2 ... pop');
  print('3 ... clear');

  try{
    return int.parse(stdin.readLineSync());
  }catch(exception){
    print(exception);
  }

  return 0;
}