import java.util.Scanner;
class MonthSchedule{
	private int j;
	private String k;
	public void input() {
		Scanner scan = new Scanner(System.in);
		System.out.println("����(�Է�:1, ����:2, ������:3>>");
		int d = scan.nextInt();
		if (d==1) {
			System.out.println("��¥(1~30)");
			int j = scan.nextInt();
			System.out.println("����(��ĭ���� �Է�:)");
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
			System.out.println("���α׷��� �����մϴ�");
		
	}
	public void view() {
		System.out.println("��¥(1~31)"+j);
		System.out.println(j+"���� �� ���� "+k+"�Դϴ�");
		input();
	}
}
public class problem_class05 {
	public static void main(String[] args) {
		MonthSchedule Day = new MonthSchedule();
		Day.input();
	}
}