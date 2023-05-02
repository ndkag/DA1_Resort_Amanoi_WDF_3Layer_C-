﻿using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AccountDAL:DBConnect
    {

        public int kiemtramatrung(string ma)
        {
            chuoikn.Open();
            int i;
            string sql = "Select count(*) from Account where UserName='" + ma.Trim() + "'";
            cmd = new SqlCommand(sql, chuoikn);
            i = (int)cmd.ExecuteScalar();
            chuoikn.Close();
            return i;
        }
        #region Đăng nhập
       
        public AccountDTO GetAccountByUsernameAndPassword(string username, string password)
        {
            AccountDTO account = null;
            string encryptedPassword = GetMD5Hash(password);
            chuoikn.Open();

                string query = "SELECT * FROM Account WHERE UserName = @UserName AND Password = @Password";
                SqlCommand command = new SqlCommand(query, chuoikn);
                command.Parameters.AddWithValue("@UserName", username);
                command.Parameters.AddWithValue("@Password", encryptedPassword);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    account = new AccountDTO();
                    account.UserName = reader.GetString(0);
                    account.DisplayName = reader.GetString(1);
                    account.Password = reader.GetString(2);
                    account.Type = reader.GetInt32(3);
                }
                reader.Close();
            chuoikn.Close();
            return account;
        }

        #endregion

        #region Quản lý tài khoản
        public DataTable getAccount()
        {
            chuoikn.Open();
            da = new SqlDataAdapter("Select [Tên đăng nhập]=UserName,[Tên người dùng]=DisplayName,[Mật khẩu] =Password, [Quyền] =Type from Account", chuoikn);
            dt = new DataTable();
            da.Fill(dt);
            chuoikn.Close();
            return dt;
        }

        public bool ThemTK(AccountDTO phong)
        {
            string sql = "Insert into Account values('" + phong.UserName + "',N'" + phong.DisplayName + "','" + phong.Password + "','" + phong.Type + "')";
            thucthisql(sql);
            return true;
        }
        public bool UpdateAccount(AccountDTO account)
        {

            string sql = "UPDATE Account SET UserName = '" + account.UserName + "', DisplayName = N'" + account.DisplayName + "', Password = '" + account.Password + "', Type ='" + account.Type + "' WHERE UserName = '" + account.UserName + "' ";
            thucthisql(sql);
            return true;
        }
        public bool DeleteAccount(string username)
        {
            string sql = "Delete from Account where UserName='" + username + "'";
            thucthisql(sql);
            return true;
        }
        #endregion

        public bool DoiMK(AccountDTO account)
        {
            string sql = "update Account set Password='" + account.Password + "' where UserName = '" + account.UserName + "' ";
            thucthisql(sql);
            return true;
        }

    }


}
