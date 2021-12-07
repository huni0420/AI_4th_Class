
interface HowLong{
    int len(String s);
}


public class EX03 {
    public static void main(String[] args) {
        HowLong h1 = (s) -> {return s.length();};
        System.out.println(h1.len("I am so happy"));
    }
}
