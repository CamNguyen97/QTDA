using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanVeXe.DAO
{
    class DiaDiemDAO
    {
        public static DiaDiemDAO instance;

        public static DiaDiemDAO Instance
        {
            get {
                if (instance == null) { 
                instance = new DiaDiemDAO();
                } 
                return instance;
            }
            set { Instance = value; }
        }

        public DiaDiemDAO() { }

        public DataTable LoadDiaDiem() {
            DataTable dt = new DataTable();
            dt = DataProvider.Instance.ExecuteQuery("EXEC sp_diadiem");
            return dt;
        }

        public DataTable LoadDiaDiemKT()
        {
            DataTable dt = new DataTable();
            dt = DataProvider.Instance.ExecuteQuery("EXEC DiaDiemKT");
            return dt;
        }

        public void ThemDiaDiem(String tendiadiem) {
            DataProvider.Instance.ExecuteNonQuery("EXEC sp_themDiaDiem '" + tendiadiem + "'");
        }

        public void ThemDiaDiemKT(String tendiadiem) {
            DataProvider.Instance.ExecuteNonQuery("EXEC sp_themDiaDiemKT '" + tendiadiem + "'");
        }

    }
}
