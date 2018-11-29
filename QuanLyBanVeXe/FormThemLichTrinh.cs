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
    public partial class FormThemLichTrinh : Form
    {
        public FormThemLichTrinh()
        {
            InitializeComponent();
            LoadCBB();
            LoadCBBDD();
        }

        private void txtBienSoXe_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void FormThemLichTrinh_Load(object sender, EventArgs e)
        {

        }
        
        public void LoadCBB(){
            cbbTaiXe.DataSource = DAO.TaiXeDAO.Instance.LoadData();
            cbbTaiXe.ValueMember = "cmtTaiXe";
            cbbTaiXe.DisplayMember = "ten";
            cbbXe.DataSource = DAO.XeDAO.Instance.LoadDataXe();
            cbbXe.ValueMember = "BienSoXe";
            cbbXe.DisplayMember = "LoaiXe";
        }

        public void LoadCBBDD() {
            cbbDiaDiemKhoiHanh.DataSource = DAO.DiaDiemDAO.Instance.LoadDiaDiem();
            cbbDiaDiemKhoiHanh.ValueMember = "MaDiaDiem";
            cbbDiaDiemKhoiHanh.DisplayMember = "TenDiaDiem";
            cbbDiaDiemKetThuc.DataSource = DAO.DiaDiemDAO.Instance.LoadDiaDiemKT();
            cbbDiaDiemKetThuc.ValueMember = "MaDiaDiem";
            cbbDiaDiemKetThuc.DisplayMember = "TenDiaDiem";
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            FormThemDiaDiem frm = new FormThemDiaDiem();
            frm.ShowDialog();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            FormThemDiaDiemKT frm = new FormThemDiaDiemKT();
            frm.ShowDialog();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            String time = dtpDate.Value.Year.ToString()+"-"+dtpDate.Value.Month.ToString()+"-"+dtpDate.Value.Day.ToString()+" "+dtpTime.Value.Hour.ToString()+":"+dtpTime.Value.Minute.ToString()+":0" ;
            String machuyendi = txtMaChuyenDi.Text;
            int cmt = int.Parse(cbbTaiXe.SelectedValue.ToString());
            String biensoxe = cbbXe.SelectedValue.ToString();
            String madiadiemkh = cbbDiaDiemKhoiHanh.SelectedValue.ToString();
            String madiadiemkt = cbbDiaDiemKetThuc.SelectedValue.ToString();
            if (madiadiemkh == madiadiemkt)
            {
                MessageBox.Show("Lịch Trình Bị Sai");
            }
            else
            {
                DAO.LichTrinhDAO.Instance.ThemLichTrinh(machuyendi, time, cmt, biensoxe, madiadiemkt, madiadiemkh);
                FormThemVe frm = new FormThemVe();
                frm.ShowDialog();
                this.Close();
            }
        }

        private void cbbDiaDiemKhoiHanh_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cbbDiaDiemKhoiHanh_Click(object sender, EventArgs e)
        {
            LoadCBBDD();
        }

        private void cbbDiaDiemKetThuc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbbTaiXe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbbDiaDiemKetThuc_Click(object sender, EventArgs e)
        {
            LoadCBBDD();
        }

    }
}
