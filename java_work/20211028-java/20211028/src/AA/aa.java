package AA;

public class aa {

	public int num1;
	public String name;

	public aa(){}

	public aa(int n) {
		num1 = n;
	}

	public aa(int n, String sn) {
		num1 = n;
		name = sn;
	}

	public void doprint() {
		System.out.println("num1 = " + num1);
		System.out.println("name = " + name);
	}
}
