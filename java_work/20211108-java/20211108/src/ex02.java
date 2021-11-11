import java.util.Scanner;

public class ex02 {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        System.out.println("파일명을 입력>>> ");
        String inputString = scan.nextLine();
        System.out.println("inputString = "+inputString);
        String ar[] = inputString.split("\\.");//escape문자 필요
        System.out.println("출력");
        System.out.println("성 = "+ar[0]);
        System.out.println("이름 = "+ar[1]);
    }
}
