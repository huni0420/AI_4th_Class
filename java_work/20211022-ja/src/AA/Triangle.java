package AA;

public class Triangle {
	static int heigh = 0;
	static int bot = 0;
	static double area = 0;

	public void trans(int h, int b) {
		heigh = h;
		bot = b;
	}

	public double cal() {
		area = heigh * bot * (1 / 2);
		return area;
	}

	public void triangle_area() {
		System.out.println(area);
	}
}
