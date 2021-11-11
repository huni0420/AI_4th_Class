import java.util.Scanner;
class MonthSchedule{
	private int j;
	private String k;
	public void input() {
		Scanner scan = new Scanner(System.in);
		System.out.println("할일(입력:1, 보기:2, 끝내기:3>>");
		int d = scan.nextInt();
		if (d==1) {
			System.out.println("날짜(1~30)");
			int j = scan.nextInt();
			System.out.println("할일(빈칸없이 입력:)");
			scan.nextLine();
			String k = scan.nextLine();
			
			this.j=j;
			this.k=k;
			input();
		}
		else if(d==2) {
			view();
		}
		else
			System.out.println("프로그램을 종료합니다");
		
	}
	public void view() {
		System.out.println("날짜(1~31)"+j);
		System.out.println(j+"일의 할 일은 "+k+"입니다");
		input();
	}
}
public class problem_class05 {
	public static void main(String[] args) {
		MonthSchedule Day = new MonthSchedule();
		Day.input();
	}
}