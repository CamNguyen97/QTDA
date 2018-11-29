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
    public partial class us_LichTrinh : UserControl
    {
        int machuyendi = 0;
        int cmt = 0;
        String bienSoXe = "";
        int madiemxp = 0;
        int madiemkt = 0;
        DateTime time;
        public us_LichTrinh()
        {
            InitializeComponent();
            LoadData();
            btnSua.Visible = false;
            btnXoa.Visible = false;
        }

        private void LoadData()
        {
            dgvData.DataSource = DAO.LichTrinhDAO.Instance.LoadData();
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            FormThemLichTrinh frm = new FormThemLichTrinh();
            frm.Show();
        }

        private void us_LichTrinh_Load(object sender, EventArgs e)
        {

        }

        public void visibleItem() {
            btnThem.Visible = false;
            btnXoa.Visible = false;
            btnSua.Visible = false;
        }

        private void btnLamMoi_Click_1(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            dgvData.DataSource = DAO.LichTrinhDAO.Instance.TimKiem(txtTimKiem.Text);
        }

        private void dgvData_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int t = e.RowIndex;
            if(t >= 0 && t < dgvData.Rows.Count - 1)
            {
                machuyendi = int.Parse(dgvData.Rows[t].Cells["MaChuyenDi1"].Value.ToString());
                cmt = int.Parse(dgvData.Rows[t].Cells["CmtTaiXe"].Value.ToString());
                bienSoXe = dgvData.Rows[t].Cells["BienSoXe1"].Value.ToString();
                madiemxp = int.Parse(dgvData.Rows[t].Cells["MaDiemXP1"].Value.ToString());
                madiemkt = int.Parse(dgvData.Rows[t].Cells["MaDiemKT1"].Value.ToString());
                time = Convert.ToDateTime(dgvData.Rows[t].Cells["ThoiGianKhoiHanh"].Value.ToString());
                if (Form1.isAd == 1)
                {
                    btnXoa.Visible = true;
                    btnSua.Visible = true;
                }
                MessageBox.Show(machuyendi.ToString());
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            int mave = DAO.VeBanDAO.Instance.getMaVe(madiemxp, madiemkt, bienSoXe);
            DAO.VeBanDAO.Instance.XoaVe(mave);
            DAO.LichTrinhDAO.Instance.XoaLichTrinh(machuyendi);
            LoadData();
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            FormSuaLichTrinh frm = new FormSuaLichTrinh();
            frm.LoadData(machuyendi ,time , time , cmt, bienSoXe, madiemxp, madiemkt);
            frm.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            for (int i = 0; i < dgvData.Rows.Count-1; i++)
            {
                DAO.LichTrinhDAO.Instance.updatetime(int.Parse(dgvData.Rows[i].Cells["MaChuyenDi1"].Value.ToString()),dgvData.Rows[i].Cells["ThoiGianKhoiHanh"].Value.ToString());
            }
        }
    }
}
