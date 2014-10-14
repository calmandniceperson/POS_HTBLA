library IGraphObject;

import '../Classes/CPoint.dart';

abstract class IGraphObject{
  void setPos(double x, double y, CPoint p);
  void draw();
  void move(double x, double y);
}