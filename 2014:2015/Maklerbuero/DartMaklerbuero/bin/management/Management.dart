library Management;

import '../classes/Objekt.dart';
import '../classes/subclasses/House.dart';
import '../classes/subclasses/Flat.dart';
import '../classes/subclasses/Estate.dart';
import '../management/Output.dart';
import '../management/MenuClass.dart';
import 'dart:io';

class Management{
  
  List<Objekt> objList = new List(); //list of objects
  Output output = new Output();
  
  /*TEMPORARIES*/
  int tempint;
  bool tempbool;
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
  
  void deleteObjekt(int onr){
    objList.remove(getObjektByObjNr(onr));
  }
  
  void editObjekt(int onr, MenuClass mc){
    for(Objekt o in objList){
      if(o.getObjNr() == onr){
        switch(mc.showEditMenu(o)){
          case 1: /*agents name*/
            stdout.writeln("This currently responsible agent's name is " + o.getAgentsName() + ".");
            stdout.write("Who's the new reponsible agent? (first name + last name)");
            o.setAgentsName(stdin.readLineSync());
            stdout.writeln("This object's new agent is " + o.getAgentsName() + ".");
            break;
          case 2: /*typus_buyus_rentus*/
            if((tempbool = o.getTBR())){
              stdout.writeln("This object is currently to be bought.");
              stdout.write("Do you want the object to be rentable? (y/n) ");
              if((temp = stdin.readLineSync().toLowerCase()).startsWith("y")){
                o.setTBR(false);
                stdout.writeln("This object now is to be rented.");
              }else{
                stdout.writeln("This object remains to be bought.");
              }
            }else if(!tempbool){
              stdout.writeln("This object is currently to be rented.");
              stdout.write("Do you want the object to be buyable? (y/n) ");
              if((temp = stdin.readLineSync().toLowerCase()).startsWith("y")){
                o.setTBR(true);
                stdout.writeln("This object now is to be bought.");
              }else{
                stdout.writeln("This object remains to be rented.");
              }
            }
            break;
          case 3: /*price*/
            stdout.writeln("This object's current price is " + o.getPrice().toString() + "€.");
            stdout.write("Enter the object's new price: ");
            o.setPrice(double.parse(stdin.readLineSync()));
            stdout.writeln("This object's new price is " + o.getPrice().toString() + "€.");
            break;
          case 4: /*area size*/
            stdout.writeln("This object's current area size is " + o.getAreaSize().toString() + "m^2.");
            stdout.write("Enter the object's new area size: ");
            o.setAreaSize(double.parse(stdin.readLineSync()));
            stdout.writeln("This object's area size now is " + o.getAreaSize().toString() + "m^2.");
            break;
          case 5: /*(house) multifamily*/
            if(o is House){
              if((tempbool = o.getMultiFam())){
                stdout.writeln("This house is a multifamily house.");
                stdout.write("Do you want to change that? ");
                if((temp = stdin.readLineSync().toLowerCase()).startsWith("y")){
                  o.setMultiFam(false);
                  stdout.writeln("This how now is a single family house.");
                }else{
                  stdout.writeln("This house remains a multifamily house.");
                }
              }else if(!tempbool){
                stdout.writeln("This house is not a multifamily house.");
                stdout.write("Do you want to change that? (y/n) ");
                if((temp = stdin.readLineSync().toLowerCase()).startsWith("y")){
                  o.setMultiFam(true);
                  stdout.writeln("This house is now a multi family house");
                }else{
                  stdout.writeln("This house remains a single family house.");
                }
              }
            }
            break;
          case 6: /*(house) floor_count*/
            if(o is House){
              stdout.writeln("This house has " + o.getFloorCount().toString() + " floors.");
              stdout.write("What's the house's new number of floors? ");
              o.setFloorCount(int.parse(stdin.readLineSync()));
              stdout.writeln("This house now has " + o.getFloorCount().toString() + " floors.");
            }
            break;
          case 7: /*(house) cellar*/
            if(o is House){
              if(o.getCellar()){
                stdout.writeln("This house has a cellar.");
                stdout.writeln("Do you want to change that? (y/n) ");
                if((temp = stdin.readLineSync().toLowerCase()).startsWith("y")){
                  o.setCellar(false);
                  stdout.writeln("This house now doesn't have a cellar anymore.");
                }else{
                  stdout.writeln("This house still has a cellar.");
                }
              }else if(!o.getCellar()){
                stdout.writeln("This house doesn't have a cellar.");
                stdout.writeln("Do you want to change that? (y/n) ");
                if((temp = stdin.readLineSync().toLowerCase()).startsWith("y")){
                  o.setCellar(true);
                  stdout.writeln("This house now has a cellar.");
                }else{
                  stdout.writeln("This house still has no cellar.");
                }
              }
            }
            break;
          case 8: /*(flat) room_count*/
            if(o is Flat){
              stdout.writeln("This flat has " + o.getRoomCount().toString() + " rooms.");
              stdout.write("What's the flat's new number of rooms? ");
              o.setRoomCount(int.parse(stdin.readLineSync()));
              stdout.writeln("This flat now has " + o.getRoomCount().toString() + " rooms.");
            }
            break;
          case 9: /*(flat) bathtub/showercabin*/
            if(o is Flat){
              if(o.getBS()){
                stdout.writeln("This flat includes a bathtub.");
                stdout.write("Do you want to change that? (y/n) ");
                if((temp = stdin.readLineSync().toLowerCase()).startsWith("y")){
                  o.setBS(false);
                  stdout.writeln("This flat now has a shower cabin.");
                }else{
                  stdout.writeln("This flat still includes a bathtub.");
                }
              }else if(!o.getBS()){
                stdout.writeln("This flat includes a shower cabin.");
                stdout.write("Do you want to change that? (y/n) ");
                if((temp = stdin.readLineSync().toLowerCase()).startsWith("y")){
                  o.setBS(true);
                  stdout.writeln("This flat now has a bathtub.");
                }else{
                  stdout.writeln("This flat still includes a shower cabin.");
                }
              }
            }
            break;
          case 10: /*(estate) dedication*/
            if(o is Estate){
              if(o.getDedication() == 1){
                stdout.writeln("This estate currently is a building area.");
                stdout.write("Do you want to change that? (y/n) ");
                if((temp = stdin.readLineSync().toLowerCase()).startsWith("y")){
                  o.setDedication(2);
                }else{
                  stdout.writeln("This estate remains a building area.");
                }
              }else if(o.getDedication() == 2){
                stdout.writeln("This estate currently is a business area.");
                stdout.write("Do you want to change that? (y/n) ");
                if((temp = stdin.readLineSync().toLowerCase()).startsWith("y")){
                  o.setDedication(1);
                }else{
                  stdout.writeln("This estate remains a business area.");
                }
              }
            }
            break;
          case 11: /*(estate) unit_value*/
            if(o is Estate){
              stdout.writeln("This estate's unit value currently is " + o.getUnitValue().toString() + ".");
              stdout.write("Enter the estate's new unit value: ");
              o.setUnitValue(double.parse(stdin.readLineSync()));
            }
            break;
        }
      }
    }
  }
}