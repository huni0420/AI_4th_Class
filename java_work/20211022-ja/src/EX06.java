import AA.bank;
public class EX06 {
	public static void main(String[] args) {
		bank a1 = new bank();
		a1.init("���¹�ȣ 1111","�ֹι�ȣ 1111",1000);
		
		bank a2 = new bank();
		a2.init("���¹�ȣ 2222","�ֹι�ȣ 2222",1000);
		
		a1.checkbal();
		a2.checkbal();
		
		
	}
}
