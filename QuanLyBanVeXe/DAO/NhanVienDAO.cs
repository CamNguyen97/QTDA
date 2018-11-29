using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanVeXe.DAO
{
    class NhanVienDAO
    {
        public static NhanVienDAO instance;

        public static NhanVienDAO Instance
        {
            get {
                if (instance == null) {
                    instance = new NhanVienDAO();
                }
                    return NhanVienDAO.instance; }
            set { NhanVienDAO.instance = value; }
        }

        public NhanVienDAO() { }

        public DataTable LoadNhanVien() {
            DataTable dt = new DataTable();
            dt = DataProvider.Instance.ExecuteQuery("EXEC sp_NhanVien");
            return dt;
        }

        public void ThemNhanVien( String ten , String diachi , int sdt , String gmail) {
            DataProvider.Instance.ExecuteNonQuery("insert tb_NhanVien values(N'"+ten+"',N'"+diachi+"','"+sdt+"','"+gmail+"')");
        }

        public void XoaNhanVien(int manv) {
                DataProvider.Instance.ExecuteNonQuery("delete tb_ChiTietVe where MaNhanVien = '"+manv+"'");
                DataProvider.Instance.ExecuteNonQuery("delete tb_NhanVien where MaNhanVien = '" + manv + "'");
        }

        public bool KiemTra(int manv) {
            DataTable dt = new DataTable();
            dt = DataProvider.Instance.ExecuteQuery("select * from tb_ChiTietVe where MaNhanVien = 2");
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else 
                return false;
        }

        public DataTable TimNhanVien(String tenNV) {
            return DataProvider.Instance.ExecuteQuery("EXEC sp_TimNhanVien '" + tenNV + "'");
        }
    }
}
