using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectDBtest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void represhgridview()
        {
            dataGridView1.DataSource = null;
            if(DataManager.kbstudent.Count > 0)
               dataGridView1.DataSource = DataManager.kbstudent;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox4.Text!="")
                DataManager.executeQuery("insert", int.Parse(textBox1.Text), textBox2.Text, int.Parse(textBox3.Text), textBox4.Text);
            else
                DataManager.executeQuery("insert", int.Parse(textBox1.Text), textBox2.Text, int.Parse(textBox3.Text));
            represhgridview();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataManager.selectQuery();
            represhgridview();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataManager.executeQuery("update", int.Parse(textBox1.Text), textBox2.Text, int.Parse(textBox3.Text), textBox4.Text);
            represhgridview();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataManager.executeQuery("delete", int.Parse(textBox1.Text));
            represhgridview();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                KBstudent temp = dataGridView1.CurrentRow.DataBoundItem as KBstudent;
                textBox1.Text = temp.hakbeon+"";
                textBox2.Text = temp.name;
                textBox3.Text = temp.age.ToString();
                textBox4.Text = temp.gender;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }

}
