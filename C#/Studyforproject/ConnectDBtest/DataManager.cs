using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectDBtest
{
    internal class DataManager
    {

        //결과 데이터 저장하는 곳
        public static List<KBstudent> kbstudent = new List<KBstudent>();
        
        
        
        const string ORADB = "Data Source=(DESCRIPTION=(ADDRESS_LIST=" +
               "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))" +
               "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE)));" +
               "User Id=c##scott;Password=tiger;";
        public static OracleConnection OraConn = new OracleConnection();

        public static DataSet ds;

        const String Table = "KB_Student";

        private static void ConnectDB()//public도 괜찮
        {
            try
            {
                OraConn = new OracleConnection(ORADB);
                OraConn.Open();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void selectQuery()
        {
            ConnectDB(); //db연결 해주고 나서, select문 날리는거다.

            string sql = $"select * from {Table}";
            OracleDataAdapter oda = new OracleDataAdapter();
            oda.SelectCommand = new OracleCommand();
            oda.SelectCommand.Connection = OraConn;
            oda.SelectCommand.CommandText = sql;  //select문 날리는 부분

            ds = new DataSet();
            oda.Fill(ds, Table);

            //List<MyTest> tests = new List<MyTest>();
            kbstudent.Clear();
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                KBstudent kb = new KBstudent();
                kb.hakbeon = int.Parse(item["hakbeon"].ToString());
                kb.name = item["name"].ToString();
                kb.age = int.Parse(item["age"].ToString());
                kb.gender = item["gender"].ToString();
                kbstudent.Add(kb);
            }
            OraConn.Close(); //db 연결 닫기
        }
        //gender라는 파라메터는 입력값이 없다면 기본적으로 "남자"값이 들어간다
        public static void executeQuery(string menu, int hakbeon, String name = null, int age = 0, String gender = "남자")
        {
            ConnectDB();

            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = OraConn;
                String query = "";
                if (menu == "insert") 
                { 
                    query = $"insert into {Table} values({hakbeon},'{name}',{age},'{gender}')";
                }
                else if (menu == "update") 
                { 
                    query = $"update {Table} set name='{name}',age={age},gender='{gender}' where hakbeon = '{hakbeon}' ";
                }
                else if (menu == "delete") 
                { 
                    query = $"delete from {Table} where hakbeon = {hakbeon}" ;
                }
                else 
                { 
                    throw new Exception(menu + "는 없는 쿼리문입니다."); 
                }
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }

            OraConn.Close();

            selectQuery(); //db 연결해서 추가,수정,삭제 후 db닫고, 다시 db 연결해서
                           //조회하고, db연결 닫음
        }
    }
}
