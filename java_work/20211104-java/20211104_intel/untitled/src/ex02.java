import aa.bb.cc.Person;
/*
 * class new
 * public protected default private
 * static
 * 매서드 오버로딩
 * 생성자 오버로딩
 * */
public class ex02 {
    public static void main(String[] args) {
        Person p1 ;
        p1= new Person();
        p1= new Person();
        System.out.println("p1"+p1.toString());
        System.out.println("p1"+p1);


        Person p2 = new Person("홍길동");
        System.out.println();
        System.out.println("p2 " +p2);
        System.out.printf("a= %d\n",233);
    }
}
