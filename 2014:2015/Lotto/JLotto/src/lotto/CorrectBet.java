package lotto;

interface ICorrectBet{
	public void printWin();
}

public class CorrectBet implements ICorrectBet{
	public void printWin(){
		System.out.println("You had 4 or more correct numbers!");
	}
}
