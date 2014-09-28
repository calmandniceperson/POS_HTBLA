library House;

import '../Objekt.dart';

class House extends Objekt{
  
  bool multifamily; //house for multiple families (true) or for a single family (false)
  int floor_count; //number of floors
  bool cellar; //does the house have a cellar (true) or not (false)
  
  House(int objnr, String an, bool tbr, double p, double as, bool mf, int fc, bool c):super(objnr, an, tbr, p, as){
    multifamily = mf;
    floor_count = fc;
    cellar = c;
  }
  
  /*GET*/
  bool getMultiFam(){
    return multifamily;
  }
  
  int getFloorCount(){
    return floor_count;
  }
  
  bool getCellar(){
    return cellar;
  }
  /*GET*/
  
  /*SET*/
  void setMultiFam(bool v){
    multifamily = v;
  }
  
  void setFloorCount(int v){
    floor_count = v;
  }
  
  void setCellar(bool v){
    cellar = v;
  }
  /*SET*/
}