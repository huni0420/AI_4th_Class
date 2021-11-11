/*
 * class명이랑 파일명은 동일해야한다...
 * ctrl +1 파일 오류 수정
 */
public class EX05 {
	public static void main(String[] args) {
		int num1 = 100;
		long num2 = 3147483647L;
		System.out.println(num1 + num2);

		int num3 =(int)(num1 + num2);//문법은 맞췄지만 출력은 원하는 수가 안나온다.
		long num4 = num1 + num2;
		System.out.println("num3= " + num3);
		System.out.println("num4=" + num4);
	}
}
