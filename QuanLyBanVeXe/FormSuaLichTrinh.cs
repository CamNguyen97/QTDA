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
    public partial class FormSuaLichTrinh : Form
    {
        public FormSuaLichTrinh()
        {
            InitializeComponent();
            LoadCBB();
            LoadCBBDD();
        }

        public void LoadCBB()
        {
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

        public void LoadData(int machuyendi, DateTime day, DateTime time, int cmtTaiXe, String bienSoXe, int madiemkh, int madiemkt)
        {
            dtpDate.Value = day;
            dtpTime.Value = time;
            cbbTaiXe.SelectedValue = cmtTaiXe.ToString();
            cbbXe.SelectedValue = bienSoXe;
            cbbDiaDiemKhoiHanh.SelectedValue = madiemkh.ToString();
            cbbDiaDiemKetThuc.SelectedValue = madiemkt.ToString();
            txtMaChuyenDi.Text = machuyendi.ToString();
        }

        private void FormSuaLichTrinh_Load(object sender, EventArgs e)
        {

        }

        private void cbbTaiXe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            String time = dtpDate.Value.Year.ToString() + "-" + dtpDate.Value.Month.ToString() + "-" + dtpDate.Value.Day.ToString() + " " + dtpTime.Value.Hour.ToString() + ":" + dtpTime.Value.Minute.ToString() +":0";
            DAO.LichTrinhDAO.Instance.SuaLichTrinh(time,int.Parse(cbbTaiXe.SelectedValue.ToString()),cbbXe.SelectedValue.ToString(),int.Parse(cbbDiaDiemKhoiHanh.SelectedValue.ToString()),int.Parse(cbbDiaDiemKetThuc.SelectedValue.ToString()),int.Parse(txtMaChuyenDi.Text));
            this.Close();
        }

        private void cbbDiaDiemKhoiHanh_Click(object sender, EventArgs e)
        {
            LoadCBBDD();
        }

        private void cbbDiaDiemKetThuc_Click(object sender, EventArgs e)
        {
            LoadCBBDD();
        }

    }
}
