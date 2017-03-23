using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Collections;

namespace SmartShop
{
    public partial class FormMain : Form
    {
        TabPage[] AllTabPages = new TabPage[9];
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            AllTabPages_SaveAndClear(true);
        }

        private void AllTabPages_Add(bool all = false)
        {
            tabControlMain.TabPages.Clear();
            if (all)
                tabControlMain.TabPages.AddRange(AllTabPages);
            else
            {
                tabControlMain.TabPages.Add(AllTabPages[0]);
                tabControlMain.TabPages.Add(AllTabPages[5]);
            }
        }

        private void AllTabPages_SaveAndClear(bool save = false)
        {
            if (save)
            {
                var AllTabPages_Enumerator = tabControlMain.TabPages.GetEnumerator();
                int i = 0;
                while (AllTabPages_Enumerator.MoveNext())
                {
                    AllTabPages[i] = (TabPage)AllTabPages_Enumerator.Current;
                    i++;
                }
            }
            tabControlMain.TabPages.Clear();
            tabControlMain.TabPages.Add(AllTabPages[0]);
        }

        private void buttonLogin_Login_Click(object sender, EventArgs e)
        {
            if (buttonLogin_Login.Text.Equals("注销"))
            {
                AllTabPages_SaveAndClear();
                this.Text = "智能超市管理系统";
                buttonLogin_Login.Text = "登录";
                textBoxLogin_password.Text = "";
                textBoxLogin_Username.Text = "";
                textBoxLogin_Username.Enabled = true;
                textBoxLogin_password.Enabled = true;
                buttonLogin_Login.Enabled = true;
                buttonLogin_Reset.Enabled = true;
                buttonQuit.Enabled = true;
                return;
            }
            string Username = textBoxLogin_Username.Text;
            string Password = textBoxLogin_password.Text;
            if (Username.Length == 0 || Password.Length == 0)
            {
                MessageBox.Show("用户名和密码不能为空");
                textBoxLogin_password.Text = "";
                textBoxLogin_Username.Text = "";
                return;
            }
            if (!IsThisAValuadUserName(Username))
            {
                MessageBox.Show("用户名不合法");
                textBoxLogin_password.Text = "";
                textBoxLogin_Username.Text = "";
                return;
            }
            textBoxLogin_password.Text = "********";
            textBoxLogin_Username.Enabled = false;
            textBoxLogin_password.Enabled = false;
            buttonLogin_Login.Enabled = false;
            buttonLogin_Reset.Enabled = false;
            Password = SHA256(Password);

            var temp = BLL.Login(Username, Password);
            if (temp.IsSuccess)
            {
                this.Text = "智能超市管理系统--当前用户：" + temp.Name;
                buttonLogin_Login.Text = "注销";
                buttonLogin_Login.Enabled = true;
                if (temp.usertype == 1)
                    AllTabPages_Add(true);
                else if (temp.usertype == 0)
                    AllTabPages_Add(false);
                buttonQuit.Enabled = false;
            }
            else
            {
                MessageBox.Show("用户名或密码不正确");
                textBoxLogin_password.Text = "";
                textBoxLogin_Username.Text = "";
                textBoxLogin_Username.Enabled = true;
                textBoxLogin_password.Enabled = true;
                buttonLogin_Login.Enabled = true;
                buttonLogin_Reset.Enabled = true;
                return;
            }
        }

        private void buttonLogin_Reset_Click(object sender, EventArgs e)
        {
            textBoxLogin_password.Text = "";
            textBoxLogin_Username.Text = "";
        }

        private string SHA256(string str)
        {
            SHA256 sha256 = new SHA256CryptoServiceProvider();
            byte[] source = Encoding.Default.GetBytes(str);
            byte[] crypto = sha256.ComputeHash(source);
            return Convert.ToBase64String(crypto);
        }

