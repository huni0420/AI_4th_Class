class MyCls{
	public void doA() {
		ex05_StCls st4 = new ex05_StCls();
		st4.print();
	}
}
public class ex05_StCls {
	int a =10;
//	static: ���� ����
	static int b = 20;
//	������ constructor, class��� �����ڸ��� �����ؾ��Ѵ�.
	ex05_StCls(){
		a++;
		b++;
	}
	public void print() {
		System.out.println("a = "+a);
		System.out.println("b = "+b);
	}
}
