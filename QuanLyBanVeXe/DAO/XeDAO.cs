using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanVeXe.DAO
{
    class XeDAO
    {
        private static XeDAO instance;

        public static XeDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new XeDAO();
                return XeDAO.instance;
            }
            set { XeDAO.instance = value; }
        }

        public XeDAO()
        {
        }

        public DataTable LoadDataXe()
        {
            DataTable dt = new DataTable();
            dt = DataProvider.Instance.ExecuteQuery("EXEC sp_Xe");
            return dt;
        }

        public void Xoa(String bienso) {
            DataProvider.Instance.ExecuteNonQuery("EXEC DeleteXe '"+ bienso +"'");
        }

        public void Them(String bienso , String maloai) {
            DataProvider.Instance.ExecuteNonQuery("EXEC InsertXe '" + bienso + "','" + maloai + "'");
        }

        public DataTable KiemTra(String bienso) {
            DataTable dt = new DataTable();
            dt = DataProvider.Instance.ExecuteQuery("EXEC KiemTraXe '" + bienso + "'");
            return dt;
        }

        public DataTable LoadCombobox() {
            DataTable dt = new DataTable();
            dt = DataProvider.Instance.ExecuteQuery("EXEC sp_LoaiXe");
            return dt;
        }

        public DataTable Timkiem(String bienso) {
            DataTable dt = new DataTable();
            dt = DataProvider.Instance.ExecuteQuery("EXEC TimXe '" + bienso + "'");
            return dt;
        }

        public int GheNgoi(String bienso) {
            int num = 0;
            num = Convert.ToInt32(DAO.DataProvider.Instance.ExecuteQuery("EXEC sp_GheNgoi '"+bienso+"'").Rows[0][0]);
            return num;        
        }

    }
}
