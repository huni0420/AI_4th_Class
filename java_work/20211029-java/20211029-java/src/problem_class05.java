import java.util.Scanner;

class MonthSchedule {
	private int i;
	int j;
	String k;

	public void schedule() {
		Scanner s = new Scanner(System.in);
			System.out.println("�̹��� ������ ���� ���α׷�.");
			System.out.println("����(�Է�=1, ����=2, ������=3)");
			int i = s.nextInt();
			if (i == 1) {
				System.out.println("��¥(1~30)?");
				j = s.nextInt();
				System.out.println("����(��ĭ���� �Է�)?");
				s.nextLine();
				k = s.nextLine();
				schedule();
			} 
			else if (i == 2) {
				System.out.println("��¥(1~30)?" + j);
				System.out.println("����(��ĭ���� �Է�)?" + k);
				schedule();
			} 
			else {
				System.out.println("���α׷��� �����մϴ�.");
			}
	}
}

public class problem_class05 {
	public static void main(String[] args) {
		MonthSchedule Day = new MonthSchedule();
		Day.schedule();
	}
}
/*�����ڴ��� Scanner ��ü�� �Է¹��� �� ���� �����Ͽ� ���� ������ ������ �۾��� �ϴ� ��ü�� 
  ������ �����Ǿ� �Է� �����¿� �ְ� �Ǿ� �Է��� ������ �ϰ� �Ǵ� ���۵��� ����Ű�� �ִ� �� �����ϴ�.
  �ذ� �����..
  Scanner scan = new Scanner(System.in);�� �ѹ� ��ü�� �����ϰ�
  �̰� ��� ����ϸ� �˴ϴ�.
*/