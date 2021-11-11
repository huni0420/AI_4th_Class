package AA;

public class problem142_02 {
	public static void main(String[] args) {
		absolute(-30,-15);
	}

	public static void absolute(int a, int b) 
	{
		
		if(a-b<=0)
			System.out.println((a-b)*-1);
		if(a-b>0)
			System.out.println(a-b);
	}
}
