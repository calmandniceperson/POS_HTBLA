library Objekt;

class Objekt{
  int objNr;
  String agents_name;
  bool typus_buyus_rentus;
  double price;
  double area_size;
  
  /*constructor*/
  Objekt(int objnr, String an, bool tbr, double p, double as){
    objNr = objnr;
    agents_name = an;
    typus_buyus_rentus = tbr;
    price = p;
    area_size = as;
  }
  
  /*GET*/
  int getObjNr(){
    return objNr;
  }
  
  String getAgentsName(){
    return agents_name;
  }
  
  bool getTBR(){
    return typus_buyus_rentus;
  }
  
  double getPrice(){
    return price;
  }
  
  double getAreaSize(){
    return area_size;
  }
  /*GET*/
  
  /*SET*/
  void setObjrNr(int v){
    objNr = v;
  }
  
  void setAgentsName(String v){
    agents_name = v;
  }
  
  void setTBR(bool v){
    typus_buyus_rentus = v;
  }
  
  void setPrice(double v){
    price = v;
  }
  
  void setAreaSize(double v){
    area_size = v;
  }
  /*SET*/
}