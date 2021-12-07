import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.function.Predicate;

public class EX06 {
    public static void main(String[] args) {
        Predicate<Integer> pr = s -> s<0;

        List<Integer> ls1 = Arrays.asList(1,-2,3,-4,6);
        List<Integer> ls2 = new ArrayList<>(ls1);

        ls2.removeIf(s->s<0);
        ls2.removeIf(pr);

        System.out.println(ls2);

    }
}
