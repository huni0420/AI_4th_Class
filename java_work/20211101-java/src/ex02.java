class AAA{
	public static int AAAA = 1000;
}
public class ex02 {
	public static int num = 100;
	
	public static void main(String[] args) {
		ex02.num -= 10;
		System.out.println("ex02.num = "+ex02.num);
		
		System.out.println("ex02.num = "+ex02.num);
		System.out.println("AAA.AAAA = "+AAA.AAAA);
	}
}
