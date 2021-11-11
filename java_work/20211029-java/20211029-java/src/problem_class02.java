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

		System.out.print("수학,과학,영어 순으로 3개의 정수 입력>>");

		int math = sc.nextInt();
		int science = sc.nextInt();
		int english = sc.nextInt();

		Grade me = new Grade(math, science, english);
		System.out.println("평균은" + me.average());
	}
}
