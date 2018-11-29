using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanVeXe.DAO

{

    class DataProvider
    {
        private static DataProvider instance;

        public static DataProvider Instance
        {
            get { 
                if(instance == null)
                    instance = new DataProvider();
                return DataProvider.instance; }
            set { DataProvider.instance = value; }
        }

        public DataProvider()
        {
        }
        public SqlConnection conn = null;
        public void openConn()
        {
            if (conn == null)
            {
                conn = new SqlConnection(Properties.Settings.Default.Str);
            }
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public DataTable ExecuteQuery(String sql)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.Str))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(sql, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);
            }
            return data;
        }

        public int ExecuteNonQuery(String sql)
        {
            openConn();
            int data = 0;
            SqlCommand command = new SqlCommand(sql, conn);
            data = command.ExecuteNonQuery();
            conn.Close();
            return data;
        }

        public object ExecuteScalar(String sql)
        {
            openConn();
            object data = null;
            SqlCommand command = new SqlCommand(sql, conn);
            data = command.ExecuteScalar();
            conn.Close();
            return data;
        }
    }
}
