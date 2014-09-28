class Objekt{
  int objNr;
  String makler;
  bool typus_kaufus_mietus;
  double kosten;
  double flaeche;
  
  Objekt(int objnr, String m, bool tkm, double k, double f){
    objNr = objnr;
    makler = m;
    typus_kaufus_mietus = tkm;
    kosten = k;
    flaeche = f;
    
    void newObjekt(){
      
    }
  }
}

class Wohnung extends Objekt{
  int anz_zimmer;
  bool bade_dusche;
  Wohnung(int objnr, String m, bool tkm, double k, double f, int anz_z, bool db):super(objnr, m, tkm, k, f){
    anz_zimmer = anz_z;
    bade_dusche = db;
  }
  
  
}