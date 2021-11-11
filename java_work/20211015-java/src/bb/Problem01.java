package bb;

public class Problem01 {
	public static void main(String[] args) {
		int num1 = 10;
		int num2 = 20;
		int num3 = 30;
		num1 = num2 = num3;
		System.out.println(num1);
		System.out.println(num2);
		System.out.println(num3);
		//=대입이 오른쪽에서 왼쪽으로 이루어 지기때문에?
	}
}
