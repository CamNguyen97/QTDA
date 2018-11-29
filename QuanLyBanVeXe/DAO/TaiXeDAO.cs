using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanVeXe.DAO
{
    class TaiXeDAO
    {
        private static TaiXeDAO instance;

        internal static TaiXeDAO Instance
        {
            get {
                if (instance == null) {
                    instance = new TaiXeDAO();
                }
                return TaiXeDAO.instance; }
            set { TaiXeDAO.instance = value; }
        }

        public TaiXeDAO() { }

        public DataTable LoadData() {
            DataTable dt = new DataTable();
            dt = DataProvider.Instance.ExecuteQuery("EXEC sp_TaiXe");
            return dt;
        }

        public void ThemTaiXe(int cmt , String ten , String sdt , String diachi) {
            DataProvider.Instance.ExecuteNonQuery("EXEC sp_ThemTaiXe '"+cmt+"',N'"+ten+"','"+sdt+"',N'"+diachi+"'");
        }

        public bool KiemTra(int cmt) {
            DataTable dt = new DataTable();
            dt = DataProvider.Instance.ExecuteQuery("select * from tb_TaiXe where tb_TaiXe.cmtTaiXe = '" + cmt + "'");
            if (dt.Rows.Count > 0) {
                return true;
            }
            return false;
        }

        public void XoaTaiXe(int cmt) {
            DataProvider.Instance.ExecuteNonQuery("delete tb_TaiXe where cmtTaiXe = '" + cmt + "'");
        }

        public DataTable TimKiem(String ten) { 
            DataTable dt = new DataTable();
            dt = DataProvider.Instance.ExecuteQuery("EXEC sp_TimKiemTaiXe '"+ten+"'");
            return dt;
        }
    }
}
