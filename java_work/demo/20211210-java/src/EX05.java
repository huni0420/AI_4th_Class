
class Counter{
    public int cnt = 0;
    public synchronized void increment(){
        cnt++;
    }
    public synchronized void decrement(){
        cnt--;
    }
    public int getCnt(){
        return cnt;
    }
}

public class EX05 {
    public static Counter cnt = new Counter();
    public static void main(String[] args) throws Exception {

        Runnable r1 = () -> {
            for(int i =0; i<10000;i++){
                cnt.decrement();
            }
        };
        Runnable r2 = () -> {
            for(int i =0; i<10000;i++){
                cnt.increment();
            }
        };
        Thread th1 = new Thread(r1);
        Thread th2 = new Thread(r2);
        th1.start();
        th2.start();
        th1.join(); //t1이 참조하는 동안 기다림
        th2.join(); //t2가 참조하는 동안 기다림
        System.out.println("종료..."+cnt.getCnt());


    }
}
