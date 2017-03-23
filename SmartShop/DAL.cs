using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Collections;

namespace SmartShop
{
    static class DAL
    {
        internal static UserInfo User_Get(string Username)
        {
            var temp = new UserInfo();
            string ConnectionString = "Data Source =" + Environment.CurrentDirectory + "/database.db";
            string sql = "SELECT * FROM User WHERE Username = '{Username}';".Replace("{Username}", Username);

            using (SQLiteConnection c = new SQLiteConnection(ConnectionString))
            {
                c.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read())
                            return null;
                        temp = new UserInfo(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetBoolean(5));
                    }
                }
            }
            return temp;
        }

        internal static ArrayList User_GetAll()
        {
            ArrayList AllUsers = new ArrayList();
            string ConnectionString = "Data Source =" + Environment.CurrentDirectory + "/database.db";
            string sql = "SELECT * FROM User;";

            using (SQLiteConnection c = new SQLiteConnection(ConnectionString))
            {
                c.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var temp = new UserInfo(reader.GetString(0), reader.GetString(1), null, reader.GetString(3), reader.GetString(4), reader.GetBoolean(5));
                            AllUsers.Add(temp);
                        }
                    }
                }
            }
            return AllUsers;
        }

        internal static int User_Delate(string Username)
        {
            string ConnectionString = "Data Source =" + Environment.CurrentDirectory + "/database.db";
            string sql = "DELETE FROM User WHERE Username = '{Username}';".Replace("{Username}", Username);
            int temp;
            using (SQLiteConnection c = new SQLiteConnection(ConnectionString))
            {
                c.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                {
                    temp = cmd.ExecuteNonQuery();
                }
            }
            return temp;
        }

        internal static int User_Add(UserInfo userInfo)
        {
            string ConnectionString = "Data Source =" + Environment.CurrentDirectory + "/database.db";
            string sql = "INSERT INTO User (IsAdmin,Phone,Name,PasswordHash,Username,UserID) VALUES ('{IsAdmin}','{Phone}','{Name}','{PasswordHash}','{Username}','{UserID}');";
            sql = sql.Replace("{IsAdmin}", userInfo.IsAdmin ? "1" : "0").Replace("{Phone}", userInfo.Phone).Replace("{Name}", userInfo.Name).Replace("{PasswordHash}", userInfo.PasswordHash).Replace("{Username}", userInfo.Username).Replace("{UserID}", userInfo.UserID);
            int temp;
            using (SQLiteConnection c = new SQLiteConnection(ConnectionString))
            {
                c.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                {
                    temp = cmd.ExecuteNonQuery();
                }
            }
            return temp;
        }

        internal class UserInfo
        {
            public UserInfo(string userID, string username, string passwordHash, string name, string phone, bool isAdmin)
            {
                UserID = userID;
                Username = username;
                PasswordHash = passwordHash;
                Name = name;
                Phone = phone;
                IsAdmin = isAdmin;
            }

            public UserInfo()
            {
            }

            override public string ToString()
            {
                return (IsAdmin ? "管理员：" : "用户：") + UserID + " " + Name + " " + Username;
            }
            public string UserID;
            public string Username;
            public string PasswordHash;
            public string Name;
            public string Phone;
            public bool IsAdmin;
        }

        internal static int User_Edit(UserInfo userInfo)
        {
            string ConnectionString = "Data Source =" + Environment.CurrentDirectory + "/database.db";
            string sql;
            if (userInfo.PasswordHash != null)
            {
                sql = "UPDATE User SET IsAdmin = '{IsAdmin}',Phone = '{Phone}',Name = '{Name}',PasswordHash = '{PasswordHash}',UserID = '{UserID}' WHERE Username = '{Username}';";
                sql = sql.Replace("{IsAdmin}", userInfo.IsAdmin ? "1" : "0").Replace("{Phone}", userInfo.Phone).Replace("{Name}", userInfo.Name).Replace("{PasswordHash}", userInfo.PasswordHash).Replace("{Username}", userInfo.Username).Replace("{UserID}", userInfo.UserID);
            }
            else
            {
                sql = "UPDATE User SET IsAdmin = '{IsAdmin}',Phone = '{Phone}',Name = '{Name}',UserID = '{UserID}' WHERE Username = '{Username}';";
                sql = sql.Replace("{IsAdmin}", userInfo.IsAdmin ? "1" : "0").Replace("{Phone}", userInfo.Phone).Replace("{Name}", userInfo.Name).Replace("{Username}", userInfo.Username).Replace("{UserID}", userInfo.UserID);
            }
            int temp;
            using (SQLiteConnection c = new SQLiteConnection(ConnectionString))
            {
                c.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                {
                    temp = cmd.ExecuteNonQuery();
                }
            }
            return temp;
        }
    }
}
