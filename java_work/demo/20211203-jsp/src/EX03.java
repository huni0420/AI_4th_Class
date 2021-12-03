interface Printable{
    void print(String s);

}
class Printer implements Printable{
    @Override
    public void print(String s) {
        System.out.println(s);
    }
}
public class EX03 {
    public static void main(String[] args) {
        Printable prn = new Printer();
        prn.print("람다는 뭘까?...");

        Printable prn2 = new Printable() {
            @Override
            public void print(String s) {

            }
        };
        prn2.print("람다는 뭘까?...");

        Printable prn3 = (s) -> {
            System.out.println(s);
        };
        prn3.print("람다는 뭘까?...");

    }
}
