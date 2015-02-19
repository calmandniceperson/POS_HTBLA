/*
 * Michael Koeppl 3AHIF
 * 19.02.2015
 * Lotto Java
 */

package lotto;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Arrays;
import java.util.Random;
import lotto.DuplicateNumberException;

public class Main {

	public static int[] corr_nums;
	static BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
	
	public static void main(String[] args) throws IOException{
		BetList blist = new BetList();
		
		String ant = "";
		
		do{
			corr_nums = new int[6];
			int numruns = 0;
			
			while(numruns != 6){
				int rnum = randInt(1, 45);
				
				if(!Arrays.asList(corr_nums).contains(rnum)){
					corr_nums[numruns] = rnum;
					numruns++;
				}else{
					continue;
				}
			}
			
			do{
				switch(menu()){
				case 1:
					System.out.print("Enter your bet (format: 22 5 1 6 7 13): ");
					String bet = br.readLine();
					
					int[] curr_bet = new int[6];
					numruns = 0;
					
					try{
						while(numruns != 6){
							if(!Arrays.asList(curr_bet).contains(Integer.parseInt(bet.split(" ")[numruns]))){
								curr_bet[numruns] = Integer.parseInt(bet.split(" ")[numruns]);
								numruns++;
							}else{
								throw new DuplicateNumberException();
							}
						}
					}catch(DuplicateNumberException ex){
						System.out.println("You entered the same number twice.");
					}
					
					blist.add(new Bet(curr_bet));
					break;
				case 2:
					String corr_num_output = "";
					for(int num : corr_nums){
						corr_num_output += (num + " ");
					}
					
					System.out.println("Correct numbers: " + corr_num_output);
					
					for(Bet b : blist.getList()){
						System.out.println(b.toString());
					}
					break;
				}
				
				
				System.out.print("Do you want to perform another action? (y/n) ");
				ant = br.readLine();
			}while(ant.toLowerCase().startsWith("y"));
			
			System.out.print("Do you want to restart? (y/n) ");
			ant = br.readLine();
		}while(ant.toLowerCase().startsWith("y"));
	}

	// method to generate a random number in a range
	public static int randInt(int min, int max) {
	    // variable so that it is not re-seeded every call.
	    Random rand = new Random();

	    // nextInt is normally exclusive of the top value,
	    // so I add 1 to make it inclusive
	    int randomNum = rand.nextInt((max - min) + 1) + min;

	    return randomNum;
	}
	
	public static int menu(){
		System.out.println("1 ... add new bet");
		System.out.println("2 ... check if you won");
		
		try{
			return Integer.parseInt(br.readLine());
		}catch(NumberFormatException ex){
			System.out.println("You didn't enter a number.");
		}catch(IOException ex){
			System.out.println("Your input was invalid.");
		}
		
		return 0;
	}
}
