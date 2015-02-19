package lotto;

import java.util.ArrayList;
import java.util.List;
import lotto.Bet;

public class BetList {
	List<Bet> betList = new ArrayList<Bet>();
	
	public void add(Bet b){
		betList.add(b);
	}
	
	public void print(){
		for(Bet b : betList){
			b.toString();
		}
	}
	
	public List<Bet> getList(){
		return betList;
	}
}
