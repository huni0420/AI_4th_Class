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
		//num2�� ���� ������ ���·� ��� �Ƿ���
		//1.�ι�° result���꿡�� �������� ||�� &&���� �ٲٰų� (num1 +=10) < 0�� �ٲ��ش�.
	}
}
