using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoCaoCuoiKy
{
    internal class DataProvider
    {
        public static string connection_string = @"Data Source=DESKTOP-JTO2V7H;Initial Catalog=qlSanBay;Integrated Security=True";
        public static SqlConnection conn = new SqlConnection(connection_string);
        public static SqlCommand cmd;
        public static SqlDataAdapter adp;
        public void OpenConnection()
        {
            try
            {
                conn.Open();
            }catch (Exception ex)
            {
                MessageBox.Show("Da co loi xay ra: " + ex.Message);
            }
        }

        public void CloseConnection()
        {
            if(conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Close();
            }
        }

        public void executeNonQuery(String query) 
        {
            OpenConnection();
            cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }

        public DataTable executeQuery(String query)
        {
            OpenConnection();
            adp = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }

        public object executeScalar(String query)
        {
            OpenConnection();
            cmd = new SqlCommand(query, conn);
            return cmd.ExecuteScalar();
            CloseConnection();
        }
    }
}
