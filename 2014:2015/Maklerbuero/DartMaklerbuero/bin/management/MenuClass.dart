library MenuClass;

import '../classes/Objekt.dart';
import '../classes/subclasses/House.dart';
import '../classes/subclasses/Flat.dart';
import '../classes/subclasses/Estate.dart';
import 'dart:io';

class MenuClass{
  
  /*
    BASE MENU
  */
  int showMainMenu(){
    stdout.writeln("\tWhat do you want to do?\t");
    stdout.writeln("1 ... create a new object");
    stdout.writeln("2 ... delete a specific object");
    stdout.writeln("3 ... edit a specific object");
    stdout.writeln("4 ... print list of objects");
    stdout.writeln("5 ... print by specific attributes");
    stdout.writeln("6 ... cheapest / most expensive / average");
    return int.parse(stdin.readLineSync());
  }
  
  /*
    Menu for attribute oriented output
    e.g. for printing all rentable objects
  */
  int showSpecificSelectionMenu(){
    stdout.writeln("\tWhat to you want to print?\t");
    stdout.writeln("1 ... print specific object (by number)");
    stdout.writeln("2 ... print all buyable objects");
    stdout.writeln("3 ... print all rentable objects");
    stdout.writeln("4 ... print all houses");
    stdout.writeln("5 ... print all flats");
    stdout.writeln("6 ... print all estates");
    return int.parse(stdin.readLineSync());
  }
  
  /*
    Menu for editing objects
  */
  int showEditMenu(Objekt o){
    stdout.writeln("\tWhat do you want to edit?\t");
    stdout.writeln("1 ... agent's name");
    stdout.writeln("2 ... buyable/rentable");
    stdout.writeln("3 ... price");
    stdout.writeln("4 ... area size");
    
    if(o is House){
      stdout.writeln("5 ... multifamily (yes/no)");
      stdout.writeln("6 ... number of floors");
      stdout.writeln("7 ... cellar (yes/no)");
    }else if(o is Flat){
      stdout.writeln("5 ... number of rooms");
      stdout.writeln("6 ... bathtub/shower cabin");
    }else if(o is Estate){
      stdout.writeln("5 ... dedication");
      stdout.writeln("6 ... unit value");
    }
    
    int temp = int.parse(stdin.readLineSync());
    
    if(temp == 5 || temp == 6 || temp == 7){
      
      /*house is not listed in switch
      because it is the default for 5,6,7*/
      if(o is Flat){
        if(temp == 5){
          temp = 8; /*number of rooms*/
        }else if(temp == 6){
          temp = 9; /*bathtub/shower cabin*/
        }
      }else if(o is Estate){
        if(temp == 5){
          temp = 10; /*dedication*/
        }else if(temp == 6){
          temp = 11; /*unit value*/
        }
      }
      
      /*
            TEMP OPTIONS
          temp = 1 -> agent's name
          temp = 2 -> buy/rent
          temp = 3 -> price
          temp = 4 -> area size
          temp = 5 -> (house) multifamily
          temp = 6 -> (house) number of floors
          temp = 7 -> (house) cellar
          temp = 8 -> (flat) number of rooms
          temp = 9 -> (flat) bathtub/shower cabin
          temp = 10 -> (estate) dedication
          temp = 11 -> (estate) unit value
      */
    }
    
    return temp;
  }
  
  /*
  Menu for printing cheapest/most expensive/average object
  */
  
  /*TO DO*/ 
  
}