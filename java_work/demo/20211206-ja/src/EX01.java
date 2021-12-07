import java.util.*;

class A implements Comparator<String>{
    @Override
    public int compare(String o1, String o2) {
        return o1.length()-o2.length();
    }
}

public class EX01 {
    public static void main(String[] args) {
//        List<String> list = new ArrayList<>();
//        list.add("Robot");
//        list.add("Box");
//        list.add("Ramda");
//        Integer
//        double
        List<String> list = Arrays.asList("Robot","Box","Ramda","AA","BB");

        Collections.sort(list, new A());
        Collections.sort(list,(String o1,String o2)->{return o2.length()-o1.length();});
        System.out.println(list);
    }
}
