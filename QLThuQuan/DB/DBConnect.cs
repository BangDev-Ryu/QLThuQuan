using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace QLThuQuan.DB
{
    public class DBConnect
    {
        private static readonly string connectionString = "Server=localhost;Database=thuquan;Uid=root;Pwd=Long@2004;";

        public static MySqlConnection GetConnection()
        {
            var conn = new MySqlConnection(connectionString);
            conn.Open();
            return conn;
        }

        public static DataTable ExecuteQuery(string query, params MySqlParameter[] parameters)
        {
            var conn = GetConnection();
            var cmd = new MySqlCommand(query, conn);
            if (parameters != null) cmd.Parameters.AddRange(parameters);
            var adapter = new MySqlDataAdapter(cmd);
            var dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public static int ExecuteNonQuery(string query, params MySqlParameter[] parameters)
        {
            var conn = GetConnection();
            var cmd = new MySqlCommand(query, conn);
            if (parameters != null) cmd.Parameters.AddRange(parameters);
            return cmd.ExecuteNonQuery();
        }

        public static object ExecuteScalar(string query, params MySqlParameter[] parameters)
        {
            var conn = GetConnection();
            var cmd = new MySqlCommand(query, conn);
            if (parameters != null) cmd.Parameters.AddRange(parameters);
            return cmd.ExecuteScalar();
        }

        public static bool TestConnection()
        {
            try
            {
                var conn = GetConnection();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
