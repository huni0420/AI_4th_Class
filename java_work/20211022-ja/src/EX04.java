import AA.bank;

public class EX04 {
	public static void main(String[] args) {
		bank a = new bank();
		bank b = new bank();
		
		a.account(1000);
		b.account(2000);
		
		a.deposit(1000);
		b.deposit(2000);
	}
}
