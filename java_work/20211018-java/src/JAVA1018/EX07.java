package JAVA1018;

import java.util.Scanner;

import AA.DD;

public class EX07 {
	public static void main(String[] args) {
		// ���ڸ� �Է¹޾� �ش�Ǵ� �������� ���
		System.out.println("���� �Է�");
		Scanner scan = new Scanner(System.in);
		int num = scan.nextInt();

		DD d1 = new DD();
		d1.doA(num);
	}
}