class MyCls{
	public void doA() {
		ex05_StCls st4 = new ex05_StCls();
		st4.print();
	}
}
public class ex05_StCls {
	int a =10;
//	static: 공유 변수
	static int b = 20;
//	생성자 constructor, class명과 생성자명은 동일해야한다.
	ex05_StCls(){
		a++;
		b++;
	}
	public void print() {
		System.out.println("a = "+a);
		System.out.println("b = "+b);
	}
}