        private bool IsThisAValuadUserName(string str)
        {
            char[] chars = str.ToLower().ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                int c = chars[i];
                if (!((c >= 'a' && c <= 'z') || (c >= '0' && c <= '9') || c == '-' || c == '_'))
                    return false;
            }
            return true;
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            var temp = MessageBox.Show("您确定要退出本系统？", "退出确认", MessageBoxButtons.OKCancel);
            if (temp.HasFlag(DialogResult.OK))
                this.Dispose();
        }

        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlMain.SelectedTab != null && tabControlMain.SelectedTab.Text.Equals("工作人员管理"))
            {
                listBoxWorkers_Refresh();
                this.AcceptButton = buttonWorker_OK;
            }
            else if (tabControlMain.SelectedTab != null && tabControlMain.SelectedTab.Text.Equals("系统登录"))
            {
                this.AcceptButton = buttonLogin_Login;
            }
            else if (tabControlMain.SelectedTab != null && tabControlMain.SelectedTab.Text.Equals("供货商管理"))
            {
                listBoxProvider_Refresh();
                this.AcceptButton = buttonProvider_OK;
            }
            else if (tabControlMain.SelectedTab != null && tabControlMain.SelectedTab.Text.Equals("商品管理"))
            {
                listBoxGoods_Refresh();
                this.AcceptButton = buttonGoods_OK;
                comboBoxGoods_Provider_Refresh();
            }
        }

        private void listBoxWorkers_Refresh()
        {
            listBoxWorkers.Items.Clear();
            var AllUsers = DAL.User_GetAll();
            foreach (DAL.UserInfo info in AllUsers)
            {
                listBoxWorkers.Items.Add(info);
            }
        }

        private void listBoxWorkers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxWorkers.SelectedItem == null)
                return;
            textBoxWorker_ID.Text = ((DAL.UserInfo)listBoxWorkers.SelectedItem).UserID;
            textBoxWorker_Name.Text = ((DAL.UserInfo)listBoxWorkers.SelectedItem).Name;
            textBoxWorker_Phone.Text = ((DAL.UserInfo)listBoxWorkers.SelectedItem).Phone;
            textBoxWorker_Username.Text = ((DAL.UserInfo)listBoxWorkers.SelectedItem).Username;
            if (((DAL.UserInfo)listBoxWorkers.SelectedItem).IsAdmin)
            {
                radioButtonWorker_TypeAdmin.Checked = true;
                radioButtonWorker_TypeUser.Checked = false;
            }
            else
            {
                radioButtonWorker_TypeAdmin.Checked = false;
                radioButtonWorker_TypeUser.Checked = true;
            }
        }

        private void radioButtonWorker_Type_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonWorker_TypeAdmin.Checked)
            {
                radioButtonWorker_TypeUser.Checked = false;
            }
            else
            {
                radioButtonWorker_TypeAdmin.Checked = false;
            }
        }

        private void buttonWorker_Delete_Click(object sender, EventArgs e)
        {
            DAL.User_Delate(((DAL.UserInfo)listBoxWorkers.SelectedItem).Username);
            listBoxWorkers_Refresh();
            Worker_SetTextBox(false, false);
        }

        private void buttonWorker_Add_Click(object sender, EventArgs e)
        {
            Worker_SetTextBox(false, false);
            Worker_SetTextBox(true, true);
        }

        private void buttonWorker_Edit_Click(object sender, EventArgs e)
        {
            if (listBoxWorkers.SelectedItem == null)
            {
                MessageBox.Show("请选择要修改的用户");
                return;
            }
            Worker_SetTextBox(true, false);
        }

        private void buttonWorker_OK_Click(object sender, EventArgs e)
        {
            if (textBoxWorker_Username.Enabled)
            {
                if (textBoxWorker_Username.Text == "" || textBoxWorker_ID.Text == "" || textBoxWorker_Name.Text == "" || textBoxWorker_Phone.Text == "" || textBoxWorker_Password.Text == "" || textBoxWorker_PasswordRepeat.Text == "")
                {
                    MessageBox.Show("所有选项不能为空");
                    return;
                }
                if (!textBoxWorker_Password.Text.Equals(textBoxWorker_PasswordRepeat.Text))
                {
                    MessageBox.Show("两次输入的密码不一致");
                    textBoxWorker_PasswordRepeat.Text = "";
                    textBoxWorker_Password.Text = "";
                    return;
                }
                if (!IsThisAValuadUserName(textBoxWorker_Username.Text))
                {
                    MessageBox.Show("用户名只能包含大小写字母、数字和下划线，不得超过10位。");
                    textBoxWorker_PasswordRepeat.Text = "";
                    textBoxWorker_Password.Text = "";
                    return;
                }
                DAL.UserInfo temp = new DAL.UserInfo(textBoxWorker_ID.Text, textBoxWorker_Username.Text, SHA256(textBoxWorker_Password.Text), textBoxWorker_Name.Text, textBoxWorker_Phone.Text, radioButtonWorker_TypeAdmin.Checked);
                DAL.User_Add(temp);
                listBoxWorkers_Refresh();
                Worker_SetTextBox(false);
            }
            else
            {
                if (textBoxWorker_Username.Text == "" || textBoxWorker_ID.Text == "" || textBoxWorker_Name.Text == "" || textBoxWorker_Phone.Text == "")
                {
                    MessageBox.Show("所有选项不能为空");
                    return;
                }
                if (!textBoxWorker_Password.Text.Equals(""))
                {
                    if (!textBoxWorker_Password.Text.Equals(textBoxWorker_PasswordRepeat.Text))
                    {
                        MessageBox.Show("两次输入的密码不一致");
                        textBoxWorker_PasswordRepeat.Text = "";
                        textBoxWorker_Password.Text = "";
                        return;
                    }
                    DAL.UserInfo temp = new DAL.UserInfo(textBoxWorker_ID.Text, textBoxWorker_Username.Text, SHA256(textBoxWorker_Password.Text), textBoxWorker_Name.Text, textBoxWorker_Phone.Text, radioButtonWorker_TypeAdmin.Checked);
                    DAL.User_Edit(temp);
                    listBoxWorkers_Refresh();
                    Worker_SetTextBox(false);
                }
                else
                {
                    DAL.UserInfo temp = new DAL.UserInfo(textBoxWorker_ID.Text, textBoxWorker_Username.Text, null, textBoxWorker_Name.Text, textBoxWorker_Phone.Text, radioButtonWorker_TypeAdmin.Checked);
                    DAL.User_Edit(temp);
                    listBoxWorkers_Refresh();
                    Worker_SetTextBox(false);
                }
            }
        }

        private void buttonWorker_Cancel_Click(object sender, EventArgs e)
        {
            Worker_SetTextBox(false);
        }

        private void Worker_SetTextBox(bool enable, bool SetUsername = false)
        {
            if (enable)
            {
                if (SetUsername)
                    textBoxWorker_Username.Enabled = true;
                textBoxWorker_ID.Enabled = true;
                textBoxWorker_Name.Enabled = true;
                textBoxWorker_Phone.Enabled = true;
                textBoxWorker_PasswordRepeat.Enabled = true;
                textBoxWorker_Password.Enabled = true;
                radioButtonWorker_TypeAdmin.Enabled = true;
                radioButtonWorker_TypeUser.Enabled = true;
                buttonWorker_OK.Enabled = true;
                buttonWorker_Cancel.Enabled = true;
                buttonWorker_Add.Enabled = false;
                buttonWorker_Edit.Enabled = false;
                buttonWorker_Delete.Enabled = false;
            }
            else
            {
                textBoxWorker_ID.Text = "";
                textBoxWorker_Name.Text = "";
                textBoxWorker_Phone.Text = "";
                textBoxWorker_Username.Text = "";
                textBoxWorker_PasswordRepeat.Text = "";
                textBoxWorker_Password.Text = "";
                radioButtonWorker_TypeUser.Checked = true;
                textBoxWorker_ID.Enabled = false;
                textBoxWorker_Name.Enabled = false;
                textBoxWorker_Phone.Enabled = false;
                textBoxWorker_Username.Enabled = false;
                textBoxWorker_PasswordRepeat.Enabled = false;
                textBoxWorker_Password.Enabled = false;
                radioButtonWorker_TypeAdmin.Enabled = false;
                radioButtonWorker_TypeUser.Enabled = false;
                buttonWorker_OK.Enabled = false;
                buttonWorker_Cancel.Enabled = false;
                buttonWorker_Add.Enabled = true;
                buttonWorker_Edit.Enabled = true;
                buttonWorker_Delete.Enabled = true;
                listBoxWorkers.SelectedIndex = -1;
            }
        }

        private void buttonProvider_Delete_Click(object sender, EventArgs e)
        {
            DAL.Provider_Delate(((DAL.ProviderInfo)listBoxProvider.SelectedItem).ProviderID);
            listBoxProvider_Refresh();
            Provider_SetTextBox(false);
        }

        private void listBoxProvider_Refresh()
        {
            listBoxProvider.Items.Clear();
            var AllProviders = DAL.Provider_GetAll();
            foreach (DAL.ProviderInfo info in AllProviders)
            {
                listBoxProvider.Items.Add(info);
            }
        }

        private void listBoxProvider_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxProvider.SelectedItem == null)
                return;
            textBoxProvider_ID.Text = ((DAL.ProviderInfo)listBoxProvider.SelectedItem).ProviderID.ToString();
            textBoxProvider_Name.Text = ((DAL.ProviderInfo)listBoxProvider.SelectedItem).Name;
            textBoxProvider_Phone.Text = ((DAL.ProviderInfo)listBoxProvider.SelectedItem).Phone;
            textBoxProvider_Address.Text = ((DAL.ProviderInfo)listBoxProvider.SelectedItem).Address;
        }

        private void buttonProvider_Add_Click(object sender, EventArgs e)
        {
            Provider_SetTextBox(false);
            Provider_SetTextBox(true);
        }

        private void buttonProvider_Edit_Click(object sender, EventArgs e)
        {
            if (listBoxProvider.SelectedItem == null)
            {
                MessageBox.Show("请选择要修改的供货商");
                return;
            }
            Provider_SetTextBox(true);
        }

        private void buttonProvider_OK_Click(object sender, EventArgs e)
        {
            if (textBoxProvider_Name.Text == "" || textBoxProvider_Phone.Text == "" || textBoxProvider_Address.Text == "")
            {
                MessageBox.Show("所有选项不能为空");
                return;
            }
            if (textBoxProvider_ID.Text.Equals(""))
            {
                DAL.ProviderInfo temp = new DAL.ProviderInfo(-1, textBoxProvider_Name.Text, textBoxProvider_Phone.Text, textBoxProvider_Address.Text);
                DAL.Provider_Add(temp);
                listBoxProvider_Refresh();
                Provider_SetTextBox(false);
            }
            else
            {
                DAL.ProviderInfo temp = new DAL.ProviderInfo(Convert.ToInt32(textBoxProvider_ID.Text), textBoxProvider_Name.Text, textBoxProvider_Phone.Text, textBoxProvider_Address.Text);
                DAL.Provider_Edit(temp);
                listBoxProvider_Refresh();
                Provider_SetTextBox(false);
            }
        }

        private void buttonProvider_Cancel_Click(object sender, EventArgs e)
        {
            Provider_SetTextBox(false);
        }

        private void Provider_SetTextBox(bool enable)
        {
            if (enable)
            {
                textBoxProvider_Address.Enabled = true;
                textBoxProvider_Name.Enabled = true;
                textBoxProvider_Phone.Enabled = true;
                buttonProvider_OK.Enabled = true;
                buttonProvider_Cancel.Enabled = true;
                buttonProvider_Add.Enabled = false;
                buttonProvider_Edit.Enabled = false;
                buttonProvider_Delete.Enabled = false;
            }
            else
            {
                textBoxProvider_Address.Text = "";
                textBoxProvider_Name.Text = "";
                textBoxProvider_Phone.Text = "";
                textBoxProvider_ID.Text = "";
                textBoxProvider_Address.Enabled = false;
                textBoxProvider_Name.Enabled = false;
                textBoxProvider_Phone.Enabled = false;
                buttonProvider_OK.Enabled = false;
                buttonProvider_Cancel.Enabled = false;
                buttonProvider_Add.Enabled = true;
                buttonProvider_Edit.Enabled = true;
                buttonProvider_Delete.Enabled = true;
                listBoxProvider.SelectedIndex = -1;
            }
        }

        private void listBoxGoods_Refresh()
        {
            listBoxGoods.Items.Clear();
            var AllGoods = DAL.Goods_GetAll();
            foreach (DAL.GoodsInfo info in AllGoods)
            {
                listBoxGoods.Items.Add(info);
            }
        }

        private void comboBoxGoods_Provider_Refresh()
        {
            comboBoxGoods_Provider.Items.Clear();
            var AllProviders = DAL.Provider_GetAll();
            foreach (DAL.ProviderInfo info in AllProviders)
            {
                comboBoxGoods_Provider.Items.Add(info);
            }
        }

        private void buttonGoods_Delete_Click(object sender, EventArgs e)
        {
            DAL.Goods_Delate(((DAL.GoodsInfo)listBoxGoods.SelectedItem).GoodsID);
            listBoxGoods_Refresh();
            Goods_SetTextBox(false);
        }

        private void Goods_SetTextBox(bool enable)
        {
            if (enable)
            {
                textBoxGoods_Price.Enabled = true;
                textBoxGoods_Name.Enabled = true;
                comboBoxGoods_Provider.Enabled = true;
                buttonGoods_OK.Enabled = true;
                buttonGoods_Cancel.Enabled = true;
                buttonGoods_Add.Enabled = false;
                buttonGoods_Edit.Enabled = false;
                buttonGoods_Delete.Enabled = false;
            }
            else
            {
                textBoxGoods_Price.Text = "";
                textBoxGoods_Name.Text = "";
                textBoxGoods_ID.Text = "";
                comboBoxGoods_Provider.SelectedIndex = 0;
                textBoxGoods_Price.Enabled = false;
                textBoxGoods_Name.Enabled = false;
                comboBoxGoods_Provider.Enabled = false;
                buttonGoods_OK.Enabled = false;
                buttonGoods_Cancel.Enabled = false;
                buttonGoods_Add.Enabled = true;
                buttonGoods_Edit.Enabled = true;
                buttonGoods_Delete.Enabled = true;
                listBoxGoods.SelectedIndex = -1;
            }
        }

        private void buttonGoods_Add_Click(object sender, EventArgs e)
        {
            Goods_SetTextBox(false);
            Goods_SetTextBox(true);
        }

        private void buttonGoods_Edit_Click(object sender, EventArgs e)
        {
            if (listBoxGoods.SelectedItem == null)
            {
                MessageBox.Show("请选择要修改的商品");
                return;
            }
            Goods_SetTextBox(true);
        }

        private void buttonGoods_OK_Click(object sender, EventArgs e)
        {
            if (textBoxGoods_Name.Text == "" || textBoxGoods_Price.Text == "" || comboBoxGoods_Provider.SelectedIndex < 0)
            {
                MessageBox.Show("所有选项不能为空");
                return;
            }
            if (textBoxGoods_ID.Text.Equals(""))
            {
                DAL.GoodsInfo temp = new DAL.GoodsInfo(-1, textBoxGoods_Name.Text, ((DAL.ProviderInfo)comboBoxGoods_Provider.SelectedItem).ProviderID, Convert.ToDouble(textBoxGoods_Price.Text));
                DAL.Goods_Add(temp);
                listBoxGoods_Refresh();
                Goods_SetTextBox(false);
            }
            else
            {
                DAL.GoodsInfo temp = new DAL.GoodsInfo(Convert.ToInt32(textBoxGoods_ID.Text), textBoxGoods_Name.Text, ((DAL.ProviderInfo)comboBoxGoods_Provider.SelectedItem).ProviderID, Convert.ToDouble(textBoxGoods_Price.Text));
                DAL.Goods_Edit(temp);
                listBoxGoods_Refresh();
                Goods_SetTextBox(false);
            }
        }

        private void buttonGoods_Cancel_Click(object sender, EventArgs e)
        {
            Goods_SetTextBox(false);
        }

        private void listBoxGoods_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxGoods.SelectedItem == null)
                return;
            textBoxGoods_ID.Text = ((DAL.GoodsInfo)listBoxGoods.SelectedItem).GoodsID.ToString();
            textBoxGoods_Name.Text = ((DAL.GoodsInfo)listBoxGoods.SelectedItem).Name;
            textBoxGoods_Price.Text = ((DAL.GoodsInfo)listBoxGoods.SelectedItem).Price.ToString();
            int i = 0;
            foreach (DAL.ProviderInfo provider in comboBoxGoods_Provider.Items)
            {
                if (provider.ProviderID == ((DAL.GoodsInfo)listBoxGoods.SelectedItem).ProviderID)
                    comboBoxGoods_Provider.SelectedIndex = i;
                i++;
            }
        }

        private void buttonGoods_ProviderDetail_Click(object sender, EventArgs e)
        {
            var temp = ((DAL.ProviderInfo)comboBoxGoods_Provider.SelectedItem);
            if (temp == null)
                return;
            MessageBox.Show("供货商名称：" + temp.Name + Environment.NewLine + "地址：" + temp.Address + Environment.NewLine + "电话：" + temp.Phone + Environment.NewLine + "编号：" + temp.ProviderID.ToString(), "供货商信息");
        }

        private void buttonPurchase_Delete_Click(object sender, EventArgs e)
        {
            if (listBoxPurchase_GoodsList.SelectedIndex != -1)
            {
                listBoxPurchase_GoodsList.Items.RemoveAt(listBoxPurchase_GoodsList.SelectedIndex);
                listBoxPurchase_RFIDList.Items.Clear();
                labelPurchaseCount.Text = "";
            }
        }

        private void buttonPurchase_Add_Click(object sender, EventArgs e)
        {
            groupBoxPurchase_Add.Location = groupBoxPurchase_Detail.Location;
            groupBoxPurchase_Add.Visible = true;
            groupBoxPurchase_Add.Enabled = true;
            groupBoxPurchase_Detail.Visible = false;
            groupBoxPurchase_Detail.Enabled = false;
            textBoxPurchase_AddGoodsFindByRFID.Text = "";
            textBoxPurchase_AddGoodsFindByName.Text = "";

            listBoxPurchase_AllGoods.Items.Clear();
            var AllGoods = DAL.Goods_GetAll();
            foreach (DAL.GoodsInfo info in AllGoods)
            {
                listBoxPurchase_AllGoods.Items.Add(info);
            }
        }

        private void buttonPurchase_Commit_Click(object sender, EventArgs e)
        {
            ArrayList PurchaseGoods = new ArrayList();
            foreach (BLL.PurchaseGoods goods in listBoxPurchase_GoodsList.Items)
            {
                if (goods.RFIDlist.Count > 0)
                {
                    PurchaseGoods.Add(goods);
                }
            }
            if(PurchaseGoods.Count>0)
            {
                BLL.Purchase(PurchaseGoods);
            }
            listBoxPurchase_GoodsList.Items.Clear();
            listBoxPurchase_RFIDList.Items.Clear();
            labelPurchaseCount.Text = "";
            textBoxPurchase_RFID.Text = "";
            groupBoxPurchase_Detail.Visible = false;
            groupBoxPurchase_Detail.Enabled = false;
        }

        private void buttonPurchase_AddGoodsOK_Click(object sender, EventArgs e)
        {
            if (listBoxPurchase_AllGoods.SelectedIndex != -1)
            {
                listBoxPurchase_GoodsList.Items.Add(new BLL.PurchaseGoods((DAL.GoodsInfo)listBoxPurchase_AllGoods.SelectedItem));
                groupBoxPurchase_Add.Visible = false;
                groupBoxPurchase_Add.Enabled = false;
            }
        }

        private void buttonPurchase_AddGoodsFindByName_Click(object sender, EventArgs e)
        {
            listBoxPurchase_AllGoods.Items.Clear();
            var AllGoods = DAL.Goods_Get(-1, textBoxPurchase_AddGoodsFindByName.Text);
            foreach (DAL.GoodsInfo info in AllGoods)
            {
                listBoxPurchase_AllGoods.Items.Add(info);
            }
        }

        private void buttonPurchase_AddGoodsFindByRFID_Click(object sender, EventArgs e)
        {
            this.AcceptButton = buttonPurchase_AddGoodsOK;
            listBoxPurchase_AllGoods.Items.Clear();
            int GoodsID = DAL.Stock_Get(Convert.ToInt32(textBoxPurchase_AddGoodsFindByRFID.Text));
            var AllGoods = DAL.Goods_Get(GoodsID, "");
            foreach (DAL.GoodsInfo info in AllGoods)
            {
                listBoxPurchase_AllGoods.Items.Add(info);
            }
        }

        private void buttonPurchase_AddGoodsReset_Click(object sender, EventArgs e)
        {
            listBoxPurchase_AllGoods.Items.Clear();
            textBoxPurchase_AddGoodsFindByRFID.Text = "";
            textBoxPurchase_AddGoodsFindByName.Text = "";
            var AllGoods = DAL.Goods_Get(-1, textBoxPurchase_AddGoodsFindByName.Text);
            foreach (DAL.GoodsInfo info in AllGoods)
            {
                listBoxPurchase_AllGoods.Items.Add(info);
            }
        }

        private void textBoxPurchase_AddGoodsFindByRFID_Click(object sender, EventArgs e)
        {
            this.AcceptButton = buttonPurchase_AddGoodsFindByRFID;
        }

        private void listBoxPurchase_GoodsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxPurchase_GoodsList.SelectedIndex == -1)
                return;
            groupBoxPurchase_Add.Visible = false;
            groupBoxPurchase_Add.Enabled = false;
            groupBoxPurchase_Detail.Visible = true;
            groupBoxPurchase_Detail.Enabled = true;

            listBoxPurchase_RFIDList.Items.Clear();
            labelPurchaseCount.Text = ((BLL.PurchaseGoods)listBoxPurchase_GoodsList.SelectedItem).RFIDlist.Count.ToString();
            foreach (int rfid in ((BLL.PurchaseGoods)listBoxPurchase_GoodsList.SelectedItem).RFIDlist)
            {
                listBoxPurchase_RFIDList.Items.Add(rfid);
            }
            textBoxPurchase_RFID.Text = "";
            textBoxPurchase_RFID.Focus();
        }

        private void textBoxPurchase_RFID_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPurchase_RFID.Text.Length == 10)
            {
                try
                {
                    int RFID = Convert.ToInt32(textBoxPurchase_RFID.Text);
                    if (DAL.Stock_Get(RFID) != -1)
                    {
                        MessageBox.Show("此标签已存在。");
                        MessageBox.Show("此标签已存在。");
                        textBoxPurchase_RFID.Text = "";
                        return;
                    }
                    foreach (BLL.PurchaseGoods goods in listBoxPurchase_GoodsList.Items)
                    {
                        foreach (int rfid in goods.RFIDlist)
                        {
                            if (rfid == RFID)
                            {
                                MessageBox.Show("此标签已存在。");
                                MessageBox.Show("此标签已存在。");
                                textBoxPurchase_RFID.Text = "";
                                return;
                            }
                        }
                    }
                    ((BLL.PurchaseGoods)listBoxPurchase_GoodsList.SelectedItem).RFIDlist.Add(RFID);
                    labelPurchaseCount.Text = ((BLL.PurchaseGoods)listBoxPurchase_GoodsList.SelectedItem).RFIDlist.Count.ToString();
                    listBoxPurchase_RFIDList.Items.Add(RFID);
                    textBoxPurchase_RFID.Text = "";
                    var temp = (BLL.PurchaseGoods)listBoxPurchase_GoodsList.SelectedItem;
                    listBoxPurchase_GoodsList.Items.RemoveAt(listBoxPurchase_GoodsList.SelectedIndex);
                    listBoxPurchase_GoodsList.Items.Insert(0, temp);
                    listBoxPurchase_GoodsList.SelectedIndex = 0;
                }
                catch (FormatException)
                {
                    MessageBox.Show("非法编号，请检查扫描器和键盘。");
                    textBoxPurchase_RFID.Text = "";
                }
            }
        }

        private void listBoxPurchase_RFIDList_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxPurchase_RFIDList.SelectedIndex != -1)
            {
                ((BLL.PurchaseGoods)listBoxPurchase_GoodsList.SelectedItem).RFIDlist.Remove((int)listBoxPurchase_RFIDList.SelectedItem);
                labelPurchaseCount.Text = ((BLL.PurchaseGoods)listBoxPurchase_GoodsList.SelectedItem).RFIDlist.Count.ToString();
                listBoxPurchase_RFIDList.Items.RemoveAt(listBoxPurchase_RFIDList.SelectedIndex);
            }
            var temp = (BLL.PurchaseGoods)listBoxPurchase_GoodsList.SelectedItem;
            listBoxPurchase_GoodsList.Items.RemoveAt(listBoxPurchase_GoodsList.SelectedIndex);
            listBoxPurchase_GoodsList.Items.Insert(0, temp);
            listBoxPurchase_GoodsList.SelectedIndex = 0;
            textBoxPurchase_RFID.Focus();
        }
    }
}
