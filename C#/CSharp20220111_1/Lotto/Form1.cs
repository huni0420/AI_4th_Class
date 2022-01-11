using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lotto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] Lotto = new int[7];
            for(int i = 0; i < 7; i++)
            {
                int num = new Random().Next(45)+1;
                if (Lotto.Contains(num) == false)
                    Lotto[i] = num;
                else
                    i--;
            }
            Array.Sort(Lotto);
            label1.Text = Lotto[0].ToString();
            label2.Text = Lotto[1].ToString();
            label3.Text = Lotto[2].ToString();
            label4.Text = Lotto[3].ToString();   
            label5.Text = Lotto[4].ToString();
            label6.Text = Lotto[5].ToString();
            label7.Text = Lotto[6].ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
