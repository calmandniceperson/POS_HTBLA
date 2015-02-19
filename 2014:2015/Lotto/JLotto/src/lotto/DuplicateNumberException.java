package lotto;

public class DuplicateNumberException extends Exception{
	/**
	 * 
	 */
	private static final long serialVersionUID = 1L;

	public DuplicateNumberException(){}
	
	public DuplicateNumberException(String message){
		super(message);
	}
}
