using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanVeXe.DAO
{
    class LoginDAO
    {
        private static LoginDAO instance;

        public static LoginDAO Instance
        {
            get {
                if (instance == null) {
                    instance = new LoginDAO();
                }
                return LoginDAO.instance; 
            }
            set { LoginDAO.instance = value; }
        }

        public LoginDAO() { 
        }

        public DataTable Login(String a, String b)
        {
            DataTable dt = new DataTable();
            dt = DataProvider.Instance.ExecuteQuery("EXEC sp_Login '" + a + "' , '" + b + "' ");
            return dt;
        }

    }
}
