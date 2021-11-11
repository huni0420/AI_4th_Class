
import java.util.Scanner;

//문제 2
public class Ex01 {
	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		System.out.println("숫자 입력");
		int n = scan.nextInt();
		
		if(n>=0&&n<10)
		System.out.println("0이상 10미만의 수");	
	}
}
