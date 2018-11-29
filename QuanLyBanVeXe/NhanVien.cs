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
    public partial class NhanVien : UserControl
    {
        int manv;

        public NhanVien()
        {
            InitializeComponent();
            LoadData();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {

        }

        public void LoadData() {
            dgvData.DataSource = DAO.NhanVienDAO.Instance.LoadNhanVien();
            btnXoa.Visible = false;
         
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int t = e.RowIndex;
            if (t >= 0 && t < dgvData.Rows.Count - 1) {
                manv = int.Parse(dgvData.Rows[t].Cells["MaNhanVien"].Value.ToString());
                btnXoa.Visible = true;
            }
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (DAO.NhanVienDAO.Instance.KiemTra(manv) == false)
            {
                DAO.NhanVienDAO.Instance.XoaNhanVien(manv);
            }
            else
                MessageBox.Show("Nhân Viên Đang Có Thông Tin Hoạt Động");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FormThemNhanVien frm = new FormThemNhanVien();
            frm.ShowDialog();
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            FormThemNhanVien frm = new FormThemNhanVien();
            frm.Show();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvData.DataSource = DAO.NhanVienDAO.Instance.TimNhanVien(txtTimKiem.Text);
        }

    }
}
