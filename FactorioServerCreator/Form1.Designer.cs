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
            this.serverListView = new System.Windows.Forms.ListView();
            this.newServerBtn = new System.Windows.Forms.Button();
            this.deleteServerBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.navigateToExe = new System.Windows.Forms.OpenFileDialog();
            this.factorioExePath = new System.Windows.Forms.TextBox();
            this.browseExeBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.visibilityGroupBox = new System.Windows.Forms.GroupBox();
            this.publicCheckBox = new System.Windows.Forms.CheckBox();
            this.lanCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.servernameTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.splitContainer1.Size = new System.Drawing.Size(997, 558);
            this.splitContainer1.SplitterDistance = 332;
            this.splitContainer1.TabIndex = 0;
            // 
            // serverListView
            // 
            this.serverListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serverListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.serverListView.Location = new System.Drawing.Point(3, 3);
            this.serverListView.MultiSelect = false;
            this.serverListView.Name = "serverListView";
            this.serverListView.Size = new System.Drawing.Size(326, 523);
            this.serverListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.serverListView.TabIndex = 0;
            this.serverListView.UseCompatibleStateImageBehavior = false;
            this.serverListView.View = System.Windows.Forms.View.List;
            // 
            // newServerBtn
            // 
            this.newServerBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.newServerBtn.Location = new System.Drawing.Point(3, 532);
            this.newServerBtn.Name = "newServerBtn";
            this.newServerBtn.Size = new System.Drawing.Size(82, 23);
            this.newServerBtn.TabIndex = 1;
            this.newServerBtn.Text = "New Server";
            this.newServerBtn.UseVisualStyleBackColor = true;
            this.newServerBtn.Click += new System.EventHandler(this.newServerBtn_Click);
            // 
            // deleteServerBtn
            // 
            this.deleteServerBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteServerBtn.Location = new System.Drawing.Point(254, 532);
            this.deleteServerBtn.Name = "deleteServerBtn";
            this.deleteServerBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteServerBtn.TabIndex = 2;
            this.deleteServerBtn.Text = "Delete";
            this.deleteServerBtn.UseVisualStyleBackColor = true;
            this.deleteServerBtn.Click += new System.EventHandler(this.deleteServerBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.visibilityGroupBox);
            this.panel1.Controls.Add(this.saveBtn);
            this.panel1.Controls.Add(this.browseExeBtn);
            this.panel1.Controls.Add(this.factorioExePath);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(661, 558);
            this.panel1.TabIndex = 0;
            // 
            // navigateToExe
            // 
            this.navigateToExe.FileName = "factorio.exe";
            this.navigateToExe.Filter = "Executable-Files|*.exe";
            this.navigateToExe.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // factorioExePath
            // 
            this.factorioExePath.Location = new System.Drawing.Point(91, 12);
            this.factorioExePath.Name = "factorioExePath";
            this.factorioExePath.Size = new System.Drawing.Size(558, 20);
            this.factorioExePath.TabIndex = 0;
            this.factorioExePath.Enter += new System.EventHandler(this.factorioExePath_Enter);
            this.factorioExePath.Leave += new System.EventHandler(this.factorioExePath_Leave);
            // 
            // browseExeBtn
            // 
            this.browseExeBtn.Location = new System.Drawing.Point(3, 12);
            this.browseExeBtn.Name = "browseExeBtn";
            this.browseExeBtn.Size = new System.Drawing.Size(82, 20);
            this.browseExeBtn.TabIndex = 1;
            this.browseExeBtn.Text = "Browse";
            this.browseExeBtn.UseVisualStyleBackColor = true;
            this.browseExeBtn.Click += new System.EventHandler(this.browseExeBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(583, 532);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 2;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            // 
            // visibilityGroupBox
            // 
            this.visibilityGroupBox.Controls.Add(this.lanCheckBox);
            this.visibilityGroupBox.Controls.Add(this.publicCheckBox);
            this.visibilityGroupBox.Location = new System.Drawing.Point(3, 38);
            this.visibilityGroupBox.Name = "visibilityGroupBox";
            this.visibilityGroupBox.Size = new System.Drawing.Size(180, 46);
            this.visibilityGroupBox.TabIndex = 3;
            this.visibilityGroupBox.TabStop = false;
            this.visibilityGroupBox.Text = "Visibility";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.usernameTextBox);
            this.groupBox2.Location = new System.Drawing.Point(189, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 46);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Credentials for public visibility";
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(199, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '•';
            this.textBox1.Size = new System.Drawing.Size(255, 20);
            this.textBox1.TabIndex = 1;
            // 
            // servernameTextBox
            // 
            this.servernameTextBox.Location = new System.Drawing.Point(91, 534);
            this.servernameTextBox.Name = "servernameTextBox";
            this.servernameTextBox.Size = new System.Drawing.Size(157, 20);
            this.servernameTextBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 558);
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
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox servernameTextBox;
    }
}

