import java.util.Scanner;

public class ex04 {
    public static void main(String[] args) {
        String numbers[] = {"one","two","three","four","five","six","seven","eight","nine"};
        Scanner scan = new Scanner(System.in);
        System.out.print("글자 입력>>>");
        String inputString = scan.nextLine();
        for(int i = 0;i< numbers.length;i++) {
            inputString = inputString.replace(numbers[i], (i+1)+"");//String.valueof(i+1)
        }
        System.out.println("inputString = "+inputString);
        for(int i = 0;i< numbers.length;i++) {
            inputString = inputString.replace((i+1)+"",numbers[i]);//String.valueof(i+1)
        }
        System.out.println("inputString = "+inputString);
    }
}