library CPoint;

class CPoint{
  
  double xcoord, ycoord;
  
  CPoint(double x, double y){
    xcoord = x;
    ycoord = y;
  }
  
  double getXCoord(){
    return xcoord;
  }
  
  double getYCoord(){
    return ycoord;
  }
  
  void setXCoord(double v){
    xcoord = v;
  }
  
  void setYCoord(double v){
    ycoord = v;
  }
}