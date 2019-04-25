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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gamePWtextBox = new System.Windows.Forms.TextBox();
            this.visibilityGroupBox = new System.Windows.Forms.GroupBox();
            this.lanCheckBox = new System.Windows.Forms.CheckBox();
            this.publicCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.browseExeBtn = new System.Windows.Forms.Button();
            this.factorioExePath = new System.Windows.Forms.TextBox();
            this.mapSettingsPage = new System.Windows.Forms.TabPage();
            this.saveBtn = new System.Windows.Forms.Button();
            this.navigateToExe = new System.Windows.Forms.OpenFileDialog();
            this.startServerBtn = new System.Windows.Forms.Button();
            this.advancedSettingsToggleBtn = new System.Windows.Forms.CheckBox();
            this.advSettingsGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.servSettingsPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.servSettingsPage.Controls.Add(this.advSettingsGroupBox);
            this.servSettingsPage.Controls.Add(this.advancedSettingsToggleBtn);
            this.servSettingsPage.Controls.Add(this.startServerBtn);
            this.servSettingsPage.Controls.Add(this.groupBox1);
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
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.gamePWtextBox);
            this.groupBox1.Location = new System.Drawing.Point(6, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(635, 92);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Misc";
            // 
            // gamePWtextBox
            // 
            this.gamePWtextBox.Location = new System.Drawing.Point(6, 19);
            this.gamePWtextBox.Name = "gamePWtextBox";
            this.gamePWtextBox.Size = new System.Drawing.Size(194, 20);
            this.gamePWtextBox.TabIndex = 5;
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
            this.browseExeBtn.Location = new System.Drawing.Point(6, 6);
            this.browseExeBtn.Name = "browseExeBtn";
            this.browseExeBtn.Size = new System.Drawing.Size(82, 20);
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
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveBtn.Location = new System.Drawing.Point(6, 519);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(90, 23);
            this.saveBtn.TabIndex = 2;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            // 
            // navigateToExe
            // 
            this.navigateToExe.FileName = "factorio.exe";
            this.navigateToExe.Filter = "Executable-Files|*.exe";
            this.navigateToExe.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
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
            // advancedSettingsToggleBtn
            // 
            this.advancedSettingsToggleBtn.AutoSize = true;
            this.advancedSettingsToggleBtn.Location = new System.Drawing.Point(6, 192);
            this.advancedSettingsToggleBtn.Name = "advancedSettingsToggleBtn";
            this.advancedSettingsToggleBtn.Size = new System.Drawing.Size(152, 17);
            this.advancedSettingsToggleBtn.TabIndex = 8;
            this.advancedSettingsToggleBtn.Text = "Edit Advanced Settings >>";
            this.advancedSettingsToggleBtn.UseVisualStyleBackColor = true;
            this.advancedSettingsToggleBtn.CheckedChanged += new System.EventHandler(this.advancedSettingsToggleBtn_CheckedChanged);
            // 
            // advSettingsGroupBox
            // 
            this.advSettingsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.advSettingsGroupBox.Enabled = false;
            this.advSettingsGroupBox.Location = new System.Drawing.Point(6, 215);
            this.advSettingsGroupBox.Name = "advSettingsGroupBox";
            this.advSettingsGroupBox.Size = new System.Drawing.Size(635, 298);
            this.advSettingsGroupBox.TabIndex = 9;
            this.advSettingsGroupBox.TabStop = false;
            this.advSettingsGroupBox.Text = "Advanced Settings";
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox gamePWtextBox;
        private System.Windows.Forms.Button startServerBtn;
        private System.Windows.Forms.CheckBox advancedSettingsToggleBtn;
        private System.Windows.Forms.GroupBox advSettingsGroupBox;
    }
}

