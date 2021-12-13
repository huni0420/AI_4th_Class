public class EX02 {
    public static void main(String[] args) {
        Runnable r1 = new Runnable() {
            @Override
            public void run() {
                String name = Thread.currentThread().getName();
                for(int i = 0; i<50;i++){
                    System.out.println(name+"="+i);
                }
            }
        };

        Runnable r2 = ()-> {
            String name = Thread.currentThread().getName();
            for(int i = 0; i<50;i++){
                System.out.println(name+"="+i);
            }
        };

        Thread th1 = new Thread(r1);
        Thread th2 = new Thread(r2);

        th1.start();
        th2.start();

        String name  = Thread.currentThread().getName();
        for(int i = 0; i<50;i++){
            System.out.println(name+"="+i);
        }
        System.out.println("name = "+name);
    }
}
