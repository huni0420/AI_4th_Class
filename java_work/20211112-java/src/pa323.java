class Car{
    int gasoline;
    public Car(int ga) {
        this.gasoline=ga;
    }
}
class HybridCar extends Car{
    int electric;

    public HybridCar(int ele, int ga) {
        super(ga);
        this.electric =ele;
    }
}

class HybridWaterCar extends HybridCar{
    int water;
    HybridWaterCar(int water,int ele,int ga){
        super(ele,ga);
        this.water = water;
    }
    public void showCurrent(){
        System.out.println("잔여 가솔린:"+gasoline);
        System.out.println("잔여 가솔린:"+electric);
        System.out.println("잔여 가솔린:"+water);
    }
}
public class pa323 {
    public static void main(String[] args) {
        HybridWaterCar hwc = new HybridWaterCar(10,5,3);
        hwc.showCurrent();
    }
}