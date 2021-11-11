
public class ex02 {
	
	public static void doA(int a) {
		System.out.println("a = "+a);
	}
	public static void main(String[] args) {

	A a = new A();
	B b = new B();
	
	ABCTake abc = new ABCTake();
	abc.takeA(a);
	abc.takeB(b);
	abc.takeC(new C());
	
	abc.seqtakeABC(new A(), new B(), new C());
	
	}
}