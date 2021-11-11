//상속 extends

class Paa{
	int num;
}
public class aa extends Paa{
	public aa() {
		System.out.println("num = "+num);
		System.out.println("일로온다.");	
	}
	
	public static void main(String[] args) {
		aa a1 = new aa();
	}
}