import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;

public class EX06 {

    public static void main(String[] args) {
        Runnable task1 =() -> {
            String name = Thread.currentThread().getName();
            System.out.println("name = "+12);
        };
        Runnable task2 =() -> {
            String name = Thread.currentThread().getName();
            System.out.println("name = "+15);
        };
        ExecutorService es = Executors.newFixedThreadPool(2);
        es.submit(task1);
        es.submit(task2);
        es.submit(() -> {String name = Thread.currentThread().getName();
            System.out.println(name+"="+35);
        });
        es.shutdown();
    }
}
