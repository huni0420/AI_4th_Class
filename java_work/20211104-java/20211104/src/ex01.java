import aa.Car;

/*
	html,css,javascript, jqeury -> node.js react...
	class
	��ü�������α׷���
	opp :object oriented programming
	
	class A{ int a = 10; int b = 20;}
	A a = new A();
	
	public protected default private ���� ����������
	static ��������..
	
*/

public class ex01 {
	
	public static void main(String[] args) {
		//�ٸ� ������ ����� �⺻������ ���� �Ұ�
		//�ٸ� ������ �������� ������ �⺻������ ���� ����
		
		Car car1 = new Car();
		car1.doPrint();
		
		Car car2 = new Car("K3",20002.2);
		car2.doPrint();
		
		Car car3 = new Car("�ƹݶ�",2202.2);
		car3.doPrint();
	}
}
