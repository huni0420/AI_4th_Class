package AA;

public class SOLVE_129 {
	public void sol1() {
		int count = 0;
		for (int num = 1; num < 100; num++) {
			if ((num % 5 != 0) || (num % 7 != 0)) {
				continue;
			}
			System.out.println(num);
			count++;
		}
		System.out.println("count = " + count);
	}

	public void sol2() {
		int sum = 0;
		int num = 0;
		for (num = 1; sum < 1000; num++) {
			if (num % 2 != 0)
				continue;
			sum += num;
			if(sum>=1000) {
				System.out.println("1000을 넘어선 값 = "+sum);
			}
		}
		System.out.println("마지막으로 더한 값 = "+num);
	}
}
