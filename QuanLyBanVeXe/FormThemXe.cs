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
    public partial class FormThemXe : Form
    {
        public FormThemXe()
        {
            InitializeComponent();
            LoadDataCombobox();
        }

        public void LoadDataCombobox() {
            cbbMaLoaiXe.DataSource = DAO.XeDAO.Instance.LoadCombobox();
            cbbMaLoaiXe.ValueMember = "MaLoaiXe";
            cbbMaLoaiXe.DisplayMember = "LoaiXe";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DAO.XeDAO.Instance.KiemTra(txtBienSoXe.Text).Rows.Count > 0)
            {
                MessageBox.Show("Trùng");
            }
            else
            {
                DAO.XeDAO.Instance.Them(txtBienSoXe.Text, cbbMaLoaiXe.SelectedValue.ToString());
                this.Close();
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

    }
}
