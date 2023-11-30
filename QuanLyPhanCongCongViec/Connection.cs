using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhanCongCongViec
{
    public class Connection
    {
        private static string ConnectionString = "Data Source=DESKTOP-O0D76JD\\PHUONG_DB;Initial Catalog=QuanLyCongViec;Integrated Security=True";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}
