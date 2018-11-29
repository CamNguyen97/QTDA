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
    public partial class FormThemKhachHang : Form
    {
        public FormThemKhachHang()
        {
            InitializeComponent();
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!DAO.KhachHangDAO.Instance.checkMaKhachHang(txtMaKhachHang.Text))
            {
                DAO.KhachHangDAO.Instance.ThemKhachHang(txtMaKhachHang.Text, txtTenKhachHang.Text, txtSDT.Text, txtDiaChi.Text);
                this.Close();
            }
            else {
                MessageBox.Show("Trùng mã khách hàng");
            }
        }
    }
}
