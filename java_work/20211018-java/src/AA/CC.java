package AA;

public class CC {
	// break;
	public void doA() {
		for (int i = 0; i < 5; i++) {
			if (i == 3)
				break;
			System.out.println("i=" + i);
		}
	}

	// continue;
	public void doB() {
		for (int i = 0; i < 5; i++) {
			if (i == 3)
				continue;
			System.out.println("i=" + i);
		}
	}

	// a�� b�� ������� �������
	public void doC(int a, int b) {
		int count = 0;
		int num = 0;// num++�϶� 1�� ������ ���ప�� 2���� ����
		while (num++ < 100) {
			if (count == 10)//������ 8���ۿ� �ȵ�...
				continue;
			if ((num % a == 0) && (num % b == 0)) {
				System.out.println("num=" + num);
				count++;
			}
		}
	}
}
