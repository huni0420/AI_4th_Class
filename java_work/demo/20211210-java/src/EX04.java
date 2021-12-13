
class MyThread extends Thread{
    @Override
    public void run() {
        String name = Thread.currentThread().getName();
        for(int i = 0; i<50;i++){
            System.out.println(name+"="+i);
        }
    }
}


public class EX04 {
    public static void main(String[] args) {
        MyThread th1 = new MyThread();
        MyThread th2 = new MyThread();
        th1.start();
        th2.start();
    }
}
