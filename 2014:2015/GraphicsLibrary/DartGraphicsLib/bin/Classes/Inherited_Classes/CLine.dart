library CLine;

import '../CGraphObject.dart'; //import /bin/Classes/CGraphObject.dart/

class CLine extends CGraphObject{
  
  double xd, yd; /*xd is the line on the x axis*/
  
  CLine(int i, double x, double y, double xdvalue, double ydvalue):super(i, x, y){
    xd = xdvalue;
    yd = ydvalue;
  }
  
  void draw(){
    super.draw();
    print("This line's start point is at (" + 
        (getPoint().getXCoord() - xd).toString() + 
        "," + 
        (getPoint().getYCoord() + yd).toString() + ")\n\r");
    print("and it's start point is at (" + 
            (getPoint().getXCoord() - xd).toString() + 
            "," + 
            (getPoint().getYCoord() + yd).toString() + ")\n\r");
  }
}