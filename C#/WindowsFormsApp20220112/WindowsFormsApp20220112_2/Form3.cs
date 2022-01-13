using System;
using System.Windows.Forms;

namespace WindowsFormsApp20220112_2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        void plus(int a)
        {
            a++;
        }

        void plus(TextBox t)
        {
            t.Text = int.Parse(t.Text) + 1 + "";
        }

        void plus(Product p)
        {
            p.price++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 100;
            plus(a);
            textBox1.Text = a.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = 100 + "";
            plus(textBox2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            p.price = int.Parse(textBox3.Text);
            plus(p);
            textBox3.Text = p.price.ToString();
        }
    }
}
