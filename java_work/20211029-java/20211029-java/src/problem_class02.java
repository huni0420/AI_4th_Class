import java.util.Scanner;

class Grade {
	int A, B, C;

	public Grade(int math, int science, int english) {
		A = math;
		B = science;
		C = english;
	}

	public int average() {
		return (A + B + C) / 3;
	}
}

public class problem_class02 {
	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);

		System.out.print("����,����,���� ������ 3���� ���� �Է�>>");

		int math = sc.nextInt();
		int science = sc.nextInt();
		int english = sc.nextInt();

		Grade me = new Grade(math, science, english);
		System.out.println("�����" + me.average());
	}
}
