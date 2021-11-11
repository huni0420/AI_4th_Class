package AA;

public class problem142_01 {
	public static void main(String[] args) {
		arithmetic(3,5);
	}
	public static void arithmetic(int a, int b)
	{
		System.out.println(a+" + "+b+" = "+(a+b));		
		System.out.println(a+" - "+b+" = "+(a-b));		
		System.out.println(a+" X "+b+" = "+(a*b));		
		System.out.println(a+" ¡À "+b+" = "+(("³ª¸ÓÁö "+(a%b))+","+((" ¸ò "+(a/b)))));		
	}
}
