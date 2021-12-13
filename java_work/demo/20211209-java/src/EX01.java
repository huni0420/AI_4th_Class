/*
*   consumer, predicate, Function, supplier
*
* */


import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class EX01 {
    public static void main(String[] args) {
        List<String> li = Arrays.asList("aa","bbb","cccc","ddddd");
        List<String> li1 = new ArrayList<>(li);

        li1.stream()
                .filter(s -> s.length()>3) // predicate
                .forEach(s -> System.out.println(s)); // consumer

        System.out.println();
        for(String temp : li){
            if(temp.length()>3)
                System.out.println(temp);
        }
    }
}
