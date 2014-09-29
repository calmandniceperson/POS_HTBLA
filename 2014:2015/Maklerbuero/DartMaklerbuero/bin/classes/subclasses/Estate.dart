library Estate;

import '../Objekt.dart';

class Estate extends Objekt{
  
  /*1=building area   2=business area  --> no enum in Dart yet -->using int for the case there are more dedications to come*/
  int dedication; 
  double unit_value; /*the unit's value*/
  
  Estate(int objnr, String an, bool tbr, double p, double as, int d, double uv):super(objnr, an, tbr, p, as){
    dedication = d;
    unit_value = uv;
  }
  
  /*GET*/
  int getDedication(){
    return dedication;
  }
  
  double getUnitValue(){
    return unit_value;
  }
  /*GET*/
  
  /*SET*/
  void setDedication(int v){
    dedication = v;
  }
  
  void setUnitValue(double v){
    unit_value = v;
  }
  /*SET*/
}