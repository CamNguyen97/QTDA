using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanVeXe.DAO
{
    class TaiKhoanDAO
    {

        public int MNV;
        private static TaiKhoanDAO instance;

        public static TaiKhoanDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new TaiKhoanDAO();
                return TaiKhoanDAO.instance;
            }
            set { TaiKhoanDAO.instance = value; }
        }

        public TaiKhoanDAO()
        {
        }

        public DataTable LoadDataTaiKhoan()
        {
            DataTable dt = new DataTable();
            dt = DataProvider.Instance.ExecuteQuery("EXEC sp_TaiKhoan");
            return dt;
        }

        public void ThemTaiKhoan(String a, String b, int c, int d)
        {
            DataProvider.Instance.ExecuteNonQuery("EXEC InsertUser '" + a + "', '" + b + "','" + c + "' , '" + d + "'");
        }

        public void XoaTaiKhoan(int a)
        {
            DataProvider.Instance.ExecuteNonQuery("EXEC DeleteUser '" + a + "'");
        }
        public void SuaTaiKhoan(String a, String b, int c , int d)
        {
            DataProvider.Instance.ExecuteNonQuery("EXEC EditUser '" + a + "' , '" + b + "' , '" + c + "' , '"+d+"'");
        }

        public DataTable KiemTra(int mnv)
        {
            DataTable dt = new DataTable();
            return (DataProvider.Instance.ExecuteQuery("EXEC KiemTraTaiKhoan '" + mnv + "'"));
        }

        public DataTable KiemTra1(String id)
        {
            DataTable dt = new DataTable();
            return (DataProvider.Instance.ExecuteQuery("EXEC KiemTraTaiKhoan1 '" + id + "'"));
        }

        public DataTable TimKiem(String id)
        {
            DataTable dt = new DataTable();
            return (DataProvider.Instance.ExecuteQuery("EXEC TimKiem '" + id + "'"));
        }

        public bool checkIsAd(String a , String b)
        {
            DataTable dt = new DataTable();
            dt = DataProvider.Instance.ExecuteQuery("select IsAd from tb_User where IDTaiKhoan = '" + a + "' AND PASS = '"+b+"'");
            int num = Convert.ToInt32(dt.Rows[0][0]);
            if ( num == 1) {
                return true;
            }
            return false;
        }

        public int getMNV(String a,String b) {
            DataTable dt = new DataTable();
            dt = DataProvider.Instance.ExecuteQuery("select MaNhanVien from tb_User where IDTaiKhoan = '" + a + "' AND PASS = '" + b + "'");
            MNV = Convert.ToInt32(dt.Rows[0][0]);
            return MNV;
        }

    }
}
