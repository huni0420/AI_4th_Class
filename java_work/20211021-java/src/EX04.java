//import AA.aa;
/*
 * 다른 패키지에 있는 클래스를 호출할떄는 import 구문을 적어야 한다.
 * 
 * 같은 패키지내에 있는 클래스를 호출할때는 import 구문을 적지 않는다.
 *  
 */
public class EX04 {
	public static void main(String[] args)
	{
		aa a1=new aa();
		System.out.println("시작");
		a1.hi(13, 169.5);
		a1.by();
		System.out.println("끝");
	}
}
