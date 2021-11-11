class AA{}


public class ex05 {
    public static void main(String[] args) {
        int arr[] = new int[5];
        for (int temp:arr){// java     // for i in arr (python)
            System.out.println("temp = "+temp);
        }
        System.out.println("arr.lengh = "+arr.length);

        String sarr[] = new String[5];
        for (String temp:sarr){     // for i in arr (python)
            System.out.println("temp = "+temp);
        }
        System.out.println("Sarr.lengh = "+sarr.length);

        AA sAA[] = new AA[5];
        for (AA temp:sAA){
            System.out.println("temp = "+temp);
        }
        System.out.println("sAA.length = "+sAA.length);
    }
}