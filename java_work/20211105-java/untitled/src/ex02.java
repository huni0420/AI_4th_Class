public class ex02 {
    public static void main(String[] args) {
        String str1 = "simple String";
        String str2 = "simple String";

        String str3 = new String("simple String");
        String str4 = new String("simple String");

        if(str1 == str2)
            System.out.println("str1 str2 동일한 인스턴스 참조");
        else
            System.out.println("str1 str2 다른 인스턴스 참조");
        if(str3==str4)
            System.out.println("str1 str2 동일한 인스턴스 참조");
        else
            System.out.println("str1 str2 다른 인스턴스 참조");
        //문자열 비교 연산자는 equals 함수를 사용한다.
        if(str3.equals(str4))
            System.out.println("str1 str2 동일한 인스턴스 참조");
        else
            System.out.println("str1 str2 다른 인스턴스 참조");

    }
}
