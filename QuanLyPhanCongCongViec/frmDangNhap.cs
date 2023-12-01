using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QuanLyPhanCongCongViec
{
    public partial class frmDangNhap : Form
    {
        private const string ConnectionString = "Data Source= DESKTOP-2E91IF7 ;Initial Catalog=QuanLyCongViec;Integrated Security=True";
        private SqlConnection connection;
        public frmDangNhap()
        {
            InitializeComponent();
        }

        //create a string MD5
        public static string GetMD5(string str)
        {
            using (MD5 md5 = new MD5CryptoServiceProvider())
            {
                byte[] fromData = Encoding.UTF8.GetBytes(str);
                byte[] targetData = md5.ComputeHash(fromData);

                StringBuilder builder = new StringBuilder();

                for (int i = 0; i < targetData.Length; i++)
                {
                    builder.Append(targetData[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        Modify modify = new Modify();
        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tentk = txt_tenDN.Text;
            string matkhau = GetMD5(txt_MK.Text);
            if (tentk.Trim() == "") { MessageBox.Show("Vui long nhap ten tai khoan", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else if (matkhau.Trim() == "") { MessageBox.Show("vui long nhap mat khau", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else
            {
                string query = "Select * from TAIKHOAN where TenDangNhap = '" + tentk + "' and MatKhau = '" + matkhau + "'";
                if (modify.TaiKhoan(query).Count > 0)
                {
                    MessageBox.Show("dang nhap thanh cong", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string name;

                    using (SqlConnection connection = new SqlConnection(ConnectionString))
                    {
                        connection.Open();
                        string maquyen;
                        string query_name;
                        string quere_quyen = "select TAIKHOAN.MaQuyen from TAIKHOAN WHERE TAIKHOAN.TenDangNhap = '" + tentk + "' and TAIKHOAN.MatKhau = '" + matkhau + "'";
                        using (SqlCommand command = new SqlCommand(quere_quyen, connection))
                        {
                            maquyen = (string)command.ExecuteScalar();
                        }
                        if (maquyen == "Q03")
                        {
                            query_name = "select HOCVIEN.TenHocVien from HOCVIEN JOIN TAIKHOAN on HOCVIEN.MaTK = TAIKHOAN.MaTK Where TAIKHOAN.TenDangNhap = '" + tentk + "' and TAIKHOAN.MatKhau = '" + matkhau + "'";
                        }
                        else
                        {
                            query_name = "select CANBO.TenCanBo from CANBO JOIN TAIKHOAN on CANBO.MaTK = TAIKHOAN.MaTK Where TAIKHOAN.TenDangNhap = '" + tentk + "' and TAIKHOAN.MatKhau = '" + matkhau + "'";
                        }

                        using (SqlCommand command = new SqlCommand(query_name, connection))
                        {
                            name = (string)command.ExecuteScalar();
                        }
                    }
                    frmMain f = new frmMain(name);
                    this.Hide();
                    f.ShowDialog();
                }
                else
                {
                    MessageBox.Show("ten tai khoan hoac mat khau khong chinh xac", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

