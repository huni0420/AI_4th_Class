package AA;

public class solve_135 {
	// 1¹ø
	public void dosol1() {
		int num = 1;
		while (num <= 8) {
			num++;
			if (num == 2) {
				for (int i = 1; i < 3; i++) {
					System.out.println(num + "*" + i + "=" + num * i);
				}
				System.out.println();
			}
			if (num == 4) {
				for (int i = 1; i < 5; i++) {
					System.out.println(num + "*" + i + "=" + num * i);
				}
				System.out.println("");
			}
			if (num == 6) {
				for (int i = 1; i < 7; i++) {
					System.out.println(num + "*" + i + "=" + num * i);
				}
				System.out.println("");
			}
			if (num == 8) {
				for (int i = 1; i < 9; i++) {
					System.out.println(num + "*" + i + "=" + num * i);
				}
				System.out.println("");
			}
		}
	}

	// 2¹ø
	public void dosol2() {

		for (int i = 0; i <= 9; i++) {
			for (int j = 0; j <= 9; j++) {
				if (i + j == 9) {
					System.out.println("A,B=" + i + "," + j);
				}
			}
		}
	}
}