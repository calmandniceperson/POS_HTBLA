import 'dart:io';
import 'management/Management.dart';
import 'management/MenuClass.dart';
import 'management/Output.dart';

void main() {
  String ant;
  MenuClass mc = new MenuClass();
  Management m = new Management();
  Output output = new Output();
  
  do{
    
    switch(mc.showMainMenu()){
      case 1:
        m.newObjekt();
        break;
      case 2:
        stdout.write("Enter the object number of the object you wish to delete: ");
        m.deleteObjekt(int.parse(stdin.readLineSync()));
        break;
      case 3:
        stdout.write("Enter the object number of the object you wish to delete: ");
        m.editObjekt(int.parse(stdin.readLineSync()), mc);
        break;
      case 4:
        output.printAll(m.getObjList());
        break;
      case 5:
        break;
      case 6:
        break;
    }
    
    stdout.write("Do you want to execute another action? (y/n)");
    ant = stdin.readLineSync();
  }while(ant.toLowerCase().startsWith("y"));
}