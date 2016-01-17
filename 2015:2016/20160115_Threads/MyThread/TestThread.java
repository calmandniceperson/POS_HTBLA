import java.lang.Thread;

public class TestThread {
	public static void main(String []args) {
		Thread t1 = new Thread(new MyThread(1));
		Thread t2 = new Thread(new MyThread(2));
		t1.start();
		t2.start();
	}
}
