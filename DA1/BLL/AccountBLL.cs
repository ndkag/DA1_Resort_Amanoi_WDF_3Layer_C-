using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace BLL
{
    public class AccountBLL
    {
        AccountDAL accountDAL = new AccountDAL();
        DBConnect db = new DBConnect();
        public AccountBLL()
        {
        }

        #region Đăng nhập
        public AccountDTO GetAccountByUsernameAndPassword(string username, string password)
        {
            return accountDAL.GetAccountByUsernameAndPassword(username, password);
        }
        public string GetMD5Hash(string input)
        {
            return db.GetMD5Hash(input);
        }

        public AccountDTO GetAccountByPassword(string password)
        {
            return accountDAL.GetAccountByPassword(password);
        }
        public AccountDTO GetAccountByUsername(string username)
        {
            return accountDAL.GetAccountByUsername(username);
        }

        #endregion

        #region Quản lý tài khoản
        public DataTable getAccount()
        {
            return accountDAL.getAccount();
        }

        public bool DeleteAccount(string username)
        {
            return accountDAL.DeleteAccount(username);
        }
        public bool UpdateAccount(AccountDTO account)
        {
            return accountDAL.UpdateAccount(account);
        }
       
        public bool ThemTK(AccountDTO phong)
        {
            return accountDAL.ThemTK(phong);
        }
            public int kiemtramatrung(string ma)
        {
            return accountDAL.kiemtramatrung(ma);
        }

        #endregion

        public bool Doimk(AccountDTO account)
        {
            return accountDAL.DoiMK(account);
        }
    
    }
}

