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
    public partial class FormThemDiaDiem : Form
    {
        public FormThemDiaDiem()
        {
            InitializeComponent();
        }

        private void FormThemDiaDiem_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            DAO.DiaDiemDAO.Instance.ThemDiaDiem(txtTenDiaDiem.Text);
            DAO.DiaDiemDAO.Instance.ThemDiaDiemKT(txtTenDiaDiem.Text);
            this.Close();
        }
    }
}
