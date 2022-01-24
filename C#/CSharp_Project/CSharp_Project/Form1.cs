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
            DataManager.selectQuery(int.Parse(label_main_tablenum.Text));
            refreshScreen();
        }
        void refreshScreen()
        {
            dataGridView1.DataSource = null;
            try
            {
                if (DataManager.menus.Count > 0)
                {
                    dataGridView1.DataSource = DataManager.menus;
                }
            }
            catch (Exception)
            {

                throw;
            }

            dataGridView2.DataSource = null;
            try
            {
                if (DataManager.menus.Count > 0)
                {
                    dataGridView2.DataSource = DataManager.menus;
                }
            }
            catch (Exception)
            {

                throw;
            }

            dataGridView3.DataSource = null;
            try
            {
                if (DataManager.menus.Count > 0)
                {
                    dataGridView3.DataSource = DataManager.menus;
                }
            }
            catch (Exception)
            {

                throw;
            }
            
            dataGridView4.DataSource = null;
            try
            {
                if (DataManager.menus.Count > 0)
                {
                    dataGridView4.DataSource = DataManager.menus;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }


        //메인 버튼부 -------------------------------------------------------------
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



        //주문 버튼부---------------------------------------------------------------------
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

            //첫실행 데이터뷰끄기
            dataGridView1.DataSource = null;
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

            //첫실행 데이터뷰끄기
            dataGridView2.DataSource = null;
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

            //첫실행 데이터뷰 끄기
            dataGridView3.DataSource = null;
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

            //첫실행 데이터뷰 끄기
            dataGridView4.DataSource = null;
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

        //창닫기 버튼--------------------------------------------------------------------
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //주문부 테이블 선택버튼---------------------------------------------------------
        //
        //테이블 선택버튼(메인메뉴)
        private void btn_main_tablenum1_Click(object sender, EventArgs e)
        {
            label_main_tablenum.Visible = true;
            label_main_tablenum.Text = "1번 테이블";
        }

        private void btn_main_tablenum2_Click(object sender, EventArgs e)
        {
            label_main_tablenum.Visible = true;
            label_main_tablenum.Text = "2번 테이블";
        }

        private void btn_main_tablenum3_Click(object sender, EventArgs e)
        {
            label_main_tablenum.Visible = true;
            label_main_tablenum.Text = "3번 테이블";
        }

        private void btn_main_tablenum4_Click(object sender, EventArgs e)
        {
            label_main_tablenum.Visible = true;
            label_main_tablenum.Text = "4번 테이블";
        }

        private void btn_main_tablenum5_Click(object sender, EventArgs e)
        {
            label_main_tablenum.Visible = true;
            label_main_tablenum.Text = "5번 테이블";
        }

        private void btn_main_tablenum6_Click(object sender, EventArgs e)
        {
            label_main_tablenum.Visible = true;
            label_main_tablenum.Text = "6번 테이블";
        }

        private void btn_main_tablenum7_Click(object sender, EventArgs e)
        {
            label_main_tablenum.Visible = true;
            label_main_tablenum.Text = "7번 테이블";
        }

        private void btn_main_tablenum8_Click(object sender, EventArgs e)
        {
            label_main_tablenum.Visible = true;
            label_main_tablenum.Text = "8번 테이블";
        }

        private void btn_main_tablenum9_Click(object sender, EventArgs e)
        {
            label_main_tablenum.Visible = true;
            label_main_tablenum.Text = "9번 테이블";
        }

        private void btn_main_tablenum10_Click(object sender, EventArgs e)
        {
            label_main_tablenum.Visible = true;
            label_main_tablenum.Text = "10번 테이블";
        }

        private void btn_main_tablenum11_Click(object sender, EventArgs e)
        {
            label_main_tablenum.Visible = true;
            label_main_tablenum.Text = "11번 테이블";
        }

        private void btn_main_tablenum12_Click(object sender, EventArgs e)
        {
            label_main_tablenum.Visible = true;
            label_main_tablenum.Text = "12번 테이블";
        }

        private void btn_main_tablenum13_Click(object sender, EventArgs e)
        {
            label_main_tablenum.Visible = true;
            label_main_tablenum.Text = "13번 테이블";
        }

        private void btn_main_tablenum14_Click(object sender, EventArgs e)
        {
            label_main_tablenum.Visible = true;
            label_main_tablenum.Text = "14번 테이블";
        }

        private void btn_main_tablenum15_Click(object sender, EventArgs e)
        {
            label_main_tablenum.Visible = true;
            label_main_tablenum.Text = "15번 테이블";
        }

        private void btn_main_tablenum16_Click(object sender, EventArgs e)
        {
            label_main_tablenum.Visible = true;
            label_main_tablenum.Text = "16번 테이블";
        }

        //
        //테이블 선택버튼(사이드 메뉴)
        private void btn_side_tablenum1_Click(object sender, EventArgs e)
        {
            label_side_tablenum.Visible = true;
            label_side_tablenum.Text = "1번 테이블";
        }

        private void btn_side_tablenum2_Click(object sender, EventArgs e)
        {
            label_side_tablenum.Visible = true;
            label_side_tablenum.Text = "2번 테이블";
        }

        private void btn_side_tablenum3_Click(object sender, EventArgs e)
        {
            label_side_tablenum.Visible = true;
            label_side_tablenum.Text = "3번 테이블";
        }

        private void btn_side_tablenum4_Click(object sender, EventArgs e)
        {
            label_side_tablenum.Visible = true;
            label_side_tablenum.Text = "4번 테이블";
        }

        private void btn_side_tablenum5_Click(object sender, EventArgs e)
        {
            label_side_tablenum.Visible = true;
            label_side_tablenum.Text = "5번 테이블";
        }

        private void btn_side_tablenum6_Click(object sender, EventArgs e)
        {
            label_side_tablenum.Visible = true;
            label_side_tablenum.Text = "6번 테이블";
        }

        private void btn_side_tablenum7_Click(object sender, EventArgs e)
        {
            label_side_tablenum.Visible = true;
            label_side_tablenum.Text = "7번 테이블";
        }

        private void btn_side_tablenum8_Click(object sender, EventArgs e)
        {
            label_side_tablenum.Visible = true;
            label_side_tablenum.Text = "8번 테이블";
        }

        private void btn_side_tablenum9_Click(object sender, EventArgs e)
        {
            label_side_tablenum.Visible = true;
            label_side_tablenum.Text = "9번 테이블";
        }

        private void btn_side_tablenum10_Click(object sender, EventArgs e)
        {
            label_side_tablenum.Visible = true;
            label_side_tablenum.Text = "10번 테이블";
        }

        private void btn_side_tablenum11_Click(object sender, EventArgs e)
        {
            label_side_tablenum.Visible = true;
            label_side_tablenum.Text = "11번 테이블";
        }

        private void btn_side_tablenum12_Click(object sender, EventArgs e)
        {
            label_side_tablenum.Visible = true;
            label_side_tablenum.Text = "12번 테이블";
        }

        private void btn_side_tablenum13_Click(object sender, EventArgs e)
        {
            label_side_tablenum.Visible = true;
            label_side_tablenum.Text = "13번 테이블";
        }

        private void btn_side_tablenum14_Click(object sender, EventArgs e)
        {
            label_side_tablenum.Visible = true;
            label_side_tablenum.Text = "14번 테이블";
        }

        private void btn_side_tablenum15_Click(object sender, EventArgs e)
        {
            label_side_tablenum.Visible = true;
            label_side_tablenum.Text = "15번 테이블";
        }

        private void btn_side_tablenum16_Click(object sender, EventArgs e)
        {
            label_side_tablenum.Visible = true;
            label_side_tablenum.Text = "16번 테이블";
        }

        //
        //테이블 선택버튼(음료 메뉴)
        private void btn_bave_tablenum1_Click(object sender, EventArgs e)
        {
            label_bave_tablenum.Visible = true;
            label_bave_tablenum.Text = "1번 테이블";
        }

        private void btn_bave_tablenum2_Click(object sender, EventArgs e)
        {
            label_bave_tablenum.Visible = true;
            label_bave_tablenum.Text = "2번 테이블";
        }

        private void btn_bave_tablenum3_Click(object sender, EventArgs e)
        {
            label_bave_tablenum.Visible = true;
            label_bave_tablenum.Text = "3번 테이블";
        }

        private void btn_bave_tablenum4_Click(object sender, EventArgs e)
        {
            label_bave_tablenum.Visible = true;
            label_bave_tablenum.Text = "4번 테이블";
        }

        private void btn_bave_tablenum5_Click(object sender, EventArgs e)
        {
            label_bave_tablenum.Visible = true;
            label_bave_tablenum.Text = "5번 테이블";
        }

        private void btn_bave_tablenum6_Click(object sender, EventArgs e)
        {
            label_bave_tablenum.Visible = true;
            label_bave_tablenum.Text = "6번 테이블";
        }

        private void btn_bave_tablenum7_Click(object sender, EventArgs e)
        {
            label_bave_tablenum.Visible = true;
            label_bave_tablenum.Text = "7번 테이블";
        }

        private void btn_bave_tablenum8_Click(object sender, EventArgs e)
        {
            label_bave_tablenum.Visible = true;
            label_bave_tablenum.Text = "8번 테이블";
        }

        private void btn_bave_tablenum9_Click(object sender, EventArgs e)
        {
            label_bave_tablenum.Visible = true;
            label_bave_tablenum.Text = "9번 테이블";
        }

        private void btn_bave_tablenum10_Click(object sender, EventArgs e)
        {
            label_bave_tablenum.Visible = true;
            label_bave_tablenum.Text = "10번 테이블";
        }

        private void btn_bave_tablenum11_Click(object sender, EventArgs e)
        {
            label_bave_tablenum.Visible = true;
            label_bave_tablenum.Text = "11번 테이블";
        }

        private void btn_bave_tablenum12_Click(object sender, EventArgs e)
        {
            label_bave_tablenum.Visible = true;
            label_bave_tablenum.Text = "12번 테이블";
        }

        private void btn_bave_tablenum13_Click(object sender, EventArgs e)
        {
            label_bave_tablenum.Visible = true;
            label_bave_tablenum.Text = "13번 테이블";
        }

        private void btn_bave_tablenum14_Click(object sender, EventArgs e)
        {
            label_bave_tablenum.Visible = true;
            label_bave_tablenum.Text = "14번 테이블";
        }

        private void btn_bave_tablenum15_Click(object sender, EventArgs e)
        {
            label_bave_tablenum.Visible = true;
            label_bave_tablenum.Text = "15번 테이블";
        }

        private void btn_bave_tablenum16_Click(object sender, EventArgs e)
        {
            label_bave_tablenum.Visible = true;
            label_bave_tablenum.Text = "16번 테이블";
        }

        //
        //테이블 선택버튼(추가메뉴)
        private void btn_add_tablenum1_Click(object sender, EventArgs e)
        {
            label_add_tablenum.Visible = true;
            label_add_tablenum.Text = "1번 테이블";
        }

        private void btn_add_tablenum2_Click(object sender, EventArgs e)
        {
            label_add_tablenum.Visible = true;
            label_add_tablenum.Text = "2번 테이블";
        }

        private void btn_add_tablenum3_Click(object sender, EventArgs e)
        {
            label_add_tablenum.Visible = true;
            label_add_tablenum.Text = "3번 테이블";
        }

        private void btn_add_tablenum4_Click(object sender, EventArgs e)
        {
            label_add_tablenum.Visible = true;
            label_add_tablenum.Text = "4번 테이블";
        }

        private void btn_add_tablenum5_Click(object sender, EventArgs e)
        {
            label_add_tablenum.Visible = true;
            label_add_tablenum.Text = "5번 테이블";
        }

        private void btn_add_tablenum6_Click(object sender, EventArgs e)
        {
            label_add_tablenum.Visible = true;
            label_add_tablenum.Text = "6번 테이블";
        }

        private void btn_add_tablenum7_Click(object sender, EventArgs e)
        {
            label_add_tablenum.Visible = true;
            label_add_tablenum.Text = "7번 테이블";
        }

        private void btn_add_tablenum8_Click(object sender, EventArgs e)
        {
            label_add_tablenum.Visible = true;
            label_add_tablenum.Text = "8번 테이블";
        }

        private void btn_add_tablenum9_Click(object sender, EventArgs e)
        {
            label_add_tablenum.Visible = true;
            label_add_tablenum.Text = "9번 테이블";
        }

        private void btn_add_tablenum10_Click(object sender, EventArgs e)
        {
            label_add_tablenum.Visible = true;
            label_add_tablenum.Text = "10번 테이블";
        }

        private void btn_add_tablenum11_Click(object sender, EventArgs e)
        {
            label_add_tablenum.Visible = true;
            label_add_tablenum.Text = "11번 테이블";
        }

        private void btn_add_tablenum12_Click(object sender, EventArgs e)
        {
            label_add_tablenum.Visible = true;
            label_add_tablenum.Text = "12번 테이블";
        }

        private void btn_add_tablenum13_Click(object sender, EventArgs e)
        {
            label_add_tablenum.Visible = true;
            label_add_tablenum.Text = "13번 테이블";
        }

        private void btn_add_tablenum14_Click(object sender, EventArgs e)
        {
            label_add_tablenum.Visible = true;
            label_add_tablenum.Text = "14번 테이블";
        }

        private void btn_add_tablenum15_Click(object sender, EventArgs e)
        {
            label_add_tablenum.Visible = true;
            label_add_tablenum.Text = "15번 테이블";
        }

        private void btn_add_tablenum16_Click(object sender, EventArgs e)
        {
            label_add_tablenum.Visible = true;
            label_add_tablenum.Text = "16번 테이블";
        }

        //
        //메인메뉴 주문 버튼----------------------------------------------------------------
        
        private void btn_mainmenu_add_Click(object sender, EventArgs e)
        {
            List<string> mainmenus = new List<string>();
            mainmenus.Add(mainmenu1.Text);
            mainmenus.Add(mainmenu2.Text);
            mainmenus.Add(mainmenu3.Text);
            mainmenus.Add(mainmenu4.Text);
            mainmenus.Add(mainmenu5.Text);
            mainmenus.Add(mainmenu6.Text);
            mainmenus.Add(mainmenu7.Text);
            mainmenus.Add(mainmenu8.Text);

            List<string> tbox_mainmenus = new List<string>();
            tbox_mainmenus.Add(textBox_mainmenu1.Text);
            tbox_mainmenus.Add(textBox_mainmenu2.Text);
            tbox_mainmenus.Add(textBox_mainmenu3.Text);
            tbox_mainmenus.Add(textBox_mainmenu4.Text);
            tbox_mainmenus.Add(textBox_mainmenu5.Text);
            tbox_mainmenus.Add(textBox_mainmenu6.Text);
            tbox_mainmenus.Add(textBox_mainmenu7.Text);
            tbox_mainmenus.Add(textBox_mainmenu8.Text);
            if (label_main_tablenum.Text == "0")
            {
                MessageBox.Show("테이블을 선택해주세요");
            }
            else if(label_main_tablenum.Text != "0")
            {
                for(int i =1; i<17; i++)
                {
                    if(label_main_tablenum.Text == $"{i}번 테이블")
                    {
                        for(int j =0; j<8; j++)
                        {
                            if (tbox_mainmenus[j] != "")
                            {
                                //DataManager.executeQuery("delete", mainmenus[j],tbox_mainmenus[j], i.ToString());
                                DataManager.executeQuery("insert",mainmenus[j],tbox_mainmenus[j] , i.ToString());
                            }
                        }
                        DataManager.selectQuery(i);
                        refreshScreen();
                    }
                }
            }
            //테이블 선택창 초기화
            label_main_tablenum.Text = "0";
            label_main_tablenum.Visible = false;
        }
        private void btn_mainmenu_delete_Click(object sender, EventArgs e)
        {
            List<string> mainmenus = new List<string>();
            mainmenus.Add(mainmenu1.Text);
            mainmenus.Add(mainmenu2.Text);
            mainmenus.Add(mainmenu3.Text);
            mainmenus.Add(mainmenu4.Text);
            mainmenus.Add(mainmenu5.Text);
            mainmenus.Add(mainmenu6.Text);
            mainmenus.Add(mainmenu7.Text);
            mainmenus.Add(mainmenu8.Text);

            List<string> tbox_mainmenus = new List<string>();
            tbox_mainmenus.Add(textBox_mainmenu1.Text);
            tbox_mainmenus.Add(textBox_mainmenu2.Text);
            tbox_mainmenus.Add(textBox_mainmenu3.Text);
            tbox_mainmenus.Add(textBox_mainmenu4.Text);
            tbox_mainmenus.Add(textBox_mainmenu5.Text);
            tbox_mainmenus.Add(textBox_mainmenu6.Text);
            tbox_mainmenus.Add(textBox_mainmenu7.Text);
            tbox_mainmenus.Add(textBox_mainmenu8.Text);
            if (label_main_tablenum.Text == "0")
            {
                MessageBox.Show("테이블을 선택해주세요");
            }
            else if (label_main_tablenum.Text != "0")
            {
                for (int i = 1; i < 17; i++)
                {
                    if (label_main_tablenum.Text == $"{i}번 테이블")
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            if (tbox_mainmenus[j] != "")
                            {
                                DataManager.executeQuery("delete", mainmenus[j],tbox_mainmenus[j], i.ToString());
                            }
                        }
                        DataManager.selectQuery(i);
                        refreshScreen();
                    }
                }
            }
            //테이블 선택창 초기화
            label_main_tablenum.Text = "0";
            label_main_tablenum.Visible = false;
        }

        private void btn_mainmenu_update_Click(object sender, EventArgs e)
        {
            List<string> mainmenus = new List<string>();
            mainmenus.Add(mainmenu1.Text);
            mainmenus.Add(mainmenu2.Text);
            mainmenus.Add(mainmenu3.Text);
            mainmenus.Add(mainmenu4.Text);
            mainmenus.Add(mainmenu5.Text);
            mainmenus.Add(mainmenu6.Text);
            mainmenus.Add(mainmenu7.Text);
            mainmenus.Add(mainmenu8.Text);

            List<string> tbox_mainmenus = new List<string>();
            tbox_mainmenus.Add(textBox_mainmenu1.Text);
            tbox_mainmenus.Add(textBox_mainmenu2.Text);
            tbox_mainmenus.Add(textBox_mainmenu3.Text);
            tbox_mainmenus.Add(textBox_mainmenu4.Text);
            tbox_mainmenus.Add(textBox_mainmenu5.Text);
            tbox_mainmenus.Add(textBox_mainmenu6.Text);
            tbox_mainmenus.Add(textBox_mainmenu7.Text);
            tbox_mainmenus.Add(textBox_mainmenu8.Text);
            if (label_main_tablenum.Text == "0")
            {
                MessageBox.Show("테이블을 선택해주세요");
            }
            else if (label_main_tablenum.Text != "0")
            {
                for (int i = 1; i < 17; i++)
                {
                    if (label_main_tablenum.Text == $"{i}번 테이블")
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            if (tbox_mainmenus[j] != "")
                            {
                                DataManager.executeQuery("update", mainmenus[j], tbox_mainmenus[j], i.ToString());
                            }
                        }
                        DataManager.selectQuery(i);
                        refreshScreen();
                    }
                }
            }
            //테이블 선택창 초기화
            label_main_tablenum.Text = "0";
            label_main_tablenum.Visible = false;
        }

        //사이드메뉴 버튼---------------------------------------------------------------------------------
        private void btn_sidemenu_add_Click(object sender, EventArgs e)
        {
            List<string> sidemenus = new List<string>();
            sidemenus.Add(sidemenu1.Text);
            sidemenus.Add(sidemenu2.Text);
            sidemenus.Add(sidemenu3.Text);
            sidemenus.Add(sidemenu4.Text);
            sidemenus.Add(sidemenu5.Text);
            sidemenus.Add(sidemenu6.Text);
            sidemenus.Add(sidemenu7.Text);
            sidemenus.Add(sidemenu8.Text);

            List<string> tbox_sidemenus = new List<string>();
            tbox_sidemenus.Add(textBox_sidemenu1.Text);
            tbox_sidemenus.Add(textBox_sidemenu2.Text);
            tbox_sidemenus.Add(textBox_sidemenu3.Text);
            tbox_sidemenus.Add(textBox_sidemenu4.Text);
            tbox_sidemenus.Add(textBox_sidemenu5.Text);
            tbox_sidemenus.Add(textBox_sidemenu6.Text);
            tbox_sidemenus.Add(textBox_sidemenu7.Text);
            tbox_sidemenus.Add(textBox_sidemenu8.Text);

            if (label_side_tablenum.Text == "0")
            {
                MessageBox.Show("테이블을 선택해주세요");
            }
            else if (label_side_tablenum.Text != "0")
            {
                for (int i = 1; i < 17; i++)
                {
                    if (label_side_tablenum.Text == $"{i}번 테이블")
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            if (tbox_sidemenus[j] != "")
                            {
                                DataManager.executeQuery("insert", sidemenus[j], tbox_sidemenus[j], i.ToString());
                            }
                        }
                        DataManager.selectQuery(i);
                        refreshScreen();
                    }
                }
            }
            //테이블 선택창 초기화
            label_side_tablenum.Text = "0";
            label_side_tablenum.Visible = false;
        }
        private void btn_sidemenu_delete_Click(object sender, EventArgs e)
        {
            List<string> sidemenus = new List<string>();
            sidemenus.Add(sidemenu1.Text);
            sidemenus.Add(sidemenu2.Text);
            sidemenus.Add(sidemenu3.Text);
            sidemenus.Add(sidemenu4.Text);
            sidemenus.Add(sidemenu5.Text);
            sidemenus.Add(sidemenu6.Text);
            sidemenus.Add(sidemenu7.Text);
            sidemenus.Add(sidemenu8.Text);

            List<string> tbox_sidemenus = new List<string>();
            tbox_sidemenus.Add(textBox_sidemenu1.Text);
            tbox_sidemenus.Add(textBox_sidemenu2.Text);
            tbox_sidemenus.Add(textBox_sidemenu3.Text);
            tbox_sidemenus.Add(textBox_sidemenu4.Text);
            tbox_sidemenus.Add(textBox_sidemenu5.Text);
            tbox_sidemenus.Add(textBox_sidemenu6.Text);
            tbox_sidemenus.Add(textBox_sidemenu7.Text);
            tbox_sidemenus.Add(textBox_sidemenu8.Text);

            if (label_side_tablenum.Text == "0")
            {
                MessageBox.Show("테이블을 선택해주세요");
            }
            else if (label_side_tablenum.Text != "0")
            {
                for (int i = 1; i < 17; i++)
                {
                    if (label_side_tablenum.Text == $"{i}번 테이블")
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            if (tbox_sidemenus[j] != "")
                            {
                                DataManager.executeQuery("delete", sidemenus[j], tbox_sidemenus[j], i.ToString());
                            }
                        }
                        DataManager.selectQuery(i);
                        refreshScreen();
                    }
                }
            }
            //테이블 선택창 초기화
            label_side_tablenum.Text = "0";
            label_side_tablenum.Visible = false;
        }

        private void btn_sidemenu_update_Click(object sender, EventArgs e)
        {
            List<string> sidemenus = new List<string>();
            sidemenus.Add(sidemenu1.Text);
            sidemenus.Add(sidemenu2.Text);
            sidemenus.Add(sidemenu3.Text);
            sidemenus.Add(sidemenu4.Text);
            sidemenus.Add(sidemenu5.Text);
            sidemenus.Add(sidemenu6.Text);
            sidemenus.Add(sidemenu7.Text);
            sidemenus.Add(sidemenu8.Text);

            List<string> tbox_sidemenus = new List<string>();
            tbox_sidemenus.Add(textBox_sidemenu1.Text);
            tbox_sidemenus.Add(textBox_sidemenu2.Text);
            tbox_sidemenus.Add(textBox_sidemenu3.Text);
            tbox_sidemenus.Add(textBox_sidemenu4.Text);
            tbox_sidemenus.Add(textBox_sidemenu5.Text);
            tbox_sidemenus.Add(textBox_sidemenu6.Text);
            tbox_sidemenus.Add(textBox_sidemenu7.Text);
            tbox_sidemenus.Add(textBox_sidemenu8.Text);

            if (label_side_tablenum.Text == "0")
            {
                MessageBox.Show("테이블을 선택해주세요");
            }
            else if (label_side_tablenum.Text != "0")
            {
                for (int i = 1; i < 17; i++)
                {
                    if (label_side_tablenum.Text == $"{i}번 테이블")
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            if (tbox_sidemenus[j] != "")
                            {
                                DataManager.executeQuery("update", sidemenus[j], tbox_sidemenus[j], i.ToString());
                            }
                        }
                        DataManager.selectQuery(i);
                        refreshScreen();
                    }
                }
            }
            //테이블 선택창 초기화
            label_side_tablenum.Text = "0";
            label_side_tablenum.Visible = false;
        }

        //음료메뉴 버튼 -------------------------------------------------------------------------------------
        private void btn_bavemenu_add_Click(object sender, EventArgs e)
        {
            List<string> bavemenus = new List<string>();
            bavemenus.Add(bavemenu1.Text);
            bavemenus.Add(bavemenu2.Text);
            bavemenus.Add(bavemenu3.Text);
            bavemenus.Add(bavemenu4.Text);
            bavemenus.Add(bavemenu5.Text);
            bavemenus.Add(bavemenu6.Text);
            bavemenus.Add(bavemenu7.Text);
            bavemenus.Add(bavemenu8.Text);

            List<string> tbox_bavemenus = new List<string>();
            tbox_bavemenus.Add(textBox_bavemenu1.Text);
            tbox_bavemenus.Add(textBox_bavemenu2.Text);
            tbox_bavemenus.Add(textBox_bavemenu3.Text);
            tbox_bavemenus.Add(textBox_bavemenu4.Text);
            tbox_bavemenus.Add(textBox_bavemenu5.Text);
            tbox_bavemenus.Add(textBox_bavemenu6.Text);
            tbox_bavemenus.Add(textBox_bavemenu7.Text);
            tbox_bavemenus.Add(textBox_bavemenu8.Text);

            if (label_bave_tablenum.Text == "0")
            {
                MessageBox.Show("테이블을 선택해주세요");
            }
            else if (label_bave_tablenum.Text != "0")
            {
                for (int i = 1; i < 17; i++)
                {
                    if (label_bave_tablenum.Text == $"{i}번 테이블")
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            if (tbox_bavemenus[j] != "")
                            {
                                DataManager.executeQuery("insert", bavemenus[j], tbox_bavemenus[j], i.ToString());
                            }
                        }
                        DataManager.selectQuery(i);
                        refreshScreen();
                    }
                }
            }
            //테이블 선택창 초기화
            label_bave_tablenum.Text = "0";
            label_bave_tablenum.Visible = false;
        }
        private void btn_bavemenu_delete_Click(object sender, EventArgs e)
        {
            List<string> bavemenus = new List<string>();
            bavemenus.Add(bavemenu1.Text);
            bavemenus.Add(bavemenu2.Text);
            bavemenus.Add(bavemenu3.Text);
            bavemenus.Add(bavemenu4.Text);
            bavemenus.Add(bavemenu5.Text);
            bavemenus.Add(bavemenu6.Text);
            bavemenus.Add(bavemenu7.Text);
            bavemenus.Add(bavemenu8.Text);

            List<string> tbox_bavemenus = new List<string>();
            tbox_bavemenus.Add(textBox_bavemenu1.Text);
            tbox_bavemenus.Add(textBox_bavemenu2.Text);
            tbox_bavemenus.Add(textBox_bavemenu3.Text);
            tbox_bavemenus.Add(textBox_bavemenu4.Text);
            tbox_bavemenus.Add(textBox_bavemenu5.Text);
            tbox_bavemenus.Add(textBox_bavemenu6.Text);
            tbox_bavemenus.Add(textBox_bavemenu7.Text);
            tbox_bavemenus.Add(textBox_bavemenu8.Text);

            if (label_bave_tablenum.Text == "0")
            {
                MessageBox.Show("테이블을 선택해주세요");
            }
            else if (label_bave_tablenum.Text != "0")
            {
                for (int i = 1; i < 17; i++)
                {
                    if (label_bave_tablenum.Text == $"{i}번 테이블")
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            if (tbox_bavemenus[j] != "")
                            {
                                DataManager.executeQuery("delete", bavemenus[j], tbox_bavemenus[j], i.ToString());
                            }
                        }
                        DataManager.selectQuery(i);
                        refreshScreen();
                    }
                }
            }
            //테이블 선택창 초기화
            label_bave_tablenum.Text = "0";
            label_bave_tablenum.Visible = false;
        }

        private void btn_bavemenu_update_Click(object sender, EventArgs e)
        {
            List<string> bavemenus = new List<string>();
            bavemenus.Add(bavemenu1.Text);
            bavemenus.Add(bavemenu2.Text);
            bavemenus.Add(bavemenu3.Text);
            bavemenus.Add(bavemenu4.Text);
            bavemenus.Add(bavemenu5.Text);
            bavemenus.Add(bavemenu6.Text);
            bavemenus.Add(bavemenu7.Text);
            bavemenus.Add(bavemenu8.Text);

            List<string> tbox_bavemenus = new List<string>();
            tbox_bavemenus.Add(textBox_bavemenu1.Text);
            tbox_bavemenus.Add(textBox_bavemenu2.Text);
            tbox_bavemenus.Add(textBox_bavemenu3.Text);
            tbox_bavemenus.Add(textBox_bavemenu4.Text);
            tbox_bavemenus.Add(textBox_bavemenu5.Text);
            tbox_bavemenus.Add(textBox_bavemenu6.Text);
            tbox_bavemenus.Add(textBox_bavemenu7.Text);
            tbox_bavemenus.Add(textBox_bavemenu8.Text);

            if (label_bave_tablenum.Text == "0")
            {
                MessageBox.Show("테이블을 선택해주세요");
            }
            else if (label_bave_tablenum.Text != "0")
            {
                for (int i = 1; i < 17; i++)
                {
                    if (label_bave_tablenum.Text == $"{i}번 테이블")
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            if (tbox_bavemenus[j] != "")
                            {
                                DataManager.executeQuery("update", bavemenus[j], tbox_bavemenus[j], i.ToString());
                            }
                        }
                        DataManager.selectQuery(i);
                        refreshScreen();
                    }
                }
            }
            //테이블 선택창 초기화
            label_bave_tablenum.Text = "0";
            label_bave_tablenum.Visible = false;
        }

        //추가메뉴 버튼 -------------------------------------------------------------------------------------
        private void btn_addmenu_add_Click(object sender, EventArgs e)
        {
            List<string> addmenus = new List<string>();
            addmenus.Add(addmenu1.Text);
            addmenus.Add(addmenu2.Text);
            addmenus.Add(addmenu3.Text);
            addmenus.Add(addmenu4.Text);
            addmenus.Add(addmenu5.Text);
            addmenus.Add(addmenu6.Text);
            addmenus.Add(addmenu7.Text);
            addmenus.Add(addmenu8.Text);

            List<string> tbox_addmenus = new List<string>();
            tbox_addmenus.Add(textBox_addmenu1.Text);
            tbox_addmenus.Add(textBox_addmenu2.Text);
            tbox_addmenus.Add(textBox_addmenu3.Text);
            tbox_addmenus.Add(textBox_addmenu4.Text);
            tbox_addmenus.Add(textBox_addmenu5.Text);
            tbox_addmenus.Add(textBox_addmenu6.Text);
            tbox_addmenus.Add(textBox_addmenu7.Text);
            tbox_addmenus.Add(textBox_addmenu8.Text);

            if (label_add_tablenum.Text == "0")
            {
                MessageBox.Show("테이블을 선택해주세요");
            }
            else if (label_add_tablenum.Text != "0")
            {
                for (int i = 1; i < 17; i++)
                {
                    if (label_add_tablenum.Text == $"{i}번 테이블")
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            if (tbox_addmenus[j] != "")
                            {
                                DataManager.executeQuery("insert", addmenus[j], tbox_addmenus[j], i.ToString());
                            }
                        }
                        DataManager.selectQuery(i);
                        refreshScreen();
                    }
                }
            }
            //테이블 선택창 초기화
            label_add_tablenum.Text = "0";
            label_add_tablenum.Visible = false;
        }
        private void btn_addmenu_delete_Click(object sender, EventArgs e)
        {
            List<string> addmenus = new List<string>();
            addmenus.Add(addmenu1.Text);
            addmenus.Add(addmenu2.Text);
            addmenus.Add(addmenu3.Text);
            addmenus.Add(addmenu4.Text);
            addmenus.Add(addmenu5.Text);
            addmenus.Add(addmenu6.Text);
            addmenus.Add(addmenu7.Text);
            addmenus.Add(addmenu8.Text);

            List<string> tbox_addmenus = new List<string>();
            tbox_addmenus.Add(textBox_addmenu1.Text);
            tbox_addmenus.Add(textBox_addmenu2.Text);
            tbox_addmenus.Add(textBox_addmenu3.Text);
            tbox_addmenus.Add(textBox_addmenu4.Text);
            tbox_addmenus.Add(textBox_addmenu5.Text);
            tbox_addmenus.Add(textBox_addmenu6.Text);
            tbox_addmenus.Add(textBox_addmenu7.Text);
            tbox_addmenus.Add(textBox_addmenu8.Text);

            if (label_add_tablenum.Text == "0")
            {
                MessageBox.Show("테이블을 선택해주세요");
            }
            else if (label_add_tablenum.Text != "0")
            {
                for (int i = 1; i < 17; i++)
                {
                    if (label_add_tablenum.Text == $"{i}번 테이블")
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            if (tbox_addmenus[j] != "")
                            {
                                DataManager.executeQuery("delete", addmenus[j], tbox_addmenus[j], i.ToString());
                            }
                        }
                        DataManager.selectQuery(i);
                        refreshScreen();
                    }
                }
            }
            //테이블 선택창 초기화
            label_add_tablenum.Text = "0";
            label_add_tablenum.Visible = false;
        }

        private void btn_addmenu_update_Click(object sender, EventArgs e)
        {
            List<string> addmenus = new List<string>();
            addmenus.Add(addmenu1.Text);
            addmenus.Add(addmenu2.Text);
            addmenus.Add(addmenu3.Text);
            addmenus.Add(addmenu4.Text);
            addmenus.Add(addmenu5.Text);
            addmenus.Add(addmenu6.Text);
            addmenus.Add(addmenu7.Text);
            addmenus.Add(addmenu8.Text);

            List<string> tbox_addmenus = new List<string>();
            tbox_addmenus.Add(textBox_addmenu1.Text);
            tbox_addmenus.Add(textBox_addmenu2.Text);
            tbox_addmenus.Add(textBox_addmenu3.Text);
            tbox_addmenus.Add(textBox_addmenu4.Text);
            tbox_addmenus.Add(textBox_addmenu5.Text);
            tbox_addmenus.Add(textBox_addmenu6.Text);
            tbox_addmenus.Add(textBox_addmenu7.Text);
            tbox_addmenus.Add(textBox_addmenu8.Text);

            if (label_add_tablenum.Text == "0")
            {
                MessageBox.Show("테이블을 선택해주세요");
            }
            else if (label_add_tablenum.Text != "0")
            {
                for (int i = 1; i < 17; i++)
                {
                    if (label_add_tablenum.Text == $"{i}번 테이블")
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            if (tbox_addmenus[j] != "")
                            {
                                DataManager.executeQuery("update", addmenus[j], tbox_addmenus[j], i.ToString());
                            }
                        }
                        DataManager.selectQuery(i);
                        refreshScreen();
                    }
                }
            }
            //테이블 선택창 초기화
            label_add_tablenum.Text = "0";
            label_add_tablenum.Visible = false;
        }
    }
}


//((DataTable)dataGridView1.DataSource).Rows.Clear();   //데이터뷰 컬럼명 놔두고 사라지게하는코드

/*
 else if(label_main_tablenum.Text != "0")
            {
                for(int i =1; i<17; i++)
                {
                    if(label_main_tablenum.Text == $"{i}번 테이블")
                    {
                        for(int j =1; j<9; j++)
                        {
                            if ($"textBox_mainmenu{j}.Text" != null)
                            {
                                DataManager.executeQuery("insert",mainmenu1.Text,textBox_mainmenu1.Text, i.ToString());
                            }
                        }
                        DataManager.selectQuery(i);
                        refreshScreen();
                        MessageBox.Show("성공");
                    }
                }
            }
데이터그리드뷰에 테이블별로 화면뿌리는 코드
*/