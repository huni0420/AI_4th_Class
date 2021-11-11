import java.util.*;

public class javaclassnextproblem {

    //    public static void main(String[] args) {
//        Scanner sc = new Scanner(System.in);
//        System.out.println("인원수>>>");
//        int custom = sc.nextInt();
//        Phone[] p = new Phone[custom];
//        List list = new ArrayList();
//        for (int i=0; i<custom ;i++) {
//            System.out.println("이름과 전화번호를 입력");
//            p[i] = new Phone(sc.next(), sc.next());
//        }
//        System.out.println("저장되었습니다.");
//        end:
//        while(true){
//            System.out.println("이름 검색");
//            String t = sc.next();
//            for(int i =0;i<custom;i++){
//                if(p[i].name.equals(t)) {
//                    System.out.println(p[i].name + "의 번호는" + p[i].tel + "입니다.");
//                    continue end;
//                }
//            }
//            for(int i =0;i<custom;i++){
//                if(!(p[i].name.equals(t))){
//                    if(t.equals("end")){
//                        break end;
//                    }
//                    System.out.println(t + "는 없습니다");
//                    continue end;
//                }
//            }
//
//        }
//    }
//}
//class Phone {
//    String name;
//    String tel;
//    public Phone(String n, String t) {
//        this.name = n;
//        this.tel = t;
//    }
//}
//============================================================================================================================
//    public static void main(String[] args) {
//        int[] array1 = {1, 5, 7, 9};
//        int[] array2 = {3, 6, -1, 100, 77};
//        int[] array3 = ArrayUtill.concat(array1, array2);
//        ArrayUtill.print(array3);
//    }
//}
//
//class ArrayUtill {
//    public static int[] concat(int[] a, int[] b) {
//        int[] c = new int[a.length+b.length];
//        for (int i =0;i< c.length;i++)
//            if(i<a.length){
//                c[i]=a[i];
//            }
//            else if(i>=a.length)
//                c[i] = b[i-a.length];
//        return c;
//    }
//    public static void print(int[] a) {
//        System.out.println(Arrays.toString(a));
//    }
//}
//===========================================================================================================================
//    public static void main(String[] args) {
//        Dictionary dic = new Dictionary();
//        System.out.println("한영 단어 검색 프로그램입니다.");
//        while(true){
//            System.out.print("한글단어:");
//            Scanner sen = new Scanner(System.in);
//            String k = sen.nextLine();
//            dic.kor2Eng(k);
//            if(k.equals("그만")){
//                break;
//            }
//        }
//    }
//}
//class Dictionary {
//    private static String[] kor = {"사랑", "아기", "돈", "미래", "희망"};
//    private static String[] eng = {"love", "baby", "money", "future", "hope"};
//    public static String kor2Eng(String word) {
//        for(int i=0;i< kor.length;i++){
//            if(kor[i].equals(word)) {
//                if (kor[i].equals("아기") || kor[i].equals("미래")){
//                    System.out.println(kor[i] + "는 " + eng[i]);
//                    break;
//                }
//                else
//                    System.out.println(kor[i]+"은 "+eng[i]);
//                    break;
//            }
//            else if(i+1==kor.length){
//                if(word.equals("그만")){
//                    break;
//                }
//                else{
//                    System.out.println(word+"는 저의 사전에 없습니다.");
//                }
//            }
//        }
//        return word;
//    }
//}
//=======================================================================================================================================================================
//    public static void main(String[] args) {
//        Add add = new Add();
//        Sub sub = new Sub();
//        Mul mul = new Mul();
//        Div div = new Div();
//        System.out.print("두 정수와 연산자를 입력하세요: ");
//        Scanner i = new Scanner(System.in);
//        int j =i.nextInt();
//        int k =i.nextInt();
//        String l =i.next();
//        if(l.equals("+")){
//            add.setValue(j,k);
//            add.calculate();
//        }
//        else if(l.equals("-")){
//            sub.setValue(j,k);
//            sub.calculate();
//        }
//        else if(l.equals("*")){
//            mul.setValue(j,k);
//            mul.calculate();
//        }
//        else if(l.equals("/")){
//            div.setValue(j,k);
//            div.calculate();
//        }
//    }
//}
//class Add{
//    private int a;
//    private int b;
//    int c = 0;
//    public void setValue(int a,int b){
//        this.a=a;
//        this.b=b;
//    }
//
//    public void calculate() {
//        c=a+b;
//        System.out.println(c);
//    }
//}
//class Sub{
//    private int a;
//    private int b;
//    int c = 0;
//    public void setValue(int a,int b){
//        this.a=a;
//        this.b=b;
//    }
//    public void calculate() {
//        c=a-b;
//        System.out.println(c);
//    }
//}
//class Mul{
//    private int a;
//    private int b;
//    int c = 0;
//    public void setValue(int a,int b){
//        this.a=a;
//        this.b=b;
//    }
//    public void calculate() {
//        c=a*b;
//        System.out.println(c);
//    }
//}
//class Div{
//    private int a;
//    private int b;
//    int c = 0;
//    public void setValue(int a,int b){
//        this.a=a;
//        this.b=b;
//    }
//    public void calculate() {
//        c=a/b;
//        System.out.println(c);
//    }
//}
//=======================================================================================================================================================================
    static String[] S = {"S>>", " ___ ", " ___ ", " ___ ", " ___ ", " ___ ", " ___ ", " ___ ", " ___ ", " ___ ", " ___ "};
    static String[] A = {"A>>", " ___ ", " ___ ", " ___ ", " ___ ", " ___ ", " ___ ", " ___ ", " ___ ", " ___ ", " ___ "};
    static String[] B = {"B>>", " ___ ", " ___ ", " ___ ", " ___ ", " ___ ", " ___ ", " ___ ", " ___ ", " ___ ", " ___ "};

