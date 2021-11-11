import AA.bank;
public class EX05 {
	public static void main(String[] args) {
		bank ref1 = new bank();
		bank ref2 = ref1;
		
		ref1.deposit(1000);
		ref2.checkbal();
		
		ref2.deposit(2000);
		ref1.checkbal();
		
		check(ref1);
		System.out.println("acc¿¡¼­ ¹Ù²Þ");
		
		ref1=null;
		if(ref1==null) {
			System.out.println("¿¬°á ²÷±è");
		}
		if(ref2!=null) {
			System.out.println("ref2´Â ¿¬°áÁß...");
		}
		
		ref1.withdaw(400);
		ref2.checkbal();
	}
	public static void check(bank acc) {
		acc.checkbal();
	}
}