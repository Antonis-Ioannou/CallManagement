using CallManagement.Crud_Operations;
using CallManagement.Properties;
using DevExpress.LookAndFeel;
using DevExpress.XtraBars.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace CallManagement
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public static string ConnectionString = string.Empty;
        static string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Megasoft\CallManagement";
        string customLayout = Path.Combine(path, @"gridLayout.xml");
        string defaultGridLayoutFile = Path.Combine(path + @"\defaultLayout.xml");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             gridView1.SaveLayoutToXml(defaultGridLayoutFile);

            if (!File.Exists(customLayout))
                gridView1.RestoreLayoutFromXml(defaultGridLayoutFile);
            //---Load saved layout settings---//
            else
                gridView1.RestoreLayoutFromXml(customLayout);            

            //---Set the state, position and size when the form loads---//
            if (Properties.Settings.Default.F1Size.Width == 0 || Properties.Settings.Default.F1Size.Height == 0)
            {
                // first start
                // optional: add default values
            }
            else
            {
                this.WindowState = Properties.Settings.Default.F1State;

                // we don't want a minimized window at startup
                if (this.WindowState == FormWindowState.Minimized) this.WindowState = FormWindowState.Normal;

                this.Location = Properties.Settings.Default.F1Location;
                this.Size = Properties.Settings.Default.F1Size;
            }
                     
            GetConnectionString();

            if (string.IsNullOrEmpty(ConnectionString))
            {
                Form formLogin = new Login();
                formLogin.ShowDialog();
            }

            //----------load saved skin/palette----------//
            var settings = Properties.Settings.Default;
            if (!String.IsNullOrEmpty(settings.SkinName))
            {
                if (!String.IsNullOrEmpty(settings.SkinName))
                {
                    UserLookAndFeel.Default.SetSkinStyle(settings.SkinName, settings.PaletteName);
                }
                else
                    UserLookAndFeel.Default.SetSkinStyle(settings.SkinName);
            }

            GetConnectionString();
            FillTableAdapter();
        }

        private void FillTableAdapter()
        {
            if (!string.IsNullOrEmpty(ConnectionString))
            {
                callingContactTableAdapter.Connection.ConnectionString = ConnectionString;
                callingContactTableAdapter.Fill(this.dataSet1.CallingContact);

                callRecieverTableAdapter.Connection.ConnectionString = ConnectionString;
                callRecieverTableAdapter.Fill(this.dataSet1.CallReciever);

                callTypeTableAdapter.Connection.ConnectionString = ConnectionString;
                callTypeTableAdapter.Fill(this.dataSet1.CallType);

                callsTableAdapter.Connection.ConnectionString = ConnectionString;
                callsTableAdapter.Fill(dataSet1.Calls);
            }
        }

        private void GetConnectionString()
        {
            string fullPath = Path.Combine(path, @"conStr.xml");

            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            if (!File.Exists(fullPath))
            {
                File.Create(fullPath);
                return;
            }

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(string));

            using (FileStream fs = new FileStream(fullPath, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                ConnectionString = xmlSerializer.Deserialize(fs).ToString();
            }
        }

        private void formCallTypes(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form formCallTypes = new CallTypes();
            formCallTypes.Show();
        }

        private void formCallingContact(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form formCallingContact = new CallingContact();
            formCallingContact.Show();
        }

        private void formCallReciever(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form formCallReciever = new CallReciever();
            formCallReciever.Show();
        }

        //---Status bar info---//
        private void gridView1_RowCountChanged(object sender, EventArgs e)
        {
            //---current total row number on grid & displayed inbound/outbound calls---//
            int gridItems = gridControl1.DefaultView.DataRowCount;
            int inbountCalls = 0;
            int outboundCalls = 0;

            DevExpress.XtraGrid.Columns.GridColumn col = gridView1.Columns.ColumnByFieldName("TypeId");
            if (col == null)
            {
                return;
            }
            else
            {
                int dataRowCount = gridControl1.DefaultView.DataRowCount;
                for (int i = 0; i < dataRowCount; i++)
                {
                    var callType = gridView1.GetRowCellDisplayText(i,col);
                    if (callType == "Εισερχόμενη Κλήση")
                    {
                        inbountCalls++;
                    }
                    else
                    {
                        outboundCalls++;
                    }
                }
            }
            if (System.Globalization.CultureInfo.CurrentCulture.Name == "en")
            {
                bsiTotalCalls.Caption = "Total calls: " + gridItems;
                bsiInboundCalls.Caption = "Inbound: " + inbountCalls;
                bsiOutboundCalls.Caption = "Outbound: " + outboundCalls;
            }
            else
            {
                bsiTotalCalls.Caption = "Σύνολο Κλήσεων: " + gridItems;
                bsiInboundCalls.Caption = "Εισερχόμενες: " + inbountCalls;
                bsiOutboundCalls.Caption = "Εξερχόμενες: " + outboundCalls;
            }
            
        }

        //---Saving position, size of window and skin---//
        private void Form1_Closing(object sender, FormClosingEventArgs e)
        {
            string text = "Are yoy sure you want to exit?";
            string title = "Exit application?";
            var buttons = MessageBoxButtons.YesNo;
            var icon = MessageBoxIcon.Question;
            DialogResult result = MessageBox.Show(text,title, buttons, icon);

            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (result == DialogResult.Yes)
                {
                    Properties.Settings.Default.F1State = this.WindowState;
                    if (this.WindowState == FormWindowState.Normal)
                    {
                        // save location and size if the state is normal
                        Properties.Settings.Default.F1Location = this.Location;
                        Properties.Settings.Default.F1Size = this.Size;
                    }
                    else
                    {
                        // save the RestoreBounds if the form is minimized or maximized!
                        Properties.Settings.Default.F1Location = this.RestoreBounds.Location;
                        Properties.Settings.Default.F1Size = this.RestoreBounds.Size;
                    }
                    //save skin
                    var settings = Properties.Settings.Default;
                    settings.SkinName = UserLookAndFeel.Default.SkinName;
                    settings.PaletteName = UserLookAndFeel.Default.ActiveSvgPaletteName;
                    //Settings.Default[skinList.Caption] = UserLookAndFeel.Default.SkinName;
                    settings.Save();

                    // don't forget to save the settings
                    Settings.Default.Save();
                    gridView1.SaveLayoutToXml(customLayout);
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        //---Save grid layout--//
        private void gridView1_ColumnWidthChanged(object sender, DevExpress.XtraGrid.Views.Base.ColumnEventArgs e)
        {
            //gridView1.SaveLayoutToXml(customLayout);
        }

        //---Reset layout to default---//
        bool restoringDefaultLayout;

        private void resetLayoutDefault(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to restore Default Layout? Your saved layout will be deleted!", "Restore Default Layout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            
            if (dialogResult == DialogResult.Yes)
            {
                File.Delete(customLayout);
                restoringDefaultLayout = true;
                gridView1.RestoreLayoutFromXml(defaultGridLayoutFile);
            }
        }

        private void refreshData(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FillTableAdapter();
        }

        private void setGreek(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string setGreek = "el";

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(string));
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Megasoft\CallManagement";

            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            using (FileStream fs = new FileStream(path + "\\languageSettings.xml", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                bool saveSuccess = true;
                try
                {
                    xmlSerializer.Serialize(fs, setGreek);
                }
                catch
                {
                    saveSuccess = false;
                }
                finally
                {
                    if (saveSuccess)
                    {
                        MessageBox.Show("Greek selected. Need to restart application to apply new settings");
                        string restartNow = "Restart application now?";
                        string title = "Restart";
                        var buttons = MessageBoxButtons.YesNo;
                        var icon = MessageBoxIcon.Question;

                        DialogResult dialogResult = MessageBox.Show(restartNow, title, buttons, icon);
                        if (dialogResult == DialogResult.Yes)
                        {
                            Process.Start(Application.ExecutablePath);
                            Process.GetCurrentProcess().Kill();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong....");
                    }
                }
            }
        }

        private void setEnglish(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string setEnglish = "en";

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(string));
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Megasoft\CallManagement";

            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            using (FileStream fs = new FileStream(path + "\\languageSettings.xml", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                bool saveSuccess = true;
                try
                {
                    xmlSerializer.Serialize(fs, setEnglish);
                }
                catch
                {
                    saveSuccess = false;
                }
                finally
                {
                    if (saveSuccess)
                    {
                        MessageBox.Show("English selected. Need to restart application to apply new settings");
                        string restartNow = "Restart application now?";
                        string title = "Restart";
                        var buttons = MessageBoxButtons.YesNo;
                        var icon = MessageBoxIcon.Question;

                        DialogResult dialogResult = MessageBox.Show(restartNow, title, buttons, icon);
                        if (dialogResult == DialogResult.Yes)
                        {
                            System.Diagnostics.Process.Start(Application.ExecutablePath);
                            Process.GetCurrentProcess().Kill();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong....");
                    }
                }
            }
        }

        private void deleteEntry(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.IsGroupRow(gridView1.FocusedRowHandle)
               || gridView1.RowCount == 0)
                return;
            //----------Δουλεύει----------//
            string warning = "Are you sure you want to delete this entry?";
            string title = "Delete Entry";
            var buttons = MessageBoxButtons.YesNo;
            var icon = MessageBoxIcon.Warning;

            DialogResult dialogResult = MessageBox.Show(warning, title, buttons, icon);
            if (dialogResult == DialogResult.Yes)
            {
                bsCalls.RemoveCurrent();
                callsTableAdapter.Update(dataSet1);
                //int selectedRow = (int)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CallsId");
                //callsTableAdapter.deleteSelectedRow(selectedRow);
                //MessageBox.Show("Delete successful!");
            }
            FillTableAdapter();
        }

        //----------//

        private void OpenEditForm(int id)
        {
            var openedForm = Application.OpenForms.OfType<EditEntry>().Select(t => t).Where(t => t.SelectedId == id).FirstOrDefault();

            if (openedForm != null)
                openedForm.BringToFront();
            else
            {
                EditEntry editEntry = new EditEntry(id);
                editEntry.Text = id < 0 ? editEntry.Text = "Create Call" : editEntry.Text = "Edit Call";
                editEntry.ReloadDataEvent += EditEntry_ReloadDataEvent;
                editEntry.Show();
            }
        }

        private void EditEntry_ReloadDataEvent()
        {
            FillTableAdapter();
        }

        private void bbiCreateEntry_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenEditForm(-1);
        }

        private void bbiEditEntry_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.IsGroupRow(gridView1.FocusedRowHandle)
                || gridView1.RowCount == 0)
                return;

            OpenEditForm((int)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CallsId"));
        }

        private void dbClickEdit(object sender, EventArgs e)
        {
            if (gridView1.IsGroupRow(gridView1.FocusedRowHandle))
                return;

            OpenEditForm((int)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CallsId"));
        }

        private void gridView1_BeforeLoadLayout(object sender, DevExpress.Utils.LayoutAllowEventArgs e)
        {
            if (e.PreviousVersion != gridView1.OptionsLayout.LayoutVersion
                && !restoringDefaultLayout)
                e.Allow = false;
        }
    }
}
