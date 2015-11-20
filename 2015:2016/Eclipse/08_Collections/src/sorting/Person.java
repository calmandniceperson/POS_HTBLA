package sorting;

public class Person implements Comparable {
	private String vname;
	private String nname;
	private int alter;
	
	Person(String vname, String nname, int alter) {
		this.vname = vname;
		this.nname = nname;
		this.alter = alter;
	}

	public String getVname() {
		return vname;
	}

	public String getNname() {
		return nname;
	}

	public int getAlter() {
		return alter;
	}

	@Override
	public int compareTo(Object o) {
		Person p = (Person)o;
		return Integer.compare(this.alter, p.alter);
		// return (x < y) ? -1 : ((x == y) ? 0 : 1);
	}

	@Override
	public String toString() {
		return "Person [vname=" + vname + ", nname=" + nname + ", alter=" + alter + ", toString()=" + super.toString()
				+ "]";
	}
}
