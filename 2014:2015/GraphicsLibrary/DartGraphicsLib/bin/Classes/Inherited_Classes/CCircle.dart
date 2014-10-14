library CCircle;

import '../CGraphObject.dart';

class CCircle extends CGraphObject{
  
  double radius;
  
  CCircle(int i, double x, double y, double rvalue):super(i, x, y){
    radius = rvalue;
  }
  
  void draw(){
    super.draw();
    print("This object is a circle with a radius of " + radius.toString() + ".");
  }
}