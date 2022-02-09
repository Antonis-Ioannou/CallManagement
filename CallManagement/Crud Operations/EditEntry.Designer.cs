
namespace CallManagement.Crud_Operations
{
    partial class EditEntry
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
            this.components = new System.ComponentModel.Container();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new CallManagement.DataSet1();
            this.callType = new DevExpress.XtraEditors.LookUpEdit();
            this.callTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet11 = new CallManagement.DataSet1();
            this.callingContact = new DevExpress.XtraEditors.LookUpEdit();
            this.callingContactBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.callReciever = new DevExpress.XtraEditors.LookUpEdit();
            this.callRecieverBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.callsTableAdapter1 = new CallManagement.DataSet1TableAdapters.CallsTableAdapter();
            this.callTypeTableAdapter = new CallManagement.DataSet1TableAdapters.CallTypeTableAdapter();
            this.callingContactTableAdapter = new CallManagement.DataSet1TableAdapters.CallingContactTableAdapter();
            this.callRecieverTableAdapter = new CallManagement.DataSet1TableAdapters.CallRecieverTableAdapter();
            this.dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.callType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.callTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.callingContact.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.callingContactBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.callReciever.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.callRecieverBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.simpleButton1);
            this.layoutControl1.Controls.Add(this.textEdit1);
            this.layoutControl1.Controls.Add(this.callType);
            this.layoutControl1.Controls.Add(this.callingContact);
            this.layoutControl1.Controls.Add(this.callReciever);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(800, 450);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(12, 108);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(776, 22);
            this.simpleButton1.StyleController = this.layoutControl1;
            this.simpleButton1.TabIndex = 9;
            this.simpleButton1.Text = "Submit Changes";
            this.simpleButton1.Click += new System.EventHandler(this.saveChanges);
            // 
            // textEdit1
            // 
            this.textEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "Notes", true));
            this.textEdit1.Location = new System.Drawing.Point(93, 84);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(695, 20);
            this.textEdit1.StyleController = this.layoutControl1;
            this.textEdit1.TabIndex = 8;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Calls";
            this.bindingSource1.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // callType
            // 
            this.callType.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "TypeId", true));
            this.callType.Location = new System.Drawing.Point(93, 12);
            this.callType.Name = "callType";
            this.callType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.callType.Properties.DataSource = this.callTypeBindingSource;
            this.callType.Properties.DisplayMember = "Description";
            this.callType.Properties.NullText = "";
            this.callType.Properties.PopupSizeable = false;
            this.callType.Properties.ValidateOnEnterKey = true;
            this.callType.Properties.ValueMember = "ID";
            this.callType.Size = new System.Drawing.Size(695, 20);
            this.callType.StyleController = this.layoutControl1;
            this.callType.TabIndex = 4;
            this.callType.Validating += new System.ComponentModel.CancelEventHandler(this.callTypeValidation);
            // 
            // callTypeBindingSource
            // 
            this.callTypeBindingSource.DataMember = "CallType";
            this.callTypeBindingSource.DataSource = this.dataSet11;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // callingContact
            // 
            this.callingContact.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "CallContactId", true));
            this.callingContact.Location = new System.Drawing.Point(93, 36);
            this.callingContact.Name = "callingContact";
            this.callingContact.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.callingContact.Properties.DataSource = this.callingContactBindingSource;
            this.callingContact.Properties.DisplayMember = "Name";
            this.callingContact.Properties.NullText = "";
            this.callingContact.Properties.PopupSizeable = false;
            this.callingContact.Properties.ValidateOnEnterKey = true;
            this.callingContact.Properties.ValueMember = "ID";
            this.callingContact.Size = new System.Drawing.Size(695, 20);
            this.callingContact.StyleController = this.layoutControl1;
            this.callingContact.TabIndex = 5;
            this.callingContact.Validating += new System.ComponentModel.CancelEventHandler(this.callingContactValidation);
            // 
            // callingContactBindingSource
            // 
            this.callingContactBindingSource.DataMember = "CallingContact";
            this.callingContactBindingSource.DataSource = this.dataSet11;
            // 
            // callReciever
            // 
            this.callReciever.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "ReceiverId", true));
            this.callReciever.Location = new System.Drawing.Point(93, 60);
            this.callReciever.Name = "callReciever";
            this.callReciever.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.callReciever.Properties.DataSource = this.callRecieverBindingSource;
            this.callReciever.Properties.DisplayMember = "Name";
            this.callReciever.Properties.NullText = "";
            this.callReciever.Properties.PopupSizeable = false;
            this.callReciever.Properties.ValidateOnEnterKey = true;
            this.callReciever.Properties.ValueMember = "ID";
            this.callReciever.Size = new System.Drawing.Size(695, 20);
            this.callReciever.StyleController = this.layoutControl1;
            this.callReciever.TabIndex = 6;
            this.callReciever.Validating += new System.ComponentModel.CancelEventHandler(this.callRecieverValidation);
            // 
            // callRecieverBindingSource
            // 
            this.callRecieverBindingSource.DataMember = "CallReciever";
            this.callRecieverBindingSource.DataSource = this.dataSet11;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem5,
            this.layoutControlItem6});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(800, 450);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.callType;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(780, 24);
            this.layoutControlItem1.Text = "CallType";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(69, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 122);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(780, 308);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.callingContact;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(780, 24);
            this.layoutControlItem2.Text = "CallingContact";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(69, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.callReciever;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(780, 24);
            this.layoutControlItem3.Text = "CallReciever";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(69, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.textEdit1;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(780, 24);
            this.layoutControlItem5.Text = "Notes";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(69, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.simpleButton1;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(780, 26);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // callsTableAdapter1
            // 
            this.callsTableAdapter1.ClearBeforeFill = true;
            // 
            // callTypeTableAdapter
            // 
            this.callTypeTableAdapter.ClearBeforeFill = true;
            // 
            // callingContactTableAdapter
            // 
            this.callingContactTableAdapter.ClearBeforeFill = true;
            // 
            // callRecieverTableAdapter
            // 
            this.callRecieverTableAdapter.ClearBeforeFill = true;
            // 
            // dxErrorProvider
            // 
            this.dxErrorProvider.ContainerControl = this;
            // 
            // EditEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.layoutControl1);
            this.Name = "EditEntry";
            this.Text = "EditEntry";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formClosing);
            this.Load += new System.EventHandler(this.EditEntry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.callType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.callTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.callingContact.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.callingContactBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.callReciever.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.callRecieverBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.CallsTableAdapter callsTableAdapter1;
        private DevExpress.XtraEditors.LookUpEdit callType;
        private DevExpress.XtraEditors.LookUpEdit callingContact;
        private DevExpress.XtraEditors.LookUpEdit callReciever;
        private DataSet1 dataSet11;
        private System.Windows.Forms.BindingSource callTypeBindingSource;
        private DataSet1TableAdapters.CallTypeTableAdapter callTypeTableAdapter;
        private System.Windows.Forms.BindingSource callingContactBindingSource;
        private DataSet1TableAdapters.CallingContactTableAdapter callingContactTableAdapter;
        private System.Windows.Forms.BindingSource callRecieverBindingSource;
        private DataSet1TableAdapters.CallRecieverTableAdapter callRecieverTableAdapter;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider;
    }
}