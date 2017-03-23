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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxProvider_Name = new System.Windows.Forms.TextBox();
            this.buttonProvider_OK = new System.Windows.Forms.Button();
            this.buttonProvider_Cancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxProvider_Address = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxProvider_Phone = new System.Windows.Forms.TextBox();
            this.textBoxProvider_ID = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonProvider_Add = new System.Windows.Forms.Button();
            this.listBoxProvider = new System.Windows.Forms.ListBox();
            this.buttonProvider_Delete = new System.Windows.Forms.Button();
            this.buttonProvider_Edit = new System.Windows.Forms.Button();
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBoxGoods_ID = new System.Windows.Forms.TextBox();
            this.buttonGoods_ProviderDetail = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.comboBoxGoods_Provider = new System.Windows.Forms.ComboBox();
            this.textBoxGoods_Name = new System.Windows.Forms.TextBox();
            this.buttonGoods_OK = new System.Windows.Forms.Button();
            this.buttonGoods_Cancel = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxGoods_Price = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.buttonGoods_Add = new System.Windows.Forms.Button();
            this.listBoxGoods = new System.Windows.Forms.ListBox();
            this.buttonGoods_Delete = new System.Windows.Forms.Button();
            this.buttonGoods_Edit = new System.Windows.Forms.Button();
            this.tabPagePurchase = new System.Windows.Forms.TabPage();
            this.tabPageSell = new System.Windows.Forms.TabPage();
            this.tabPageInventory = new System.Windows.Forms.TabPage();
            this.tabPagePurchaseStatistics = new System.Windows.Forms.TabPage();
            this.tabPageSellStatistics = new System.Windows.Forms.TabPage();
            this.groupBoxPurchase_Detail = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.buttonPurchase_Add = new System.Windows.Forms.Button();
            this.listBoxPurchase_GoodsList = new System.Windows.Forms.ListBox();
            this.buttonPurchase_Delete = new System.Windows.Forms.Button();
            this.buttonPurchase_Commit = new System.Windows.Forms.Button();
            this.listBoxPurchase_RFIDList = new System.Windows.Forms.ListBox();
            this.textBoxPurchase_RFID = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.labelPurchaseCount = new System.Windows.Forms.Label();
            this.groupBoxPurchase_Add = new System.Windows.Forms.GroupBox();
            this.buttonPurchase_AddGoodsOK = new System.Windows.Forms.Button();
            this.listBoxPurchase_AllGoods = new System.Windows.Forms.ListBox();
            this.buttonPurchase_AddGoodsFindByName = new System.Windows.Forms.Button();
            this.textBoxPurchase_AddGoodsFindByName = new System.Windows.Forms.TextBox();
            this.textBoxPurchase_AddGoodsFindByRFID = new System.Windows.Forms.TextBox();
            this.buttonPurchase_AddGoodsFindByRFID = new System.Windows.Forms.Button();
            this.buttonPurchase_AddGoodsReset = new System.Windows.Forms.Button();
            this.tabControlMain.SuspendLayout();
            this.tabPageLogin.SuspendLayout();
            this.tabPageProviderManage.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPageWorkerManage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPageGoodsManage.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabPagePurchase.SuspendLayout();
            this.groupBoxPurchase_Detail.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBoxPurchase_Add.SuspendLayout();
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
            this.tabControlMain.Multiline = true;
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
            this.tabPageProviderManage.Controls.Add(this.groupBox3);
            this.tabPageProviderManage.Controls.Add(this.groupBox4);
            this.tabPageProviderManage.Location = new System.Drawing.Point(4, 22);
            this.tabPageProviderManage.Name = "tabPageProviderManage";
            this.tabPageProviderManage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProviderManage.Size = new System.Drawing.Size(587, 403);
            this.tabPageProviderManage.TabIndex = 0;
            this.tabPageProviderManage.Text = "供货商管理";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxProvider_Name);
            this.groupBox3.Controls.Add(this.buttonProvider_OK);
            this.groupBox3.Controls.Add(this.buttonProvider_Cancel);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.textBoxProvider_Address);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.textBoxProvider_Phone);
            this.groupBox3.Controls.Add(this.textBoxProvider_ID);
            this.groupBox3.Location = new System.Drawing.Point(311, 77);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(178, 249);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "详细信息";
            // 
            // textBoxProvider_Name
            // 
            this.textBoxProvider_Name.Enabled = false;
            this.textBoxProvider_Name.Location = new System.Drawing.Point(60, 16);
            this.textBoxProvider_Name.MaxLength = 10;
            this.textBoxProvider_Name.Multiline = true;
            this.textBoxProvider_Name.Name = "textBoxProvider_Name";
            this.textBoxProvider_Name.Size = new System.Drawing.Size(112, 60);
            this.textBoxProvider_Name.TabIndex = 13;
            // 
            // buttonProvider_OK
            // 
            this.buttonProvider_OK.Enabled = false;
            this.buttonProvider_OK.Location = new System.Drawing.Point(10, 210);
            this.buttonProvider_OK.Name = "buttonProvider_OK";
            this.buttonProvider_OK.Size = new System.Drawing.Size(78, 30);
            this.buttonProvider_OK.TabIndex = 4;
            this.buttonProvider_OK.Text = "确定";
            this.buttonProvider_OK.UseVisualStyleBackColor = true;
            this.buttonProvider_OK.Click += new System.EventHandler(this.buttonProvider_OK_Click);
            // 
            // buttonProvider_Cancel
            // 
            this.buttonProvider_Cancel.Enabled = false;
            this.buttonProvider_Cancel.Location = new System.Drawing.Point(94, 210);
            this.buttonProvider_Cancel.Name = "buttonProvider_Cancel";
            this.buttonProvider_Cancel.Size = new System.Drawing.Size(78, 30);
            this.buttonProvider_Cancel.TabIndex = 5;
            this.buttonProvider_Cancel.Text = "取消";
            this.buttonProvider_Cancel.UseVisualStyleBackColor = true;
            this.buttonProvider_Cancel.Click += new System.EventHandler(this.buttonProvider_Cancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 15F);
            this.label4.Location = new System.Drawing.Point(6, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "名称";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 15F);
            this.label12.Location = new System.Drawing.Point(6, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 20);
            this.label12.TabIndex = 7;
            this.label12.Text = "编号";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 15F);
            this.label13.Location = new System.Drawing.Point(6, 110);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 20);
            this.label13.TabIndex = 8;
            this.label13.Text = "电话";
            // 
            // textBoxProvider_Address
            // 
            this.textBoxProvider_Address.Enabled = false;
            this.textBoxProvider_Address.Location = new System.Drawing.Point(60, 136);
            this.textBoxProvider_Address.MaxLength = 16;
            this.textBoxProvider_Address.Multiline = true;
            this.textBoxProvider_Address.Name = "textBoxProvider_Address";
            this.textBoxProvider_Address.Size = new System.Drawing.Size(112, 68);
            this.textBoxProvider_Address.TabIndex = 16;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 15F);
            this.label14.Location = new System.Drawing.Point(6, 136);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 20);
            this.label14.TabIndex = 9;
            this.label14.Text = "地址";
            // 
            // textBoxProvider_Phone
            // 
            this.textBoxProvider_Phone.Enabled = false;
            this.textBoxProvider_Phone.Location = new System.Drawing.Point(60, 109);
            this.textBoxProvider_Phone.MaxLength = 16;
            this.textBoxProvider_Phone.Name = "textBoxProvider_Phone";
            this.textBoxProvider_Phone.Size = new System.Drawing.Size(112, 21);
            this.textBoxProvider_Phone.TabIndex = 15;
            // 
            // textBoxProvider_ID
            // 
            this.textBoxProvider_ID.Enabled = false;
            this.textBoxProvider_ID.Location = new System.Drawing.Point(60, 82);
            this.textBoxProvider_ID.MaxLength = 16;
            this.textBoxProvider_ID.Name = "textBoxProvider_ID";
            this.textBoxProvider_ID.Size = new System.Drawing.Size(112, 21);
            this.textBoxProvider_ID.TabIndex = 14;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonProvider_Add);
            this.groupBox4.Controls.Add(this.listBoxProvider);
            this.groupBox4.Controls.Add(this.buttonProvider_Delete);
            this.groupBox4.Controls.Add(this.buttonProvider_Edit);
            this.groupBox4.Location = new System.Drawing.Point(98, 77);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(207, 249);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "供货商列表";
            // 
            // buttonProvider_Add
            // 
            this.buttonProvider_Add.Location = new System.Drawing.Point(158, 95);
            this.buttonProvider_Add.Name = "buttonProvider_Add";
            this.buttonProvider_Add.Size = new System.Drawing.Size(42, 69);
            this.buttonProvider_Add.TabIndex = 4;
            this.buttonProvider_Add.Text = "添加";
            this.buttonProvider_Add.UseVisualStyleBackColor = true;
            this.buttonProvider_Add.Click += new System.EventHandler(this.buttonProvider_Add_Click);
            // 
            // listBoxProvider
            // 
            this.listBoxProvider.FormattingEnabled = true;
            this.listBoxProvider.ItemHeight = 12;
            this.listBoxProvider.Location = new System.Drawing.Point(6, 20);
            this.listBoxProvider.Name = "listBoxProvider";
            this.listBoxProvider.Size = new System.Drawing.Size(146, 220);
            this.listBoxProvider.TabIndex = 0;
            this.listBoxProvider.SelectedIndexChanged += new System.EventHandler(this.listBoxProvider_SelectedIndexChanged);
            // 
            // buttonProvider_Delete
            // 
            this.buttonProvider_Delete.Location = new System.Drawing.Point(158, 20);
            this.buttonProvider_Delete.Name = "buttonProvider_Delete";
            this.buttonProvider_Delete.Size = new System.Drawing.Size(42, 69);
            this.buttonProvider_Delete.TabIndex = 2;
            this.buttonProvider_Delete.Text = "删除";
            this.buttonProvider_Delete.UseVisualStyleBackColor = true;
            this.buttonProvider_Delete.Click += new System.EventHandler(this.buttonProvider_Delete_Click);
            // 
            // buttonProvider_Edit
            // 
            this.buttonProvider_Edit.Location = new System.Drawing.Point(158, 171);
            this.buttonProvider_Edit.Name = "buttonProvider_Edit";
            this.buttonProvider_Edit.Size = new System.Drawing.Size(42, 69);
            this.buttonProvider_Edit.TabIndex = 3;
            this.buttonProvider_Edit.Text = "修改";
            this.buttonProvider_Edit.UseVisualStyleBackColor = true;
            this.buttonProvider_Edit.Click += new System.EventHandler(this.buttonProvider_Edit_Click);
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
            this.groupBox2.Location = new System.Drawing.Point(311, 77);
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
            this.groupBox1.Location = new System.Drawing.Point(98, 77);
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
            this.tabPageGoodsManage.Controls.Add(this.groupBox5);
            this.tabPageGoodsManage.Controls.Add(this.groupBox6);
            this.tabPageGoodsManage.Location = new System.Drawing.Point(4, 22);
            this.tabPageGoodsManage.Name = "tabPageGoodsManage";
            this.tabPageGoodsManage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGoodsManage.Size = new System.Drawing.Size(587, 403);
            this.tabPageGoodsManage.TabIndex = 2;
            this.tabPageGoodsManage.Text = "商品管理";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBoxGoods_ID);
            this.groupBox5.Controls.Add(this.buttonGoods_ProviderDetail);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.comboBoxGoods_Provider);
            this.groupBox5.Controls.Add(this.textBoxGoods_Name);
            this.groupBox5.Controls.Add(this.buttonGoods_OK);
            this.groupBox5.Controls.Add(this.buttonGoods_Cancel);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.textBoxGoods_Price);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Location = new System.Drawing.Point(311, 77);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(178, 249);
            this.groupBox5.TabIndex = 24;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "详细信息";
            // 
            // textBoxGoods_ID
            // 
            this.textBoxGoods_ID.Enabled = false;
            this.textBoxGoods_ID.Location = new System.Drawing.Point(61, 182);
            this.textBoxGoods_ID.MaxLength = 16;
            this.textBoxGoods_ID.Name = "textBoxGoods_ID";
            this.textBoxGoods_ID.Size = new System.Drawing.Size(111, 21);
            this.textBoxGoods_ID.TabIndex = 22;
            // 
            // buttonGoods_ProviderDetail
            // 
            this.buttonGoods_ProviderDetail.Location = new System.Drawing.Point(94, 127);
            this.buttonGoods_ProviderDetail.Name = "buttonGoods_ProviderDetail";
            this.buttonGoods_ProviderDetail.Size = new System.Drawing.Size(75, 23);
            this.buttonGoods_ProviderDetail.TabIndex = 21;
            this.buttonGoods_ProviderDetail.Text = "详情";
            this.buttonGoods_ProviderDetail.UseVisualStyleBackColor = true;
            this.buttonGoods_ProviderDetail.Click += new System.EventHandler(this.buttonGoods_ProviderDetail_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("宋体", 15F);
            this.label18.Location = new System.Drawing.Point(144, 94);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(29, 20);
            this.label18.TabIndex = 20;
            this.label18.Text = "元";
            // 
            // comboBoxGoods_Provider
            // 
            this.comboBoxGoods_Provider.Enabled = false;
            this.comboBoxGoods_Provider.FormattingEnabled = true;
            this.comboBoxGoods_Provider.Location = new System.Drawing.Point(11, 156);
            this.comboBoxGoods_Provider.Name = "comboBoxGoods_Provider";
            this.comboBoxGoods_Provider.Size = new System.Drawing.Size(162, 20);
            this.comboBoxGoods_Provider.TabIndex = 19;
            // 
            // textBoxGoods_Name
            // 
            this.textBoxGoods_Name.Enabled = false;
            this.textBoxGoods_Name.Location = new System.Drawing.Point(60, 17);
            this.textBoxGoods_Name.MaxLength = 10;
            this.textBoxGoods_Name.Multiline = true;
            this.textBoxGoods_Name.Name = "textBoxGoods_Name";
            this.textBoxGoods_Name.Size = new System.Drawing.Size(112, 71);
            this.textBoxGoods_Name.TabIndex = 13;
            // 
            // buttonGoods_OK
            // 
            this.buttonGoods_OK.Enabled = false;
            this.buttonGoods_OK.Location = new System.Drawing.Point(10, 210);
            this.buttonGoods_OK.Name = "buttonGoods_OK";
            this.buttonGoods_OK.Size = new System.Drawing.Size(78, 30);
            this.buttonGoods_OK.TabIndex = 4;
            this.buttonGoods_OK.Text = "确定";
            this.buttonGoods_OK.UseVisualStyleBackColor = true;
            this.buttonGoods_OK.Click += new System.EventHandler(this.buttonGoods_OK_Click);
            // 
            // buttonGoods_Cancel
            // 
            this.buttonGoods_Cancel.Enabled = false;
            this.buttonGoods_Cancel.Location = new System.Drawing.Point(94, 210);
            this.buttonGoods_Cancel.Name = "buttonGoods_Cancel";
            this.buttonGoods_Cancel.Size = new System.Drawing.Size(78, 30);
            this.buttonGoods_Cancel.TabIndex = 5;
            this.buttonGoods_Cancel.Text = "取消";
            this.buttonGoods_Cancel.UseVisualStyleBackColor = true;
            this.buttonGoods_Cancel.Click += new System.EventHandler(this.buttonGoods_Cancel_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("宋体", 15F);
            this.label15.Location = new System.Drawing.Point(6, 17);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 20);
            this.label15.TabIndex = 6;
            this.label15.Text = "名称";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("宋体", 15F);
            this.label16.Location = new System.Drawing.Point(6, 95);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 20);
            this.label16.TabIndex = 7;
            this.label16.Text = "价格";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("宋体", 15F);
            this.label17.Location = new System.Drawing.Point(6, 127);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 20);
            this.label17.TabIndex = 8;
            this.label17.Text = "供货商";
            // 
            // textBoxGoods_Price
            // 
            this.textBoxGoods_Price.Enabled = false;
            this.textBoxGoods_Price.Location = new System.Drawing.Point(61, 94);
            this.textBoxGoods_Price.MaxLength = 16;
            this.textBoxGoods_Price.Name = "textBoxGoods_Price";
            this.textBoxGoods_Price.Size = new System.Drawing.Size(82, 21);
            this.textBoxGoods_Price.TabIndex = 14;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("宋体", 15F);
            this.label20.Location = new System.Drawing.Point(7, 183);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(49, 20);
            this.label20.TabIndex = 11;
            this.label20.Text = "编号";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.buttonGoods_Add);
            this.groupBox6.Controls.Add(this.listBoxGoods);
            this.groupBox6.Controls.Add(this.buttonGoods_Delete);
            this.groupBox6.Controls.Add(this.buttonGoods_Edit);
            this.groupBox6.Location = new System.Drawing.Point(98, 77);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(207, 249);
            this.groupBox6.TabIndex = 23;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "商品列表";
            // 
            // buttonGoods_Add
            // 
            this.buttonGoods_Add.Location = new System.Drawing.Point(158, 95);
            this.buttonGoods_Add.Name = "buttonGoods_Add";
            this.buttonGoods_Add.Size = new System.Drawing.Size(42, 69);
            this.buttonGoods_Add.TabIndex = 4;
            this.buttonGoods_Add.Text = "添加";
            this.buttonGoods_Add.UseVisualStyleBackColor = true;
            this.buttonGoods_Add.Click += new System.EventHandler(this.buttonGoods_Add_Click);
            // 
            // listBoxGoods
            // 
            this.listBoxGoods.FormattingEnabled = true;
            this.listBoxGoods.ItemHeight = 12;
            this.listBoxGoods.Location = new System.Drawing.Point(6, 20);
            this.listBoxGoods.Name = "listBoxGoods";
            this.listBoxGoods.Size = new System.Drawing.Size(146, 220);
            this.listBoxGoods.TabIndex = 0;
            this.listBoxGoods.SelectedIndexChanged += new System.EventHandler(this.listBoxGoods_SelectedIndexChanged);
            // 
            // buttonGoods_Delete
            // 
            this.buttonGoods_Delete.Location = new System.Drawing.Point(158, 20);
            this.buttonGoods_Delete.Name = "buttonGoods_Delete";
            this.buttonGoods_Delete.Size = new System.Drawing.Size(42, 69);
            this.buttonGoods_Delete.TabIndex = 2;
            this.buttonGoods_Delete.Text = "删除";
            this.buttonGoods_Delete.UseVisualStyleBackColor = true;
            this.buttonGoods_Delete.Click += new System.EventHandler(this.buttonGoods_Delete_Click);
            // 
            // buttonGoods_Edit
            // 
            this.buttonGoods_Edit.Location = new System.Drawing.Point(158, 171);
            this.buttonGoods_Edit.Name = "buttonGoods_Edit";
            this.buttonGoods_Edit.Size = new System.Drawing.Size(42, 69);
            this.buttonGoods_Edit.TabIndex = 3;
            this.buttonGoods_Edit.Text = "修改";
            this.buttonGoods_Edit.UseVisualStyleBackColor = true;
            this.buttonGoods_Edit.Click += new System.EventHandler(this.buttonGoods_Edit_Click);
            // 
            // tabPagePurchase
            // 
            this.tabPagePurchase.BackColor = System.Drawing.SystemColors.Control;
            this.tabPagePurchase.Controls.Add(this.groupBoxPurchase_Add);
            this.tabPagePurchase.Controls.Add(this.groupBoxPurchase_Detail);
            this.tabPagePurchase.Controls.Add(this.groupBox8);
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
            // groupBoxPurchase_Detail
            // 
            this.groupBoxPurchase_Detail.Controls.Add(this.labelPurchaseCount);
            this.groupBoxPurchase_Detail.Controls.Add(this.label22);
            this.groupBoxPurchase_Detail.Controls.Add(this.label21);
            this.groupBoxPurchase_Detail.Controls.Add(this.label19);
            this.groupBoxPurchase_Detail.Controls.Add(this.textBoxPurchase_RFID);
            this.groupBoxPurchase_Detail.Controls.Add(this.listBoxPurchase_RFIDList);
            this.groupBoxPurchase_Detail.Enabled = false;
            this.groupBoxPurchase_Detail.Location = new System.Drawing.Point(311, 77);
            this.groupBoxPurchase_Detail.Name = "groupBoxPurchase_Detail";
            this.groupBoxPurchase_Detail.Size = new System.Drawing.Size(178, 249);
            this.groupBoxPurchase_Detail.TabIndex = 26;
            this.groupBoxPurchase_Detail.TabStop = false;
            this.groupBoxPurchase_Detail.Text = "详情";
            this.groupBoxPurchase_Detail.Visible = false;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.buttonPurchase_Add);
            this.groupBox8.Controls.Add(this.listBoxPurchase_GoodsList);
            this.groupBox8.Controls.Add(this.buttonPurchase_Delete);
            this.groupBox8.Controls.Add(this.buttonPurchase_Commit);
            this.groupBox8.Location = new System.Drawing.Point(98, 77);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(207, 249);
            this.groupBox8.TabIndex = 25;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "进货单";
            // 
            // buttonPurchase_Add
            // 
            this.buttonPurchase_Add.Location = new System.Drawing.Point(158, 95);
            this.buttonPurchase_Add.Name = "buttonPurchase_Add";
            this.buttonPurchase_Add.Size = new System.Drawing.Size(42, 69);
            this.buttonPurchase_Add.TabIndex = 4;
            this.buttonPurchase_Add.Text = "添加";
            this.buttonPurchase_Add.UseVisualStyleBackColor = true;
            this.buttonPurchase_Add.Click += new System.EventHandler(this.buttonPurchase_Add_Click);
            // 
            // listBoxPurchase_GoodsList
            // 
            this.listBoxPurchase_GoodsList.FormattingEnabled = true;
            this.listBoxPurchase_GoodsList.ItemHeight = 12;
            this.listBoxPurchase_GoodsList.Location = new System.Drawing.Point(6, 20);
            this.listBoxPurchase_GoodsList.Name = "listBoxPurchase_GoodsList";
            this.listBoxPurchase_GoodsList.Size = new System.Drawing.Size(146, 220);
            this.listBoxPurchase_GoodsList.TabIndex = 0;
            this.listBoxPurchase_GoodsList.SelectedIndexChanged += new System.EventHandler(this.listBoxPurchase_GoodsList_SelectedIndexChanged);
            // 
            // buttonPurchase_Delete
            // 
            this.buttonPurchase_Delete.Location = new System.Drawing.Point(158, 20);
            this.buttonPurchase_Delete.Name = "buttonPurchase_Delete";
            this.buttonPurchase_Delete.Size = new System.Drawing.Size(42, 69);
            this.buttonPurchase_Delete.TabIndex = 2;
            this.buttonPurchase_Delete.Text = "删除";
            this.buttonPurchase_Delete.UseVisualStyleBackColor = true;
            this.buttonPurchase_Delete.Click += new System.EventHandler(this.buttonPurchase_Delete_Click);
            // 
            // buttonPurchase_Commit
            // 
            this.buttonPurchase_Commit.Location = new System.Drawing.Point(158, 171);
            this.buttonPurchase_Commit.Name = "buttonPurchase_Commit";
            this.buttonPurchase_Commit.Size = new System.Drawing.Size(42, 69);
            this.buttonPurchase_Commit.TabIndex = 3;
            this.buttonPurchase_Commit.Text = "提交";
            this.buttonPurchase_Commit.UseVisualStyleBackColor = true;
            this.buttonPurchase_Commit.Click += new System.EventHandler(this.buttonPurchase_Commit_Click);
            // 
            // listBoxPurchase_RFIDList
            // 
            this.listBoxPurchase_RFIDList.FormattingEnabled = true;
            this.listBoxPurchase_RFIDList.ItemHeight = 12;
            this.listBoxPurchase_RFIDList.Location = new System.Drawing.Point(6, 20);
            this.listBoxPurchase_RFIDList.Name = "listBoxPurchase_RFIDList";
            this.listBoxPurchase_RFIDList.Size = new System.Drawing.Size(166, 172);
            this.listBoxPurchase_RFIDList.TabIndex = 1;
            this.listBoxPurchase_RFIDList.DoubleClick += new System.EventHandler(this.listBoxPurchase_RFIDList_DoubleClick);
            // 
            // textBoxPurchase_RFID
            // 
            this.textBoxPurchase_RFID.Location = new System.Drawing.Point(99, 219);
            this.textBoxPurchase_RFID.MaxLength = 10;
            this.textBoxPurchase_RFID.Name = "textBoxPurchase_RFID";
            this.textBoxPurchase_RFID.Size = new System.Drawing.Size(73, 21);
            this.textBoxPurchase_RFID.TabIndex = 3;
            this.textBoxPurchase_RFID.TextChanged += new System.EventHandler(this.textBoxPurchase_RFID_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(4, 222);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(89, 12);
            this.label19.TabIndex = 4;
            this.label19.Text = "请扫描RFID标签";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 199);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(41, 12);
            this.label21.TabIndex = 5;
            this.label21.Text = "合计：";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(95, 199);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(77, 12);
            this.label22.TabIndex = 6;
            this.label22.Text = "个，双击删除";
            // 
            // labelPurchaseCount
            // 
            this.labelPurchaseCount.AutoSize = true;
            this.labelPurchaseCount.Location = new System.Drawing.Point(42, 199);
            this.labelPurchaseCount.Name = "labelPurchaseCount";
            this.labelPurchaseCount.Size = new System.Drawing.Size(0, 12);
            this.labelPurchaseCount.TabIndex = 7;
            // 
            // groupBoxPurchase_Add
            // 
            this.groupBoxPurchase_Add.Controls.Add(this.buttonPurchase_AddGoodsReset);
            this.groupBoxPurchase_Add.Controls.Add(this.buttonPurchase_AddGoodsFindByRFID);
            this.groupBoxPurchase_Add.Controls.Add(this.textBoxPurchase_AddGoodsFindByRFID);
            this.groupBoxPurchase_Add.Controls.Add(this.textBoxPurchase_AddGoodsFindByName);
            this.groupBoxPurchase_Add.Controls.Add(this.buttonPurchase_AddGoodsOK);
            this.groupBoxPurchase_Add.Controls.Add(this.listBoxPurchase_AllGoods);
            this.groupBoxPurchase_Add.Controls.Add(this.buttonPurchase_AddGoodsFindByName);
            this.groupBoxPurchase_Add.Enabled = false;
            this.groupBoxPurchase_Add.Location = new System.Drawing.Point(374, 6);
            this.groupBoxPurchase_Add.Name = "groupBoxPurchase_Add";
            this.groupBoxPurchase_Add.Size = new System.Drawing.Size(207, 249);
            this.groupBoxPurchase_Add.TabIndex = 27;
            this.groupBoxPurchase_Add.TabStop = false;
            this.groupBoxPurchase_Add.Text = "添加进货商品";
            this.groupBoxPurchase_Add.Visible = false;
            // 
            // buttonPurchase_AddGoodsOK
            // 
            this.buttonPurchase_AddGoodsOK.Location = new System.Drawing.Point(159, 103);
            this.buttonPurchase_AddGoodsOK.Name = "buttonPurchase_AddGoodsOK";
            this.buttonPurchase_AddGoodsOK.Size = new System.Drawing.Size(42, 77);
            this.buttonPurchase_AddGoodsOK.TabIndex = 4;
            this.buttonPurchase_AddGoodsOK.Text = "添加";
            this.buttonPurchase_AddGoodsOK.UseVisualStyleBackColor = true;
            this.buttonPurchase_AddGoodsOK.Click += new System.EventHandler(this.buttonPurchase_AddGoodsOK_Click);
            // 
            // listBoxPurchase_AllGoods
            // 
            this.listBoxPurchase_AllGoods.FormattingEnabled = true;
            this.listBoxPurchase_AllGoods.ItemHeight = 12;
            this.listBoxPurchase_AllGoods.Location = new System.Drawing.Point(6, 20);
            this.listBoxPurchase_AllGoods.Name = "listBoxPurchase_AllGoods";
            this.listBoxPurchase_AllGoods.Size = new System.Drawing.Size(147, 160);
            this.listBoxPurchase_AllGoods.TabIndex = 0;
            // 
            // buttonPurchase_AddGoodsFindByName
            // 
            this.buttonPurchase_AddGoodsFindByName.Location = new System.Drawing.Point(115, 186);
            this.buttonPurchase_AddGoodsFindByName.Name = "buttonPurchase_AddGoodsFindByName";
            this.buttonPurchase_AddGoodsFindByName.Size = new System.Drawing.Size(86, 21);
            this.buttonPurchase_AddGoodsFindByName.TabIndex = 3;
            this.buttonPurchase_AddGoodsFindByName.Text = "按名称查找";
            this.buttonPurchase_AddGoodsFindByName.UseVisualStyleBackColor = true;
            this.buttonPurchase_AddGoodsFindByName.Click += new System.EventHandler(this.buttonPurchase_AddGoodsFindByName_Click);
            // 
            // textBoxPurchase_AddGoodsFindByName
            // 
            this.textBoxPurchase_AddGoodsFindByName.Location = new System.Drawing.Point(6, 186);
            this.textBoxPurchase_AddGoodsFindByName.MaxLength = 64;
            this.textBoxPurchase_AddGoodsFindByName.Name = "textBoxPurchase_AddGoodsFindByName";
            this.textBoxPurchase_AddGoodsFindByName.Size = new System.Drawing.Size(103, 21);
            this.textBoxPurchase_AddGoodsFindByName.TabIndex = 5;
            // 
            // textBoxPurchase_AddGoodsFindByRFID
            // 
            this.textBoxPurchase_AddGoodsFindByRFID.Location = new System.Drawing.Point(6, 213);
            this.textBoxPurchase_AddGoodsFindByRFID.MaxLength = 10;
            this.textBoxPurchase_AddGoodsFindByRFID.Name = "textBoxPurchase_AddGoodsFindByRFID";
            this.textBoxPurchase_AddGoodsFindByRFID.Size = new System.Drawing.Size(103, 21);
            this.textBoxPurchase_AddGoodsFindByRFID.TabIndex = 6;
            this.textBoxPurchase_AddGoodsFindByRFID.Click += new System.EventHandler(this.textBoxPurchase_AddGoodsFindByRFID_Click);
            // 
            // buttonPurchase_AddGoodsFindByRFID
            // 
            this.buttonPurchase_AddGoodsFindByRFID.Location = new System.Drawing.Point(115, 213);
            this.buttonPurchase_AddGoodsFindByRFID.Name = "buttonPurchase_AddGoodsFindByRFID";
            this.buttonPurchase_AddGoodsFindByRFID.Size = new System.Drawing.Size(86, 21);
            this.buttonPurchase_AddGoodsFindByRFID.TabIndex = 7;
            this.buttonPurchase_AddGoodsFindByRFID.Text = "按RFID查找";
            this.buttonPurchase_AddGoodsFindByRFID.UseVisualStyleBackColor = true;
            this.buttonPurchase_AddGoodsFindByRFID.Click += new System.EventHandler(this.buttonPurchase_AddGoodsFindByRFID_Click);
            // 
            // buttonPurchase_AddGoodsReset
            // 
            this.buttonPurchase_AddGoodsReset.Location = new System.Drawing.Point(159, 20);
            this.buttonPurchase_AddGoodsReset.Name = "buttonPurchase_AddGoodsReset";
            this.buttonPurchase_AddGoodsReset.Size = new System.Drawing.Size(42, 77);
            this.buttonPurchase_AddGoodsReset.TabIndex = 8;
            this.buttonPurchase_AddGoodsReset.Text = "重置过滤";
            this.buttonPurchase_AddGoodsReset.UseVisualStyleBackColor = true;
            this.buttonPurchase_AddGoodsReset.Click += new System.EventHandler(this.buttonPurchase_AddGoodsReset_Click);
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
            this.tabPageProviderManage.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.tabPageWorkerManage.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabPageGoodsManage.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.tabPagePurchase.ResumeLayout(false);
            this.groupBoxPurchase_Detail.ResumeLayout(false);
            this.groupBoxPurchase_Detail.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBoxPurchase_Add.ResumeLayout(false);
            this.groupBoxPurchase_Add.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxProvider_Name;
        private System.Windows.Forms.Button buttonProvider_OK;
        private System.Windows.Forms.Button buttonProvider_Cancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxProvider_Address;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxProvider_Phone;
        private System.Windows.Forms.TextBox textBoxProvider_ID;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonProvider_Add;
        private System.Windows.Forms.ListBox listBoxProvider;
        private System.Windows.Forms.Button buttonProvider_Delete;
        private System.Windows.Forms.Button buttonProvider_Edit;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBoxGoods_Name;
        private System.Windows.Forms.Button buttonGoods_OK;
        private System.Windows.Forms.Button buttonGoods_Cancel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBoxGoods_Price;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button buttonGoods_Add;
        private System.Windows.Forms.ListBox listBoxGoods;
        private System.Windows.Forms.Button buttonGoods_Delete;
        private System.Windows.Forms.Button buttonGoods_Edit;
        private System.Windows.Forms.Button buttonGoods_ProviderDetail;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox comboBoxGoods_Provider;
        private System.Windows.Forms.TextBox textBoxGoods_ID;
        private System.Windows.Forms.GroupBox groupBoxPurchase_Detail;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button buttonPurchase_Add;
        private System.Windows.Forms.ListBox listBoxPurchase_GoodsList;
        private System.Windows.Forms.Button buttonPurchase_Delete;
        private System.Windows.Forms.Button buttonPurchase_Commit;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBoxPurchase_RFID;
        private System.Windows.Forms.ListBox listBoxPurchase_RFIDList;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label labelPurchaseCount;
        private System.Windows.Forms.GroupBox groupBoxPurchase_Add;
        private System.Windows.Forms.TextBox textBoxPurchase_AddGoodsFindByRFID;
        private System.Windows.Forms.TextBox textBoxPurchase_AddGoodsFindByName;
        private System.Windows.Forms.Button buttonPurchase_AddGoodsOK;
        private System.Windows.Forms.ListBox listBoxPurchase_AllGoods;
        private System.Windows.Forms.Button buttonPurchase_AddGoodsFindByName;
        private System.Windows.Forms.Button buttonPurchase_AddGoodsFindByRFID;
        private System.Windows.Forms.Button buttonPurchase_AddGoodsReset;
    }
}

