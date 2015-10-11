package poly4_wrapper;

public class WrapperHaupt {

	public static void main(String[] args) {
		long startTime = System.currentTimeMillis();
		Integer iw = 2;
		long endTime = System.currentTimeMillis();
		long dauer1 = endTime - startTime;
		System.out.println("1 Autoboxing: " + dauer1 + "ms");
		
		/*
		 * BLOCK 2 - 1232435 durchlaeufe mit neuerstellung
		 */
		// autoboxing
		startTime = System.currentTimeMillis();
		for(int i = 0; i < 1232435; i++) {
			Integer iw2 = i;
		}
		endTime = System.currentTimeMillis();
		long dauer2 = endTime - startTime;
		System.out.println("\n1232435 Autoboxings mit wiederholter Erstellung des Wrappers: " + dauer2 + "ms");
		
		// boxing
		Integer iw4;
		startTime = System.currentTimeMillis();
		for(int i = 0; i < 342352352; i++) {
			iw4 = Integer.valueOf(i);
		}
		endTime = System.currentTimeMillis();
		long dauer3 = endTime - startTime;
		System.out.println("342352352 Boxings ohne wiederholter Erstellung des Wrappers: " + dauer3 + "ms");
		System.out.println("Autoboxing war um " + (dauer3-dauer2) + "ms schneller als Boxing.");
		
		startTime = System.currentTimeMillis();
		for(int i = 0; i < 1232435; i++) {
			int iw2 = i;
		}
		endTime = System.currentTimeMillis();
		long dauer4 = endTime - startTime;
		System.out.println("1232435 Integer mit wiederholter Erstellung eines Integers: " + dauer3 + "ms");
		System.out.println("Erstellung des Integers war um " + (dauer2-dauer4) + "ms schneller.");
		
		/*
		 * BLOCK 3 - 342352352 durchlaeufe ohne neuerstellung
		 */
		// autoboxing
		Integer iw3;
		startTime = System.currentTimeMillis();
		for(int i = 0; i < 342352352; i++) {
			iw3 = i;
		}
		endTime = System.currentTimeMillis();
		long dauer5 = endTime - startTime;
		System.out.println("\n342352352 Autoboxings ohne wiederholter Erstellung des Wrappers: " + dauer5 + "ms");
		
		// boxing
		Integer iw5;
		startTime = System.currentTimeMillis();
		for(int i = 0; i < 342352352; i++) {
			iw5 = Integer.valueOf(i);
		}
		endTime = System.currentTimeMillis();
		long dauer6 = endTime - startTime;
		System.out.println("342352352 Boxings ohne wiederholter Erstellung des Wrappers: " + dauer6 + "ms");
		System.out.println("Autoboxing war um " + (dauer6-dauer5) + "ms schneller als Boxing.");
		
		// int
		int iw3_int;
		startTime = System.currentTimeMillis();
		for(int i = 0; i < 342352352; i++) {
			iw3_int = i;
		}
		endTime = System.currentTimeMillis();
		long dauer7 = endTime - startTime;
		System.out.println("342352352 Integerzuweisung ohne wiederholter Erstellung des Integers: " + dauer7 + "ms");
		System.out.println("Erstellung des Integers war um " + (dauer5 - dauer7) + "ms schneller als Boxing.");
	}

}
