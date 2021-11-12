/*
    생략가능
    1. import java.lang.*;
    2. super()
    3. toString()
    4. this. super. 생략가능
    5. extends Object -> 자바에서 최상위 클래스
    6. @Override
 */
import java.lang.*;
//기본생성자 호출은 무조건 하기 때문에 부모클래스에 선언 되어져 있어야 한다.
class MobilePhone extends Object{
    int number;
    public MobilePhone(){}
    MobilePhone(int number){
        this.number = number;
    }

    @Override
    public String toString() {
        return "MobilePhone{" +
                "number=" + number +
                '}';
    }
    public void answer(){
        System.out.println("Hi from"+number);
    }
}
public class SmartPhone extends MobilePhone {
    private String androidVer;
    SmartPhone(){}
    SmartPhone(int num, String androidVer){
        super(num);
        this.androidVer = androidVer;
    }
    public void playApp(){
        System.out.println("안드로이드 몇버전 = "+androidVer);
    }

    public static void main(String[] args) {
        MobilePhone mp = new MobilePhone(123);
        System.out.println(mp);
        mp.answer();
        System.out.println();
        SmartPhone sp = new SmartPhone(400,"9버전");
        System.out.println(sp);
        sp.answer();
        sp.playApp();

        MobilePhone mps = new SmartPhone(500, "10버전");
        mps.answer();
        //다형성...
        //자식 객체는 부모 클래스에 담을 수 있다.
        //부모 참조변수는 자식객체를 참소할 수 있다.
        //Object -> MobilePhone -> SmartPhone
        Object a = new MobilePhone();
        Object b = new SmartPhone(600,"11버전");

        ((MobilePhone)a).answer();

        ((SmartPhone)b).playApp();
    }
}
