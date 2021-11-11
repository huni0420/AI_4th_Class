package bb;

public class problem02 {
	public static void main(String[] args) {
		int num1 = 0;
		int num2 = 0;
		boolean result;

		result = ((num1 += 10) < 0) && ((num2 += 10) > 0);
		System.out.println("result = " + result);
		System.out.println("num1 = " + num1);
		System.out.println("num2 = " + num2 + '\n');

		result = ((num1 += 10) > 0) || ((num2 += 10) > 0);
		System.out.println("result = " + result);
		System.out.println("num1 = " + num1);
		System.out.println("num2 = " + num2);
		//num2의 값이 증가한 상태로 출력 되려면
		//1.두번째 result연산에서 논리연산자 ||을 &&으로 바꾸거나 (num1 +=10) < 0로 바꿔준다.
	}
}
