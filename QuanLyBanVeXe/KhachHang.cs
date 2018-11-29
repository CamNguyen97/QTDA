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
    public partial class KhachHang : UserControl
    {
        public String makh = "";
        public String tenkh = "";
        public String sdt = "";
        public String diachi = "";
        public KhachHang()
        {
            InitializeComponent();
            if (Form1.isAd == 1)
            {
                LoadData();
            }
            else
                LoadData1();
        }

        public void LoadData() {
            dgvData.DataSource = DAO.KhachHangDAO.Instance.LoadData();
            btnSua.Visible = false;
            btnXoa.Visible = false;
            btnThem.Visible = false;
        }

        public void LoadData1()
        {
            dgvData.DataSource = DAO.KhachHangDAO.Instance.LoadData();
            btnSua.Visible = false;
            btnXoa.Visible = false;
            btnThem.Visible = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FormThemKhachHang frm = new FormThemKhachHang();
            frm.Show();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            if (Form1.isAd == 1) { LoadData(); }
            else
                LoadData1();
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int t = e.RowIndex;
            if (t > 0 && t < dgvData.Rows.Count - 1) {
                makh = dgvData.Rows[t].Cells["MaKhachHang"].Value.ToString();
                tenkh = dgvData.Rows[t].Cells["TenKhachHang"].Value.ToString();
                sdt = dgvData.Rows[t].Cells["sdt1"].Value.ToString();
                diachi = dgvData.Rows[t].Cells["diachi1"].Value.ToString();
                if (Form1.isAd == 0) {
                    btnSua.Visible = true;
                    btnXoa.Visible = true;
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DAO.KhachHangDAO.Instance.XoaKhachHang(makh);
            LoadData1();
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            FormSuaKhachHang frm = new FormSuaKhachHang(makh, tenkh, sdt, diachi);
            frm.Show();

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvData.DataSource = DAO.KhachHangDAO.Instance.TimKiem(txtTimKiem.Text);
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
