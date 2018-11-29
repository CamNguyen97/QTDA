using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanVeXe.DAO
{
    class VeBanDAO
    {
        public static VeBanDAO instance;

        public static VeBanDAO Instance
        {

            get
            {
                if (instance == null)
                {
                    instance = new VeBanDAO();
                }
                return VeBanDAO.instance;
            }
            set { VeBanDAO.instance = value; }
        }

            public VeBanDAO(){}

            public DataTable LoadData() {
                DataTable dt = new DataTable();
                dt = DataProvider.Instance.ExecuteQuery("EXEC sp_Ve");
                return dt;
            }

            public DataTable LoadData1() {
                DataTable dt = new DataTable();
                int num = TaiKhoanDAO.Instance.MNV;
                dt = DataProvider.Instance.ExecuteQuery("EXEC sp_BanVe '" + num + "'");
                return dt;
            }

            public void ThemVeBan(int gia , int machuyendi) {
                DataProvider.Instance.ExecuteNonQuery("EXEC sp_ThemVe '"+gia+"','"+machuyendi+"'");
            }

            public bool KiemTraVe(int machuyendi) {
                DataTable dt = new DataTable();
                dt = DataProvider.Instance.ExecuteQuery("EXEC sp_KiemTraVe '" + machuyendi + "'");
                if (dt.Rows.Count > 0) { 
                    return true; 
                }
                else {
                    return false;
                }
            }

            public void XoaVe(int mave) {
                DataProvider.Instance.ExecuteNonQuery("EXEC sp_XoaMaVe '" + mave + "'");
                LoadData1();
            }

            public void SuaVe(int gia, int mave) {
                DataProvider.Instance.ExecuteNonQuery("EXEC sp_SuaVe '"+gia+"','"+mave+"'");
            }

            public int getMaVe(int diemxp, int diemkt, String bienSoXe) {
                if(DataProvider.Instance.ExecuteQuery("exec sp_timMaVe '" + diemxp + "','" + diemkt + "','" + bienSoXe + "'").Rows.Count >= 1 ){
                int mave = int.Parse(DataProvider.Instance.ExecuteQuery("exec sp_timMaVe '" + diemxp + "','" + diemkt + "','" + bienSoXe + "'").Rows[0][0].ToString());
                return mave;
                }
                return 0;
            }

            public DataTable getViTri(int mave) {
                DataTable dt = new DataTable();
                dt = DataProvider.Instance.ExecuteQuery("select ViTriGheNgoi from tb_ChiTietVe where MaVe = '" + mave + "'");
                return dt;
            }

            public void ThemVeBan1(int vitri , int manv , String ngayban , int makh , int mave) {
                DataProvider.Instance.ExecuteNonQuery("exec sp_ThemVeBan '"+vitri+"','"+manv+"','"+ngayban+"','"+makh+"','"+mave+"'");
            }

            public void SuaVeBan(int vitri, int mave , int makh , String ngayban) {
                DataProvider.Instance.ExecuteNonQuery("update tb_ChiTietVe set ViTriGheNgoi = '" + vitri + "' , MaVe = '" + mave + "' where MaKhachHang = '" + makh + "' AND NgayBan = '" + ngayban + "'");
            }
            public DataTable TimVe(int machuyendi)
            {
                return DataProvider.Instance.ExecuteQuery("exec sp_TimVe '"+machuyendi+"'");
            }
    }
}
