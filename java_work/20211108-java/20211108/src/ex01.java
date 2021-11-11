import java.util.Scanner;

public class ex01 {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        System.out.println("이름과 성과 이름을 띄워서 영어로 입력>>> ");
        String inputString = scan.nextLine();
        System.out.println("inputString = "+inputString);
//        int blinkNumber = inputString.charAt(' ');
//        System.out.println("blinkNumber = "+blinkNumber);
        String ar[] = inputString.split(" ");
//        for(String a : ar){
//            System.out.println("a = "+a);
//        }
        System.out.println("성 = "+ar[0]);
        System.out.println("이름 = "+ar[1]);
    }
}