using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Project
{
    public class DataManager
    {
        const string ORADB = "Data Source=(DESCRIPTION=(ADDRESS_LIST=" +
                  "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))" +
                  "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE)));" +
                  "User Id=system;Password=1234;";
        public static OracleConnection OraConn = new OracleConnection(ORADB);

        public static List<Menu> menus = new List<Menu>();

        const string TABLE = "menu";
        static void ConnectDB() 
        {
            try
            {
                OraConn.Open();
            }
            catch (Exception ex)
            {
                throw new Exception("DB 연결 에러 " + ex.Message + "에러 위치 " + Environment.NewLine + ex.StackTrace);
            }
        }
        public static void selectQuery()
        {
            ConnectDB();

            string sql;
            sql = "select * from " + TABLE;

            OracleDataAdapter oda = new OracleDataAdapter();
            oda.SelectCommand = new OracleCommand();
            oda.SelectCommand.Connection = OraConn;
            oda.SelectCommand.CommandText = sql;

            DataSet ds = new DataSet();
            oda.Fill(ds, TABLE);

            menus.Clear();

            foreach (DataRow item in ds.Tables[0].Rows)
            {
                Menu menu = new Menu();
                menu.tb_number = int.Parse(item["tablenum"].ToString());
                menu.menu = item["menu"].ToString();
                menu.quantity = int.Parse(item["quantity"].ToString());
                menus.Add(menu);
            }
            OraConn.Close();
        }
        public static void selectQuery(int num)
        {
            ConnectDB();

            string sql;
            sql = "select * from " + TABLE + " where tablenum =" + num;

            OracleDataAdapter oda = new OracleDataAdapter();
            oda.SelectCommand = new OracleCommand();
            oda.SelectCommand.Connection = OraConn;
            oda.SelectCommand.CommandText = sql;

            DataSet ds = new DataSet();
            oda.Fill(ds, TABLE);

            menus.Clear();

            foreach (DataRow item in ds.Tables[0].Rows)
            {
                Menu menu = new Menu();
                menu.tb_number = int.Parse(item["tablenum"].ToString());
                menu.menu = item["menu"].ToString();
                menu.quantity = int.Parse(item["quantity"].ToString());
                menus.Add(menu);
            }
            OraConn.Close();
        }


        static string Query(string menu, string menus, string quantity, string tablenum)
        {
            string query = "";
            switch (menu)
            {
                case "update":
                    query = $"update {TABLE} set quantity = {quantity} where menu = '{menus}' and tablenum = {tablenum}";
                    break;
                case "insert":
                        query = $"insert into {TABLE} values('{menus}',{tablenum},{quantity})";
                    break;
                case "delete":
                    query = $"delete from {TABLE} where menu = '{menus}' and tablenum = {tablenum}";
                    break;
                default:

                    break;
            }
            return query;
        }

        //executeQuery("delete",1)
        //executeQuery("update",1,"30규1234","이동준","010-2940-1613")
        //삽입, 삭제, 수정 역할 함
        //삽입 : 주차공간 추가, 삭제 : 주차공간 삭제, 수정 : 주차 및 출차처리
        public static void executeQuery(string menu, string menus, string quantity, string tablenum)
        {
            ConnectDB();
            string query = "";
            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = OraConn;
                query = Query(menu, menus, quantity, tablenum);
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) //쿼리문에 문제 생길 시 오류 발생
            {
                //쿼리문과 함께 오류 메시지들 출력
                OraConn.Close(); //쿼리 날렸을 때 실패하면 db접속을 닫아준다.
                throw new Exception(query + "_" + ex.Message + "오류위치" + Environment.NewLine + ex.StackTrace);
            }

            OraConn.Close();

            selectQuery(); //수정 삭제 삽입 후 테이블 조회해서 cars List 업데이트 시킴
        }

    }
}
