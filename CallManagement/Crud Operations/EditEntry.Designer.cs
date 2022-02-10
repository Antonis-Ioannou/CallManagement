
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditEntry));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.sbSubmitChanges = new DevExpress.XtraEditors.SimpleButton();
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
            this.lciCallType = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lciCallingContact = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciCallReciever = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciNotes = new DevExpress.XtraLayout.LayoutControlItem();
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
            ((System.ComponentModel.ISupportInitialize)(this.lciCallType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCallingContact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCallReciever)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.sbSubmitChanges);
            this.layoutControl1.Controls.Add(this.textEdit1);
            this.layoutControl1.Controls.Add(this.callType);
            this.layoutControl1.Controls.Add(this.callingContact);
            this.layoutControl1.Controls.Add(this.callReciever);
            resources.ApplyResources(this.layoutControl1, "layoutControl1");
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            // 
            // sbSubmitChanges
            // 
            resources.ApplyResources(this.sbSubmitChanges, "sbSubmitChanges");
            this.sbSubmitChanges.Name = "sbSubmitChanges";
            this.sbSubmitChanges.StyleController = this.layoutControl1;
            this.sbSubmitChanges.Click += new System.EventHandler(this.saveChangesBtn);
            // 
            // textEdit1
            // 
            this.textEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "Notes", true));
            resources.ApplyResources(this.textEdit1, "textEdit1");
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.StyleController = this.layoutControl1;
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
            resources.ApplyResources(this.callType, "callType");
            this.callType.Name = "callType";
            this.callType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("callType.Properties.Buttons"))))});
            this.callType.Properties.DataSource = this.callTypeBindingSource;
            this.callType.Properties.DisplayMember = "Description";
            this.callType.Properties.NullText = resources.GetString("callType.Properties.NullText");
            this.callType.Properties.PopupSizeable = false;
            this.callType.Properties.ValidateOnEnterKey = true;
            this.callType.Properties.ValueMember = "ID";
            this.callType.StyleController = this.layoutControl1;
            this.callType.Modified += new System.EventHandler(this.callTypeChanged);
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
            resources.ApplyResources(this.callingContact, "callingContact");
            this.callingContact.Name = "callingContact";
            this.callingContact.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("callingContact.Properties.Buttons"))))});
            this.callingContact.Properties.DataSource = this.callingContactBindingSource;
            this.callingContact.Properties.DisplayMember = "Name";
            this.callingContact.Properties.NullText = resources.GetString("callingContact.Properties.NullText");
            this.callingContact.Properties.PopupSizeable = false;
            this.callingContact.Properties.ValidateOnEnterKey = true;
            this.callingContact.Properties.ValueMember = "ID";
            this.callingContact.StyleController = this.layoutControl1;
            this.callingContact.Modified += new System.EventHandler(this.callingContactChanged);
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
            resources.ApplyResources(this.callReciever, "callReciever");
            this.callReciever.Name = "callReciever";
            this.callReciever.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("callReciever.Properties.Buttons"))))});
            this.callReciever.Properties.DataSource = this.callRecieverBindingSource;
            this.callReciever.Properties.DisplayMember = "Name";
            this.callReciever.Properties.NullText = resources.GetString("callReciever.Properties.NullText");
            this.callReciever.Properties.PopupSizeable = false;
            this.callReciever.Properties.ValidateOnEnterKey = true;
            this.callReciever.Properties.ValueMember = "ID";
            this.callReciever.StyleController = this.layoutControl1;
            this.callReciever.Modified += new System.EventHandler(this.callRecieverChanged);
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
            this.lciCallType,
            this.emptySpaceItem1,
            this.lciCallingContact,
            this.lciCallReciever,
            this.lciNotes,
            this.layoutControlItem6});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(800, 450);
            this.Root.TextVisible = false;
            // 
            // lciCallType
            // 
            this.lciCallType.Control = this.callType;
            this.lciCallType.Location = new System.Drawing.Point(0, 0);
            this.lciCallType.Name = "lciCallType";
            this.lciCallType.Size = new System.Drawing.Size(780, 24);
            resources.ApplyResources(this.lciCallType, "lciCallType");
            this.lciCallType.TextSize = new System.Drawing.Size(69, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 122);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(780, 308);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lciCallingContact
            // 
            this.lciCallingContact.Control = this.callingContact;
            this.lciCallingContact.Location = new System.Drawing.Point(0, 24);
            this.lciCallingContact.Name = "lciCallingContact";
            this.lciCallingContact.Size = new System.Drawing.Size(780, 24);
            resources.ApplyResources(this.lciCallingContact, "lciCallingContact");
            this.lciCallingContact.TextSize = new System.Drawing.Size(69, 13);
            // 
            // lciCallReciever
            // 
            this.lciCallReciever.Control = this.callReciever;
            this.lciCallReciever.Location = new System.Drawing.Point(0, 48);
            this.lciCallReciever.Name = "lciCallReciever";
            this.lciCallReciever.Size = new System.Drawing.Size(780, 24);
            resources.ApplyResources(this.lciCallReciever, "lciCallReciever");
            this.lciCallReciever.TextSize = new System.Drawing.Size(69, 13);
            // 
            // lciNotes
            // 
            this.lciNotes.Control = this.textEdit1;
            this.lciNotes.Location = new System.Drawing.Point(0, 72);
            this.lciNotes.Name = "lciNotes";
            this.lciNotes.Size = new System.Drawing.Size(780, 24);
            resources.ApplyResources(this.lciNotes, "lciNotes");
            this.lciNotes.TextSize = new System.Drawing.Size(69, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.sbSubmitChanges;
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
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.Controls.Add(this.layoutControl1);
            this.Name = "EditEntry";
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
            ((System.ComponentModel.ISupportInitialize)(this.lciCallType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCallingContact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCallReciever)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem lciCallType;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem lciCallingContact;
        private DevExpress.XtraLayout.LayoutControlItem lciCallReciever;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraLayout.LayoutControlItem lciNotes;
        private DevExpress.XtraEditors.SimpleButton sbSubmitChanges;
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