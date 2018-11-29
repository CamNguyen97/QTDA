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
    public partial class FormThemVeBan : Form
    {
        public static int vitri;
        public int manhanvien;
        public String ngayban;
        public int makh;
        public int mave;

        public FormThemVeBan()
        {
            InitializeComponent();
            LoadData();
            LoadXe();
            cbbMaKhachHang.Visible = false;
            btnChoNgoi.Enabled = false;
        }

        public void LoadData() {
            cbbDiaDiemXp.DataSource = DAO.DiaDiemDAO.Instance.LoadDiaDiem();
            cbbDiaDiemXp.ValueMember = "MaDiaDiem";
            cbbDiaDiemXp.DisplayMember = "TenDiaDiem";

            cbbDiaDiemKt.DataSource = DAO.DiaDiemDAO.Instance.LoadDiaDiemKT();
            cbbDiaDiemKt.ValueMember = "MaDiaDiem";
            cbbDiaDiemKt.DisplayMember = "TenDiaDiem";

            cbbMaKhachHang.DataSource = DAO.KhachHangDAO.Instance.LoadData();
            cbbMaKhachHang.ValueMember = "MaKhachHang";
            cbbMaKhachHang.DisplayMember = "MaKhachHang";

        }

        public void LoadXe() {
            cbbBienSoXe.DataSource = DAO.LichTrinhDAO.Instance.timXe(int.Parse(cbbDiaDiemXp.SelectedValue.ToString()), int.Parse(cbbDiaDiemKt.SelectedValue.ToString()));
            cbbBienSoXe.ValueMember = "BienSoXe";
            cbbBienSoXe.DisplayMember = "LoaiXe";
        }

        private void btnChoNgoi_Click(object sender, EventArgs e)
        {
            mave = DAO.VeBanDAO.Instance.getMaVe(int.Parse(cbbDiaDiemXp.SelectedValue.ToString()), int.Parse(cbbDiaDiemKt.SelectedValue.ToString()), cbbBienSoXe.SelectedValue.ToString());
            int t = DAO.XeDAO.Instance.GheNgoi(cbbBienSoXe.SelectedValue.ToString());
            switch (t) {
                case 34: FormXe34 frm = new FormXe34();
                    frm.LoadData(mave);
                    frm.ShowDialog();
                    break;
                case 29: FormXe29 frm29 = new FormXe29();
                    frm29.LoadData(mave);
                    frm29.ShowDialog();
                    break;
                case 16: FormXe16 frm16 = new FormXe16();
                    frm16.LoadData(mave);
                    frm16.ShowDialog();
                    break;
                default :
                    MessageBox.Show("Chọn Xe");
                    break;
            }
        }

        private void cbDatVe_OnChange(object sender, EventArgs e)
        {
            if (cbDatVe.Checked == true)
            {
                cbbMaKhachHang.Visible = true;
            }
            if (cbDatVe.Checked == false)
            {
                cbbMaKhachHang.Visible = false;
            }
        }

        private void cbbDiaDiemXp_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadXe();
        }

        private void FormThemVeBan_Load(object sender, EventArgs e)
        {

        }

        private void cbbDiaDiemKt_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadXe();
        }

        private void cbbBienSoXe_SelectionChangeCommitted(object sender, EventArgs e)
        {

            txtBienSoXe.Text = cbbBienSoXe.SelectedValue.ToString();
            txtThoiGian.Text = DAO.DataProvider.Instance.ExecuteQuery("select ThoiGianKhoiHanh from tb_Xe,tb_ChiTietChuyenDi where MaDiaDiemXuatPhat = '" + cbbDiaDiemXp.SelectedValue + "' AND MaDiaDiemKetThuc = '" + cbbDiaDiemKt.SelectedValue + "' AND tb_ChiTietChuyenDi.BienSoXe = tb_Xe.BienSoXe").Rows[0][0].ToString();
            txtGiaVe.Text = DAO.DataProvider.Instance.ExecuteQuery("select GiaVe from tb_Xe,tb_ChiTietChuyenDi,tb_Ve where MaDiaDiemXuatPhat = '" + cbbDiaDiemXp.SelectedValue + "' AND MaDiaDiemKetThuc = '" + cbbDiaDiemKt.SelectedValue + "' AND tb_ChiTietChuyenDi.BienSoXe = tb_Xe.BienSoXe AND tb_Ve.MaChuyenDi = tb_ChiTietChuyenDi.MaChuyenDi").Rows[0][0].ToString();
            btnChoNgoi.Enabled = true;
        }

        private void cbbBienSoXe_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnThemVeBan_Click(object sender, EventArgs e)
        {
            if (cbDatVe.Checked == true)
            {
                makh = int.Parse(cbbMaKhachHang.SelectedValue.ToString());
            }
            else {
                makh = 0;
            }
            manhanvien = Form1.manv;
            ngayban = DateTime.Now.ToString();
            mave = DAO.VeBanDAO.Instance.getMaVe(int.Parse(cbbDiaDiemXp.SelectedValue.ToString()), int.Parse(cbbDiaDiemKt.SelectedValue.ToString()),cbbBienSoXe.SelectedValue.ToString());
            DAO.VeBanDAO.Instance.ThemVeBan1(vitri, manhanvien, ngayban, makh, mave);
            this.Close();
        }
    }
}
