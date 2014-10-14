library Printer;

import '../Classes/CGraphObject.dart';
import '../Management/Management.dart';

class Printer{
  
  /*
   * Management object for accessing the management classes' methods
   */
  Management m;
  
  /*
   * temporary object for storing a found object
   */
  CGraphObject tempobj;
  
  void printObject(int objnr){
    
    if((tempobj = m.getObjectById(objnr)) != null){
      print("____________________________");
      print("Objektnummer: " + tempobj.getId ().toString ());
      
      /*if(tempobj is CLine){
        tempobj.draw();
      }else if(tempobj is CCircle){
        tempobj.draw();
      }else if(tempobj is CRectangle){
        tempobj.draw();
      }else if(tempobj is CSquare){
        tempobj.draw()
      }*/
      
      tempobj.draw();
    }
  }
  
  void printAll(List gList){
    for(CGraphObject o in gList){
      printObject(o.getId());
    }
  }
  
}