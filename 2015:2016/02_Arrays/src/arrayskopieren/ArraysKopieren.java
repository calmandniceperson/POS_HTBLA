package arrayskopieren;

import java.util.*;

public class ArraysKopieren {
	public static void main(String[] args) {
		char[] alph = "abcdefghijklmnopqrstuvwxyz".toCharArray();
		char[] alphdest_arraycopy = new char[26];
		System.out.println("Calling arraycopy...");
		System.arraycopy(alph, 0, alphdest_arraycopy, 0, alph.length);
		for(int i = 0; i <= alphdest_arraycopy.length - 1; i++) {
			System.out.print(alphdest_arraycopy[i] + " ");
		}
		
		System.out.println("\n\nCalling copyof...");
		char[]alphdest_copyof = Arrays.copyOf(alph, alph.length);
		for(int i = 0; i <= alphdest_copyof.length - 1; i++) {
			System.out.print(alphdest_copyof[i] + " ");
		}
	}
}
