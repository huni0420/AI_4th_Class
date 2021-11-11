package AA;

public class bank {
	
	static int bal=0;
	public String accnumber;
	public String ssnumber;
	
	public bank(String acc,String ss, int balance) {
		accnumber = acc;
		ssnumber=ss;
		bal=balance;
	}
	public bank() {
		
	}
	public int deposit(int num) {
		bal+=num;
		System.out.println(bal);
		return bal;
	}
	public int withdaw(int num) {
		bal -= num;
		System.out.println(bal);
		return bal;
	}
	public void checkbal() {
		System.out.println(bal);
		System.out.println("°èÁÂ¹øÈ£ : " +accnumber);
		System.out.println("ÁÖ¹Î¹øÈ£ : " +ssnumber);
	}
	public void init(String acc, String ss, int balance) {
		accnumber = acc;
		ssnumber=ss;
		bal=balance;
	}
}
