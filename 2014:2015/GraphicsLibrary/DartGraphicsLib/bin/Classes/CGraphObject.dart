/*
 * CGraphObject serves as a base class for CLine, CCircle, CSquare, and CRectangle
 * 
 * --> stores the ID of each object
 * --> stores a center for each object
 * 
 * 
 * METHOD LIST:
 *  --> CGraphObject(int, double, double) <-- contstructor
 *  --> getPoint()
 *  --> setPos(double, double, CPoint)
 *  --> draw()
 *  --> move(double, double)
 */

library CGraphObject;

import 'CPoint.dart';
import '../Interfaces/IGraphObject.dart'; //interface

class CGraphObject implements IGraphObject{
  
  int id;
  CPoint point;
  
  /*
   * constructor
   * saves id and calls setPos() to create the center
   */
  CGraphObject(int i, double x, double y){
    id = i;
    setPos(x, y, point);
  }
  
  /*
   * returns the center
   */
  CPoint getPoint(){
    return point;
  }
  
  /*
   * returns the object's id
   */
  int getId(){
    return id;
  }
  
  
  
  
  /*________________________________________________
   * 
   * IMPLEMENTATION OF INTERFACE METHODS
   * setPos() ,move() , draw()
   * 
   * 
   */
  
  /*
   * sets the data for the center
   */
  void setPos(double x, double y, CPoint p){
    p = new CPoint(x, y);
  }
  
  /*
   * prints the data of the center
   */
  void draw(){
    print("The central point's coordinates are: (" + 
        point.getXCoord().toString() + 
        "," + 
        point.getYCoord().toString() + ")");
  }
  
  /*
   * moves the center of an object by a value entered by the user
   */
  void move(double x, double y){
    /*
     * "x != null" because in Dart all numeric types are null by default
     */
    if(x != null){ 
      point.setXCoord(point.getXCoord() + x);
    }
    
    if(y != null){
      point.setYCoord(point.getYCoord() + y);
    }
  }
}