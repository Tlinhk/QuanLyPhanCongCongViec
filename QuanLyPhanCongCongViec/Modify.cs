using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QuanLyPhanCongCongViec
{
    public class Modify
    {
        public Modify()
        {
        }
        SqlCommand _command;
        SqlDataReader _reader;
        public List<TaiKhoan> TaiKhoan(string query)
        {
            List<TaiKhoan> taikhoan = new List<TaiKhoan>();
            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                conn.Open();
                _command = new SqlCommand(query, conn);
                _reader = _command.ExecuteReader();
                while (_reader.Read())
                {
                    taikhoan.Add(new TaiKhoan(_reader.GetString(0), _reader.GetString(1)));
                }
                conn.Close();
            }
            return taikhoan;
        }
    }
}
