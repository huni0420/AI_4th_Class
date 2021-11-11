import java.util.Scanner;

class MonthSchedule {
	private int i;
	int j;
	String k;

	public void schedule() {
		Scanner s = new Scanner(System.in);
			System.out.println("이번달 스케쥴 관리 프로그램.");
			System.out.println("할일(입력=1, 보기=2, 끝내기=3)");
			int i = s.nextInt();
			if (i == 1) {
				System.out.println("날짜(1~30)?");
				j = s.nextInt();
				System.out.println("할일(빈칸없이 입력)?");
				s.nextLine();
				k = s.nextLine();
				schedule();
			} 
			else if (i == 2) {
				System.out.println("날짜(1~30)?" + j);
				System.out.println("할일(빈칸없이 입력)?" + k);
				schedule();
			} 
			else {
				System.out.println("프로그램을 종료합니다.");
			}
	}
}

public class problem_class05 {
	public static void main(String[] args) {
		MonthSchedule Day = new MonthSchedule();
		Day.schedule();
	}
}
/*질문자님이 Scanner 객체를 입력받을 때 마나 생성하여 쓰기 때문에 동일한 작업을 하는 객체가 
  여러개 생성되어 입력 대기상태에 있게 되어 입력을 여러번 하게 되는 오작동을 일으키고 있는 것 같습니다.
  해결 방법은..
  Scanner scan = new Scanner(System.in);를 한번 객체를 생성하고
  이걸 계속 사용하면 됩니다.
*/