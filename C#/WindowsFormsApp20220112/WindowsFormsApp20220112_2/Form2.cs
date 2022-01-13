using System;
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
    public partial class Form2 : Form
    {
        List<string> list = new List<string>();
        
        public Form2()
        {
            InitializeComponent();

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


        void addText(String text)
        {
            list.Add(text);
            ListText.Text = "";
            foreach (var item in list)
            {
                ListText.Text += item + " ";
            }
        }

        void removeText(String text)
        {
            list.Remove(text);
            ListText.Text = "";
            foreach (var item in list)
            {
                ListText.Text += item + " ";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addText(button1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addText(((Button)sender).Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addText((sender as Button).Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            addText((sender as Button).Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            removeText((sender as Button).Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            removeText((sender as Button).Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            removeText((sender as Button).Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            removeText((sender as Button).Text);
        }

        void changeColor(Label l)
        {
            l.BackColor = Color.Transparent;
            if (int.Parse(l.Text) <= 10)
            {
                l.ForeColor = Color.Yellow;
                l.BackColor = Color.Black;
            }
            else if (int.Parse(l.Text) <= 20)
                l.ForeColor = Color.Blue;
            else if (int.Parse(l.Text) <= 20)
                l.ForeColor = Color.Red;
            else if (int.Parse(l.Text) <= 20)
                l.ForeColor = Color.Black;
            else
                l.ForeColor = Color.Green;

        }

        void pIncrease(Product p)
        {
            p.price++;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Product myp = new Product();
            myp.price = 10;
            pIncrease(myp);
            MessageBox.Show("Test" + myp.price);

            int[] lotto = new int[7];
            for (int i = 0; i < lotto.Length; i++)
            {
                int num = new Random().Next(45) + 1;

                if (lotto.Contains(num))
                    i--;
                else
                    lotto[i] = num;
            }
            Array.Sort(lotto);

            num1.Text = lotto[0].ToString();
            num2.Text = lotto[1].ToString();
            num3.Text = lotto[2].ToString();
            num4.Text = lotto[3].ToString();
            num5.Text = lotto[4].ToString();
            num6.Text = lotto[5].ToString();
            num7.Text = lotto[6].ToString();


            changeColor(num1);
            changeColor(num2);
            changeColor(num3);
            changeColor(num4);
            changeColor(num5);
            changeColor(num6);
            changeColor(num7);

            Label[] labels = { num1, num2, num3, num4, num5,  num6, num7 };


            for (int i = 0; i < labels.Length; i++)
            {
                if (lotto[i] <= 10)
                {
                    labels[i].ForeColor = Color.Yellow;
                    labels[i].BackColor = Color.Blue;
                }
                else if (lotto[i] <= 20)
                {
                    labels[i].ForeColor = Color.Blue;
                }
                else if (lotto[i] <= 30)
                {
                    labels[i].ForeColor = Color.Red;
                }
                else if (lotto[i] <= 40)
                {
                    labels[i].ForeColor = Color.Black;
                }
                else
                    labels[i].ForeColor = Color.Green;

            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            new Form3().Show();
        }
    }
}
