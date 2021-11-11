import java.util.Scanner;

class Phone {
    String n;
    String t;

    public Phone(String n, String t){
        this.n = n;
        this.t = t;
    }
}
class loop{
    public void loop(){}
}

public class PhoneBook {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        System.out.println("인원수>>.");
        int k = input.nextInt();
        Phone[] p = new Phone[k];
        for (int i = 0; i < k; i++) {
            System.out.println("이름과 전화번호>>>");
            p[i] = new Phone(input.next(), input.next());
        }
        System.out.println("저장되었습니다.");
        loop a = new loop();
        a.loop();
        System.out.println("검색할 이름");
        String name = input.next();
        for (int i = 0;; i++) {
            if (p[i].n.equals(name)) {
                System.out.println(p[i].n + "의 번호는 " + p[i].t + "입니다.");
                a.loop();
            } else if (!(p[i].n.equals(name))) {
                System.out.println(name + "은 없습니다.");
                a.loop();
            } else if (name.equals("그만")) {
                break;
            }
        }
    }
}