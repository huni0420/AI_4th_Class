
/*
프로그램이 실행 되면... 프로세스가.. 실행이...
프로세스는 여러개의 쓰레드가 작업
이 쓰레드가. 작업
저 쓰레드가... 작업

pyqt 메일전송...
 */

public class EX01 {
    public static void main(String[] args) {
        Thread th = Thread.currentThread();
        String name = th.getName();
        System.out.println("name = "+name);

    }
}
