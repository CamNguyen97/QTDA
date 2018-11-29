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
    public partial class FormSuaVe : Form
    {
        int mave;
        public FormSuaVe()
        {
            InitializeComponent();
        }


        public void LoadData(int Mave ,int giave, int machuyendi) {
            mave = Mave;
            txtGiaVe.Text = giave.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DAO.VeBanDAO.Instance.SuaVe(int.Parse(txtGiaVe.Text), mave);
            this.Close();
        }

        private void FormSuaVe_Load(object sender, EventArgs e)
        {

        }
    }
}
