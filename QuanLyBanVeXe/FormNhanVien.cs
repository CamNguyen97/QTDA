using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanVeXe
{
    public partial class FormNhanVien : Form
    {
        public FormNhanVien()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {

        }

        private void khachHang1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            us_KhachHang.Visible = false;
            us_VeBan.Visible = false;
            us_LichTrinh.Visible = true;
            us_LichTrinh.visibleItem();
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            us_KhachHang.Visible = false;
            us_LichTrinh.Visible = false;
            us_VeBan.Visible = true;
        }

        private void btnKhachHang_Click_1(object sender, EventArgs e)
        {
            us_LichTrinh.Visible = false;
            us_VeBan.Visible = false;
            us_KhachHang.Visible = true;
        }

		private void btnLogout_Click(object sender, EventArgs e)
		{
			Form1 frm = new Form1();
			this.Visible = false;
			frm.ShowDialog();
		}
	}
}
