using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataProvider
    {
        // Kết nối
        public static SqlConnection Connect()
        {
            string ConnectionString = @"Data Source=TUANIT;Initial Catalog=QuanLyHocSinh;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            return con;
        }
        // Đóng kết nối
        public static void CloseConnect(SqlConnection con) { con.Close(); }
        //// Tạo chuỗi kết nối
        //private string ConnectionString = @"Data Source=DESKTOP-RIMVVK5;Initial Catalog=QuanLySinhVien;Integrated Security=True";

        //Lấy DataTable
        public static DataTable LayDataTable(string sQuery, SqlConnection con)
        {
            SqlDataAdapter da = new SqlDataAdapter(sQuery, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        // Thực thi truy vấn ExecuteNonQuery
        public static bool ExecuteQueriesNonQuery(string sQuery, SqlConnection con)
        {
            try
            {
                SqlCommand com = new SqlCommand(sQuery, con);
                com.ExecuteNonQuery();
                return true;
            }
            catch (Exception e) { return false; }
        }
        // Thực thi truy vấn ExecuteQuery
        //public DataTable ExecuteQuery(string query, object[] parameter = null)
        //{
        //    DataTable data = new DataTable();
        //    using (SqlConnection con = new SqlConnection(ConnectionString))
        //    {
        //        con.Open();
        //        SqlCommand command = new SqlCommand(query, con);
        //        if (parameter != null)
        //        {
        //            string[] listPara = query.Split(' ');
        //            int i = 0;
        //            foreach (string item in listPara)
        //            {
        //                if (item.Contains('@'))
        //                {
        //                    command.Parameters.AddWithValue(item, parameter[i]);
        //                    i++;
        //                }
        //            }
        //        }
        //        SqlDataAdapter adapter = new SqlDataAdapter(command);
        //        adapter.Fill(data);
        //        con.Close();
        //    }
        //    return data;
        //}

        // Thực thi truy vấn ExecuteNonQuery
        //public int ExecuteNonQuery(string query, object[] parameter = null)
        //{
        //    int data = 0;
        //    using (SqlConnection connection = new SqlConnection(connectionSTR))
        //    {
        //        connection.Open();
        //        SqlCommand command = new SqlCommand(query, connection);
        //        if (parameter != null)
        //        {
        //            string[] listPara = query.Split(' ');
        //            int i = 0;
        //            foreach (string item in listPara)
        //            {
        //                if (item.Contains('@'))
        //                {
        //                    command.Parameters.AddWithValue(item, parameter[i]);
        //                    i++;
        //                }
        //            }
        //        }
        //        data = command.ExecuteNonQuery();
        //        connection.Close();
        //    }
        //    return data;
        //}

        // Thực thi truy vấn ExecuteScalar
        //public object ExecuteScalar(string query, object[] parameter = null)
        //{
        //    object data = 0;
        //    using (SqlConnection connection = new SqlConnection(connectionSTR))
        //    {
        //        connection.Open();
        //        SqlCommand command = new SqlCommand(query, connection);
        //        if (parameter != null)
        //        {
        //            string[] listPara = query.Split(' ');
        //            int i = 0;
        //            foreach (string item in listPara)
        //            {
        //                if (item.Contains('@'))
        //                {
        //                    command.Parameters.AddWithValue(item, parameter[i]);
        //                    i++;
        //                }
        //            }
        //        }
        //        data = command.ExecuteScalar();
        //        connection.Close();
        //    }
        //    return data;
        //}

    }
}
