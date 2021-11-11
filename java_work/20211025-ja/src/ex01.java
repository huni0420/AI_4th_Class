import java.util.Scanner;

import aa.Exam;

//문제 1 정수 n을 전달해서 2의 n승을 계산해서 반환하는 재귀 메서드

public class ex01 {
	
	public static void main(String[] args) {
		Exam ex = new Exam();
		Scanner scan = new Scanner(System.in);
		while(true) {
			System.out.println("몇승을 구하십니까?");
			int inputNum = scan.nextInt();
			int result = ex.exam01(inputNum);
			if(inputNum == -1) {
				System.out.println("종료합니다.");
				break;
			}			else {
				System.out.println("resutl = "+result);
			}
		}
	}
}
