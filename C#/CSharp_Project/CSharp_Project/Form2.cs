using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
            textBox1.MaxLength = 16;
            textBox2.MaxLength = 11;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}