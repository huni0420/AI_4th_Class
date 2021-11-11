import AA.bank;
public class EX06 {
	public static void main(String[] args) {
		bank a1 = new bank();
		a1.init("°èÁÂ¹øÈ£ 1111","ÁÖ¹Î¹øÈ£ 1111",1000);
		
		bank a2 = new bank();
		a2.init("°èÁÂ¹øÈ£ 2222","ÁÖ¹Î¹øÈ£ 2222",1000);
		
		a1.checkbal();
		a2.checkbal();
		
		
	}
}
