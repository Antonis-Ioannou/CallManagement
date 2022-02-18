
namespace CallManagement
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.simpleButtonSave = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonConnect = new DevExpress.XtraEditors.SimpleButton();
            this.comboBoxEditDatabase = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboBoxEditServer = new DevExpress.XtraEditors.ComboBoxEdit();
            this.textEditPassword = new DevExpress.XtraEditors.TextEdit();
            this.textEditUserName = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciUserName = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lciPassword = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciServer = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciDatabase = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditDatabase.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditServer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciServer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDatabase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.simpleButtonSave);
            this.layoutControl1.Controls.Add(this.simpleButtonConnect);
            this.layoutControl1.Controls.Add(this.comboBoxEditDatabase);
            this.layoutControl1.Controls.Add(this.comboBoxEditServer);
            this.layoutControl1.Controls.Add(this.textEditPassword);
            this.layoutControl1.Controls.Add(this.textEditUserName);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1047, 579);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // simpleButtonSave
            // 
            this.simpleButtonSave.Location = new System.Drawing.Point(12, 134);
            this.simpleButtonSave.Name = "simpleButtonSave";
            this.simpleButtonSave.Size = new System.Drawing.Size(1023, 22);
            this.simpleButtonSave.StyleController = this.layoutControl1;
            this.simpleButtonSave.TabIndex = 9;
            this.simpleButtonSave.Text = "Save";
            this.simpleButtonSave.Click += new System.EventHandler(this.loginSave);
            // 
            // simpleButtonConnect
            // 
            this.simpleButtonConnect.Location = new System.Drawing.Point(12, 84);
            this.simpleButtonConnect.Name = "simpleButtonConnect";
            this.simpleButtonConnect.Size = new System.Drawing.Size(1023, 22);
            this.simpleButtonConnect.StyleController = this.layoutControl1;
            this.simpleButtonConnect.TabIndex = 8;
            this.simpleButtonConnect.Text = "Connect";
            this.simpleButtonConnect.Click += new System.EventHandler(this.loginConnect);
            // 
            // comboBoxEditDatabase
            // 
            this.comboBoxEditDatabase.Location = new System.Drawing.Point(73, 110);
            this.comboBoxEditDatabase.Name = "comboBoxEditDatabase";
            this.comboBoxEditDatabase.Properties.AutoComplete = false;
            this.comboBoxEditDatabase.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditDatabase.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEditDatabase.Size = new System.Drawing.Size(962, 20);
            this.comboBoxEditDatabase.StyleController = this.layoutControl1;
            this.comboBoxEditDatabase.TabIndex = 7;
            this.comboBoxEditDatabase.SelectedIndexChanged += new System.EventHandler(this.loginDatabase);
            this.comboBoxEditDatabase.TextChanged += new System.EventHandler(this.enablingSaveBtn);
            // 
            // comboBoxEditServer
            // 
            this.comboBoxEditServer.Location = new System.Drawing.Point(73, 60);
            this.comboBoxEditServer.Name = "comboBoxEditServer";
            this.comboBoxEditServer.Properties.AutoComplete = false;
            this.comboBoxEditServer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditServer.Size = new System.Drawing.Size(962, 20);
            this.comboBoxEditServer.StyleController = this.layoutControl1;
            this.comboBoxEditServer.TabIndex = 6;
            this.comboBoxEditServer.SelectedIndexChanged += new System.EventHandler(this.loginServer);
            // 
            // textEditPassword
            // 
            this.textEditPassword.Location = new System.Drawing.Point(73, 36);
            this.textEditPassword.Name = "textEditPassword";
            this.textEditPassword.Size = new System.Drawing.Size(962, 20);
            this.textEditPassword.StyleController = this.layoutControl1;
            this.textEditPassword.TabIndex = 5;
            this.textEditPassword.EditValueChanged += new System.EventHandler(this.loginPassword);
            // 
            // textEditUserName
            // 
            this.textEditUserName.Location = new System.Drawing.Point(73, 12);
            this.textEditUserName.Name = "textEditUserName";
            this.textEditUserName.Size = new System.Drawing.Size(962, 20);
            this.textEditUserName.StyleController = this.layoutControl1;
            this.textEditUserName.TabIndex = 4;
            this.textEditUserName.EditValueChanged += new System.EventHandler(this.loginUserName);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciUserName,
            this.emptySpaceItem1,
            this.lciPassword,
            this.lciServer,
            this.lciDatabase,
            this.layoutControlItem5,
            this.layoutControlItem6});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1047, 579);
            this.Root.TextVisible = false;
            // 
            // lciUserName
            // 
            this.lciUserName.Control = this.textEditUserName;
            this.lciUserName.Location = new System.Drawing.Point(0, 0);
            this.lciUserName.Name = "lciUserName";
            this.lciUserName.Size = new System.Drawing.Size(1027, 24);
            this.lciUserName.Text = "UserName";
            this.lciUserName.TextSize = new System.Drawing.Size(49, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 148);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(1027, 411);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lciPassword
            // 
            this.lciPassword.Control = this.textEditPassword;
            this.lciPassword.Location = new System.Drawing.Point(0, 24);
            this.lciPassword.Name = "lciPassword";
            this.lciPassword.Size = new System.Drawing.Size(1027, 24);
            this.lciPassword.Text = "Password";
            this.lciPassword.TextSize = new System.Drawing.Size(49, 13);
            // 
            // lciServer
            // 
            this.lciServer.Control = this.comboBoxEditServer;
            this.lciServer.Location = new System.Drawing.Point(0, 48);
            this.lciServer.Name = "lciServer";
            this.lciServer.Size = new System.Drawing.Size(1027, 24);
            this.lciServer.Text = "Server";
            this.lciServer.TextSize = new System.Drawing.Size(49, 13);
            // 
            // lciDatabase
            // 
            this.lciDatabase.Control = this.comboBoxEditDatabase;
            this.lciDatabase.Location = new System.Drawing.Point(0, 98);
            this.lciDatabase.Name = "lciDatabase";
            this.lciDatabase.Size = new System.Drawing.Size(1027, 24);
            this.lciDatabase.Text = "Database";
            this.lciDatabase.TextSize = new System.Drawing.Size(49, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.simpleButtonConnect;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(1027, 26);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.simpleButtonSave;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 122);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(1027, 26);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 579);
            this.Controls.Add(this.layoutControl1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditDatabase.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditServer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciServer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDatabase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.SimpleButton simpleButtonSave;
        private DevExpress.XtraEditors.SimpleButton simpleButtonConnect;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditDatabase;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditServer;
        private DevExpress.XtraEditors.TextEdit textEditPassword;
        private DevExpress.XtraEditors.TextEdit textEditUserName;
        private DevExpress.XtraLayout.LayoutControlItem lciUserName;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem lciPassword;
        private DevExpress.XtraLayout.LayoutControlItem lciServer;
        private DevExpress.XtraLayout.LayoutControlItem lciDatabase;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}