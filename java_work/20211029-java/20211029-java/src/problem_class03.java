import java.util.Scanner;

class song {
	String title, artist, country;
	int year;

	public song(String title, String artist, String country, int year) {
		this.title = title;
		this.artist = artist;
		this.country = country;
		this.year = year;
	}

	public void show() {
		System.out.println(year + "�� " + country + "������ " + artist + "�� �θ� " + title);
	}
}

public class problem_class03 {
	public static void main(String[] args) {
		System.out.println("�� ����,����,����,�⵵ ������ �Է��ϼ���>>");
		Scanner scan = new Scanner(System.in);
		String title = scan.nextLine();
		String artist = scan.nextLine();
		String country = scan.nextLine();
		int year = scan.nextInt();

		song album = new song(title, artist, country, year);

		album.show();
	}
}
