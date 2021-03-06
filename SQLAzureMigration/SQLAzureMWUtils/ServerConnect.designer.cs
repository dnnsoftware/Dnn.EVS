﻿namespace SQLAzureMWUtils
{
    partial class ServerConnect
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerConnect));
            this.rbSpecifyUserPassword = new System.Windows.Forms.RadioButton();
            this.WindowsAuthenticationRadioButton = new System.Windows.Forms.RadioButton();
            this.ServerNamesComboBox = new System.Windows.Forms.ComboBox();
            this.CancelCommandButton = new System.Windows.Forms.Button();
            this.ConnectCommandButton = new System.Windows.Forms.Button();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.ServerNameLabel = new System.Windows.Forms.Label();
            this.gbAuth = new System.Windows.Forms.GroupBox();
            this.tbDatabase = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbDatabase = new System.Windows.Forms.GroupBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.rbSpecifiedDB = new System.Windows.Forms.RadioButton();
            this.rbMasterDB = new System.Windows.Forms.RadioButton();
            this.gboxSaveServerInfo = new System.Windows.Forms.GroupBox();
            this.rbForget = new System.Windows.Forms.RadioButton();
            this.rbSave = new System.Windows.Forms.RadioButton();
            this.gbAuth.SuspendLayout();
            this.gbDatabase.SuspendLayout();
            this.gboxSaveServerInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbSpecifyUserPassword
            // 
            resources.ApplyResources(this.rbSpecifyUserPassword, "rbSpecifyUserPassword");
            this.rbSpecifyUserPassword.Name = "rbSpecifyUserPassword";
            // 
            // WindowsAuthenticationRadioButton
            // 
            resources.ApplyResources(this.WindowsAuthenticationRadioButton, "WindowsAuthenticationRadioButton");
            this.WindowsAuthenticationRadioButton.Checked = true;
            this.WindowsAuthenticationRadioButton.Name = "WindowsAuthenticationRadioButton";
            this.WindowsAuthenticationRadioButton.TabStop = true;
            this.WindowsAuthenticationRadioButton.CheckedChanged += new System.EventHandler(this.WindowsAuthenticationRadioButton_CheckedChanged);
            // 
            // ServerNamesComboBox
            // 
            resources.ApplyResources(this.ServerNamesComboBox, "ServerNamesComboBox");
            this.ServerNamesComboBox.FormattingEnabled = true;
            this.ServerNamesComboBox.Name = "ServerNamesComboBox";
            this.ServerNamesComboBox.Sorted = true;
            this.ServerNamesComboBox.SelectedIndexChanged += new System.EventHandler(this.ServerNamesComboBox_SelectedIndexChanged);
            this.ServerNamesComboBox.Leave += new System.EventHandler(this.ServerNamesComboBox_Leave);
            // 
            // CancelCommandButton
            // 
            resources.ApplyResources(this.CancelCommandButton, "CancelCommandButton");
            this.CancelCommandButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelCommandButton.Name = "CancelCommandButton";
            this.CancelCommandButton.Click += new System.EventHandler(this.CancelCommandButton_Click);
            // 
            // ConnectCommandButton
            // 
            resources.ApplyResources(this.ConnectCommandButton, "ConnectCommandButton");
            this.ConnectCommandButton.Name = "ConnectCommandButton";
            this.ConnectCommandButton.Click += new System.EventHandler(this.ConnectCommandButton_Click);
            // 
            // PasswordTextBox
            // 
            resources.ApplyResources(this.PasswordTextBox, "PasswordTextBox");
            this.PasswordTextBox.Name = "PasswordTextBox";
            // 
            // UserNameTextBox
            // 
            resources.ApplyResources(this.UserNameTextBox, "UserNameTextBox");
            this.UserNameTextBox.Name = "UserNameTextBox";
            // 
            // PasswordLabel
            // 
            resources.ApplyResources(this.PasswordLabel, "PasswordLabel");
            this.PasswordLabel.Name = "PasswordLabel";
            // 
            // UserNameLabel
            // 
            resources.ApplyResources(this.UserNameLabel, "UserNameLabel");
            this.UserNameLabel.Name = "UserNameLabel";
            // 
            // ServerNameLabel
            // 
            resources.ApplyResources(this.ServerNameLabel, "ServerNameLabel");
            this.ServerNameLabel.Name = "ServerNameLabel";
            // 
            // gbAuth
            // 
            resources.ApplyResources(this.gbAuth, "gbAuth");
            this.gbAuth.Controls.Add(this.UserNameLabel);
            this.gbAuth.Controls.Add(this.rbSpecifyUserPassword);
            this.gbAuth.Controls.Add(this.PasswordLabel);
            this.gbAuth.Controls.Add(this.UserNameTextBox);
            this.gbAuth.Controls.Add(this.WindowsAuthenticationRadioButton);
            this.gbAuth.Controls.Add(this.PasswordTextBox);
            this.gbAuth.Name = "gbAuth";
            this.gbAuth.TabStop = false;
            // 
            // tbDatabase
            // 
            resources.ApplyResources(this.tbDatabase, "tbDatabase");
            this.tbDatabase.Name = "tbDatabase";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // gbDatabase
            // 
            resources.ApplyResources(this.gbDatabase, "gbDatabase");
            this.gbDatabase.Controls.Add(this.btnHelp);
            this.gbDatabase.Controls.Add(this.rbSpecifiedDB);
            this.gbDatabase.Controls.Add(this.tbDatabase);
            this.gbDatabase.Controls.Add(this.rbMasterDB);
            this.gbDatabase.Controls.Add(this.label1);
            this.gbDatabase.Name = "gbDatabase";
            this.gbDatabase.TabStop = false;
            // 
            // btnHelp
            // 
            resources.ApplyResources(this.btnHelp, "btnHelp");
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // rbSpecifiedDB
            // 
            resources.ApplyResources(this.rbSpecifiedDB, "rbSpecifiedDB");
            this.rbSpecifiedDB.Name = "rbSpecifiedDB";
            this.rbSpecifiedDB.UseVisualStyleBackColor = true;
            // 
            // rbMasterDB
            // 
            resources.ApplyResources(this.rbMasterDB, "rbMasterDB");
            this.rbMasterDB.Checked = true;
            this.rbMasterDB.Name = "rbMasterDB";
            this.rbMasterDB.TabStop = true;
            this.rbMasterDB.UseVisualStyleBackColor = true;
            this.rbMasterDB.CheckedChanged += new System.EventHandler(this.rbMasterDB_CheckedChanged);
            // 
            // gboxSaveServerInfo
            // 
            resources.ApplyResources(this.gboxSaveServerInfo, "gboxSaveServerInfo");
            this.gboxSaveServerInfo.Controls.Add(this.rbForget);
            this.gboxSaveServerInfo.Controls.Add(this.rbSave);
            this.gboxSaveServerInfo.Name = "gboxSaveServerInfo";
            this.gboxSaveServerInfo.TabStop = false;
            // 
            // rbForget
            // 
            resources.ApplyResources(this.rbForget, "rbForget");
            this.rbForget.Name = "rbForget";
            this.rbForget.TabStop = true;
            this.rbForget.UseVisualStyleBackColor = true;
            // 
            // rbSave
            // 
            resources.ApplyResources(this.rbSave, "rbSave");
            this.rbSave.Name = "rbSave";
            this.rbSave.TabStop = true;
            this.rbSave.UseVisualStyleBackColor = true;
            // 
            // ServerConnect
            // 
            this.AcceptButton = this.ConnectCommandButton;
            resources.ApplyResources(this, "$this");
            this.CancelButton = this.CancelCommandButton;
            this.Controls.Add(this.gboxSaveServerInfo);
            this.Controls.Add(this.gbDatabase);
            this.Controls.Add(this.gbAuth);
            this.Controls.Add(this.ServerNamesComboBox);
            this.Controls.Add(this.CancelCommandButton);
            this.Controls.Add(this.ConnectCommandButton);
            this.Controls.Add(this.ServerNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ServerConnect";
            this.ShowInTaskbar = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ServerConnect_FormClosing);
            this.Load += new System.EventHandler(this.ServerConnect_Load);
            this.gbAuth.ResumeLayout(false);
            this.gbAuth.PerformLayout();
            this.gbDatabase.ResumeLayout(false);
            this.gbDatabase.PerformLayout();
            this.gboxSaveServerInfo.ResumeLayout(false);
            this.gboxSaveServerInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbSpecifyUserPassword;
        private System.Windows.Forms.RadioButton WindowsAuthenticationRadioButton;
        private System.Windows.Forms.ComboBox ServerNamesComboBox;
        private System.Windows.Forms.Button CancelCommandButton;
        private System.Windows.Forms.Button ConnectCommandButton;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label ServerNameLabel;
        private System.Windows.Forms.GroupBox gbAuth;
        private System.Windows.Forms.TextBox tbDatabase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbDatabase;
        private System.Windows.Forms.RadioButton rbSpecifiedDB;
        private System.Windows.Forms.RadioButton rbMasterDB;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.GroupBox gboxSaveServerInfo;
        private System.Windows.Forms.RadioButton rbForget;
        private System.Windows.Forms.RadioButton rbSave;
    }
}