package meinhund;

public class MeinHund {
	private String Name;
	private String rasse;
	private int alter;
	private String fellfarbe;
	
	public MeinHund(String name, String rasse, int alter, String fellfarbe) {
		super();
		Name = name;
		this.rasse = rasse;
		this.alter = alter;
		this.fellfarbe = fellfarbe;
	}
	
	public String getName() {
		return Name;
	}

	public void setName(String name) {
		Name = name;
	}

	public String getRasse() {
		return rasse;
	}
	public void setRasse(String rasse) {
		this.rasse = rasse;
	}
	public int getAlter() {
		return alter;
	}
	public void setAlter(int alter) {
		this.alter = alter;
	}
	public String getFellfarbe() {
		return fellfarbe;
	}
	public void setFellfarbe(String fellfarbe) {
		this.fellfarbe = fellfarbe;
	}
}
