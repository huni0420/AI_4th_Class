namespace WindowsFormsApp20220112_2
{
    public class Product
    {
        public static int pCount = 0;

        public Product()
        {
            pCount++;
        }
        public static int showCount()
        {
            return pCount;
        }
        public Product(string name, int price)
        {
            this.name = name;
            this.price = price;
        }

        public string name { get; set; }
        public int price { get; set; }

        public void introduce()
        {
            System.Windows.Forms.MessageBox.Show($"이 제품명은 {name}, 가격은 {price}입니다.");
        }
    }
}