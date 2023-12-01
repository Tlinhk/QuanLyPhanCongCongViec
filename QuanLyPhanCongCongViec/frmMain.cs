using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhanCongCongViec
{
    public partial class frmMain : Form
    {
        private string user;
        public frmMain()
        {
            InitializeComponent();
        }

        public frmMain(string user)
        {
            InitializeComponent();
            this.user = user;
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();

            }

            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_child.Controls.Add(childForm);
            panel_child.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void frmMain_Load(object sender, EventArgs e)
        {
            lbl_name.Text = user;
            DateTime t = DateTime.Now;
            lbl_thoigian.Text = t.ToString("HH:mm:ss dd-MM-yyyy");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();

            }
            lbl_page.Text = "Home";
        }

        private void btn_KHCT_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQLKeHoachCT());
            lbl_page.Text = btn_KHCT.Text;
        }

        private void btn_PCCT_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQLPhanCongCT());
            lbl_page.Text = btn_PCCT.Text;
        }

        private void btn_THCT_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQLThucHienCT());
            lbl_page.Text = btn_THCT.Text;
        }

        private void btn_NKCT_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQLNhatKyCT());
            lbl_page.Text = btn_NKCT.Text;
        }

        private void btn_quantri_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQLNguoiDung());
            lbl_page.Text = btn_quantri.Text;
        }

        private void btn_dangxuat_Click(object sender, EventArgs e)
        {

        }
    }
}

