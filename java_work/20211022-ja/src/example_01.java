import AA.Triangle;

import java.util.Scanner;

public class example_01 {
	public static void main(String[] args) {
		Triangle hi = new Triangle();
		Scanner scan = new Scanner(System.in);
		int heigh = scan.nextInt();
		hi.trans(3, 4);
		hi.cal();
		hi.triangle_area();
	}
}