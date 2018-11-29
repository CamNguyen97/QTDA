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
    public partial class Form1 : Form
    {
        public static int manv;
        public static int isAd;

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = DAO.LoginDAO.Instance.Login(txtTaiKhoan.Text, txtMatKhau.Text);
            if (dt.Rows.Count > 0)
            {
                if (DAO.TaiKhoanDAO.Instance.checkIsAd(txtTaiKhoan.Text , txtMatKhau.Text))
                {
                    isAd = 1;
                    manv = DAO.TaiKhoanDAO.Instance.getMNV(txtTaiKhoan.Text, txtMatKhau.Text);
                    FormMain frm = new FormMain();
                    frm.ShowDialog();
                    this.Close();
                }
                else
                {
                    isAd = 0;
                    manv = DAO.TaiKhoanDAO.Instance.getMNV(txtTaiKhoan.Text, txtMatKhau.Text);
                    FormNhanVien frm = new FormNhanVien();
                    frm.ShowDialog();
                    this.Close();
                    
                }
            }
            else
                MessageBox.Show("Sai mật khẩu");
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void txtMatKhau_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtMatKhau_OnValueChanged_1(object sender, EventArgs e)
        {

        }
    }
}
