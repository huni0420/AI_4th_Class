
public class EX03 {
	static int bal = 0;

	public static void main(String[] args) {
		deposit(10000);
		chekdep();
		withdraw(3000);
		chekdep();
	}

	public static int deposit(int amount) {
		bal += amount;
		return bal;
	}

	public static int withdraw(int amount) {
		bal -= amount;
		return bal;
	}

	public static int chekdep() {
		System.out.println("ภÜพื: " + bal);
		return bal;
	}
}
