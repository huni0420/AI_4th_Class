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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btn_order_Click(object sender, EventArgs e)
        {
            //버튼교체
            btn_order.Visible = false;
            btn_order_close.Visible = true;
            panel_lab1.Visible = true;

            //다른 버튼 실행 끄기
            btn_table_close_Click(sender, e);
            btn_calculate_close_Click(sender, e);
            btn_parking_close_Click(sender, e);

            //켜져있는 다른 판넬 끄기
            panel_lab2.Visible = false;
            panel_lab3.Visible = false;
            panel_lab4.Visible = false;

            //주문창의 판넬끄기
            btn_mainmenu_close_Click(sender, e);
            btn_sidemenu_close_Click(sender, e);
            btn_beverage_close_Click(sender, e);
            btn_addmenu_close_Click(sender, e);
        }

        private void btn_table_Click(object sender, EventArgs e)
        {
            //버튼교체
            btn_table.Visible = false;
            btn_table_close.Visible = true;
            panel_lab2.Visible = true;

            //다른 버튼 실행 끄기
            btn_order_close_Click(sender, e);
            btn_calculate_close_Click(sender, e);
            btn_parking_close_Click(sender, e);

            //켜져있는 다른 판넬 끄기
            panel_lab1.Visible = false;
            panel_lab3.Visible = false;
            panel_lab4.Visible = false;

            //주문창의 판넬끄기
            btn_mainmenu_close_Click(sender, e);
            btn_sidemenu_close_Click(sender, e);
            btn_beverage_close_Click(sender, e);
            btn_addmenu_close_Click(sender, e);
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            //버튼교체
            btn_calculate.Visible = false;
            btn_calculate_close.Visible = true;
            panel_lab3.Visible = true;

            //다른 버튼 실행 끄기
            btn_order_close_Click(sender, e);
            btn_table_close_Click(sender, e);
            btn_parking_close_Click(sender, e);

            //켜져있는 다른 판넬 끄기
            panel_lab1.Visible = false;
            panel_lab2.Visible = false;
            panel_lab4.Visible = false;

            //주문창의 판넬끄기
            btn_mainmenu_close_Click(sender, e);
            btn_sidemenu_close_Click(sender, e);
            btn_beverage_close_Click(sender, e);
            btn_addmenu_close_Click(sender, e);
        }

        private void btn_parking_Click(object sender, EventArgs e)
        {
            //버튼교체
            btn_parking.Visible = false;
            btn_parking_close.Visible = true;
            panel_lab4.Visible = true;

            //다른 버튼 실행 끄기
            btn_order_close_Click(sender, e);
            btn_table_close_Click(sender, e);
            btn_calculate_close_Click(sender, e);

            //켜져있는 다른 판넬 끄기
            panel_lab1.Visible = false;
            panel_lab2.Visible = false;
            panel_lab3.Visible = false;

            //주문창의 판넬끄기
            btn_mainmenu_close_Click(sender, e);
            btn_sidemenu_close_Click(sender, e);
            btn_beverage_close_Click(sender, e);
            btn_addmenu_close_Click(sender, e);
        }

        private void btn_order_close_Click(object sender, EventArgs e)
        {
            btn_order_close.Visible = false;
            btn_order.Visible = true;
            panel_lab1.Visible = false;

            //메뉴 내용들 끄기
            panel_mainmenu.Visible = false;
            panel_sidemenu.Visible = false;
            panel_baverage.Visible = false;
            panel_addmenu.Visible = false;
        }

        private void btn_table_close_Click(object sender, EventArgs e)
        {
            btn_table_close.Visible = false;
            btn_table.Visible = true;
            panel_lab2.Visible = false;
        }

        private void btn_calculate_close_Click(object sender, EventArgs e)
        {
            btn_calculate_close.Visible = false;
            btn_calculate.Visible = true;
            panel_lab3.Visible = false;
        }

        private void btn_parking_close_Click(object sender, EventArgs e)
        {
            btn_parking_close.Visible = false;
            btn_parking.Visible = true;
            panel_lab4.Visible = false;
        }



        //주문 버튼들-------------------------------------------------------------------
        private void btn_mainmenu_Click(object sender, EventArgs e)
        {
            //버튼교체
            btn_mainmenu.Visible = false;
            btn_mainmenu_close.Visible = true;
            panel_mainmenu.Visible = true;

            //다른 버튼 실행 끄기
            btn_sidemenu_close_Click(sender, e);
            btn_beverage_close_Click(sender, e);
            btn_addmenu_close_Click(sender, e);


            //다른 판넬 끄기
            panel_sidemenu.Visible = false;
            panel_baverage.Visible = false;
            panel_addmenu.Visible = false;
        }

        private void btn_sidemenu_Click(object sender, EventArgs e)
        {
            //버튼교체
            btn_sidemenu.Visible = false;
            btn_sidemenu_close.Visible = true;
            panel_sidemenu.Visible = true;

            //다른 버튼 실행 끄기
            btn_mainmenu_close_Click(sender, e);
            btn_beverage_close_Click(sender, e);
            btn_addmenu_close_Click(sender, e);

            //다른 판넬 끄기
            panel_mainmenu.Visible = false;
            panel_baverage.Visible = false;
            panel_addmenu.Visible = false;
        }

        private void btn_beverage_Click(object sender, EventArgs e)
        {
            //버튼교체
            btn_beverage.Visible = false;
            btn_beverage_close.Visible = true;
            panel_baverage.Visible = true;

            //다른 버튼 실행 끄기
            btn_mainmenu_close_Click(sender, e);
            btn_sidemenu_close_Click(sender, e);
            btn_addmenu_close_Click(sender, e);

            //다른 판넬 끄기
            panel_mainmenu.Visible = false;
            panel_sidemenu.Visible = false;
            panel_addmenu.Visible = false;
        }

        private void btn_addmenu_Click(object sender, EventArgs e)
        {
            //버튼교체
            btn_addmenu.Visible = false;
            btn_addmenu_close.Visible = true;
            panel_addmenu.Visible = true;

            //다른 버튼 실행 끄기
            btn_mainmenu_close_Click(sender, e);
            btn_sidemenu_close_Click(sender, e);
            btn_beverage_close_Click(sender, e);

            //다른 판넬 끄기
            panel_mainmenu.Visible = false;
            panel_sidemenu.Visible = false;
            panel_baverage.Visible = false;
        }

        private void btn_mainmenu_close_Click(object sender, EventArgs e)
        {
            btn_mainmenu.Visible = true;
            btn_mainmenu_close.Visible = false;
            panel_mainmenu.Visible = false;
        }

        private void btn_sidemenu_close_Click(object sender, EventArgs e)
        {
            btn_sidemenu.Visible = true;
            btn_sidemenu_close.Visible = false;
            panel_sidemenu.Visible = false;
        }

        private void btn_beverage_close_Click(object sender, EventArgs e)
        {
            btn_beverage.Visible = true;
            btn_beverage_close.Visible = false;
            panel_baverage.Visible = false;
        }

        private void btn_addmenu_close_Click(object sender, EventArgs e)
        {
            btn_addmenu.Visible = true;
            btn_addmenu_close.Visible = false;
            panel_addmenu.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
