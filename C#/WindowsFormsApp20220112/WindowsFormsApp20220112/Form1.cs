using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp20220112
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] lotto = new int[7];
            for(int i = 0; i<lotto.Length; i++)
            {
                int num = new Random().Next(45)+1;

                if (lotto.Contains(num))
                    i--;
                else
                    lotto[i] = num;
            }
            Array.Sort(lotto);

            label1.Text = lotto[0].ToString();
            label2.Text = lotto[1].ToString();
            label3.Text = lotto[2].ToString();
            label4.Text = lotto[3].ToString();
            label5.Text = lotto[4].ToString();
            label6.Text = lotto[5].ToString();
            label7.Text = lotto[6].ToString();
            Label[] labels = { label1, label2, label3, label4, label5, label6, label7 };


            for(int i =0; i<labels.Length; i++)
            {
                if(lotto[i] <=10)
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
    }
}
