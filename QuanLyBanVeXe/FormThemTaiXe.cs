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
    public partial class FormThemTaiXe : Form
    {
        public FormThemTaiXe()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!DAO.TaiXeDAO.Instance.KiemTra(int.Parse(txtCmt.Text)))
            {
                int cmt = int.Parse(txtCmt.Text);
                String ten = txtHoTen.Text;
                String sdt = txtSDT.Text;
                String diachi = txtDiaChi.Text;
                DAO.TaiXeDAO.Instance.ThemTaiXe(cmt, ten, sdt, diachi);
                this.Close();
            }
            else
                MessageBox.Show("Số cmt bị trùng");
        }
    }
}
