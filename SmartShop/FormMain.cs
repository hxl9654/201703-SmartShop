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
            textBoxWorker_ID.Text = "";
            textBoxWorker_Name.Text = "";
            textBoxWorker_Phone.Text = "";
            textBoxWorker_Username.Text = "";
            textBoxWorker_PasswordRepeat.Text = "";
            textBoxWorker_Password.Text = "";
            radioButtonWorker_TypeUser.Checked = true;
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
    }
}
