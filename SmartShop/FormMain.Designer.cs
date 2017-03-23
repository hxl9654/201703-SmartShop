namespace SmartShop
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageLogin = new System.Windows.Forms.TabPage();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLogin_Reset = new System.Windows.Forms.Button();
            this.buttonLogin_Login = new System.Windows.Forms.Button();
            this.textBoxLogin_password = new System.Windows.Forms.TextBox();
            this.textBoxLogin_Username = new System.Windows.Forms.TextBox();
            this.tabPageProviderManage = new System.Windows.Forms.TabPage();
            this.tabPageWorkerManage = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxWorker_Username = new System.Windows.Forms.TextBox();
            this.buttonWorker_OK = new System.Windows.Forms.Button();
            this.radioButtonWorker_TypeUser = new System.Windows.Forms.RadioButton();
            this.buttonWorker_Cancel = new System.Windows.Forms.Button();
            this.radioButtonWorker_TypeAdmin = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxWorker_ID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxWorker_Phone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxWorker_Name = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxWorker_PasswordRepeat = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxWorker_Password = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonWorker_Add = new System.Windows.Forms.Button();
            this.listBoxWorkers = new System.Windows.Forms.ListBox();
            this.buttonWorker_Delete = new System.Windows.Forms.Button();
            this.buttonWorker_Edit = new System.Windows.Forms.Button();
            this.tabPageGoodsManage = new System.Windows.Forms.TabPage();
            this.tabPagePurchase = new System.Windows.Forms.TabPage();
            this.tabPageSell = new System.Windows.Forms.TabPage();
            this.tabPageInventory = new System.Windows.Forms.TabPage();
            this.tabPagePurchaseStatistics = new System.Windows.Forms.TabPage();
            this.tabPageSellStatistics = new System.Windows.Forms.TabPage();
            this.tabControlMain.SuspendLayout();
            this.tabPageLogin.SuspendLayout();
            this.tabPageWorkerManage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageLogin);
            this.tabControlMain.Controls.Add(this.tabPageProviderManage);
            this.tabControlMain.Controls.Add(this.tabPageWorkerManage);
            this.tabControlMain.Controls.Add(this.tabPageGoodsManage);
            this.tabControlMain.Controls.Add(this.tabPagePurchase);
            this.tabControlMain.Controls.Add(this.tabPageSell);
            this.tabControlMain.Controls.Add(this.tabPageInventory);
            this.tabControlMain.Controls.Add(this.tabPagePurchaseStatistics);
            this.tabControlMain.Controls.Add(this.tabPageSellStatistics);
            this.tabControlMain.Location = new System.Drawing.Point(12, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(595, 429);
            this.tabControlMain.TabIndex = 0;
            this.tabControlMain.SelectedIndexChanged += new System.EventHandler(this.tabControlMain_SelectedIndexChanged);
            // 
            // tabPageLogin
            // 
            this.tabPageLogin.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageLogin.Controls.Add(this.buttonQuit);
            this.tabPageLogin.Controls.Add(this.label3);
            this.tabPageLogin.Controls.Add(this.label2);
            this.tabPageLogin.Controls.Add(this.label1);
            this.tabPageLogin.Controls.Add(this.buttonLogin_Reset);
            this.tabPageLogin.Controls.Add(this.buttonLogin_Login);
            this.tabPageLogin.Controls.Add(this.textBoxLogin_password);
            this.tabPageLogin.Controls.Add(this.textBoxLogin_Username);
            this.tabPageLogin.Location = new System.Drawing.Point(4, 22);
            this.tabPageLogin.Name = "tabPageLogin";
            this.tabPageLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLogin.Size = new System.Drawing.Size(587, 403);
            this.tabPageLogin.TabIndex = 8;
            this.tabPageLogin.Text = "系统登录";
            // 
            // buttonQuit
            // 
            this.buttonQuit.Location = new System.Drawing.Point(425, 342);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(156, 55);
            this.buttonQuit.TabIndex = 7;
            this.buttonQuit.Text = "退出系统";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "密 码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "账 号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 20F);
            this.label1.Location = new System.Drawing.Point(226, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "系统登录";
            // 
            // buttonLogin_Reset
            // 
            this.buttonLogin_Reset.Location = new System.Drawing.Point(289, 225);
            this.buttonLogin_Reset.Name = "buttonLogin_Reset";
            this.buttonLogin_Reset.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin_Reset.TabIndex = 3;
            this.buttonLogin_Reset.Text = "重置";
            this.buttonLogin_Reset.UseVisualStyleBackColor = true;
            this.buttonLogin_Reset.Click += new System.EventHandler(this.buttonLogin_Reset_Click);
            // 
            // buttonLogin_Login
            // 
            this.buttonLogin_Login.Location = new System.Drawing.Point(208, 225);
            this.buttonLogin_Login.Name = "buttonLogin_Login";
            this.buttonLogin_Login.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin_Login.TabIndex = 2;
            this.buttonLogin_Login.Text = "登录";
            this.buttonLogin_Login.UseVisualStyleBackColor = true;
            this.buttonLogin_Login.Click += new System.EventHandler(this.buttonLogin_Login_Click);
            // 
            // textBoxLogin_password
            // 
            this.textBoxLogin_password.Location = new System.Drawing.Point(247, 185);
            this.textBoxLogin_password.MaxLength = 16;
            this.textBoxLogin_password.Name = "textBoxLogin_password";
            this.textBoxLogin_password.PasswordChar = '*';
            this.textBoxLogin_password.Size = new System.Drawing.Size(117, 21);
            this.textBoxLogin_password.TabIndex = 1;
            this.textBoxLogin_password.Text = "123456";
            this.textBoxLogin_password.UseSystemPasswordChar = true;
            // 
            // textBoxLogin_Username
            // 
            this.textBoxLogin_Username.Location = new System.Drawing.Point(247, 158);
            this.textBoxLogin_Username.MaxLength = 10;
            this.textBoxLogin_Username.Name = "textBoxLogin_Username";
            this.textBoxLogin_Username.Size = new System.Drawing.Size(117, 21);
            this.textBoxLogin_Username.TabIndex = 0;
            this.textBoxLogin_Username.Text = "root";
            // 
            // tabPageProviderManage
            // 
            this.tabPageProviderManage.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageProviderManage.Location = new System.Drawing.Point(4, 22);
            this.tabPageProviderManage.Name = "tabPageProviderManage";
            this.tabPageProviderManage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProviderManage.Size = new System.Drawing.Size(587, 403);
            this.tabPageProviderManage.TabIndex = 0;
            this.tabPageProviderManage.Text = "供货商管理";
            // 
            // tabPageWorkerManage
            // 
            this.tabPageWorkerManage.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageWorkerManage.Controls.Add(this.groupBox2);
            this.tabPageWorkerManage.Controls.Add(this.groupBox1);
            this.tabPageWorkerManage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPageWorkerManage.Location = new System.Drawing.Point(4, 22);
            this.tabPageWorkerManage.Name = "tabPageWorkerManage";
            this.tabPageWorkerManage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWorkerManage.Size = new System.Drawing.Size(587, 403);
            this.tabPageWorkerManage.TabIndex = 1;
            this.tabPageWorkerManage.Text = "工作人员管理";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxWorker_Username);
            this.groupBox2.Controls.Add(this.buttonWorker_OK);
            this.groupBox2.Controls.Add(this.radioButtonWorker_TypeUser);
            this.groupBox2.Controls.Add(this.buttonWorker_Cancel);
            this.groupBox2.Controls.Add(this.radioButtonWorker_TypeAdmin);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBoxWorker_ID);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBoxWorker_Phone);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBoxWorker_Name);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBoxWorker_PasswordRepeat);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textBoxWorker_Password);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(298, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(178, 249);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "详细信息";
            // 
            // textBoxWorker_Username
            // 
            this.textBoxWorker_Username.Enabled = false;
            this.textBoxWorker_Username.Location = new System.Drawing.Point(60, 16);
            this.textBoxWorker_Username.MaxLength = 10;
            this.textBoxWorker_Username.Name = "textBoxWorker_Username";
            this.textBoxWorker_Username.Size = new System.Drawing.Size(112, 21);
            this.textBoxWorker_Username.TabIndex = 13;
            // 
            // buttonWorker_OK
            // 
            this.buttonWorker_OK.Enabled = false;
            this.buttonWorker_OK.Location = new System.Drawing.Point(10, 210);
            this.buttonWorker_OK.Name = "buttonWorker_OK";
            this.buttonWorker_OK.Size = new System.Drawing.Size(78, 30);
            this.buttonWorker_OK.TabIndex = 4;
            this.buttonWorker_OK.Text = "确定";
            this.buttonWorker_OK.UseVisualStyleBackColor = true;
            this.buttonWorker_OK.Click += new System.EventHandler(this.buttonWorker_OK_Click);
            // 
            // radioButtonWorker_TypeUser
            // 
            this.radioButtonWorker_TypeUser.AutoSize = true;
            this.radioButtonWorker_TypeUser.Checked = true;
            this.radioButtonWorker_TypeUser.Enabled = false;
            this.radioButtonWorker_TypeUser.Location = new System.Drawing.Point(125, 129);
            this.radioButtonWorker_TypeUser.Name = "radioButtonWorker_TypeUser";
            this.radioButtonWorker_TypeUser.Size = new System.Drawing.Size(47, 16);
            this.radioButtonWorker_TypeUser.TabIndex = 20;
            this.radioButtonWorker_TypeUser.TabStop = true;
            this.radioButtonWorker_TypeUser.Text = "用户";
            this.radioButtonWorker_TypeUser.UseVisualStyleBackColor = true;
            this.radioButtonWorker_TypeUser.CheckedChanged += new System.EventHandler(this.radioButtonWorker_Type_CheckedChanged);
            // 
            // buttonWorker_Cancel
            // 
            this.buttonWorker_Cancel.Enabled = false;
            this.buttonWorker_Cancel.Location = new System.Drawing.Point(94, 210);
            this.buttonWorker_Cancel.Name = "buttonWorker_Cancel";
            this.buttonWorker_Cancel.Size = new System.Drawing.Size(78, 30);
            this.buttonWorker_Cancel.TabIndex = 5;
            this.buttonWorker_Cancel.Text = "取消";
            this.buttonWorker_Cancel.UseVisualStyleBackColor = true;
            this.buttonWorker_Cancel.Click += new System.EventHandler(this.buttonWorker_Cancel_Click);
            // 
            // radioButtonWorker_TypeAdmin
            // 
            this.radioButtonWorker_TypeAdmin.AutoSize = true;
            this.radioButtonWorker_TypeAdmin.Enabled = false;
            this.radioButtonWorker_TypeAdmin.Location = new System.Drawing.Point(60, 129);
            this.radioButtonWorker_TypeAdmin.Name = "radioButtonWorker_TypeAdmin";
            this.radioButtonWorker_TypeAdmin.Size = new System.Drawing.Size(59, 16);
            this.radioButtonWorker_TypeAdmin.TabIndex = 19;
            this.radioButtonWorker_TypeAdmin.Text = "管理员";
            this.radioButtonWorker_TypeAdmin.UseVisualStyleBackColor = true;
            this.radioButtonWorker_TypeAdmin.CheckedChanged += new System.EventHandler(this.radioButtonWorker_Type_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 15F);
            this.label5.Location = new System.Drawing.Point(6, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "账号";
            // 
            // textBoxWorker_ID
            // 
            this.textBoxWorker_ID.Enabled = false;
            this.textBoxWorker_ID.Location = new System.Drawing.Point(60, 178);
            this.textBoxWorker_ID.MaxLength = 4;
            this.textBoxWorker_ID.Name = "textBoxWorker_ID";
            this.textBoxWorker_ID.Size = new System.Drawing.Size(112, 21);
            this.textBoxWorker_ID.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 15F);
            this.label6.Location = new System.Drawing.Point(6, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "密码";
            // 
            // textBoxWorker_Phone
            // 
            this.textBoxWorker_Phone.Enabled = false;
            this.textBoxWorker_Phone.Location = new System.Drawing.Point(60, 151);
            this.textBoxWorker_Phone.MaxLength = 16;
            this.textBoxWorker_Phone.Name = "textBoxWorker_Phone";
            this.textBoxWorker_Phone.Size = new System.Drawing.Size(112, 21);
            this.textBoxWorker_Phone.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 15F);
            this.label7.Location = new System.Drawing.Point(6, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "确认";
            // 
            // textBoxWorker_Name
            // 
            this.textBoxWorker_Name.Enabled = false;
            this.textBoxWorker_Name.Location = new System.Drawing.Point(60, 97);
            this.textBoxWorker_Name.MaxLength = 16;
            this.textBoxWorker_Name.Name = "textBoxWorker_Name";
            this.textBoxWorker_Name.Size = new System.Drawing.Size(112, 21);
            this.textBoxWorker_Name.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 15F);
            this.label8.Location = new System.Drawing.Point(6, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "姓名";
            // 
            // textBoxWorker_PasswordRepeat
            // 
            this.textBoxWorker_PasswordRepeat.Enabled = false;
            this.textBoxWorker_PasswordRepeat.Location = new System.Drawing.Point(60, 70);
            this.textBoxWorker_PasswordRepeat.MaxLength = 16;
            this.textBoxWorker_PasswordRepeat.Name = "textBoxWorker_PasswordRepeat";
            this.textBoxWorker_PasswordRepeat.PasswordChar = '*';
            this.textBoxWorker_PasswordRepeat.Size = new System.Drawing.Size(112, 21);
            this.textBoxWorker_PasswordRepeat.TabIndex = 15;
            this.textBoxWorker_PasswordRepeat.UseSystemPasswordChar = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 15F);
            this.label9.Location = new System.Drawing.Point(6, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "工号";
            // 
            // textBoxWorker_Password
            // 
            this.textBoxWorker_Password.Enabled = false;
            this.textBoxWorker_Password.Location = new System.Drawing.Point(60, 43);
            this.textBoxWorker_Password.MaxLength = 16;
            this.textBoxWorker_Password.Name = "textBoxWorker_Password";
            this.textBoxWorker_Password.PasswordChar = '*';
            this.textBoxWorker_Password.Size = new System.Drawing.Size(112, 21);
            this.textBoxWorker_Password.TabIndex = 14;
            this.textBoxWorker_Password.UseSystemPasswordChar = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 15F);
            this.label10.Location = new System.Drawing.Point(6, 152);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "电话";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 15F);
            this.label11.Location = new System.Drawing.Point(6, 125);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "职位";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonWorker_Add);
            this.groupBox1.Controls.Add(this.listBoxWorkers);
            this.groupBox1.Controls.Add(this.buttonWorker_Delete);
            this.groupBox1.Controls.Add(this.buttonWorker_Edit);
            this.groupBox1.Location = new System.Drawing.Point(85, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 249);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "工作人员列表";
            // 
            // buttonWorker_Add
            // 
            this.buttonWorker_Add.Location = new System.Drawing.Point(158, 95);
            this.buttonWorker_Add.Name = "buttonWorker_Add";
            this.buttonWorker_Add.Size = new System.Drawing.Size(42, 69);
            this.buttonWorker_Add.TabIndex = 4;
            this.buttonWorker_Add.Text = "添加";
            this.buttonWorker_Add.UseVisualStyleBackColor = true;
            this.buttonWorker_Add.Click += new System.EventHandler(this.buttonWorker_Add_Click);
            // 
            // listBoxWorkers
            // 
            this.listBoxWorkers.FormattingEnabled = true;
            this.listBoxWorkers.ItemHeight = 12;
            this.listBoxWorkers.Location = new System.Drawing.Point(6, 20);
            this.listBoxWorkers.Name = "listBoxWorkers";
            this.listBoxWorkers.Size = new System.Drawing.Size(146, 220);
            this.listBoxWorkers.TabIndex = 0;
            this.listBoxWorkers.SelectedIndexChanged += new System.EventHandler(this.listBoxWorkers_SelectedIndexChanged);
            // 
            // buttonWorker_Delete
            // 
            this.buttonWorker_Delete.Location = new System.Drawing.Point(158, 20);
            this.buttonWorker_Delete.Name = "buttonWorker_Delete";
            this.buttonWorker_Delete.Size = new System.Drawing.Size(42, 69);
            this.buttonWorker_Delete.TabIndex = 2;
            this.buttonWorker_Delete.Text = "删除";
            this.buttonWorker_Delete.UseVisualStyleBackColor = true;
            this.buttonWorker_Delete.Click += new System.EventHandler(this.buttonWorker_Delete_Click);
            // 
            // buttonWorker_Edit
            // 
            this.buttonWorker_Edit.Location = new System.Drawing.Point(158, 171);
            this.buttonWorker_Edit.Name = "buttonWorker_Edit";
            this.buttonWorker_Edit.Size = new System.Drawing.Size(42, 69);
            this.buttonWorker_Edit.TabIndex = 3;
            this.buttonWorker_Edit.Text = "修改";
            this.buttonWorker_Edit.UseVisualStyleBackColor = true;
            this.buttonWorker_Edit.Click += new System.EventHandler(this.buttonWorker_Edit_Click);
            // 
            // tabPageGoodsManage
            // 
            this.tabPageGoodsManage.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageGoodsManage.Location = new System.Drawing.Point(4, 22);
            this.tabPageGoodsManage.Name = "tabPageGoodsManage";
            this.tabPageGoodsManage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGoodsManage.Size = new System.Drawing.Size(587, 403);
            this.tabPageGoodsManage.TabIndex = 2;
            this.tabPageGoodsManage.Text = "商品管理";
            // 
            // tabPagePurchase
            // 
            this.tabPagePurchase.BackColor = System.Drawing.SystemColors.Control;
            this.tabPagePurchase.Location = new System.Drawing.Point(4, 22);
            this.tabPagePurchase.Name = "tabPagePurchase";
            this.tabPagePurchase.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePurchase.Size = new System.Drawing.Size(587, 403);
            this.tabPagePurchase.TabIndex = 3;
            this.tabPagePurchase.Text = "商品进货";
            // 
            // tabPageSell
            // 
            this.tabPageSell.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageSell.Location = new System.Drawing.Point(4, 22);
            this.tabPageSell.Name = "tabPageSell";
            this.tabPageSell.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSell.Size = new System.Drawing.Size(587, 403);
            this.tabPageSell.TabIndex = 4;
            this.tabPageSell.Text = "商品销售";
            // 
            // tabPageInventory
            // 
            this.tabPageInventory.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageInventory.Location = new System.Drawing.Point(4, 22);
            this.tabPageInventory.Name = "tabPageInventory";
            this.tabPageInventory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInventory.Size = new System.Drawing.Size(587, 403);
            this.tabPageInventory.TabIndex = 5;
            this.tabPageInventory.Text = "库存盘点";
            // 
            // tabPagePurchaseStatistics
            // 
            this.tabPagePurchaseStatistics.BackColor = System.Drawing.SystemColors.Control;
            this.tabPagePurchaseStatistics.Location = new System.Drawing.Point(4, 22);
            this.tabPagePurchaseStatistics.Name = "tabPagePurchaseStatistics";
            this.tabPagePurchaseStatistics.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePurchaseStatistics.Size = new System.Drawing.Size(587, 403);
            this.tabPagePurchaseStatistics.TabIndex = 6;
            this.tabPagePurchaseStatistics.Text = "进货统计";
            // 
            // tabPageSellStatistics
            // 
            this.tabPageSellStatistics.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageSellStatistics.Location = new System.Drawing.Point(4, 22);
            this.tabPageSellStatistics.Name = "tabPageSellStatistics";
            this.tabPageSellStatistics.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSellStatistics.Size = new System.Drawing.Size(587, 403);
            this.tabPageSellStatistics.TabIndex = 7;
            this.tabPageSellStatistics.Text = "销售统计";
            // 
            // FormMain
            // 
            this.AcceptButton = this.buttonLogin_Login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 441);
            this.ControlBox = false;
            this.Controls.Add(this.tabControlMain);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(635, 480);
            this.MinimumSize = new System.Drawing.Size(635, 480);
            this.Name = "FormMain";
            this.Text = "智能超市管理系统";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageLogin.ResumeLayout(false);
            this.tabPageLogin.PerformLayout();
            this.tabPageWorkerManage.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageProviderManage;
        private System.Windows.Forms.TabPage tabPageWorkerManage;
        private System.Windows.Forms.TabPage tabPageGoodsManage;
        private System.Windows.Forms.TabPage tabPagePurchase;
        private System.Windows.Forms.TabPage tabPageSell;
        private System.Windows.Forms.TabPage tabPageInventory;
        private System.Windows.Forms.TabPage tabPagePurchaseStatistics;
        private System.Windows.Forms.TabPage tabPageLogin;
        private System.Windows.Forms.TabPage tabPageSellStatistics;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLogin_Reset;
        private System.Windows.Forms.Button buttonLogin_Login;
        private System.Windows.Forms.TextBox textBoxLogin_password;
        private System.Windows.Forms.TextBox textBoxLogin_Username;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.Button buttonWorker_Cancel;
        private System.Windows.Forms.Button buttonWorker_OK;
        private System.Windows.Forms.Button buttonWorker_Edit;
        private System.Windows.Forms.Button buttonWorker_Delete;
        private System.Windows.Forms.ListBox listBoxWorkers;
        private System.Windows.Forms.RadioButton radioButtonWorker_TypeUser;
        private System.Windows.Forms.RadioButton radioButtonWorker_TypeAdmin;
        private System.Windows.Forms.TextBox textBoxWorker_ID;
        private System.Windows.Forms.TextBox textBoxWorker_Phone;
        private System.Windows.Forms.TextBox textBoxWorker_Name;
        private System.Windows.Forms.TextBox textBoxWorker_PasswordRepeat;
        private System.Windows.Forms.TextBox textBoxWorker_Password;
        private System.Windows.Forms.TextBox textBoxWorker_Username;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonWorker_Add;
    }
}

