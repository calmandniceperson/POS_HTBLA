import java.lang.Runnable;

public class MyThread implements Runnable{
	private int threadNum;
	
	public MyThread(int tn) {
		this.threadNum = tn;
	}
	
	public void run() {
		for(int i = 0; i <= 99; i++) {
			System.out.println("Thread "+threadNum+": " + i);
		}
	}
}
