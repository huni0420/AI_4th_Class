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
                  "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));" +
                  "User Id=system;Password=1234;";
        public static OracleConnection OraConn = new OracleConnection(ORADB);

        public static List<Menu> menus = new List<Menu>();
        public static List<Parking> parkings = new List<Parking>();

        const string TABLE = "menu";
        const string TABLE1 = "parking";
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
        public static void selectQuery_p()
        {
            ConnectDB();

            string sql;
            sql = "select * from " + TABLE1;

            OracleDataAdapter oda = new OracleDataAdapter();
            oda.SelectCommand = new OracleCommand();
            oda.SelectCommand.Connection = OraConn;
            oda.SelectCommand.CommandText = sql;

            DataSet ds = new DataSet();
            oda.Fill(ds, TABLE1);

            parkings.Clear();

            foreach (DataRow item in ds.Tables[0].Rows)
            {
                Parking parking = new Parking();
                parking.CarName = item["carname"].ToString();
                parking.Time = item["time"].ToString();
                parking.Status = item["status"].ToString();
                parking.ParkingNum = item["parkingnum"].ToString();
                /*parking.Cash = int.Parse(item["Cash"].ToString());
                parking.Credit = int.Parse(item["Credit"].ToString());
                parking.Discount = int.Parse(item["Discount"].ToString());*/
                parkings.Add(parking);
            }
            OraConn.Close();
        }
        public static void selectQuery_p(string MM)
        {
            ConnectDB();

            string sql;
            sql = "select * from " + TABLE1 + " where time like "+$"'{MM}"+"%'";

            OracleDataAdapter oda = new OracleDataAdapter();
            oda.SelectCommand = new OracleCommand();
            oda.SelectCommand.Connection = OraConn;
            oda.SelectCommand.CommandText = sql;

            DataSet ds = new DataSet();
            oda.Fill(ds, TABLE1);

            parkings.Clear();

            foreach (DataRow item in ds.Tables[0].Rows)
            {
                Parking parking = new Parking();
                parking.CarName = item["carname"].ToString();
                parking.Time = item["time"].ToString();
                parking.Status = item["status"].ToString();
                parking.ParkingNum = item["parkingnum"].ToString();
                /*parking.Cash = int.Parse(item["Cash"].ToString());
                parking.Credit = int.Parse(item["Credit"].ToString());
                parking.Discount = int.Parse(item["Discount"].ToString());*/
                parkings.Add(parking);
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
                    query = $"delete from {TABLE} where menu = '{menus}' and tablenum = {tablenum} and quantity = {quantity}";
                    break;
                default:

                    break;
            }
            return query;
        }

        static string Query_p(string menu, string carname, string time, string status, string parkingnum)
        {
            string query = "";
            switch (menu)
            {
                case "insert":
                    query = $"insert into {TABLE1} values('{carname}','{time}','{status}','{parkingnum}')";
                    break;
                case "update":
                    query = $"update {TABLE1} set time = '{time}', status = '{status}' where carname = '{carname}'";
                    break;
                case "delete":
                    query = $"delete from {TABLE1} where carname = '{carname}'";
                    break;
                default:

                    break;
            }
            return query;
        }

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
            catch (Exception ex) 
            {
                OraConn.Close(); 
                throw new Exception(query + "_" + ex.Message + "오류위치" + Environment.NewLine + ex.StackTrace);
            }

            OraConn.Close();

            selectQuery();
        }
        public static void executeQuery_p(string menu, string carname, string time, string status, string parkingnum)
        {
            ConnectDB();
            string query = "";
            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = OraConn;
                query = Query_p(menu, carname, time, status, parkingnum);
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                OraConn.Close();
                throw new Exception(query + "_" + ex.Message + "오류위치" + Environment.NewLine + ex.StackTrace);
            }

            OraConn.Close();

            selectQuery_p();
        }
    }
}
