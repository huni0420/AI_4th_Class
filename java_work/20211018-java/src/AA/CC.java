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

	// a와 b의 공배수를 출력하자
	public void doC(int a, int b) {
		int count = 0;
		int num = 0;// num++일때 1을 넣으면 실행값에 2부터 시작
		while (num++ < 100) {
			if (count == 10)//실행은 8번밖에 안됨...
				continue;
			if ((num % a == 0) && (num % b == 0)) {
				System.out.println("num=" + num);
				count++;
			}
		}
	}
}
