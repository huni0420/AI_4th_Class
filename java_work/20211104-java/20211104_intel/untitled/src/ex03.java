class A{
    private int num;
    A(){
        System.out.println("기본 생성자");
    }
    A(int num){
        this();
        System.out.println("int num 이 있는 생성자");
    }
    A(int n1, int n2){
        this(10);
        System.out.println("n1 n2 있는 생성자");
    }
}
public class ex03 {
    public static void main(String[] args) {
//        new A();//new -> 생성되고 사라짐(가리키는 게 없기때문에)
//        new A(10);
        new A(20,30);
    }
}
