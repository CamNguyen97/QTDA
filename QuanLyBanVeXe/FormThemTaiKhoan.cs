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
    public partial class FormThemTaiKhoan : Form
    {
        public FormThemTaiKhoan()
        {
            InitializeComponent();
            LoadCbb();
            txtMaNhanVien.Text = "";
        }

        public void LoadCbb() {
            cbbMaNhanVien.DataSource = DAO.NhanVienDAO.Instance.LoadNhanVien();
            cbbMaNhanVien.ValueMember = "MaNhanVien";
            cbbMaNhanVien.DisplayMember = "TenNhanVien";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int IsAd = 0;
            if (cb1.Checked) {
                IsAd = 1;
            }
            if (cb2.Checked) {
                IsAd = 0;
            }
            if (DAO.TaiKhoanDAO.Instance.KiemTra(int.Parse(cbbMaNhanVien.SelectedValue.ToString())).Rows.Count == 0 && DAO.TaiKhoanDAO.Instance.KiemTra1(txtTaiKhoan.Text).Rows.Count == 0)
            {
                DAO.TaiKhoanDAO.Instance.ThemTaiKhoan(txtTaiKhoan.Text, txtMatKhau.Text, int.Parse(cbbMaNhanVien.SelectedValue.ToString()), IsAd);
                MessageBox.Show("Thêm Thành Công");
                this.Close();
            }
            if (DAO.TaiKhoanDAO.Instance.KiemTra(int.Parse(cbbMaNhanVien.SelectedValue.ToString())).Rows.Count != 0)
            {
                MessageBox.Show("Nhân Viên Đã Có Tài Khoản");
            }
            if (DAO.TaiKhoanDAO.Instance.KiemTra1(txtTaiKhoan.Text).Rows.Count != 0)
            {
                MessageBox.Show("Tên Tài Khoản Bị Trùng");
            }
        }

        private void cb1_OnChange(object sender, EventArgs e)
        {
            if (cb1.Checked == true)
            {
                cb2.Visible = false;
            }
            else
                cb2.Visible = true;
        }

        private void cb2_OnChange(object sender, EventArgs e)
        {
            if (cb2.Checked == true)
            {
                cb1.Visible = false;
            }
            else
                cb1.Visible = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaNhanVien.Text = cbbMaNhanVien.SelectedValue.ToString();
        }
    }
}
