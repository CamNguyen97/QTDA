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
    public partial class VeBan : UserControl
    {
        public int mave;
        public int giave;
        public int machuyendi;
        public int diemxp;
        public int diemkt;
        public String BienSoXe;
        public int makh;
        string ngayban;

        public VeBan()
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
            dgvData.DataSource = DAO.VeBanDAO.Instance.LoadData();
            btnSua.Visible = false;
            btnXoa.Visible = false;
            dgvData1.Visible = false;
            btnThem1.Visible = false;
        }

        public void LoadData1() {
            dgvData1.DataSource = DAO.VeBanDAO.Instance.LoadData1();
            btnSua.Visible = false;
            btnXoa.Visible = false;
            dgvData.Visible = false;
            btnThem.Visible = false;
        }

        private void VeBan_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FormThemVe frm = new FormThemVe();
            frm.ShowDialog();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            if (Form1.isAd == 1)
            {
                LoadData();
            }
            else
                LoadData1();
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int t = e.RowIndex;
            if (t >= 0 && t < dgvData.Rows.Count -1) {
                mave = int.Parse(dgvData.Rows[t].Cells["MaVe1"].Value.ToString());
                giave = int.Parse(dgvData.Rows[t].Cells["GiaVe1"].Value.ToString());
                machuyendi = int.Parse(dgvData.Rows[t].Cells["MaChuyenDi1"].Value.ToString());
                btnXoa.Visible = true;
                btnSua.Visible = true;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (Form1.isAd == 1)
            {
                FormSuaVe frm = new FormSuaVe();
                frm.LoadData(mave, giave, machuyendi);
                frm.ShowDialog();
            }
            else
            {
                FormSuaVeBan frm1 = new FormSuaVeBan();
                frm1.LoadDataSua(diemxp, diemkt, BienSoXe, makh,ngayban);
                frm1.ShowDialog();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
                DAO.VeBanDAO.Instance.XoaVe(mave);
                LoadData();
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvData1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int t = e.RowIndex;
            if (t >= 0 && t < dgvData1.Rows.Count - 1)
            {
                mave = int.Parse(dgvData1.Rows[t].Cells["MaVe12"].Value.ToString());
                diemxp = int.Parse(dgvData1.Rows[t].Cells["MaDiaDiem"].Value.ToString());
                diemkt = int.Parse(dgvData1.Rows[t].Cells["MaDiaDiem1"].Value.ToString());
                BienSoXe = dgvData1.Rows[t].Cells["BienSoXe1"].Value.ToString();
                makh = int.Parse(dgvData1.Rows[t].Cells["MaKhachHang"].Value.ToString());
                ngayban = dgvData1.Rows[t].Cells["NgayBan"].Value.ToString();
                btnSua.Visible = true;
                btnXoa.Visible = false;
            }
        }

        private void btnThem1_Click(object sender, EventArgs e)
        {
            FormThemVeBan frm = new FormThemVeBan();
            frm.ShowDialog();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
           dgvData.DataSource =  DAO.VeBanDAO.Instance.TimVe(int.Parse(txtTimKiem.Text));
        }
    }
}
