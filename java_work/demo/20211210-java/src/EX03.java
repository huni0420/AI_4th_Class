public class EX03 {
    public static void main(String[] args) {
        Runnable task1 = () ->{
            for(int i = 0; i<20; i++){
                if(i%2==0){
                    System.out.println(i+"");
                    try {
                        Thread.sleep(100);
                    }catch (InterruptedException e){
                        e.printStackTrace();
                    }
                }
            }
        };

        Runnable task2 = () ->{
            for(int i = 0; i<20; i++){
                if(i%2==1){
                    System.out.println(i+"");
                    try {
                        Thread.sleep(100);
                    }catch (InterruptedException e){
                        e.printStackTrace();
                    }
                }
            }
        };
        new Thread(task1).start();
        new Thread(task2).start();

    }
}
