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
        private static string ConnectionString = "Data Source =" + Environment.CurrentDirectory + "/database.db";
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

        internal static UserInfo User_Get(string Username)
        {
            var temp = new UserInfo();
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

        internal static int User_Edit(UserInfo userInfo)
        {
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

        internal class ProviderInfo
        {
            public ProviderInfo(int providerID, string name, string phone, string address)
            {
                ProviderID = providerID;
                Name = name;
                Phone = phone;
                Address = address;
            }

            public ProviderInfo()
            {
            }

            override public string ToString()
            {
                return ProviderID + " " + Name;
            }
            public int ProviderID;
            public string Name;
            public string Phone;
            public string Address;
        }

        internal static ArrayList Provider_GetAll()
        {
            ArrayList AllProvider = new ArrayList();
            string sql = "SELECT * FROM Provider;";

            using (SQLiteConnection c = new SQLiteConnection(ConnectionString))
            {
                c.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var temp = new ProviderInfo(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
                            AllProvider.Add(temp);
                        }
                    }
                }
            }
            return AllProvider;
        }

        internal static int Provider_Delate(int ProviderID)
        {
            string sql = "DELETE FROM Provider WHERE ID = '{ProviderID}';".Replace("{ProviderID}", ProviderID.ToString());
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

        internal static int Provider_Add(ProviderInfo providerInfo)
        {
            string sql = "INSERT INTO Provider (Name,Phone,Address) VALUES ('{Name}','{Phone}','{Address}');";
            sql = sql.Replace("{Phone}", providerInfo.Phone).Replace("{Name}", providerInfo.Name).Replace("{Address}", providerInfo.Address);
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

        internal static int Provider_Edit(ProviderInfo providerInfo)
        {
            string sql = "UPDATE Provider SET Phone = '{Phone}',Name = '{Name}',Address = '{Address}' WHERE ID = '{ProviderID}';";
            sql = sql.Replace("{Phone}", providerInfo.Phone).Replace("{Name}", providerInfo.Name).Replace("{Address}", providerInfo.Address).Replace("{ProviderID}", providerInfo.ProviderID.ToString());
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
