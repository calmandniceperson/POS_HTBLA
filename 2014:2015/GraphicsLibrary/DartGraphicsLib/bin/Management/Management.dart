library Management;

import 'dart:io';
import '../Classes/CGraphObject.dart';
import '../Classes/Inherited_Classes/CLine.dart';
import '../Classes/Inherited_Classes/CCircle.dart';
import '../Classes/Inherited_Classes/CRectangle.dart';
import '../Classes/Inherited_Classes/CSquare.dart';
import 'Printer.dart';

class Management{
  
  /*
   * creating an object of printer for output
   */
  Printer printer = new Printer();
 
  /*
   * id for the new object
   */
  int objnr;
  
  /*
   * temporary object
   */
  CGraphObject tempobj;
  
  /*
   * additional information for CLine, CCircle, CSquare, and CRectangle
   */
  double x, y, xd, yd, radius, seitenlaenge;
  
  /*
   * this list stores all objects (CLinie, CCircle, CSquare, CRectangle)
   */
  List<CGraphObject> graphList = new List(); 
  
  /*
   * returns an object with a specific ID
   * (returns null, if there is no object with the given number)
   */
  CGraphObject getObjectById(int v){
    for(CGraphObject o in graphList){
      if(o.getId() == v){
        return o;
      }
    }
    return null;
  }
  
  /*
   * gets all the information needed to create a new object (CLinie,...)
   * creates a new object and adds it to the list
   */
  void newGraphObj(int type, int preid){
    
    /*
     * preid --> for replacing an object with a new one (old one gets removed and the new one
     *           is added with the same ID)
     * 
     * if the list is empty the number for the new object is 1
     * if the list is NOT empty the number for the next object will be the current last element's number + 1 
     */
    if(preid == null){
      if(graphList.isEmpty){
        objnr = 1;
      }else{
        objnr = graphList.length; //increases the object number for the new object
      }
    }else{
      objnr = preid;
    }
    
    /*
     * getting input data for the center (x and y)
     */
    print("Enter the center's x coordinate: ");
    x = double.parse (stdin.readLineSync());
    print("Enter the center's y coordinate: ");
    y = double.parse (stdin.readLineSync());
    
    /*
     * switching between the user's choice of creating a Line, Square, Circle, or Rectangle
     * with an integer
     */
    switch(type){
      case 1:
        print("Geben Sie an, wie weit die Endpunkte horizontal vom Mittelpunkt entfernt sind: ");
        xd = double.parse (stdin.readLineSync());
        print("Geben Sie an, wie weit die Endpunkte vertikal vom Mittelpunkt entfernt sind: ");
        yd = double.parse (stdin.readLineSync());
        
        graphList.add (new CLine (objnr, x, y, xd, yd));
        
        printer.printObject (objnr);
        
        break;
      case 2:
        print("Geben Sie die Höhe an: ");
        xd = double.parse (stdin.readLineSync());
        print("Geben Sie die Breite an: ");
        yd = double.parse (stdin.readLineSync());
        
        graphList.add (new CRectangle (objnr, x, y, xd, yd));
        
        printer.printObject (objnr);
        
        break;
      case 3:
        print("Geben Sie den Radius des Kreises an: ");
        radius = double.parse (stdin.readLineSync());
        
        graphList.add (new CCircle (objnr, x, y, radius));
        
        printer.printObject (objnr);
        break;
      case 4:
        print("Geben Sie die Länge einer Seite an: ");
        seitenlaenge = double.parse (stdin.readLineSync());
        
        graphList.add (new CSquare (objnr, x, y, seitenlaenge));
        
        printer.printObject (objnr);
        break;
    }
  }
}