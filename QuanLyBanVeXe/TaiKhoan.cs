using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanVeXe
{
    public partial class TaiKhoan : UserControl
    {
        String taiKhoan = "";
        String MatKhau = "";
        int MaNV = 0;

        public TaiKhoan()
        {
            InitializeComponent();
            LoadData();
            btnSua.Visible = false;
            btnXoa.Visible = false;
        }
        
        private void LoadData()
        {
            dgvData.DataSource = DAO.TaiKhoanDAO.Instance.LoadDataTaiKhoan();
        }

        private void TaiKhoan_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FormThemTaiKhoan frm = new FormThemTaiKhoan();
            frm.Show();
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int t = e.RowIndex;
            if (t >= 0 && t < dgvData.Rows.Count - 1) {
                taiKhoan = dgvData.Rows[t].Cells["IDTaiKhoan"].Value.ToString();
                MatKhau = dgvData.Rows[t].Cells["PASS"].Value.ToString();
                MaNV = int.Parse(dgvData.Rows[t].Cells["MaNhanVien"].Value.ToString());
                btnSua.Visible = true;
                btnXoa.Visible = true;
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadData();
            taiKhoan = "";
            MatKhau = "";
            MaNV = 0;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            FormSuaTaiKhoan frm = new FormSuaTaiKhoan();
            frm.Show();
            frm.LoadData(taiKhoan, MatKhau, MaNV);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DAO.TaiKhoanDAO.Instance.XoaTaiKhoan(MaNV);
            LoadData();
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvData.DataSource = DAO.TaiKhoanDAO.Instance.TimKiem(txtTimKiem.Text);
        }


        
    }
}
