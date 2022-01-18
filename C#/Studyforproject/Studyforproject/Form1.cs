using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studyforproject
{
    public partial class Form1 : Form
    {
        const string ORADB = "Data Source=(DESCRIPTION=(ADDRESS_LIST=" +
               "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))" +
               "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE)));" +
               "User Id=c##scott;Password=tiger;";
        public static OracleConnection OraConn = new OracleConnection(ORADB);

        //OracleCommand cmd = new OracleCommand();
        public static DataSet ds;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_connect_select_Click(object sender, EventArgs e)
        {
            //오라클 연결부
            try
            {
                //OraConn = new OracleConnection();
                OraConn.Open();
                //cmd = new OracleCommand();
            }
            catch (System.Exception ex)
            {

                throw;
            }
            
            //쿼리문 날리기
            String sql = "select * from myoracletest"; //문자열 안에 세미클론 넣지 말기
            OracleDataAdapter oda = new OracleDataAdapter();
            oda.SelectCommand = new OracleCommand();
            oda.SelectCommand.Connection = OraConn;
            oda.SelectCommand.CommandText = sql;

            ds = new DataSet();//데이터를 저장하는 DataSet 객체 생성
            oda.Fill(ds,"myoracletest");//DataSet에 쿼리 결과물을 저장하는 코드
            
            //그 결과를 List에 저장
            List<Mytest> tests = new List<Mytest>();
            //테이블에 있는 데이터만큼 foreach문을 수행함
            foreach (DataRow item in ds.Tables[0].Rows)//DataSet에 테이블이 여러개가 들어갈 수 있는데, 현재는 하나만 들어간 것.
            {
                Mytest mytest = new Mytest();
                mytest.name = item["Name"].ToString();
                mytest.id = int.Parse(item["Id"].ToString());
                tests.Add(mytest);
            }

            //List에 있는 걸 datagridview로 옮김
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = tests;
            //db연결 닫기
            OraConn.Close();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            //db랑 연결 ->똑같은 코드가 계속 반복 됨
            try
            {
                OraConn = new OracleConnection(ORADB);
                OraConn.Open();
            }
            catch (System.Exception)
            {

                throw;
            }
            try
            {
                //db에 insert문 전송
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = OraConn;
                cmd.CommandText = $"insert into  MyoracleTest values({textBox_ID.Text},'{textBox_Name.Text}')";
                cmd.ExecuteNonQuery();
                //db 연결 닫기
                OraConn.Close();
            }
            catch (System.Exception)
            {

                throw;
            }
            btn_connect_select_Click(sender, e);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            //db랑 연결 ->똑같은 코드가 계속 반복 됨
            try
            {
                OraConn = new OracleConnection(ORADB);
                OraConn.Open();
            }
            catch (System.Exception)
            {

                throw;
            }
            try
            {
                //db에 update문 전송
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = OraConn;
                cmd.CommandText = $"update MyoracleTest set name='{textBox_Name.Text}'where id={textBox_ID.Text}";
                //cmd.CommandText = $"insert into  MyoracleTest values({textBox_ID.Text},'{textBox_Name.Text}')";
                cmd.ExecuteNonQuery();
                //db 연결 닫기
                OraConn.Close();
            }
            catch (System.Exception)
            {

                throw;
            }
            btn_connect_select_Click(sender, e);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            //db랑 연결 ->똑같은 코드가 계속 반복 됨
            try
            {
                OraConn = new OracleConnection(ORADB);
                OraConn.Open();
            }
            catch (System.Exception)
            {

                throw;
            }
            try
            {
                //db에 update문 전송
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = OraConn;
                cmd.CommandText = $"delete from MyoracleTest where id={textBox_ID.Text}";
                //cmd.CommandText = $"insert into  MyoracleTest values({textBox_ID.Text},'{textBox_Name.Text}')";
                cmd.ExecuteNonQuery();
                //db 연결 닫기
                OraConn.Close();
            }
            catch (System.Exception)
            {

                throw;
            }
            btn_connect_select_Click(sender, e);
        }
    }
}
