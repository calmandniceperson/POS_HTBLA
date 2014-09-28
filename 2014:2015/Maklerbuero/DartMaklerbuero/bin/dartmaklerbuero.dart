import 'dart:io';

void main() {
  Objekt obj = new Objekt();
  obj.newHouse();
}

class Objekt{
  void newHouse(){
    stdout.write('How much does the house cost?');
    int kosten = int.parse(stdin.readLineSync());
    stdout.write('What color does it have?');
    String color = stdin.readLineSync();
  }
}