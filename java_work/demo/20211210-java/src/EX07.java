import java.util.concurrent.Callable;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;
import java.util.concurrent.Future;

public class EX07 {

    public static void main(String[] args) throws Exception {
        Callable<String> task = () -> {
            for(int i = 0; i<10; i++){
                System.out.println(i);
            }
            return "이거 반환됨..";
        };

        ExecutorService es = Executors.newFixedThreadPool(1);
        Future<String> fu = es.submit(task);
        String retValue = fu.get();
        System.out.println("retValue = "+retValue);
        es.shutdown();
    }
}