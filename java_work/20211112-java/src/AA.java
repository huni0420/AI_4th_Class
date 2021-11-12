public class AA extends A {
    int b = 20;

    @Override  //생략가능... override=재정의
    public void doA() {
        super.doA();
        System.out.println("AA doA");
    }
}
