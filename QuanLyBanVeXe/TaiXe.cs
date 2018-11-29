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
    public partial class TaiXe : UserControl
    {
        private int cmt;
        public TaiXe()
        {
            InitializeComponent();
            LoadData();
            btnXoa.Visible = false;
        }

        public void LoadData() {
            dgvData.DataSource = DAO.TaiXeDAO.Instance.LoadData();
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FormThemTaiXe frm = new FormThemTaiXe();
            frm.ShowDialog();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int t = e.RowIndex;
            if(t>= 0 && t< dgvData.Rows.Count - 1){
                cmt = int.Parse(dgvData.Rows[t].Cells["cmtTaiXe"].Value.ToString());
            }
            btnXoa.Visible = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DAO.TaiXeDAO.Instance.XoaTaiXe(cmt);
            LoadData();
            btnXoa.Visible = false;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvData.DataSource = DAO.TaiXeDAO.Instance.TimKiem(txtTimKiem.Text);
        }
    }
}
