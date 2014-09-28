library Management;

import '../classes/Objekt.dart';
import '../classes/subclasses/House.dart';
import '../classes/subclasses/Flat.dart';
import '../classes/subclasses/Estate.dart';
import '../management/Output.dart';

//import '../classes/subclasses/House.dart' as house;
import 'dart:io';

class Management{
  
  List<Objekt> objList = new List(); //list of objects
  Output output = new Output();
  
  /*TEMPORARIES*/
  int tempint;
  String temp;
  Objekt tempobj;
  /*TEMPORARIES*/
  
  /*Objekt*/
  int objnr;
  String agents_name;
  bool typus_buyus_rentus;
  double price;
  double area_size;
  /*Objekt*/
  
  /*House*/
  bool multifamily;
  int floor_count;
  bool cellar;
  /*House*/
  
  /*Flat*/
  int room_count;
  bool bathtub_showercabin;
  /*Flat*/
  
  /*Estate*/
  int dedication;
  double unit_value;
  /*Estate*/
  
  List getObjList(){
    return objList;
  }
  
  /*get the object by it's object number*/
  Objekt getObjektByObjNr(int v){
    for(Objekt o in objList){
      if(o.getObjNr() == v){
        return o;
      }
    }
    return null;
  }
  
  void newObjekt(){
    
    if(objList.isNotEmpty){
      objnr = objList.last.getObjNr() + 1;
    }else{
      objnr = 1;
    }
    
    stdout.write("What's the responsible agent's first name? ");
    String fname = stdin.readLineSync();
    
    stdout.write("What's the reponsible agent's last name? ");
    String lname = stdin.readLineSync();
    
    agents_name = fname + lname; //combine first name and last name
    
    stdout.write("Is the object up for buying (1) or for renting (2)?");
    if((tempint = int.parse(stdin.readLineSync())) == 1){
      typus_buyus_rentus = true;
    }else if(tempint == 2){
      typus_buyus_rentus = false;
    }
    
    stdout.write("What's the object's price? ");
    price = double.parse(stdin.readLineSync());
    
    stdout.write("What's the size of the object's area? ");
    area_size = double.parse(stdin.readLineSync());
    
    stdout.write("Is the object a house (1), a flat (2), or an estate (3)? ");
    switch(int.parse(stdin.readLineSync())){
      case 1:
        stdout.write("Is the house a multifamily house? (y/n) ");
        if((temp = stdin.readLineSync().toLowerCase()) == "y"){
          multifamily = true;
        }else if(temp == "n"){
          multifamily = false;
        }
        
        stdout.write("How many floors does the house have? ");
        floor_count = int.parse(stdin.readLineSync());
        
        stdout.write("Does the house have a cellar? (y/n) ");
        if((temp = stdin.readLineSync().toLowerCase()) == "y"){
          cellar = true;
        }else if(temp == "n"){
          cellar = false;
        }
        
        objList.add(new House(objnr, agents_name, typus_buyus_rentus, price, area_size, multifamily, floor_count, cellar));
        
        if((tempobj = getObjektByObjNr(objnr)) != null){
          output.printObjekt(tempobj);
        }
        break;
      case 2:
        stdout.write("How many rooms does the flat have? ");
        room_count = int.parse(stdin.readLineSync());
        
        stdout.write("Does the flat have a bathtub (1) or a shower cabin (2)? ");
        if((tempint = int.parse(stdin.readLineSync())) == 1){
          bathtub_showercabin = true;
        }else if(tempint == 2){
          bathtub_showercabin = false;
        }
        
        objList.add(new Flat(objnr, agents_name, typus_buyus_rentus, price, area_size, room_count, bathtub_showercabin));
        
        if((tempobj = getObjektByObjNr(objnr)) != null){
          output.printObjekt(tempobj);
        }
        break;
      case 3:
        stdout.write("What's the estate's dedication?");
        stdout.write("Is it a building area (1) or a business area (2)? ");
        if((tempint = int.parse(stdin.readLineSync())) == 1){
          dedication = 1; /*building area*/
        }else if(tempint == 2){
          dedication = 2;
        }
        
        objList.add(new Estate(objnr, agents_name, typus_buyus_rentus, price, area_size, dedication, unit_value));
        
        if((tempobj = getObjektByObjNr(objnr)) != null){
          output.printObjekt(tempobj);
        }
        break;
    }
  }
}