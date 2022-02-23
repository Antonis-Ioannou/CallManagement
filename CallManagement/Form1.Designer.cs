
namespace CallManagement
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.backstageViewControl1 = new DevExpress.XtraBars.Ribbon.BackstageViewControl();
            this.backstageViewClientControl1 = new DevExpress.XtraBars.Ribbon.BackstageViewClientControl();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.cbeLanguage = new DevExpress.XtraEditors.ComboBoxEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciLanguage = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.bsviSettings = new DevExpress.XtraBars.Ribbon.BackstageViewTabItem();
            this.bbiCallTypes = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCallingContact = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCallReceiver = new DevExpress.XtraBars.BarButtonItem();
            this.bbiResetLayout = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCreateEntry = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEditEntry = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDeleteEntry = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRefreshData = new DevExpress.XtraBars.BarButtonItem();
            this.bsiLanguage = new DevExpress.XtraBars.BarSubItem();
            this.bciEnglish = new DevExpress.XtraBars.BarCheckItem();
            this.bciGreek = new DevExpress.XtraBars.BarCheckItem();
            this.bsiSkin = new DevExpress.XtraBars.BarSubItem();
            this.skinList = new DevExpress.XtraBars.SkinBarSubItem();
            this.skinPaletteDropDown = new DevExpress.XtraBars.SkinPaletteDropDownButtonItem();
            this.ribbonPageManageCalls = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgActions = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageCalls = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgParameters = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageLayout = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgLayout = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.applicationMenu1 = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            this.barToggleSwitchItem3 = new DevExpress.XtraBars.BarToggleSwitchItem();
            this.barToggleSwitchItem4 = new DevExpress.XtraBars.BarToggleSwitchItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.barToggleSwitchItem1 = new DevExpress.XtraBars.BarToggleSwitchItem();
            this.barToggleSwitchItem2 = new DevExpress.XtraBars.BarToggleSwitchItem();
            this.skinPaletteDropDownButtonItem1 = new DevExpress.XtraBars.SkinPaletteDropDownButtonItem();
            this.skinDropDownButtonItem1 = new DevExpress.XtraBars.SkinDropDownButtonItem();
            this.skinDropDownButtonItem2 = new DevExpress.XtraBars.SkinDropDownButtonItem();
            this.skinBarSubItem1 = new DevExpress.XtraBars.SkinBarSubItem();
            this.skinPaletteDropDownButtonItem2 = new DevExpress.XtraBars.SkinPaletteDropDownButtonItem();
            this.skinDropDownButtonItem3 = new DevExpress.XtraBars.SkinDropDownButtonItem();
            this.skinBarSubItem2 = new DevExpress.XtraBars.SkinBarSubItem();
            this.skinPaletteDropDownButtonItem3 = new DevExpress.XtraBars.SkinPaletteDropDownButtonItem();
            this.barCheckItem1 = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItem2 = new DevExpress.XtraBars.BarCheckItem();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bsCalls = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new CallManagement.DataSet1();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCallsId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreationDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTypeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.callsCallTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colReceiverId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.callsCallRecieverBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colCallContactId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.callsCallingContactBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colNotes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.callsTableAdapter = new CallManagement.DataSet1TableAdapters.CallsTableAdapter();
            this.callTypeTableAdapter = new CallManagement.DataSet1TableAdapters.CallTypeTableAdapter();
            this.callRecieverTableAdapter = new CallManagement.DataSet1TableAdapters.CallRecieverTableAdapter();
            this.callingContactTableAdapter = new CallManagement.DataSet1TableAdapters.CallingContactTableAdapter();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.bsiTotalCalls = new DevExpress.XtraBars.BarStaticItem();
            this.bsiInboundCalls = new DevExpress.XtraBars.BarStaticItem();
            this.bsiOutboundCalls = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.sharedImageCollection1 = new DevExpress.Utils.SharedImageCollection(this.components);
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backstageViewControl1)).BeginInit();
            this.backstageViewControl1.SuspendLayout();
            this.backstageViewClientControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbeLanguage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLanguage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCalls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.callsCallTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.callsCallRecieverBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.callsCallingContactBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sharedImageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sharedImageCollection1.ImageSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ApplicationButtonDropDownControl = this.backstageViewControl1;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.bbiCallTypes,
            this.bbiCallingContact,
            this.bbiCallReceiver,
            this.bbiResetLayout,
            this.bbiCreateEntry,
            this.bbiEditEntry,
            this.bbiDeleteEntry,
            this.bbiRefreshData,
            this.bsiLanguage,
            this.bsiSkin,
            this.skinList,
            this.skinPaletteDropDown,
            this.bciEnglish,
            this.bciGreek});
            resources.ApplyResources(this.ribbonControl1, "ribbonControl1");
            this.ribbonControl1.MaxItemId = 36;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageManageCalls,
            this.ribbonPageCalls,
            this.ribbonPageLayout});
            // 
            // backstageViewControl1
            // 
            this.backstageViewControl1.Controls.Add(this.backstageViewClientControl1);
            this.backstageViewControl1.Items.Add(this.bsviSettings);
            resources.ApplyResources(this.backstageViewControl1, "backstageViewControl1");
            this.backstageViewControl1.Name = "backstageViewControl1";
            this.backstageViewControl1.OwnerControl = this.ribbonControl1;
            this.backstageViewControl1.SelectedTab = this.bsviSettings;
            this.backstageViewControl1.SelectedTabIndex = 0;
            this.backstageViewControl1.VisibleInDesignTime = true;
            // 
            // backstageViewClientControl1
            // 
            this.backstageViewClientControl1.Controls.Add(this.layoutControl2);
            resources.ApplyResources(this.backstageViewClientControl1, "backstageViewClientControl1");
            this.backstageViewClientControl1.Name = "backstageViewClientControl1";
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.cbeLanguage);
            resources.ApplyResources(this.layoutControl2, "layoutControl2");
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup1;
            // 
            // cbeLanguage
            // 
            resources.ApplyResources(this.cbeLanguage, "cbeLanguage");
            this.cbeLanguage.MenuManager = this.ribbonControl1;
            this.cbeLanguage.Name = "cbeLanguage";
            this.cbeLanguage.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("cbeLanguage.Properties.Buttons"))))});
            this.cbeLanguage.StyleController = this.layoutControl2;
            this.cbeLanguage.SelectedIndexChanged += new System.EventHandler(this.changeLanguage);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciLanguage,
            this.emptySpaceItem1,
            this.emptySpaceItem3});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(825, 399);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lciLanguage
            // 
            this.lciLanguage.Control = this.cbeLanguage;
            this.lciLanguage.Location = new System.Drawing.Point(0, 0);
            this.lciLanguage.MaxSize = new System.Drawing.Size(325, 24);
            this.lciLanguage.MinSize = new System.Drawing.Size(325, 24);
            this.lciLanguage.Name = "lciLanguage";
            this.lciLanguage.Size = new System.Drawing.Size(325, 24);
            this.lciLanguage.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            resources.ApplyResources(this.lciLanguage, "lciLanguage");
            this.lciLanguage.TextSize = new System.Drawing.Size(47, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 24);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(805, 355);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(325, 0);
            this.emptySpaceItem3.MaxSize = new System.Drawing.Size(480, 24);
            this.emptySpaceItem3.MinSize = new System.Drawing.Size(480, 24);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(480, 24);
            this.emptySpaceItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // bsviSettings
            // 
            this.bsviSettings.AllowHtmlString = true;
            resources.ApplyResources(this.bsviSettings, "bsviSettings");
            this.bsviSettings.ContentControl = this.backstageViewClientControl1;
            this.bsviSettings.Name = "bsviSettings";
            this.bsviSettings.Selected = true;
            // 
            // bbiCallTypes
            // 
            resources.ApplyResources(this.bbiCallTypes, "bbiCallTypes");
            this.bbiCallTypes.Id = 2;
            this.bbiCallTypes.Name = "bbiCallTypes";
            this.bbiCallTypes.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.formCallTypes);
            // 
            // bbiCallingContact
            // 
            resources.ApplyResources(this.bbiCallingContact, "bbiCallingContact");
            this.bbiCallingContact.Id = 5;
            this.bbiCallingContact.Name = "bbiCallingContact";
            this.bbiCallingContact.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.formCallingContact);
            // 
            // bbiCallReceiver
            // 
            resources.ApplyResources(this.bbiCallReceiver, "bbiCallReceiver");
            this.bbiCallReceiver.Id = 6;
            this.bbiCallReceiver.Name = "bbiCallReceiver";
            this.bbiCallReceiver.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.formCallReciever);
            // 
            // bbiResetLayout
            // 
            resources.ApplyResources(this.bbiResetLayout, "bbiResetLayout");
            this.bbiResetLayout.Id = 8;
            this.bbiResetLayout.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiResetLayout.ImageOptions.Image")));
            this.bbiResetLayout.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiResetLayout.ImageOptions.LargeImage")));
            this.bbiResetLayout.Name = "bbiResetLayout";
            this.bbiResetLayout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.resetLayoutDefault);
            // 
            // bbiCreateEntry
            // 
            resources.ApplyResources(this.bbiCreateEntry, "bbiCreateEntry");
            this.bbiCreateEntry.Id = 10;
            this.bbiCreateEntry.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiCreateEntry.ImageOptions.Image")));
            this.bbiCreateEntry.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiCreateEntry.ImageOptions.LargeImage")));
            this.bbiCreateEntry.Name = "bbiCreateEntry";
            this.bbiCreateEntry.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiCreateEntry_ItemClick);
            // 
            // bbiEditEntry
            // 
            resources.ApplyResources(this.bbiEditEntry, "bbiEditEntry");
            this.bbiEditEntry.Id = 11;
            this.bbiEditEntry.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiEditEntry.ImageOptions.Image")));
            this.bbiEditEntry.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiEditEntry.ImageOptions.LargeImage")));
            this.bbiEditEntry.Name = "bbiEditEntry";
            this.bbiEditEntry.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiEditEntry_ItemClick);
            // 
            // bbiDeleteEntry
            // 
            resources.ApplyResources(this.bbiDeleteEntry, "bbiDeleteEntry");
            this.bbiDeleteEntry.Id = 12;
            this.bbiDeleteEntry.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiDeleteEntry.ImageOptions.Image")));
            this.bbiDeleteEntry.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiDeleteEntry.ImageOptions.LargeImage")));
            this.bbiDeleteEntry.Name = "bbiDeleteEntry";
            this.bbiDeleteEntry.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.deleteEntry);
            // 
            // bbiRefreshData
            // 
            resources.ApplyResources(this.bbiRefreshData, "bbiRefreshData");
            this.bbiRefreshData.Id = 13;
            this.bbiRefreshData.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiRefreshData.ImageOptions.Image")));
            this.bbiRefreshData.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiRefreshData.ImageOptions.LargeImage")));
            this.bbiRefreshData.Name = "bbiRefreshData";
            this.bbiRefreshData.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.refreshData);
            // 
            // bsiLanguage
            // 
            resources.ApplyResources(this.bsiLanguage, "bsiLanguage");
            this.bsiLanguage.Id = 16;
            this.bsiLanguage.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bciEnglish),
            new DevExpress.XtraBars.LinkPersistInfo(this.bciGreek)});
            this.bsiLanguage.Name = "bsiLanguage";
            // 
            // bciEnglish
            // 
            resources.ApplyResources(this.bciEnglish, "bciEnglish");
            this.bciEnglish.Id = 34;
            this.bciEnglish.Name = "bciEnglish";
            this.bciEnglish.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.setEnglish);
            // 
            // bciGreek
            // 
            resources.ApplyResources(this.bciGreek, "bciGreek");
            this.bciGreek.Id = 35;
            this.bciGreek.Name = "bciGreek";
            this.bciGreek.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.setGreek);
            // 
            // bsiSkin
            // 
            resources.ApplyResources(this.bsiSkin, "bsiSkin");
            this.bsiSkin.Id = 17;
            this.bsiSkin.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.skinList),
            new DevExpress.XtraBars.LinkPersistInfo(this.skinPaletteDropDown)});
            this.bsiSkin.Name = "bsiSkin";
            // 
            // skinList
            // 
            this.skinList.AllowSerializeChildren = DevExpress.Utils.DefaultBoolean.False;
            resources.ApplyResources(this.skinList, "skinList");
            this.skinList.Id = 27;
            this.skinList.Name = "skinList";
            // 
            // skinPaletteDropDown
            // 
            this.skinPaletteDropDown.Id = 29;
            this.skinPaletteDropDown.Name = "skinPaletteDropDown";
            // 
            // ribbonPageManageCalls
            // 
            this.ribbonPageManageCalls.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgActions});
            this.ribbonPageManageCalls.Name = "ribbonPageManageCalls";
            resources.ApplyResources(this.ribbonPageManageCalls, "ribbonPageManageCalls");
            // 
            // rpgActions
            // 
            this.rpgActions.ItemLinks.Add(this.bbiCreateEntry);
            this.rpgActions.ItemLinks.Add(this.bbiEditEntry);
            this.rpgActions.ItemLinks.Add(this.bbiDeleteEntry);
            this.rpgActions.ItemLinks.Add(this.bbiRefreshData);
            this.rpgActions.Name = "rpgActions";
            resources.ApplyResources(this.rpgActions, "rpgActions");
            // 
            // ribbonPageCalls
            // 
            this.ribbonPageCalls.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgParameters});
            this.ribbonPageCalls.Name = "ribbonPageCalls";
            resources.ApplyResources(this.ribbonPageCalls, "ribbonPageCalls");
            // 
            // rpgParameters
            // 
            this.rpgParameters.ItemLinks.Add(this.bbiCallingContact);
            this.rpgParameters.ItemLinks.Add(this.bbiCallTypes);
            this.rpgParameters.ItemLinks.Add(this.bbiCallReceiver);
            this.rpgParameters.Name = "rpgParameters";
            resources.ApplyResources(this.rpgParameters, "rpgParameters");
            // 
            // ribbonPageLayout
            // 
            this.ribbonPageLayout.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgLayout});
            this.ribbonPageLayout.Name = "ribbonPageLayout";
            resources.ApplyResources(this.ribbonPageLayout, "ribbonPageLayout");
            // 
            // rpgLayout
            // 
            this.rpgLayout.ItemLinks.Add(this.bbiResetLayout);
            this.rpgLayout.Name = "rpgLayout";
            resources.ApplyResources(this.rpgLayout, "rpgLayout");
            // 
            // applicationMenu1
            // 
            this.applicationMenu1.ItemLinks.Add(this.bsiLanguage);
            this.applicationMenu1.ItemLinks.Add(this.bsiSkin);
            this.applicationMenu1.Name = "applicationMenu1";
            this.applicationMenu1.Ribbon = this.ribbonControl1;
            this.applicationMenu1.ShowRightPane = true;
            // 
            // barToggleSwitchItem3
            // 
            resources.ApplyResources(this.barToggleSwitchItem3, "barToggleSwitchItem3");
            this.barToggleSwitchItem3.Id = 32;
            this.barToggleSwitchItem3.Name = "barToggleSwitchItem3";
            // 
            // barToggleSwitchItem4
            // 
            resources.ApplyResources(this.barToggleSwitchItem4, "barToggleSwitchItem4");
            this.barToggleSwitchItem4.Id = 33;
            this.barToggleSwitchItem4.Name = "barToggleSwitchItem4";
            // 
            // barButtonItem4
            // 
            resources.ApplyResources(this.barButtonItem4, "barButtonItem4");
            this.barButtonItem4.Id = 7;
            this.barButtonItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.barButtonItem4.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.LargeImage")));
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barSubItem1
            // 
            resources.ApplyResources(this.barSubItem1, "barSubItem1");
            this.barSubItem1.Id = 14;
            this.barSubItem1.Name = "barSubItem1";
            // 
            // barSubItem2
            // 
            resources.ApplyResources(this.barSubItem2, "barSubItem2");
            this.barSubItem2.Id = 15;
            this.barSubItem2.Name = "barSubItem2";
            // 
            // barToggleSwitchItem1
            // 
            resources.ApplyResources(this.barToggleSwitchItem1, "barToggleSwitchItem1");
            this.barToggleSwitchItem1.Id = 18;
            this.barToggleSwitchItem1.Name = "barToggleSwitchItem1";
            // 
            // barToggleSwitchItem2
            // 
            resources.ApplyResources(this.barToggleSwitchItem2, "barToggleSwitchItem2");
            this.barToggleSwitchItem2.Id = 19;
            this.barToggleSwitchItem2.Name = "barToggleSwitchItem2";
            // 
            // skinPaletteDropDownButtonItem1
            // 
            this.skinPaletteDropDownButtonItem1.Id = 20;
            this.skinPaletteDropDownButtonItem1.Name = "skinPaletteDropDownButtonItem1";
            // 
            // skinDropDownButtonItem1
            // 
            this.skinDropDownButtonItem1.Id = 21;
            this.skinDropDownButtonItem1.Name = "skinDropDownButtonItem1";
            // 
            // skinDropDownButtonItem2
            // 
            this.skinDropDownButtonItem2.Id = 22;
            this.skinDropDownButtonItem2.Name = "skinDropDownButtonItem2";
            // 
            // skinBarSubItem1
            // 
            this.skinBarSubItem1.AllowSerializeChildren = DevExpress.Utils.DefaultBoolean.False;
            resources.ApplyResources(this.skinBarSubItem1, "skinBarSubItem1");
            this.skinBarSubItem1.Id = 23;
            this.skinBarSubItem1.Name = "skinBarSubItem1";
            // 
            // skinPaletteDropDownButtonItem2
            // 
            this.skinPaletteDropDownButtonItem2.Id = 24;
            this.skinPaletteDropDownButtonItem2.Name = "skinPaletteDropDownButtonItem2";
            // 
            // skinDropDownButtonItem3
            // 
            this.skinDropDownButtonItem3.Id = 25;
            this.skinDropDownButtonItem3.Name = "skinDropDownButtonItem3";
            // 
            // skinBarSubItem2
            // 
            this.skinBarSubItem2.AllowSerializeChildren = DevExpress.Utils.DefaultBoolean.False;
            resources.ApplyResources(this.skinBarSubItem2, "skinBarSubItem2");
            this.skinBarSubItem2.Id = 26;
            this.skinBarSubItem2.Name = "skinBarSubItem2";
            // 
            // skinPaletteDropDownButtonItem3
            // 
            this.skinPaletteDropDownButtonItem3.Id = 28;
            this.skinPaletteDropDownButtonItem3.Name = "skinPaletteDropDownButtonItem3";
            // 
            // barCheckItem1
            // 
            resources.ApplyResources(this.barCheckItem1, "barCheckItem1");
            this.barCheckItem1.Id = 30;
            this.barCheckItem1.Name = "barCheckItem1";
            // 
            // barCheckItem2
            // 
            resources.ApplyResources(this.barCheckItem2, "barCheckItem2");
            this.barCheckItem2.Id = 31;
            this.barCheckItem2.Name = "barCheckItem2";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl1);
            resources.ApplyResources(this.layoutControl1, "layoutControl1");
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bsCalls;
            resources.ApplyResources(this.gridControl1, "gridControl1");
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbonControl1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemLookUpEdit2,
            this.repositoryItemLookUpEdit3});
            this.gridControl1.ShowOnlyPredefinedDetails = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.dbClickEdit);
            // 
            // bsCalls
            // 
            this.bsCalls.DataMember = "Calls";
            this.bsCalls.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCallsId,
            this.colCreationDate,
            this.colTypeId,
            this.colReceiverId,
            this.colCallContactId,
            this.colNotes,
            this.colModifiedDate});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsLayout.LayoutVersion = "1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colCreationDate, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gridView1.ColumnWidthChanged += new DevExpress.XtraGrid.Views.Base.ColumnEventHandler(this.gridView1_ColumnWidthChanged);
            this.gridView1.BeforeLoadLayout += new DevExpress.Utils.LayoutAllowEventHandler(this.gridView1_BeforeLoadLayout);
            this.gridView1.RowCountChanged += new System.EventHandler(this.gridView1_RowCountChanged);
            // 
            // colCallsId
            // 
            resources.ApplyResources(this.colCallsId, "colCallsId");
            this.colCallsId.FieldName = "CallsId";
            this.colCallsId.Name = "colCallsId";
            this.colCallsId.ShowUnboundExpressionMenu = true;
            // 
            // colCreationDate
            // 
            resources.ApplyResources(this.colCreationDate, "colCreationDate");
            this.colCreationDate.FieldName = "CreationDate";
            this.colCreationDate.Name = "colCreationDate";
            // 
            // colTypeId
            // 
            resources.ApplyResources(this.colTypeId, "colTypeId");
            this.colTypeId.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colTypeId.FieldName = "TypeId";
            this.colTypeId.Name = "colTypeId";
            // 
            // repositoryItemLookUpEdit1
            // 
            resources.ApplyResources(this.repositoryItemLookUpEdit1, "repositoryItemLookUpEdit1");
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("repositoryItemLookUpEdit1.Buttons"))))});
            this.repositoryItemLookUpEdit1.DataSource = this.callsCallTypeBindingSource;
            this.repositoryItemLookUpEdit1.DisplayMember = "Description";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ValueMember = "ID";
            // 
            // callsCallTypeBindingSource
            // 
            this.callsCallTypeBindingSource.DataMember = "CallType";
            this.callsCallTypeBindingSource.DataSource = this.dataSet1;
            // 
            // colReceiverId
            // 
            resources.ApplyResources(this.colReceiverId, "colReceiverId");
            this.colReceiverId.ColumnEdit = this.repositoryItemLookUpEdit2;
            this.colReceiverId.FieldName = "ReceiverId";
            this.colReceiverId.Name = "colReceiverId";
            // 
            // repositoryItemLookUpEdit2
            // 
            resources.ApplyResources(this.repositoryItemLookUpEdit2, "repositoryItemLookUpEdit2");
            this.repositoryItemLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("repositoryItemLookUpEdit2.Buttons"))))});
            this.repositoryItemLookUpEdit2.DataSource = this.callsCallRecieverBindingSource;
            this.repositoryItemLookUpEdit2.DisplayMember = "Name";
            this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
            this.repositoryItemLookUpEdit2.ValueMember = "ID";
            // 
            // callsCallRecieverBindingSource
            // 
            this.callsCallRecieverBindingSource.DataMember = "CallReciever";
            this.callsCallRecieverBindingSource.DataSource = this.dataSet1;
            // 
            // colCallContactId
            // 
            resources.ApplyResources(this.colCallContactId, "colCallContactId");
            this.colCallContactId.ColumnEdit = this.repositoryItemLookUpEdit3;
            this.colCallContactId.FieldName = "CallContactId";
            this.colCallContactId.Name = "colCallContactId";
            // 
            // repositoryItemLookUpEdit3
            // 
            resources.ApplyResources(this.repositoryItemLookUpEdit3, "repositoryItemLookUpEdit3");
            this.repositoryItemLookUpEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("repositoryItemLookUpEdit3.Buttons"))))});
            this.repositoryItemLookUpEdit3.DataSource = this.callsCallingContactBindingSource;
            this.repositoryItemLookUpEdit3.DisplayMember = "Name";
            this.repositoryItemLookUpEdit3.Name = "repositoryItemLookUpEdit3";
            this.repositoryItemLookUpEdit3.ValueMember = "ID";
            // 
            // callsCallingContactBindingSource
            // 
            this.callsCallingContactBindingSource.DataMember = "CallingContact";
            this.callsCallingContactBindingSource.DataSource = this.dataSet1;
            // 
            // colNotes
            // 
            resources.ApplyResources(this.colNotes, "colNotes");
            this.colNotes.FieldName = "Notes";
            this.colNotes.Name = "colNotes";
            // 
            // colModifiedDate
            // 
            resources.ApplyResources(this.colModifiedDate, "colModifiedDate");
            this.colModifiedDate.FieldName = "ModifiedDate";
            this.colModifiedDate.Name = "colModifiedDate";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1308, 478);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1288, 458);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // callsTableAdapter
            // 
            this.callsTableAdapter.ClearBeforeFill = true;
            // 
            // callTypeTableAdapter
            // 
            this.callTypeTableAdapter.ClearBeforeFill = true;
            // 
            // callRecieverTableAdapter
            // 
            this.callRecieverTableAdapter.ClearBeforeFill = true;
            // 
            // callingContactTableAdapter
            // 
            this.callingContactTableAdapter.ClearBeforeFill = true;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bsiTotalCalls,
            this.bsiInboundCalls,
            this.bsiOutboundCalls});
            this.barManager1.MaxItemId = 3;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bsiTotalCalls),
            new DevExpress.XtraBars.LinkPersistInfo(this.bsiInboundCalls),
            new DevExpress.XtraBars.LinkPersistInfo(this.bsiOutboundCalls)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            resources.ApplyResources(this.bar3, "bar3");
            // 
            // bsiTotalCalls
            // 
            resources.ApplyResources(this.bsiTotalCalls, "bsiTotalCalls");
            this.bsiTotalCalls.Id = 0;
            this.bsiTotalCalls.Name = "bsiTotalCalls";
            // 
            // bsiInboundCalls
            // 
            resources.ApplyResources(this.bsiInboundCalls, "bsiInboundCalls");
            this.bsiInboundCalls.Id = 1;
            this.bsiInboundCalls.Name = "bsiInboundCalls";
            // 
            // bsiOutboundCalls
            // 
            resources.ApplyResources(this.bsiOutboundCalls, "bsiOutboundCalls");
            this.bsiOutboundCalls.Id = 2;
            this.bsiOutboundCalls.Name = "bsiOutboundCalls";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            resources.ApplyResources(this.barDockControlTop, "barDockControlTop");
            this.barDockControlTop.Manager = this.barManager1;
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            resources.ApplyResources(this.barDockControlBottom, "barDockControlBottom");
            this.barDockControlBottom.Manager = this.barManager1;
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            resources.ApplyResources(this.barDockControlLeft, "barDockControlLeft");
            this.barDockControlLeft.Manager = this.barManager1;
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            resources.ApplyResources(this.barDockControlRight, "barDockControlRight");
            this.barDockControlRight.Manager = this.barManager1;
            // 
            // sharedImageCollection1
            // 
            // 
            // 
            // 
            this.sharedImageCollection1.ImageSource.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("sharedImageCollection1.ImageSource.ImageStream")));
            this.sharedImageCollection1.ParentControl = this;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.backstageViewControl1);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "Form1";
            this.Ribbon = this.ribbonControl1;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_Closing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backstageViewControl1)).EndInit();
            this.backstageViewControl1.ResumeLayout(false);
            this.backstageViewClientControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbeLanguage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLanguage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCalls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.callsCallTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.callsCallRecieverBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.callsCallingContactBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sharedImageCollection1.ImageSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sharedImageCollection1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageCalls;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgParameters;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource bsCalls;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.CallsTableAdapter callsTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colCallsId;
        private DevExpress.XtraGrid.Columns.GridColumn colCreationDate;
        private DevExpress.XtraGrid.Columns.GridColumn colTypeId;
        private DevExpress.XtraGrid.Columns.GridColumn colReceiverId;
        private DevExpress.XtraGrid.Columns.GridColumn colCallContactId;
        private DevExpress.XtraGrid.Columns.GridColumn colNotes;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedDate;
        private DevExpress.XtraBars.BarButtonItem bbiCallTypes;
        private DevExpress.XtraBars.BarButtonItem bbiCallingContact;
        private DevExpress.XtraBars.BarButtonItem bbiCallReceiver;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private System.Windows.Forms.BindingSource callsCallTypeBindingSource;
        private DataSet1TableAdapters.CallTypeTableAdapter callTypeTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
        private System.Windows.Forms.BindingSource callsCallRecieverBindingSource;
        private DataSet1TableAdapters.CallRecieverTableAdapter callRecieverTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit3;
        private System.Windows.Forms.BindingSource callsCallingContactBindingSource;
        private DataSet1TableAdapters.CallingContactTableAdapter callingContactTableAdapter;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarStaticItem bsiTotalCalls;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarStaticItem bsiInboundCalls;
        private DevExpress.XtraBars.BarStaticItem bsiOutboundCalls;
        private DevExpress.XtraBars.BarButtonItem bbiResetLayout;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgLayout;
        private DevExpress.XtraBars.BarButtonItem bbiCreateEntry;
        private DevExpress.XtraBars.BarButtonItem bbiEditEntry;
        private DevExpress.XtraBars.BarButtonItem bbiDeleteEntry;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageManageCalls;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgActions;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageLayout;
        private DevExpress.XtraBars.BarButtonItem bbiRefreshData;
        private DevExpress.XtraBars.Ribbon.ApplicationMenu applicationMenu1;
        private DevExpress.XtraBars.BarSubItem bsiLanguage;
        private DevExpress.XtraBars.BarSubItem bsiSkin;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private DevExpress.XtraBars.BarToggleSwitchItem barToggleSwitchItem1;
        private DevExpress.XtraBars.BarToggleSwitchItem barToggleSwitchItem2;
        private DevExpress.XtraBars.SkinPaletteDropDownButtonItem skinPaletteDropDownButtonItem1;
        private DevExpress.XtraBars.SkinDropDownButtonItem skinDropDownButtonItem1;
        private DevExpress.XtraBars.SkinDropDownButtonItem skinDropDownButtonItem2;
        private DevExpress.XtraBars.SkinBarSubItem skinBarSubItem1;
        private DevExpress.XtraBars.SkinPaletteDropDownButtonItem skinPaletteDropDownButtonItem2;
        private DevExpress.XtraBars.SkinDropDownButtonItem skinDropDownButtonItem3;
        private DevExpress.XtraBars.SkinBarSubItem skinBarSubItem2;
        private DevExpress.XtraBars.SkinBarSubItem skinList;
        private DevExpress.XtraBars.SkinPaletteDropDownButtonItem skinPaletteDropDownButtonItem3;
        private DevExpress.XtraBars.SkinPaletteDropDownButtonItem skinPaletteDropDown;
        private DevExpress.XtraBars.BarCheckItem barCheckItem1;
        private DevExpress.XtraBars.BarCheckItem barCheckItem2;
        private DevExpress.XtraBars.BarToggleSwitchItem barToggleSwitchItem3;
        private DevExpress.XtraBars.BarToggleSwitchItem barToggleSwitchItem4;
        private DevExpress.XtraBars.BarCheckItem bciEnglish;
        private DevExpress.XtraBars.BarCheckItem bciGreek;
        private DevExpress.XtraBars.Ribbon.BackstageViewControl backstageViewControl1;
        private DevExpress.XtraBars.Ribbon.BackstageViewClientControl backstageViewClientControl1;
        private DevExpress.XtraBars.Ribbon.BackstageViewTabItem bsviSettings;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.ComboBoxEdit cbeLanguage;
        private DevExpress.XtraLayout.LayoutControlItem lciLanguage;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.Utils.SharedImageCollection sharedImageCollection1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
    }
}

