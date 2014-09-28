library Flat;

import '../Objekt.dart';

class Flat extends Objekt{
  
  int room_count; //number of rooms
  bool bathtub_showercabin; //bathtub (true) or shower cabin (false)
  
  //constructor
  Flat(int objnr, String an, bool tbr, double p, double as, int rc, bool bs):super(objnr, an, tbr, p, as){
    room_count = rc;
    bathtub_showercabin = bs;
  }
  
  /*GET*/
  int getRoomCount(){
    return room_count;
  }
  
  bool getBS(){
    return bathtub_showercabin;
  }
  /*GET*/
  
  /*SET*/
  void setRoomCount(int v){
    room_count = v;
  }
  
  void setBS(bool v){
    bathtub_showercabin = v;
  }
  /*SET*/
}