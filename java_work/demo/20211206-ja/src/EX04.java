import java.util.*;

public class EX04 {
    public static void main(String[] args) {
        List<String> list = Arrays.asList("Robot", "Box", "Ramda", "AA", "BB"); // imutaqble 변경불가능하다.
        List<String> list1 = new ArrayList<>(list); // mutable 변경가능하게 바꿈

        list1.removeIf((s) -> s.length() > 3);
        System.out.println(list1);
    }
}
