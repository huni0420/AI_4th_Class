using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp20220112_2
{
    public partial class Form1 : Form
    {
            List<string> list = new List<string>();
        public Form1()
        {
            InitializeComponent();
            btn_list_study.Text = "안녕";

            Random random = new Random();
            button1.Text = random.Next(100).ToString();
            button5.Text = button1.Text;
            button2.Text = random.Next(100).ToString();
            button6.Text = button2.Text;
            button3.Text = random.Next(100).ToString();
            button7.Text = button3.Text;
            button4.Text = random.Next(100).ToString();
            button8.Text = button4.Text;

        }

        private void btn_list_study_Click(object sender, EventArgs e)
        {
            List<int> numbers = new List<int>();
            numbers.Add(1000);
            numbers.Add(-1000);
            numbers.Sort();
            numbers.Remove(1000);
            MessageBox.Show("Test" + numbers[0]);
            foreach(var item in numbers)
            {
                MessageBox.Show(item + "");
            }
            ArrayList a = new ArrayList();
            a.Add(1);
            a.Add("가즈아");
            a.Add(numbers);
            MessageBox.Show("" +a[0]+a[1]+a[2]);
        }
        private void ListText_Click(object sender, EventArgs e)
        {
            
        }
        //1~4 추가버튼 부분
        private void button1_Click(object sender, EventArgs e)
        {
            list.Add(button1.Text);
            ListText.Text = "";
            foreach(var item in list)
            {
                ListText.Text += item + " ";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            list.Add(button2.Text);
            ListText.Text = "";
            foreach (var item in list)
            {
                ListText.Text += item + " ";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            list.Add(button3.Text);
            ListText.Text = "";
            foreach (var item in list)
            {
                ListText.Text += item + " ";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            list.Add(button4.Text);
            ListText.Text = "";
            foreach (var item in list)
            {
                ListText.Text += item + " ";
            }
        }
        //5~8 제거버튼부분
        private void button5_Click(object sender, EventArgs e)
        {
            list.Remove(button5.Text);
            ListText.Text = "";
            foreach (var item in list)
            {
                ListText.Text += item + " ";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            list.Remove(button6.Text);
            ListText.Text = "";
            foreach (var item in list)
            {
                ListText.Text += item + " ";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            list.Remove(button7.Text);
            ListText.Text = "";
            foreach (var item in list)
            {
                ListText.Text += item + " ";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            list.Remove(button8.Text);
            ListText.Text = "";
            foreach (var item in list)
            {
                ListText.Text += item + " ";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

            Class1 c = new Class1();

            Product p = new Product();
            p.name = textBox1.Text;
            p.price = int.Parse(textBox2.Text);
            p.introduce();
            MessageBox.Show("pCount = " + Product.pCount);

            Product p2 = new Product();
            p2.name = textBox3.Text;
            p2.price = int.Parse(textBox4.Text);
            p2.introduce();
            MessageBox.Show("pCount = " + Product.pCount);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"현재 제품 개수는 {Product.showCount()}입니다.");
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            //new Form2().Show(); //모달리스, Modeless
            new Form2().ShowDialog();
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            new Form3().Show();
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }
    }
}
