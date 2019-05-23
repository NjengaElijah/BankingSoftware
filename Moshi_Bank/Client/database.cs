using System;
using System.Collections.Generic;

using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
namespace Moshi_Bank.Client
{
    class database
    {
        private static string ip = "localhost";
        private static string port = "3306";
        private static string un = "root";
        private static string pssd = "";
        private static string db = "moshi_bank";

        public database(string Host, string Port, string User, string Password)
        {
            ip = Host;
            port = Port;
            un = User;
            pssd = Password;

        }
        public static string IP
        {
            get
            {
                return ip;
            }
            set
            {
                ip = value;
            }
        }
        public static string PORT
        {
            get
            {
                return port;
            }
            set
            {
                port = value;
            }
        }
        public static string USERNAME
        {
            get
            {
                return un;
            }
            set
            {
                un = value;
            }
        }
        public static string PASSWORD
        {
            get
            {
                return pssd;
            }
            set
            {
                pssd = value;
            }
        }
        public static string DB
        {
            get
            {
                return db;
            }
            set
            {
                db = value;
            }
        }
        private static MySqlConnection con;

        public static MySqlConnection connection
        {
            get
            {
                checkConn();
                return con;
            }
        }
        public static void OpenConnection()
        {
            con = new MySqlConnection("datasource=" + database.IP + ";port=" + database.PORT + ";database=" + DB + ";username=" + database.USERNAME + ";password=" + database.PASSWORD);
            try
            {
                ClearPools(); con.Open();
            }
            catch
            {
                throw;
            }
        }
        private static void checkConn()
        {
            if (database.con.State == ConnectionState.Closed)
            {
                database.OpenConnection();
            }
        }
        public static void ClearPools()
        {
            con.Close();
            con.ClearAllPoolsAsync();
            con.CloseAsync();
        }
        public static void CloseConnection()
        {
            con.Close();
        }
        public static void execute(string querry)
        { 
            MySqlCommand cmd = new MySqlCommand();

            cmd.Connection = database.connection;
            cmd.CommandText = querry;
            cmd.ExecuteNonQuery();
        }
        public static MySqlDataReader executeQuerry(string querry)
        {
            //if (database.connection.State == ConnectionState.Closed)
            //{
            //    database.OpenConnection();
            //}
            MySqlDataReader read = null;
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = database.connection;
            cmd.CommandText = querry;
            read = cmd.ExecuteReader();
            return read;
        }
        public static void NewExecute(string querry, List<String> parameter, List<Object> value)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = database.connection;
            cmd.CommandText = querry;
            if (parameter != null || value != null)
            {
                for (int x = 0; x < parameter.Count; x++)
                {
                    cmd.Parameters.AddWithValue(parameter[x], value[x]);
                }
            }
            cmd.ExecuteNonQuery();
        }
        public static MySqlDataReader NewExecuteQuerry(string querry, List<String> parameter, List<Object> value)
        {
            MySqlDataReader read = null;
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = database.connection;
            cmd.CommandText = querry; if (parameter != null || value != null)
            {
                for (int x = 0; x < parameter.Count; x++)
                {
                    cmd.Parameters.AddWithValue(parameter[x], value[x]);
                }
            }
            read = cmd.ExecuteReader();
            return read;
        }
        public static BindingSource SelectForDataGridView(string querry, List<String> parameter, List<Object> value)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = database.connection;
            cmd.CommandText = querry;
            if (parameter != null || value != null)
            {
                for (int x = 0; x < parameter.Count; x++)
                {
                    cmd.Parameters.AddWithValue(parameter[x], value[x]);
                }
            }
            BindingSource bs = new BindingSource();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            bs.DataSource = dt;

            return bs;

        }
    }
}
