library Output;

import 'dart:io';
import '../classes/Objekt.dart';
import '../classes/subclasses/House.dart';
import '../classes/subclasses/Flat.dart';
import '../classes/subclasses/Estate.dart';

class Output{
  void printObjekt(Objekt o){
    
    stdout.writeln();
    
    stdout.writeln("Object number: " + o.getObjNr().toString());
    
    stdout.writeln("Agent's name: " + o.getAgentsName());
    
    if(o.getTBR()){
      stdout.writeln("This object is to be bought.");
    }else if(!o.getTBR()){
      stdout.writeln("This object is to be rented.");
    }
    
    stdout.writeln("Price: " + o.getPrice().toString());
    
    stdout.writeln("Area size: " + o.getAreaSize().toString());
    
    /*TYPESPECIFIC OUTPUT*/
    if(o is House){
      
      if(o.getMultiFam()){
        stdout.writeln("This house is a multifamily house.");
      }else if(!o.getMultiFam()){
        stdout.writeln("This house is made for 1 family living in it.");
      }
      
      stdout.writeln("The house has " + o.getFloorCount().toString() + " floors.");
      
      if(o.getCellar()){
        stdout.writeln("This house has a cellar.");
      }else if(!o.getCellar()){
        stdout.writeln("This house does not have a cellar.");
      }
      
    }else if(o is Flat){
      
      stdout.writeln("The flat has " + o.getRoomCount().toString() + " rooms.");
      
      if(o.getBS()){
        stdout.writeln("The flat includes a bathtub.");
      }else if(!o.getBS()){
        stdout.writeln("The flat includes a shower cabin.");
      }
      
    }else if(o is Estate){
      
      if(o.getDedication() == 1){
        stdout.writeln("The estate is a building area.");
      }else if(o.getDedication() == 2){
        stdout.writeln("The estate is a business area.");
      }
      
      stdout.writeln("The estate's unit value is " + o.getUnitValue().toString() + ".");
      
    }
    
    stdout.writeln();
  }
  
  void printAll(List objList){
    for(Objekt o in objList){
      printObjekt(o);
    }
  }
}