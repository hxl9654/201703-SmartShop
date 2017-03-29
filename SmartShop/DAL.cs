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

            public override string ToString()
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

            public override string ToString()
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

        internal class GoodsInfo
        {
            public GoodsInfo(int goodsID, string name, int providerID, double price)
            {
                ProviderID = providerID;
                Name = name;
                Price = price;
                GoodsID = goodsID;
            }

            public GoodsInfo()
            {
            }

            public override string ToString()
            {
                return GoodsID + " " + Name;
            }
            public int ProviderID;
            public string Name;
            public double Price;
            public int GoodsID;
        }

        internal static ArrayList Goods_GetAll()
        {
            ArrayList AllGoods = new ArrayList();
            string sql = "SELECT * FROM Goods;";

            using (SQLiteConnection c = new SQLiteConnection(ConnectionString))
            {
                c.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var temp = new GoodsInfo(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(3), reader.GetDouble(2));
                            AllGoods.Add(temp);
                        }
                    }
                }
            }
            return AllGoods;
        }

        internal static ArrayList Goods_Get(int ID, string Name, int ProviderID = -1)
        {
            ArrayList AllGoods = new ArrayList();
            string sql;
            if (ProviderID != -1)
                sql = "SELECT * FROM Goods Where ProviderID = '{ProviderID}';".Replace("{ProviderID}", ProviderID.ToString());
            else if (ID < 0)
                sql = "SELECT * FROM Goods Where Name LIKE '%{Name}%';".Replace("{Name}", Name);
            else
                sql = "SELECT * FROM Goods Where ID = '{ID}';".Replace("{ID}", ID.ToString());
            using (SQLiteConnection c = new SQLiteConnection(ConnectionString))
            {
                c.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var temp = new GoodsInfo(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(3), reader.GetDouble(2));
                            AllGoods.Add(temp);
                        }
                    }
                }
            }
            return AllGoods;
        }

        internal static int Goods_Delate(int GoodsID)
        {
            string sql = "DELETE FROM Goods WHERE ID = '{GoodsID}';".Replace("{GoodsID}", GoodsID.ToString());
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

        internal static int Goods_Add(GoodsInfo goodsInfo)
        {
            string sql = "INSERT INTO Goods (Name,Price,ProviderID) VALUES ('{Name}','{Price}','{ProviderID}');";
            sql = sql.Replace("{Name}", goodsInfo.Name).Replace("{Price}", goodsInfo.Price.ToString()).Replace("{ProviderID}", goodsInfo.ProviderID.ToString());
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

        internal static int Goods_Edit(GoodsInfo goodsInfo)
        {
            string sql = "UPDATE Goods SET Price = '{Price}',Name = '{Name}',ProviderID = '{ProviderID}' WHERE ID = '{GoodsID}';";
            sql = sql.Replace("{Price}", goodsInfo.Price.ToString()).Replace("{Name}", goodsInfo.Name).Replace("{ProviderID}", goodsInfo.ProviderID.ToString()).Replace("{GoodsID}", goodsInfo.GoodsID.ToString());
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

        internal static int Stock_Get(long RFID)
        {
            string sql = "SELECT * FROM Stock WHERE RFID = '{RFID}';".Replace("{RFID}", RFID.ToString());

            using (SQLiteConnection c = new SQLiteConnection(ConnectionString))
            {
                c.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read())
                            return -1;
                        return reader.GetInt32(1);
                    }
                }
            }
        }

        internal static Dictionary<int, ArrayList> Stock_GetAll()
        {
            Dictionary<int, ArrayList> AllStock = new Dictionary<int, ArrayList>();
            string sql = "SELECT * FROM Stock;";

            using (SQLiteConnection c = new SQLiteConnection(ConnectionString))
            {
                c.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (!AllStock.ContainsKey(reader.GetInt32(1)))
                                AllStock.Add(reader.GetInt32(1), new ArrayList());
                            AllStock[reader.GetInt32(1)].Add(reader.GetInt64(0));
                        }
                    }
                }
            }
            return AllStock;
        }

        internal static int Stock_Add(long RFID, int goodsID)
        {
            string sql = "INSERT INTO Stock (RFID,goodsID) VALUES ('{RFID}','{goodsID}');";
            sql = sql.Replace("{RFID}", RFID.ToString()).Replace("{goodsID}", goodsID.ToString());
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

        internal static int Stock_Delete(long rfid, int goodsID = -1)
        {
            string sql;
            if (goodsID != -1)
                sql = "DELETE FROM Stock WHERE GoodsID = '{GoodsID}';".Replace("{GoodsID}", goodsID.ToString());
            else
                sql = "DELETE FROM Stock WHERE RFID = '{RFID}';".Replace("{RFID}", rfid.ToString());
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

        internal class SellAndPurchaseHistory
        {
            public SellAndPurchaseHistory(string timestamp, string text)
            {
                Timestamp = timestamp;
                Text = text;
            }
            public override string ToString()
            {
                return Timestamp;
            }
            public string Timestamp;
            public string Text;
        }

        internal static int PurchaseHistory_Add(string text)
        {
            string sql = "INSERT INTO PurchaseHistory (text) VALUES ('{text}');";
            sql = sql.Replace("{text}", text);
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

        internal static ArrayList PurchaseHistory_GetAll()
        {
            ArrayList purchaseHistory = new ArrayList();
            string sql = "SELECT * FROM PurchaseHistory;";

            using (SQLiteConnection c = new SQLiteConnection(ConnectionString))
            {
                c.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var temp = new SellAndPurchaseHistory(reader.GetString(0), reader.GetString(1));
                            purchaseHistory.Add(temp);
                        }
                    }
                }
            }
            return purchaseHistory;
        }

        internal static int SellHistory_Add(string text)
        {
            string sql = "INSERT INTO SellHistory (text) VALUES ('{text}');";
            sql = sql.Replace("{text}", text);
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

        internal static ArrayList SellHistory_GetAll()
        {
            ArrayList SellHistory = new ArrayList();
            string sql = "SELECT * FROM SellHistory;";

            using (SQLiteConnection c = new SQLiteConnection(ConnectionString))
            {
                c.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var temp = new SellAndPurchaseHistory(reader.GetString(0), reader.GetString(1));
                            SellHistory.Add(temp);
                        }
                    }
                }
            }
            return SellHistory;
        }
    }
}
