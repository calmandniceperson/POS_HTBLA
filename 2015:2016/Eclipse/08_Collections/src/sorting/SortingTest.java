package sorting;

import java.util.ArrayList;
import java.util.Calendar;
import java.util.Collections;
import java.util.GregorianCalendar;

public class SortingTest {

	public static void main(String[] args) {
		ArrayList<Person> pl = new ArrayList<Person>();
		pl.add(new Person("Hans", "Meier", 12));
		pl.add(new Person("Fritz", "Mueller", 17));
		pl.add(new Person("Markus", "Troester", 11));
		pl.add(new Person("Tim", "Berger", 23));
		pl.add(new Person("Max", "Mustermann", 18));
		
		for(Person p:pl) {
			System.out.println(p.toString());
		}
		System.out.println("\n");
		Collections.sort(pl);
		for(Person p:pl) {
			System.out.println(p.toString());
		}
	}

}
