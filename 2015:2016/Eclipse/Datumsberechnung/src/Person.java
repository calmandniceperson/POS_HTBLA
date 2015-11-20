import java.time.LocalDate;

public class Person {
	LocalDate geb;
	String name;
	
	Person(LocalDate geb, String name) {
		this.geb = geb;
		this.name = name;
	}
	
	public LocalDate getGeb(){
		return this.geb;
	}
	
	public String getName() {
		return this.name;
	}
}
