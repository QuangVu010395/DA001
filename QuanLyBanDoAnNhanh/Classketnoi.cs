using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace QuanLyBanDoAnNhanh
{
    class Classketnoi
    {
        SqlConnection conn;
        string loi = "";
        public SqlConnection ketnoi()
        {
            conn = new SqlConnection();
            conn.ConnectionString = "server=LAPTOP-QOATVA32\\SQLEXPRESS;user=vu123;password=123456;database=QuanLy";
            loi = "";
            try
            {
                conn.Open();
            }
            catch (SqlException ex)
            {
                loi = "SERVER FAIL";
            }
            return conn;
        }
        public string getloi()
        {
            return loi;
        }
    }
}
