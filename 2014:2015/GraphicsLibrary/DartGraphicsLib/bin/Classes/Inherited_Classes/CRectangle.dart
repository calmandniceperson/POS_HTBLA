library CRectangle;

import '../CGraphObject.dart';

class CRectangle extends CGraphObject{
  
  /*
   * xd = width/2
   * yd = height/2
   */
  double xd, yd;
  
  CRectangle(int i, double x, double y, double xdvalue, double ydvalue):super(i, x, y){
    /*
     * /2 because we want the user to enter the full height and width
     * because it would look odd otherwise
     */
    xd = x/2;
    yd = y/2;
  }
  
  /*
   * override base draw and call base draw
   * prints the center, height, width and all 4 corners
   */
  void draw(){
    super.draw();
    print("This object is a rectangle.");
    print("height: " + (xd*2).toString());
    print("width: " + (yd*2).toString());
    print("data of the upper left corner: (" + (getPoint().getXCoord () - xd).toString () + "," + (getPoint().getYCoord () + yd).toString () + ")");
    print("data of the upper right corner: (" + (getPoint().getXCoord () + xd).toString () + "," + (getPoint().getYCoord () + yd).toString () + ")");
    print("data of lower left corner: (" + (getPoint().getXCoord () - xd).toString () + "," + (getPoint().getYCoord () - yd).toString () + ")");
    print("data of lower right corner: (" + (getPoint().getXCoord () + xd).toString () + "," + (getPoint().getYCoord () - yd).toString () + ")");
  }
}