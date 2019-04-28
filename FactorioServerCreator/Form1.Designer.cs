namespace FactorioServerCreator
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.servernameTextBox = new System.Windows.Forms.TextBox();
            this.deleteServerBtn = new System.Windows.Forms.Button();
            this.serverListView = new System.Windows.Forms.ListView();
            this.newServerBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.servSettingsPage = new System.Windows.Forms.TabPage();
            this.advSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.maxPlayerTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.autoSaveCheckBox = new System.Windows.Forms.CheckBox();
            this.autoPauseCheckBox = new System.Windows.Forms.CheckBox();
            this.pauseGameComboBox = new System.Windows.Forms.ComboBox();
            this.pauseGameLabel = new System.Windows.Forms.Label();
            this.uploadBandwidthComboBox = new System.Windows.Forms.ComboBox();
            this.uploadSlotsComboBox = new System.Windows.Forms.ComboBox();
            this.uploadBandwidthLabel = new System.Windows.Forms.Label();
            this.uploadSlotLabel = new System.Windows.Forms.Label();
            this.allowedCommandsComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.returningPlayerlimitCheckBox = new System.Windows.Forms.CheckBox();
            this.userVerificationCheckBox = new System.Windows.Forms.CheckBox();
            this.advancedSettingsToggleBtn = new System.Windows.Forms.CheckBox();
            this.startServerBtn = new System.Windows.Forms.Button();
            this.gamePasswordGroupBox = new System.Windows.Forms.GroupBox();
            this.gamePWtextBox = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.visibilityGroupBox = new System.Windows.Forms.GroupBox();
            this.lanCheckBox = new System.Windows.Forms.CheckBox();
            this.publicCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.browseExeBtn = new System.Windows.Forms.Button();
            this.factorioExePath = new System.Windows.Forms.TextBox();
            this.mapSettingsPage = new System.Windows.Forms.TabPage();
            this.navigateToExe = new System.Windows.Forms.OpenFileDialog();
            this.hintLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.servSettingsPage.SuspendLayout();
            this.advSettingsGroupBox.SuspendLayout();
            this.gamePasswordGroupBox.SuspendLayout();
            this.visibilityGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.servernameTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.deleteServerBtn);
            this.splitContainer1.Panel1.Controls.Add(this.serverListView);
            this.splitContainer1.Panel1.Controls.Add(this.newServerBtn);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(997, 577);
            this.splitContainer1.SplitterDistance = 332;
            this.splitContainer1.TabIndex = 0;
            // 
            // servernameTextBox
            // 
            this.servernameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.servernameTextBox.Location = new System.Drawing.Point(91, 553);
            this.servernameTextBox.Name = "servernameTextBox";
            this.servernameTextBox.Size = new System.Drawing.Size(157, 20);
            this.servernameTextBox.TabIndex = 3;
            this.servernameTextBox.Enter += new System.EventHandler(this.servernameTextBox_Enter);
            this.servernameTextBox.Leave += new System.EventHandler(this.servernameTextBox_Leave);
            // 
            // deleteServerBtn
            // 
            this.deleteServerBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteServerBtn.Location = new System.Drawing.Point(254, 551);
            this.deleteServerBtn.Name = "deleteServerBtn";
            this.deleteServerBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteServerBtn.TabIndex = 2;
            this.deleteServerBtn.Text = "Delete";
            this.deleteServerBtn.UseVisualStyleBackColor = true;
            this.deleteServerBtn.Click += new System.EventHandler(this.deleteServerBtn_Click);
            // 
            // serverListView
            // 
            this.serverListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serverListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.serverListView.Location = new System.Drawing.Point(4, 3);
            this.serverListView.MultiSelect = false;
            this.serverListView.Name = "serverListView";
            this.serverListView.Size = new System.Drawing.Size(326, 544);
            this.serverListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.serverListView.TabIndex = 0;
            this.serverListView.UseCompatibleStateImageBehavior = false;
            this.serverListView.View = System.Windows.Forms.View.List;
            // 
            // newServerBtn
            // 
            this.newServerBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.newServerBtn.Location = new System.Drawing.Point(3, 551);
            this.newServerBtn.Name = "newServerBtn";
            this.newServerBtn.Size = new System.Drawing.Size(82, 23);
            this.newServerBtn.TabIndex = 1;
            this.newServerBtn.Text = "New Server";
            this.newServerBtn.UseVisualStyleBackColor = true;
            this.newServerBtn.Click += new System.EventHandler(this.newServerBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(661, 577);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.servSettingsPage);
            this.tabControl1.Controls.Add(this.mapSettingsPage);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(655, 574);
            this.tabControl1.TabIndex = 5;
            // 
            // servSettingsPage
            // 
            this.servSettingsPage.BackColor = System.Drawing.Color.White;
            this.servSettingsPage.Controls.Add(this.hintLabel);
            this.servSettingsPage.Controls.Add(this.advSettingsGroupBox);
            this.servSettingsPage.Controls.Add(this.advancedSettingsToggleBtn);
            this.servSettingsPage.Controls.Add(this.startServerBtn);
            this.servSettingsPage.Controls.Add(this.gamePasswordGroupBox);
            this.servSettingsPage.Controls.Add(this.saveBtn);
            this.servSettingsPage.Controls.Add(this.visibilityGroupBox);
            this.servSettingsPage.Controls.Add(this.groupBox2);
            this.servSettingsPage.Controls.Add(this.browseExeBtn);
            this.servSettingsPage.Controls.Add(this.factorioExePath);
            this.servSettingsPage.Location = new System.Drawing.Point(4, 22);
            this.servSettingsPage.Name = "servSettingsPage";
            this.servSettingsPage.Padding = new System.Windows.Forms.Padding(3);
            this.servSettingsPage.Size = new System.Drawing.Size(647, 548);
            this.servSettingsPage.TabIndex = 0;
            this.servSettingsPage.Text = "Server Settings";
            // 
            // advSettingsGroupBox
            // 
            this.advSettingsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.advSettingsGroupBox.Controls.Add(this.maxPlayerTextBox);
            this.advSettingsGroupBox.Controls.Add(this.label2);
            this.advSettingsGroupBox.Controls.Add(this.autoSaveCheckBox);
            this.advSettingsGroupBox.Controls.Add(this.autoPauseCheckBox);
            this.advSettingsGroupBox.Controls.Add(this.pauseGameComboBox);
            this.advSettingsGroupBox.Controls.Add(this.pauseGameLabel);
            this.advSettingsGroupBox.Controls.Add(this.uploadBandwidthComboBox);
            this.advSettingsGroupBox.Controls.Add(this.uploadSlotsComboBox);
            this.advSettingsGroupBox.Controls.Add(this.uploadBandwidthLabel);
            this.advSettingsGroupBox.Controls.Add(this.uploadSlotLabel);
            this.advSettingsGroupBox.Controls.Add(this.allowedCommandsComboBox);
            this.advSettingsGroupBox.Controls.Add(this.label1);
            this.advSettingsGroupBox.Controls.Add(this.returningPlayerlimitCheckBox);
            this.advSettingsGroupBox.Controls.Add(this.userVerificationCheckBox);
            this.advSettingsGroupBox.Enabled = false;
            this.advSettingsGroupBox.Location = new System.Drawing.Point(6, 173);
            this.advSettingsGroupBox.Name = "advSettingsGroupBox";
            this.advSettingsGroupBox.Size = new System.Drawing.Size(635, 340);
            this.advSettingsGroupBox.TabIndex = 9;
            this.advSettingsGroupBox.TabStop = false;
            this.advSettingsGroupBox.Text = "Advanced Settings";
            // 
            // maxPlayerTextBox
            // 
            this.maxPlayerTextBox.Location = new System.Drawing.Point(79, 18);
            this.maxPlayerTextBox.Name = "maxPlayerTextBox";
            this.maxPlayerTextBox.Size = new System.Drawing.Size(52, 20);
            this.maxPlayerTextBox.TabIndex = 14;
            this.maxPlayerTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maxPlayerTextBox_KeyPress);
            this.maxPlayerTextBox.MouseLeave += new System.EventHandler(this.maxPlayerTextBox_MouseLeave);
            this.maxPlayerTextBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.maxPlayerTextBox_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Max. Players:";
            // 
            // autoSaveCheckBox
            // 
            this.autoSaveCheckBox.AutoSize = true;
            this.autoSaveCheckBox.Checked = true;
            this.autoSaveCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoSaveCheckBox.Location = new System.Drawing.Point(6, 113);
            this.autoSaveCheckBox.Name = "autoSaveCheckBox";
            this.autoSaveCheckBox.Size = new System.Drawing.Size(151, 17);
            this.autoSaveCheckBox.TabIndex = 12;
            this.autoSaveCheckBox.Text = "Auto Save Only On Server";
            this.autoSaveCheckBox.UseVisualStyleBackColor = true;
            // 
            // autoPauseCheckBox
            // 
            this.autoPauseCheckBox.AutoSize = true;
            this.autoPauseCheckBox.Checked = true;
            this.autoPauseCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoPauseCheckBox.Location = new System.Drawing.Point(6, 90);
            this.autoPauseCheckBox.Name = "autoPauseCheckBox";
            this.autoPauseCheckBox.Size = new System.Drawing.Size(81, 17);
            this.autoPauseCheckBox.TabIndex = 11;
            this.autoPauseCheckBox.Text = "Auto Pause";
            this.autoPauseCheckBox.UseVisualStyleBackColor = true;
            // 
            // pauseGameComboBox
            // 
            this.pauseGameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pauseGameComboBox.FormattingEnabled = true;
            this.pauseGameComboBox.Items.AddRange(new object[] {
            "Admins Only",
            "Everyone"});
            this.pauseGameComboBox.Location = new System.Drawing.Point(530, 94);
            this.pauseGameComboBox.Name = "pauseGameComboBox";
            this.pauseGameComboBox.Size = new System.Drawing.Size(98, 21);
            this.pauseGameComboBox.TabIndex = 10;
            // 
            // pauseGameLabel
            // 
            this.pauseGameLabel.AutoSize = true;
            this.pauseGameLabel.Location = new System.Drawing.Point(434, 97);
            this.pauseGameLabel.Name = "pauseGameLabel";
            this.pauseGameLabel.Size = new System.Drawing.Size(71, 13);
            this.pauseGameLabel.TabIndex = 9;
            this.pauseGameLabel.Text = "Pause Game:";
            // 
            // uploadBandwidthComboBox
            // 
            this.uploadBandwidthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uploadBandwidthComboBox.FormattingEnabled = true;
            this.uploadBandwidthComboBox.Items.AddRange(new object[] {
            "Unlimited",
            "100",
            "200",
            "300",
            "400",
            "500",
            "1000",
            "2000"});
            this.uploadBandwidthComboBox.Location = new System.Drawing.Point(530, 67);
            this.uploadBandwidthComboBox.Name = "uploadBandwidthComboBox";
            this.uploadBandwidthComboBox.Size = new System.Drawing.Size(98, 21);
            this.uploadBandwidthComboBox.TabIndex = 8;
            // 
            // uploadSlotsComboBox
            // 
            this.uploadSlotsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uploadSlotsComboBox.FormattingEnabled = true;
            this.uploadSlotsComboBox.Items.AddRange(new object[] {
            "Unlimited",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.uploadSlotsComboBox.Location = new System.Drawing.Point(530, 40);
            this.uploadSlotsComboBox.Name = "uploadSlotsComboBox";
            this.uploadSlotsComboBox.Size = new System.Drawing.Size(98, 21);
            this.uploadSlotsComboBox.TabIndex = 7;
            // 
            // uploadBandwidthLabel
            // 
            this.uploadBandwidthLabel.AutoSize = true;
            this.uploadBandwidthLabel.Location = new System.Drawing.Point(434, 70);
            this.uploadBandwidthLabel.Name = "uploadBandwidthLabel";
            this.uploadBandwidthLabel.Size = new System.Drawing.Size(94, 13);
            this.uploadBandwidthLabel.TabIndex = 6;
            this.uploadBandwidthLabel.Text = "Max Upload in kB:";
            // 
            // uploadSlotLabel
            // 
            this.uploadSlotLabel.AutoSize = true;
            this.uploadSlotLabel.Location = new System.Drawing.Point(434, 43);
            this.uploadSlotLabel.Name = "uploadSlotLabel";
            this.uploadSlotLabel.Size = new System.Drawing.Size(96, 13);
            this.uploadSlotLabel.TabIndex = 4;
            this.uploadSlotLabel.Text = "Max. Upload Slots:";
            // 
            // allowedCommandsComboBox
            // 
            this.allowedCommandsComboBox.DisplayMember = "0";
            this.allowedCommandsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.allowedCommandsComboBox.FormattingEnabled = true;
            this.allowedCommandsComboBox.Items.AddRange(new object[] {
            "Admins Only",
            "True",
            "False"});
            this.allowedCommandsComboBox.Location = new System.Drawing.Point(530, 13);
            this.allowedCommandsComboBox.Name = "allowedCommandsComboBox";
            this.allowedCommandsComboBox.Size = new System.Drawing.Size(98, 21);
            this.allowedCommandsComboBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(434, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Allow Commands:";
            // 
            // returningPlayerlimitCheckBox
            // 
            this.returningPlayerlimitCheckBox.AutoSize = true;
            this.returningPlayerlimitCheckBox.Location = new System.Drawing.Point(6, 44);
            this.returningPlayerlimitCheckBox.Name = "returningPlayerlimitCheckBox";
            this.returningPlayerlimitCheckBox.Size = new System.Drawing.Size(216, 17);
            this.returningPlayerlimitCheckBox.TabIndex = 1;
            this.returningPlayerlimitCheckBox.Text = "Ignore Player Limit For Returning Players";
            this.returningPlayerlimitCheckBox.UseVisualStyleBackColor = true;
            // 
            // userVerificationCheckBox
            // 
            this.userVerificationCheckBox.AutoSize = true;
            this.userVerificationCheckBox.Checked = true;
            this.userVerificationCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.userVerificationCheckBox.Location = new System.Drawing.Point(6, 67);
            this.userVerificationCheckBox.Name = "userVerificationCheckBox";
            this.userVerificationCheckBox.Size = new System.Drawing.Size(143, 17);
            this.userVerificationCheckBox.TabIndex = 0;
            this.userVerificationCheckBox.Text = "Require User Verification";
            this.userVerificationCheckBox.UseVisualStyleBackColor = true;
            // 
            // advancedSettingsToggleBtn
            // 
            this.advancedSettingsToggleBtn.AutoSize = true;
            this.advancedSettingsToggleBtn.Location = new System.Drawing.Point(3, 150);
            this.advancedSettingsToggleBtn.Name = "advancedSettingsToggleBtn";
            this.advancedSettingsToggleBtn.Size = new System.Drawing.Size(152, 17);
            this.advancedSettingsToggleBtn.TabIndex = 8;
            this.advancedSettingsToggleBtn.Text = "Edit Advanced Settings >>";
            this.advancedSettingsToggleBtn.UseVisualStyleBackColor = true;
            this.advancedSettingsToggleBtn.CheckedChanged += new System.EventHandler(this.advancedSettingsToggleBtn_CheckedChanged);
            // 
            // startServerBtn
            // 
            this.startServerBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.startServerBtn.Enabled = false;
            this.startServerBtn.Location = new System.Drawing.Point(549, 519);
            this.startServerBtn.Name = "startServerBtn";
            this.startServerBtn.Size = new System.Drawing.Size(92, 23);
            this.startServerBtn.TabIndex = 7;
            this.startServerBtn.Text = "Start Server";
            this.startServerBtn.UseVisualStyleBackColor = true;
            // 
            // gamePasswordGroupBox
            // 
            this.gamePasswordGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gamePasswordGroupBox.Controls.Add(this.gamePWtextBox);
            this.gamePasswordGroupBox.Location = new System.Drawing.Point(6, 94);
            this.gamePasswordGroupBox.Name = "gamePasswordGroupBox";
            this.gamePasswordGroupBox.Size = new System.Drawing.Size(635, 50);
            this.gamePasswordGroupBox.TabIndex = 6;
            this.gamePasswordGroupBox.TabStop = false;
            this.gamePasswordGroupBox.Text = "Server Password";
            // 
            // gamePWtextBox
            // 
            this.gamePWtextBox.Location = new System.Drawing.Point(6, 19);
            this.gamePWtextBox.Name = "gamePWtextBox";
            this.gamePWtextBox.Size = new System.Drawing.Size(623, 20);
            this.gamePWtextBox.TabIndex = 5;
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveBtn.Location = new System.Drawing.Point(6, 519);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(90, 23);
            this.saveBtn.TabIndex = 2;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // visibilityGroupBox
            // 
            this.visibilityGroupBox.Controls.Add(this.lanCheckBox);
            this.visibilityGroupBox.Controls.Add(this.publicCheckBox);
            this.visibilityGroupBox.Location = new System.Drawing.Point(6, 42);
            this.visibilityGroupBox.Name = "visibilityGroupBox";
            this.visibilityGroupBox.Size = new System.Drawing.Size(180, 46);
            this.visibilityGroupBox.TabIndex = 3;
            this.visibilityGroupBox.TabStop = false;
            this.visibilityGroupBox.Text = "Visibility";
            // 
            // lanCheckBox
            // 
            this.lanCheckBox.AutoSize = true;
            this.lanCheckBox.Checked = true;
            this.lanCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lanCheckBox.Location = new System.Drawing.Point(105, 19);
            this.lanCheckBox.Name = "lanCheckBox";
            this.lanCheckBox.Size = new System.Drawing.Size(44, 17);
            this.lanCheckBox.TabIndex = 1;
            this.lanCheckBox.Text = "Lan";
            this.lanCheckBox.UseVisualStyleBackColor = true;
            // 
            // publicCheckBox
            // 
            this.publicCheckBox.AutoSize = true;
            this.publicCheckBox.Location = new System.Drawing.Point(6, 19);
            this.publicCheckBox.Name = "publicCheckBox";
            this.publicCheckBox.Size = new System.Drawing.Size(93, 17);
            this.publicCheckBox.TabIndex = 0;
            this.publicCheckBox.Text = "Public (Lobby)";
            this.publicCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.passwordTextBox);
            this.groupBox2.Controls.Add(this.usernameTextBox);
            this.groupBox2.Location = new System.Drawing.Point(192, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(449, 46);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Credentials for public visibility";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTextBox.Location = new System.Drawing.Point(199, 16);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '•';
            this.passwordTextBox.Size = new System.Drawing.Size(244, 20);
            this.passwordTextBox.TabIndex = 1;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(6, 16);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(187, 20);
            this.usernameTextBox.TabIndex = 0;
            this.usernameTextBox.Enter += new System.EventHandler(this.usernameTextBox_Enter);
            this.usernameTextBox.Leave += new System.EventHandler(this.usernameTextBox_Leave);
            // 
            // browseExeBtn
            // 
            this.browseExeBtn.Location = new System.Drawing.Point(6, 4);
            this.browseExeBtn.Name = "browseExeBtn";
            this.browseExeBtn.Size = new System.Drawing.Size(82, 23);
            this.browseExeBtn.TabIndex = 1;
            this.browseExeBtn.Text = "Browse";
            this.browseExeBtn.UseVisualStyleBackColor = true;
            this.browseExeBtn.Click += new System.EventHandler(this.browseExeBtn_Click);
            // 
            // factorioExePath
            // 
            this.factorioExePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.factorioExePath.Location = new System.Drawing.Point(94, 6);
            this.factorioExePath.Name = "factorioExePath";
            this.factorioExePath.Size = new System.Drawing.Size(541, 20);
            this.factorioExePath.TabIndex = 0;
            this.factorioExePath.Enter += new System.EventHandler(this.factorioExePath_Enter);
            this.factorioExePath.Leave += new System.EventHandler(this.factorioExePath_Leave);
            // 
            // mapSettingsPage
            // 
            this.mapSettingsPage.Location = new System.Drawing.Point(4, 22);
            this.mapSettingsPage.Name = "mapSettingsPage";
            this.mapSettingsPage.Padding = new System.Windows.Forms.Padding(3);
            this.mapSettingsPage.Size = new System.Drawing.Size(647, 548);
            this.mapSettingsPage.TabIndex = 1;
            this.mapSettingsPage.Text = "Map Settings";
            this.mapSettingsPage.UseVisualStyleBackColor = true;
            // 
            // navigateToExe
            // 
            this.navigateToExe.FileName = "factorio.exe";
            this.navigateToExe.Filter = "Executable-Files|*.exe";
            this.navigateToExe.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // hintLabel
            // 
            this.hintLabel.AutoSize = true;
            this.hintLabel.ForeColor = System.Drawing.Color.Green;
            this.hintLabel.Location = new System.Drawing.Point(108, 524);
            this.hintLabel.Name = "hintLabel";
            this.hintLabel.Size = new System.Drawing.Size(0, 13);
            this.hintLabel.TabIndex = 15;
            this.hintLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 577);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Factorio Server Creator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.servSettingsPage.ResumeLayout(false);
            this.servSettingsPage.PerformLayout();
            this.advSettingsGroupBox.ResumeLayout(false);
            this.advSettingsGroupBox.PerformLayout();
            this.gamePasswordGroupBox.ResumeLayout(false);
            this.gamePasswordGroupBox.PerformLayout();
            this.visibilityGroupBox.ResumeLayout(false);
            this.visibilityGroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView serverListView;
        private System.Windows.Forms.Button deleteServerBtn;
        private System.Windows.Forms.Button newServerBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button browseExeBtn;
        private System.Windows.Forms.TextBox factorioExePath;
        private System.Windows.Forms.OpenFileDialog navigateToExe;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.GroupBox visibilityGroupBox;
        private System.Windows.Forms.CheckBox lanCheckBox;
        private System.Windows.Forms.CheckBox publicCheckBox;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox servernameTextBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage servSettingsPage;
        private System.Windows.Forms.TabPage mapSettingsPage;
        private System.Windows.Forms.GroupBox gamePasswordGroupBox;
        private System.Windows.Forms.TextBox gamePWtextBox;
        private System.Windows.Forms.Button startServerBtn;
        private System.Windows.Forms.CheckBox advancedSettingsToggleBtn;
        private System.Windows.Forms.GroupBox advSettingsGroupBox;
        private System.Windows.Forms.ComboBox allowedCommandsComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox returningPlayerlimitCheckBox;
        private System.Windows.Forms.CheckBox userVerificationCheckBox;
        private System.Windows.Forms.ComboBox uploadBandwidthComboBox;
        private System.Windows.Forms.ComboBox uploadSlotsComboBox;
        private System.Windows.Forms.Label uploadBandwidthLabel;
        private System.Windows.Forms.Label uploadSlotLabel;
        private System.Windows.Forms.ComboBox pauseGameComboBox;
        private System.Windows.Forms.Label pauseGameLabel;
        private System.Windows.Forms.CheckBox autoPauseCheckBox;
        private System.Windows.Forms.CheckBox autoSaveCheckBox;
        private System.Windows.Forms.TextBox maxPlayerTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label hintLabel;
    }
}

