import java.util.*;

public class test {
    public static void main(String[] args) {
        sConsert sconsert = new sConsert();
        sconsert.Start();
    }
}

class sConsert{
    String[] S = {"S>>", " ___ ", " ___ ", " ___ ", " ___ ", " ___ ", " ___ ", " ___ ", " ___ ", " ___ ", " ___ "};
    String[] A = {"A>>", " ___ ", " ___ ", " ___ ", " ___ ", " ___ ", " ___ ", " ___ ", " ___ ", " ___ ", " ___ "};
    String[] B = {"B>>", " ___ ", " ___ ", " ___ ", " ___ ", " ___ ", " ___ ", " ___ ", " ___ ", " ___ ", " ___ "};

    Scanner input = new Scanner(System.in);
    public int i=0;
    public void Start(){
        System.out.println("명품콘서트홀 예약 시스템입니다.");
        System.out.print("예약:1, 조회:2, 취소:3, 끝내기:4 >> ");

        i = input.nextInt();
        if(i==1)
            reserve(i);
        if(i==2)
            search();
        if(i==3)
            reserve(i);
    }
    public void reserve(int k) {
        System.out.print("좌석구분 S(1), A(2), B(3)>> ");
        k = input.nextInt();
        if (k == 1) {
            for (int i = 0; i < 11; i++) {
                System.out.print(S[i]);
            }
            System.out.println();
            System.out.print("이름>> ");
            String name = input.next();
            System.out.print("번호>> ");
            int number = input.nextInt();
            S[number] = name;
//            for (int i = 0; i < 11; i++) {
//                System.out.print(S[i]);
//            }
        }
        if (k == 2) {
            for (int i = 0; i < 11; i++) {
                System.out.print(A[i]);
            }
            System.out.println();
            System.out.print("이름>> ");
            String name = input.next();
            System.out.print("번호>> ");
            int number = input.nextInt();
            A[number] = name;
//            for (int i = 0; i < 11; i++) {
//                System.out.print(A[i]);
//            }
        }
        if (k == 3) {
            for (int i = 0; i < 11; i++) {
                System.out.print(B[i]);
            }
            System.out.println();
            System.out.print("이름>> ");
            String name = input.next();
            System.out.print("번호>> ");
            int number = input.nextInt();
            B[number] = name;
//            for (int i = 0; i < 11; i++) {
//                System.out.print(B[i]);
//            }
        }
    }
    public void search(){
        for (int i = 0; i < 11; i++) {
            System.out.print(S[i]);
        }
        for (int i = 0; i < 11; i++) {
            System.out.print(A[i]);
        }
        for (int i = 0; i < 11; i++) {
            System.out.print(B[i]);
        }
    }
}