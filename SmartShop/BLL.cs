using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        internal class PurchaseGoods
        {
            public PurchaseGoods(DAL.GoodsInfo goodsInfo)
            {
                GoodsInfo = goodsInfo;
            }
            override public string ToString()
            {
                return RFIDlist.Count + "个 " + GoodsInfo.Name;
            }
            public DAL.GoodsInfo GoodsInfo;
            public ArrayList RFIDlist = new ArrayList();
        }

        internal static void Purchase(ArrayList purchaseGoods)
        {
            string text = "";
            int count1 = 0, count2 = 0;
            foreach (BLL.PurchaseGoods goods in purchaseGoods)
            {
                foreach (int rfid in goods.RFIDlist)
                {
                    DAL.Stock_Add(rfid, goods.GoodsInfo.GoodsID);
                }
                count1++;
                count2 += goods.RFIDlist.Count;
                text += "品名：" + goods.GoodsInfo.Name + "，数量：" + goods.RFIDlist.Count + "。" + Environment.NewLine;
            }
            text = "本次进货品种数：" + count1 + "，总件数：" + count2 + Environment.NewLine + "。详情如下：" + Environment.NewLine + text;
            DAL.PurchaseHistory_Add(text);
        }
    }
}
