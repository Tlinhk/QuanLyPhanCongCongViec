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
    public partial class frmQLKeHoachCT : Form
    {
        public frmQLKeHoachCT()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {

        }

        private void txbThoigian_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_Trucban_Click(object sender, EventArgs e)
        {

        }

        private void btnThemKHCT_Click(object sender, EventArgs e)
        {
            frmThemKeHoach f = new frmThemKeHoach();
            f.Show();
        }
    }
}
