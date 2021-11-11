import aa.Car;

/*
	html,css,javascript, jqeury -> node.js react...
	class
	객체지향프로그래밍
	opp :object oriented programming
	
	class A{ int a = 10; int b = 20;}
	A a = new A();
	
	public protected default private 접근 제어지시자
	static 공유변수..
	
*/

public class ex01 {
	
	public static void main(String[] args) {
		//다른 생성자 선언시 기본생성자 생략 불가
		//다른 생성자 선언하지 않을시 기본생성자 생략 가능
		
		Car car1 = new Car();
		car1.doPrint();
		
		Car car2 = new Car("K3",20002.2);
		car2.doPrint();
		
		Car car3 = new Car("아반떼",2202.2);
		car3.doPrint();
	}
}
