using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp20220112_DataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.Columns.Add("name", "이름");
            dataGridView1.Columns.Add("major", "전공");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(textBox1.Text, textBox2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add(textBox_name.Text, textBox_age.Text+"세", textBox_grade.Text+"학년", textBox_score.Text+"점");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }
    }
}
