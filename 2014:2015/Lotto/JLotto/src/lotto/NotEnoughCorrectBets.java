package lotto;

interface INotEnoughCorrectBets{
	public void print();
}

public class NotEnoughCorrectBets {
	public void print(){
		System.out.println("Unfortunately the bet listed below doesn't have enough correct number.");
	}
}
