import java.lang.Thread;
import java.lang.InterruptedException;

public class TestThread {
	public static void main(String []args) {
		Thread t1 = new Thread() {
		    public void run() {
				for(int i = 0; i <= 99; i++) {
					System.out.println("Thread 1: " + i);
					/*try {
						Thread.sleep(200);
					} catch (InterruptedException ex) {
						
					}*/
				}
			}
		};
		Thread t2 = new Thread() {
		    public void run() {
		   	    for(int i = 0; i <= 99; i++) {
					System.out.println("Thread 2: " + i);
					/*try {
						Thread.sleep(200);
					} catch (InterruptedException ex) {
						
					}*/
				}
			}
		};
		t1.start();
		t2.start();
	}
}
