library CSquare;

import '../CGraphObject.dart';

class CSquare extends CGraphObject{
  
  double hsl; /*half side length*/
  
  CSquare(int i, double x, double y, double hslvalue):super(i, x, y){
    hsl = hslvalue/2;
  }
  
  void draw(){
    super.draw();
        print("This object is a rectangle.");
        print("height: " + (hsl*2).toString());
        print("width: " + (hsl*2).toString());
        print("data of the upper left corner: (" + (getPoint().getXCoord () - hsl).toString () + "," + (getPoint().getYCoord () + hsl).toString () + ")");
        print("data of the upper right corner: (" + (getPoint().getXCoord () + hsl).toString () + "," + (getPoint().getYCoord () + hsl).toString () + ")");
        print("data of lower left corner: (" + (getPoint().getXCoord () - hsl).toString () + "," + (getPoint().getYCoord () - hsl).toString () + ")");
        print("data of lower right corner: (" + (getPoint().getXCoord () + hsl).toString () + "," + (getPoint().getYCoord () - hsl).toString () + ")");
  }
}