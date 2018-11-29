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
    public partial class FormSuaTaiKhoan : Form
    {
        public FormSuaTaiKhoan()
        {
            InitializeComponent();
        }

        public void LoadData(String id, String pass, int mnv) {
            txtTaiKhoan.Text = id;
            txtMatKhau.Text = pass;
            txtMaNhanVien.Text = mnv.ToString();
            if (DAO.TaiKhoanDAO.Instance.checkIsAd(id, pass))
            {
                cb1.Checked = true;
            }
            else
                cb2.Checked = true;
        }

        private void FormSuaTaiKhoan_Load(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int num = 0;
            if (cb1.Checked)
            { 
                num = 1; 
            }
            if (cb2.Checked)
            {
                num = 0;
            }
            DAO.TaiKhoanDAO.Instance.SuaTaiKhoan(txtTaiKhoan.Text, txtMatKhau.Text, int.Parse(txtMaNhanVien.Text),num);
            this.Close();
        }

        private void cb1_OnChange(object sender, EventArgs e)
        {
            if (cb1.Checked)
            {
                cb2.Visible = false;
            }
            else
                cb2.Visible = true;
        }

        private void cb2_OnChange(object sender, EventArgs e)
        {
            if (cb2.Checked)
            {
                cb1.Visible = false;
            }
            else 
                cb1.Visible = true;
        }
    }
}
