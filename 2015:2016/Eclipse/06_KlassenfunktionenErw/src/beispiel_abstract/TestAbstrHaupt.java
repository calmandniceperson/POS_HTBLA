package beispiel_abstract;

public class TestAbstrHaupt {
    public static void main(String[] args) {
          Schueler s = new Schueler();
          System.out.println("Name : "+s.getName()+ " "+s.singName());
//Person p = new Person(); abstrakte Klassen kann man nicht //instanzieren.
} }