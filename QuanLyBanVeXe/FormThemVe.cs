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
    public partial class FormThemVe : Form
    {
        public FormThemVe()
        {
            InitializeComponent();
            LoadData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoadData() {
            cbbMaChuyenDi.DataSource = DAO.LichTrinhDAO.Instance.LoadData();
            cbbMaChuyenDi.ValueMember = "MaChuyenDi";
            cbbMaChuyenDi.DisplayMember = "MaChuyenDi";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!DAO.VeBanDAO.Instance.KiemTraVe(int.Parse(cbbMaChuyenDi.SelectedValue.ToString())))
            {
                DAO.VeBanDAO.Instance.ThemVeBan(int.Parse(txtGiaVe.Text),Convert.ToInt32(cbbMaChuyenDi.SelectedValue.ToString()));
                this.Close();
            }
            else
                MessageBox.Show("Mã Chuyến Đi Đã Có Vé");
        }


        private void FormThemVe_Load(object sender, EventArgs e)
        {

        }
    }
}
