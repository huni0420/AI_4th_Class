import java.util.Scanner;

import aa.Exam;

//���� 1 ���� n�� �����ؼ� 2�� n���� ����ؼ� ��ȯ�ϴ� ��� �޼���

public class ex01 {
	
	public static void main(String[] args) {
		Exam ex = new Exam();
		Scanner scan = new Scanner(System.in);
		while(true) {
			System.out.println("����� ���Ͻʴϱ�?");
			int inputNum = scan.nextInt();
			int result = ex.exam01(inputNum);
			if(inputNum == -1) {
				System.out.println("�����մϴ�.");
				break;
			}			else {
				System.out.println("resutl = "+result);
			}
		}
	}
}
