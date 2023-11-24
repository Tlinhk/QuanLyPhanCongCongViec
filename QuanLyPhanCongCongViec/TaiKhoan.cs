using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhanCongCongViec
{
    public class TaiKhoan
    {
        private string tentaikhoan;
        private string matkhau;

        public string Matkhau { get => matkhau; set => matkhau = value; }

        public TaiKhoan(string tentaikhoan, string matkhau)
        {
            this.tentaikhoan = tentaikhoan;
            this.matkhau = matkhau;
        }

        public TaiKhoan()
        {
        }
    }
}
