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
    public partial class FormSuaKhachHang : Form
    {

        public FormSuaKhachHang(String makh, String tenkh, String sdt, String diachi)
        {
            InitializeComponent();
            this.makh = makh;
            this.tenkh = tenkh;
            this.sdt = sdt;
            this.diachi = diachi;
        }

        public String makh;
        public String tenkh;
        public String sdt;
        public String diachi;

        private void FormSuaKhachHang_Load(object sender, EventArgs e)
        {
            txtMaKhachHang.Text = makh;
            txtTenKhachHang.Text = tenkh;
            txtSDT.Text = sdt;
            txtDiaChi.Text = diachi;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DAO.KhachHangDAO.Instance.SuaKhachHang(txtMaKhachHang.Text, txtTenKhachHang.Text, txtSDT.Text, txtDiaChi.Text);
            this.Close();
        }
    }
}
