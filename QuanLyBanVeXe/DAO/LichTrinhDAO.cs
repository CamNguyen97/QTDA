using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanVeXe.DAO
{
    class LichTrinhDAO
    {
        private static LichTrinhDAO instance;
    

        public static LichTrinhDAO Instance
        {
            get {
                 if (instance == null) {
                 instance = new LichTrinhDAO();
                   }
            return instance; 
        }
            set { instance = value; }
        }

        public LichTrinhDAO() { }

        public DataTable LoadData(){
            DataTable dt = new DataTable();
            dt = DataProvider.Instance.ExecuteQuery("EXEC sp_LichTrinh");
            return dt;
        }

        public void ThemLichTrinh(String machuyendi,String thoigian , int cmttaixe , String biensoxe , String madiadiemxp , String madiadiemkt) {
         DataProvider.Instance.ExecuteNonQuery("EXEC sp_ThemLichTrinh 0,'"+thoigian+"','"+cmttaixe+"','"+biensoxe+"',0,'"+madiadiemxp+"','"+madiadiemkt+"'");
        }

        public DataTable TimKiem(string tendiadiemxp) {
            DataTable dt = new DataTable();
            //dt = DataProvider.Instance.ExecuteQuery("EXEC sp_TimKiemLichTrinh '"+machuyendi+"'");
            dt = DataProvider.Instance.ExecuteQuery("EXEC sp_TimKiemLichTrinh '" + tendiadiemxp + "'");
            return dt;
        }

        public void XoaLichTrinh(int machuyendi) {
            DataProvider.Instance.ExecuteNonQuery("EXEC sp_XoaLichTrinh '"+machuyendi+"'");
        }

        public void updatetime(int macd, string time) {
            DataProvider.Instance.ExecuteQuery("exec updatetime  '"+time+"' , '"+macd+"'");
        }

        public void SuaLichTrinh(String thoigian, int cmtTaiXe, String bienSoXe, int maDiaDiemXP, int maDiaDiemKT, int maChuyenDi) {
            DAO.DataProvider.Instance.ExecuteNonQuery("exec sp_SuaLichTrinh '"+thoigian+"','"+cmtTaiXe+"','"+bienSoXe+"','"+maDiaDiemXP+"','"+maDiaDiemKT+"','"+maChuyenDi+"'");
        }

        public DataTable timXe(int maxp, int makt) {
            DataTable dt = new DataTable();
            dt = DataProvider.Instance.ExecuteQuery("exec sp_timXe '"+maxp+"','"+makt+"'");
            return dt;
        }


    }
}
