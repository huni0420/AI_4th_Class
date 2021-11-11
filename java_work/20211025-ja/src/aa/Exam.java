package aa;

public class Exam {
	public int exam01(int n) {
		if(n>0)
			return 2* exam01(n-1);
		else
			return 1;
	}
	public String exam02(int n) {
		if(n>0) {
			return n/2 + exam02(n-1);
		}
		else {
			return "1";
		}
		
	}
}
