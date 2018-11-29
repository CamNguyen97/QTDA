using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanVeXe.DAO
{
    class KhachHangDAO
    {
        private static KhachHangDAO instance;

        internal static KhachHangDAO Instance
        {
            get {
                if (instance == null)
                {
                    instance = new KhachHangDAO();
                }
                return KhachHangDAO.instance; }
            set { KhachHangDAO.instance = value; }
        }

        public KhachHangDAO() { }

        public DataTable LoadData() {
            DataTable dt = new DataTable();
            dt = DataProvider.Instance.ExecuteQuery("EXEC sp_KhachHang");
            return dt;
        }

        public void ThemKhachHang(String makhachhang,String tenkhachhang,String sdt , String diachi) {
            DataProvider.Instance.ExecuteNonQuery("EXEC sp_ThemKhachHang '" + makhachhang + "',N'" + tenkhachhang + "','" + sdt + "',N'" + diachi + "'");
        }

        public void XoaKhachHang(String makh) {
            DataProvider.Instance.ExecuteNonQuery("EXEC sp_XoaKhachHang '" + makh + "'");
        }

        public bool checkMaKhachHang(String makh) {
            DataTable dt = new DataTable();
            dt = DataProvider.Instance.ExecuteQuery("select * from KhachHang where MaKhachHang = '" + makh + "'");
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }

        public void SuaKhachHang(String makh , String tenkh , String sdt , String diachi) {
            DataProvider.Instance.ExecuteNonQuery("EXEC sp_SuaKhachHang '"+makh+"','"+tenkh+"','"+sdt+"','"+diachi+"'");
        }
       
        public DataTable TimKiem(String tenkh) {
            DataTable dt = new DataTable();
            dt = DataProvider.Instance.ExecuteQuery("EXEC sp_TimKH '" + tenkh + "'");
            return dt;
        }
    }
}