    public static void main(String[] args) {
        Consert consert = new Consert();
        System.out.println("명품콘서트홀 예약 시스템입니다");
        end:
        while (true) {
            System.out.print("예약:1, 조회:2, 취소:3, 끝내기:4 >> ");
            Scanner scan = new Scanner(System.in);
            int consert_tiket = scan.nextInt();
            if (consert_tiket == 1) {
                System.out.print("좌석구분 S(1), A(2), B(3)>>");
                int sit = scan.nextInt();
                if (sit == 1) {
                    for (int i = 0; i < 11; i++) {
                        System.out.print(S[i]);
                    }
                    System.out.println();
                    System.out.print("이름>> ");
                    String name = scan.next();
                    System.out.print("번호>> ");
                    int num = scan.nextInt();
                    consert.Reserve_Sits(num, name, S);
                    consert.Reserve();
                }
                if (sit == 2) {
                    for (int i = 0; i < 11; i++) {
                        System.out.print(A[i]);
                    }
                    System.out.println();
                    System.out.print("이름>>");
                    String name = scan.next();
                    System.out.print("번호>>");
                    int num = scan.nextInt();
                    consert.Reserve_Sits(num, name, A);
                    consert.Reserve();
                }
                if (sit == 3) {
                    for (int i = 0; i < 11; i++) {
                        System.out.print(B[i]);
                    }
                    System.out.println();
                    System.out.print("이름>>");
                    String name = scan.next();
                    System.out.println();
                    System.out.print("번호>>");
                    int num = scan.nextInt();
                    consert.Reserve_Sits(num, name, B);
                    consert.Reserve();
                }
            }
            if (consert_tiket == 2) {
                consert.Search(S, A, B);
                System.out.println("<<<조회를 완료하였습니다.>>>");
            }
            if (consert_tiket == 3) {
                System.out.print("좌석 S:1, A:2, B:3>>");
                int sit = scan.nextInt();
                if (sit == 1) {
                    for (int i = 0; i < 11; i++) {
                        System.out.print(S[i]);
                    }
                    System.out.println();
                    System.out.print("이름>>");
                    String name = scan.next();
                    consert.Cancel_Sits(name, S);
                    consert.Cancel();
                }
                if (sit == 2) {
                    for (int i = 0; i < 11; i++) {
                        System.out.print(A[i]);
                    }
                    System.out.println();
                    System.out.print("이름>>");
                    String name = scan.next();
                    consert.Cancel_Sits(name, A);
                    consert.Cancel();
                }
                if (sit == 3) {
                    for (int i = 0; i < 11; i++) {
                        System.out.print(B[i]);
                    }
                    System.out.println();
                    System.out.print("이름>>");
                    String name = scan.next();
                    consert.Cancel_Sits(name, B);
                    consert.Cancel();
                }
            }
            if (consert_tiket == 4) {
                break end;
            }
        }
    }

    static class Consert {
        int num;
        String name;
        String T[];

        public void Reserve_Sits(int num, String name, String[] T) {
            this.num = num;
            this.name = name;
            this.T = T;
        }

        public void Cancel_Sits(String name, String[] T) {
            this.name = name;
            this.T = T;
        }

        public String[] Reserve() {
            for (int i = 1; i < 11; i++) {
                if (i == num) {
                    T[num] = ""+name;
                }
            }
            return T;
        }

        public void Search(String[] S, String[] A, String[] B) {
            for (int i = 0; i < 11; i++) {
                System.out.print(S[i]);
            }
            System.out.println();
            for (int i = 0; i < 11; i++) {
                System.out.print(A[i]);
            }
            System.out.println();
            for (int i = 0; i < 11; i++) {
                System.out.print(B[i]);
            }
            System.out.println();
        }

        public String[] Cancel() {
            for (int i = 1; i < 11; i++) {
                if (T[i].equals(name)) {
                    T[i] = " ___ ";
                }
            }
            return T;
        }
    }
}


