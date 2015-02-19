package lotto;

import lotto.CorrectBet;
import lotto.NotEnoughCorrectBets;

public class Bet {
	
	int[] bet;
	CorrectBet correctBetListener = new CorrectBet();
	NotEnoughCorrectBets necb = new NotEnoughCorrectBets();
	
	public Bet(int[] arr){
		bet = arr;
	}

	@Override
	public String toString() {
		int anz_corr_nums = 0;
		String output = "";
		
		for(int num : bet){
			output += (num + " ");
			for(int cornum : Main.corr_nums){
				if(num == cornum){
					anz_corr_nums++;
				}else{
					continue;
				}
			}
		}
		
		if(anz_corr_nums > 4){
			if(correctBetListener != null){
				correctBetListener.printWin();
			}
		}else{
			if(necb != null){
				necb.print();
			}
		}
		
		return output;
	}
	
	
}