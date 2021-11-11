import AA.Car;
public class ex04 {
	public static void main(String[] args) {
		Car c1 = new Car();
		c1.doPrint();
		c1.in_area = 30; //접근불가
		System.out.println();
		c1.setIn_area(30);
		c1.setName("자동차");
		c1.setHeight(180);
		c1.doPrint();
	}
}
