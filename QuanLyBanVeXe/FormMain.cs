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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            us_TaiKhoan.Visible = false;
            us_Xe.Visible = false;
            us_khachHang.Visible = false;
            us_NhanVien.Visible = false;
            us_taiXe.Visible = false;
            us_VeBan.Visible = false;
            us_ThongKe.Visible = false;
            us_LichTrinh.Visible = true;
        }

        private void txtTime_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
          
        }

        private void userControl11_Load_1(object sender, EventArgs e)
        {

        }

        private void userControl11_Load_2(object sender, EventArgs e)
        {

        }

        private void btnTaiKhoan_Click_1(object sender, EventArgs e)
        {
            us_Xe.Visible = false;
            us_LichTrinh.Visible = false;
            us_VeBan.Visible = false;
            us_khachHang.Visible = false;
            us_taiXe.Visible = false;
            us_NhanVien.Visible = false;
            us_ThongKe.Visible = false;
            us_TaiKhoan.Visible = true;
        }

        private void btnXe_Click(object sender, EventArgs e)
        {
            us_TaiKhoan.Visible = false;
            us_LichTrinh.Visible = false;
            us_VeBan.Visible = false;
            us_khachHang.Visible = false;
            us_taiXe.Visible = false;
            us_NhanVien.Visible = false;
            us_ThongKe.Visible = false;
            us_Xe.Visible = true;
        }

        private void xe1_Load(object sender, EventArgs e)
        {

        }

        private void btnVe_Click(object sender, EventArgs e)
        {
            us_TaiKhoan.Visible = false;
            us_LichTrinh.Visible = false;
            us_Xe.Visible = false;
            us_khachHang.Visible = false;
            us_taiXe.Visible = false;
            us_ThongKe.Visible = false;
            us_NhanVien.Visible = false;
            us_VeBan.Visible = true;
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            us_TaiKhoan.Visible = false;
            us_LichTrinh.Visible = false;
            us_Xe.Visible = false;
            us_VeBan.Visible = false;
            us_taiXe.Visible = false;
            us_ThongKe.Visible = false;
            us_NhanVien.Visible = false;
            us_khachHang.Visible = true;
        }

        private void btnTaiXe_Click(object sender, EventArgs e)
        {
            us_TaiKhoan.Visible = false;
            us_LichTrinh.Visible = false;
            us_Xe.Visible = false;
            us_VeBan.Visible = false;
            us_khachHang.Visible = false;
            us_ThongKe.Visible = false;
            us_NhanVien.Visible = false;
            us_taiXe.Visible = true;
        }

        private void us_taiXe_Load(object sender, EventArgs e)
        {

        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            us_TaiKhoan.Visible = false;
            us_LichTrinh.Visible = false;
            us_Xe.Visible = false;
            us_VeBan.Visible = false;
            us_khachHang.Visible = false;
            us_taiXe.Visible = false;
            us_NhanVien.Visible = false;
            us_ThongKe.Visible = true;
        }

        private void nhanVien1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuTileButton4_Click(object sender, EventArgs e)
        {
            us_TaiKhoan.Visible = false;
            us_LichTrinh.Visible = false;
            us_Xe.Visible = false;
            us_VeBan.Visible = false;
            us_khachHang.Visible = false;
            us_taiXe.Visible = false;
            us_ThongKe.Visible = false;
            us_NhanVien.Visible = true;
        }

		private void btnLogout_Click(object sender, EventArgs e)
		{
			Form1 frm = new Form1();
			this.Visible = false;
			frm.ShowDialog();
		}
	}
}
