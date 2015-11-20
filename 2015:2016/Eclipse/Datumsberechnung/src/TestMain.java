import java.time.LocalDate;
import java.time.temporal.ChronoUnit;

public class TestMain {

	public static void main(String[] args) {
		Person p1 = new Person(LocalDate.of(1997, 3, 7), "Michael");
		Person p2 = new Person(LocalDate.of(1991, 8, 2), "Hans");
		
		if(p1.getGeb().isBefore(p2.getGeb())) {
			System.out.println(p1.getName() + " ist " + ChronoUnit.YEARS.between(p1.getGeb(),  p2.getGeb()) + " Jahre aelter als " + p2.getName());
		} else if(p1.getGeb().isAfter(p2.getGeb())) {
			System.out.println(p2.getName() + " ist " + ChronoUnit.YEARS.between(p2.getGeb(),  p1.getGeb()) + " Jahre aelter als " + p1.getName());
		} else {
			System.out.println(p1.getName() + " und " + p2.getName() + " sind gleichalt.");
		}
		
		System.out.println(p1.getName() + "s Geburtstag ist am " + p1.getGeb());
		System.out.println(p2.getName() + " Geburtstag ist am " + p2.getGeb());
	}

}
