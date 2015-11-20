import java.util.Hashtable;
import java.util.Properties;
import java.util.Stack;
import java.util.Vector;

public class LegatBeispiel {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Vector<String> v = new Vector<String>();
		v.add("Hello");
		v.add(0, "First");
		System.out.println(v);
		
		System.out.println("\nStack: ");
		Stack<String> s = new Stack<String>();
		s.push("Hello");
		s.push("there");
		System.out.println(s);
		System.out.println("Last element: " + s.peek());
		s.pop();
		System.out.println("Last element after pop: " + s.peek());
		
		System.out.println("\nHashTable: ");
		Hashtable<String, Object> ht = new Hashtable<String, Object>();
		ht.put("1.", new Integer(1));
		ht.put("3.", new Integer(3));
		System.out.println(ht.entrySet());
		System.out.println(ht.values());
		System.out.println(ht.keySet());
		
		System.out.println("\nProperties: ");
		Properties p = new Properties();
		p.put("Hello", 1);
		System.out.println(p);
	}

}
