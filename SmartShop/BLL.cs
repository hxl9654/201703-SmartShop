using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace SmartShop
{
    static class BLL
    {
        internal static (bool IsSuccess, int usertype, string Name) Login(string username, string password)
        {
            DAL.UserInfo temp = DAL.User_Get(username);
            if (temp != null && password.Equals(temp.PasswordHash))
                return (true, temp.IsAdmin ? 1 : 0, temp.Name);
            else
                return (false, -1, "");
        }

        internal class SellAndPurchaseGoods
        {
            public SellAndPurchaseGoods(DAL.GoodsInfo goodsInfo)
            {
                GoodsInfo = goodsInfo;
            }
            public override string ToString()
            {
                return RFIDlist.Count + "个 " + GoodsInfo.Name;
            }
            public DAL.GoodsInfo GoodsInfo;
            public ArrayList RFIDlist = new ArrayList();
        }

        internal static void Purchase(ArrayList purchaseGoods, string user)
        {
            string text = "";
            int count1 = 0, count2 = 0;
            foreach (BLL.SellAndPurchaseGoods goods in purchaseGoods)
            {
                foreach (long rfid in goods.RFIDlist)
                {
                    DAL.Stock_Add(rfid, goods.GoodsInfo.GoodsID);
                }
                count1++;
                count2 += goods.RFIDlist.Count;
                text += "品名：" + goods.GoodsInfo.Name + "，数量：" + goods.RFIDlist.Count + "。" + Environment.NewLine;
            }
            text = "本次进货品种数：" + count1 + "，总件数：" + count2 + "。" + Environment.NewLine + "详情如下：" + Environment.NewLine + text + Environment.NewLine + "操作用户：" + user;
            DAL.PurchaseHistory_Add(text);
        }

        internal static void Sell(ArrayList sellGoods, string user)
        {
            string text = "";
            int count1 = 0, count2 = 0;
            foreach (BLL.SellAndPurchaseGoods goods in sellGoods)
            {
                foreach (long rfid in goods.RFIDlist)
                {
                    DAL.Stock_Delete(rfid);
                }
                count1++;
                count2 += goods.RFIDlist.Count;
                text += "品名：" + goods.GoodsInfo.Name + "，数量：" + goods.RFIDlist.Count + "。" + Environment.NewLine;
            }
            text = "本次销售品种数：" + count1 + "，总件数：" + count2 + "。" + Environment.NewLine + "详情如下：" + Environment.NewLine + text + Environment.NewLine + "操作用户：" + user;
            DAL.SellHistory_Add(text);
        }

        internal class InventoryGoods
        {
            public InventoryGoods(DAL.GoodsInfo goodsInfo, ArrayList RFIDlist)
            {
                GoodsInfo = goodsInfo;
                RFIDList = RFIDlist;
            }
            public override string ToString()
            {
                return "商品ID：" + GoodsInfo.GoodsID + "，商品名称：" + GoodsInfo.Name + "； 库存记录" + RFIDList.Count + "个，盘点结果" + Inventorylist.Count + "个。";
            }
            public DAL.GoodsInfo GoodsInfo;
            public ArrayList RFIDList;
            public ArrayList Inventorylist = new ArrayList();
        }

        internal static ArrayList Inventory_Prepare()
        {
            ArrayList InventoryList = new ArrayList();
            var temp = DAL.Stock_GetAll();
            foreach (var key in temp.Keys)
            {
                DAL.GoodsInfo GoodsInfo = (DAL.GoodsInfo)DAL.Goods_Get(key, "")[0];
                ArrayList RFIDList = temp[key];
                InventoryList.Add(new InventoryGoods(GoodsInfo, RFIDList));
            }
            return InventoryList;
        }

        internal static string Inventory_Result(ListBox.ObjectCollection items)
        {
            string message = "盘点结果如下：" + Environment.NewLine;
            foreach (BLL.InventoryGoods goods in items)
            {
                message += goods.ToString() + Environment.NewLine;
            }
            message += "确定将本次盘点结果写入数据库吗？";
            return message;
        }

        internal static void Inventory_Submit(ListBox.ObjectCollection items)
        {
            foreach (BLL.InventoryGoods goods in items)
            {
                foreach(long rfid in goods.RFIDList)
                {
                    if(!goods.Inventorylist.Contains(rfid))
                        DAL.Stock_Delete(rfid);
                }
            }
        }
    }
}
