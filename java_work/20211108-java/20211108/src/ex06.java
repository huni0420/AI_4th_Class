class Box{
    private String conts;
    //생성자 toString
    //alt + insert
    public Box(String conts){
        this.conts = conts;
    }

    @Override
    public String toString() {
        return "Box{" +
                "conts='" + conts + '\'' +
                '}';
    }
}
public class ex06 {
    public static void main(String[] args) {
        Box boxs[] = new Box[3];   // == Box[] boxes = new Box[3];
        for (Box temp : boxs)
            System.out.println("temp = "+temp);
        boxs[0] = new Box("사과");
        boxs[1] = new Box("바나나");
        boxs[2] = new Box("수박");
        for(Box temp : boxs)
            System.out.println("temp = "+temp);
    }
}
