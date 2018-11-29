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
    public partial class Xe : UserControl
    {
        private String maLoaiXe;
        private String bienSoXe;
        public Xe()
        {
            InitializeComponent();
            LoadData();
            btnXoa.Visible = false;
        }

        private void LoadData()
        {
            dgvData.DataSource = DAO.XeDAO.Instance.LoadDataXe();
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FormThemXe frm = new FormThemXe();
            frm.Show();
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int t = e.RowIndex;
            if (t >= 0 && t < dgvData.Rows.Count - 1) {
                maLoaiXe = dgvData.Rows[t].Cells["MaLoaiXe1"].Value.ToString();
                bienSoXe = dgvData.Rows[t].Cells["BienSoXe1"].Value.ToString();
                btnXoa.Visible = true;
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadData();
            maLoaiXe = "";
            bienSoXe = "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DAO.XeDAO.Instance.Xoa(bienSoXe);
            LoadData();
        }

        private void Xe_Load(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvData.DataSource = DAO.XeDAO.Instance.Timkiem(txtTimKiem.Text);
        }



    }
}
