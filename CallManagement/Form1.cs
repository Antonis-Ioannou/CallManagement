﻿using CallManagement.Crud_Operations;
using CallManagement.Messages;
using CallManagement.Properties;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraEditors;
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
                try
                {
                    ConnectionString = xmlSerializer.Deserialize(fs).ToString();
                }
                catch (Exception)
                {
                    //XtraMessageBox.Show(e.Message);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (System.Globalization.CultureInfo.CurrentCulture.Name == "en")
            {
                bciEnglish.Checked = true;
                bciGreek.Checked = false;
            }
            else
            {
                bciGreek.Checked = true;
                bciEnglish.Checked = false;
            }

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
                formLogin.StartPosition = FormStartPosition.Manual;
                formLogin.Location = Settings.Default.F1Location;
                formLogin.ShowDialog();
                if (formLogin.DialogResult != DialogResult.OK)
                {
                    XtraMessageBox.Show("Exiting application. Create connection and try again");
                    Process.GetCurrentProcess().Kill();
                }
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

            //---backstage view language settings---//
            List<string> languages = new List<string> {"English", "Ελληνικά" };
            DevExpress.XtraEditors.Repository.RepositoryItemComboBox properties = cbeLanguage.Properties;
            properties.Items.AddRange(languages);
            //---backstage view skin settings---//
            DevExpress.UserSkins.BonusSkins.Register();
            foreach (SkinContainer cnt in SkinManager.Default.Skins)
            {
                cbeSkins.Properties.Items.Add(cnt.SkinName);
            }
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

        private void formCallTypes(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var formCallTypes = Application.OpenForms.OfType<CallTypes>().Select(t => t).FirstOrDefault();
            if (formCallTypes != null)
            {
                formCallTypes.BringToFront();
            }
            else
            {
                formCallTypes = new CallTypes();
                formCallTypes.Show();
            }
        }

        private void formCallingContact(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var formCallingContact = Application.OpenForms.OfType<CallingContact>().Select(t => t).FirstOrDefault();
            if (formCallingContact != null)
            {
                formCallingContact.BringToFront();
            }
            else
            {
                formCallingContact = new CallingContact();
                formCallingContact.Show();
            }
        }

        private void formCallReciever(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var formCallReciever = Application.OpenForms.OfType<CallReciever>().Select(t => t).FirstOrDefault();
            if (formCallReciever != null)
            {
                formCallReciever.BringToFront();
            }
            else
            {
                formCallReciever = new CallReciever();
                formCallReciever.Show();
            }
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
                    var callType = gridView1.GetRowCellDisplayText(i, col);
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
            bsiTotalCalls.Caption = Messages.Messages.barStatusItemTotalCalls + gridItems;
            bsiInboundCalls.Caption = Messages.Messages.barStatusItemInbound + inbountCalls;
            bsiOutboundCalls.Caption = Messages.Messages.barStatusItemOutbound + outboundCalls;

        }

        //---Saving position, size of window and skin---//
        private void Form1_Closing(object sender, FormClosingEventArgs e)
        {
            DialogResult result;
            string title = Messages.Messages.ApplicationClosingConfirmationTitle;
            string text = Messages.Messages.ApplicationClosingConfirmationText;
            var buttons = MessageBoxButtons.YesNo;
            var icon = MessageBoxIcon.Question;

            result = XtraMessageBox.Show(text, title, buttons, icon);

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
            string text = Messages.Messages.resetLayoutText;
            string title = Messages.Messages.resetLayoutTitle;
            DialogResult dialogResult;
            var buttons = MessageBoxButtons.YesNo;
            var icon = MessageBoxIcon.Question;

            dialogResult = XtraMessageBox.Show(text, title, buttons, icon);

            if (dialogResult == DialogResult.Yes)
            {
                File.Delete(customLayout);
                restoringDefaultLayout = true;
                gridView1.RestoreLayoutFromXml(defaultGridLayoutFile);
            }
        }

        //---backstageview language settings---//
        private void changeLanguage(object sender, EventArgs e)
        {
            int langIndex = cbeLanguage.SelectedIndex;
            if (langIndex == 0)
            {
                string setEnglish = "en";

                if (System.Globalization.CultureInfo.CurrentCulture.Name == "en")
                {
                    XtraMessageBox.Show(Messages.Messages.EnglishLanguageCaption);
                    return;
                }

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
                        XtraMessageBox.Show(Messages.Messages.EnglishLanguageCaption);
                        string restartNow = Messages.Messages.languageChangeRestartAppText;
                        string title = Messages.Messages.languageChangeRestartAppTitle;
                        string exception = Messages.Messages.languageChangeRestartAppException;
                        var buttons = MessageBoxButtons.YesNo;
                        var icon = MessageBoxIcon.Question;
                        if (saveSuccess)
                        {
                            DialogResult dialogResult = XtraMessageBox.Show(restartNow, title, buttons, icon);
                            if (dialogResult == DialogResult.Yes)
                            {
                                //save skin
                                var settings = Properties.Settings.Default;
                                settings.SkinName = UserLookAndFeel.Default.SkinName;
                                settings.PaletteName = UserLookAndFeel.Default.ActiveSvgPaletteName;
                                settings.Save();

                                System.Diagnostics.Process.Start(Application.ExecutablePath);
                                Process.GetCurrentProcess().Kill();
                                bciGreek.Checked = false;
                                bciEnglish.Checked = true;
                            }
                            bciEnglish.Checked = false;
                        }
                        else
                        {
                            XtraMessageBox.Show(exception);
                        }
                    }
                }
            }
            else
            {
                string setGreek = "el";

                if (System.Globalization.CultureInfo.CurrentCulture.Name == "el")
                {
                    XtraMessageBox.Show(Messages.Messages.GreekLanguageCaption);

                    return;
                }

                XmlSerializer xmlSerializer = new XmlSerializer(typeof(string));
                string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Megasoft\CallManagement";

                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);

                using (FileStream fs = new FileStream(path + "\\languageSettings.xml", FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    string restartNow2 = Messages.Messages.languageChangeRestartAppText;
                    string title2 = Messages.Messages.languageChangeRestartAppTitle;
                    var buttons = MessageBoxButtons.YesNo;
                    var icon = MessageBoxIcon.Question;
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
                            XtraMessageBox.Show(Messages.Messages.GreekLanguageCaption);
                            DialogResult dialogResult = XtraMessageBox.Show(restartNow2, title2, buttons, icon);
                            if (dialogResult == DialogResult.Yes)
                            {
                                //save skin
                                var settings = Properties.Settings.Default;
                                settings.SkinName = UserLookAndFeel.Default.SkinName;
                                settings.PaletteName = UserLookAndFeel.Default.ActiveSvgPaletteName;
                                settings.Save();

                                Process.Start(Application.ExecutablePath);
                                Process.GetCurrentProcess().Kill();
                                bciGreek.Checked = true;
                                bciEnglish.Checked = false;
                            }
                            bciGreek.Checked = false;
                        }
                        else
                        {
                            XtraMessageBox.Show("Something went wrong....");
                        }
                    }
                }
            }
        }

        //---backstageview skin settings---//
        private void changeSkin(object sender, EventArgs e)
        {
            ComboBoxEdit comboBox = sender as ComboBoxEdit;
            string skinName = comboBox.Text;
            if(!string.IsNullOrEmpty(skinName))
            UserLookAndFeel.Default.SkinName = skinName;
        }

        private void refreshData(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FillTableAdapter();
        }

        //---application menu change language---//
        private void setGreek(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string setGreek = "el";

            if (System.Globalization.CultureInfo.CurrentCulture.Name == "el")
            {
                XtraMessageBox.Show(Messages.Messages.GreekLanguageCaption);
                bciEnglish.Checked = false;
                bciGreek.Checked = true;
                return;
            }

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(string));
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Megasoft\CallManagement";

            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            using (FileStream fs = new FileStream(path + "\\languageSettings.xml", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                string restartNow2 = Messages.Messages.languageChangeRestartAppText;
                string title2 = Messages.Messages.languageChangeRestartAppTitle;
                var buttons = MessageBoxButtons.YesNo;
                var icon = MessageBoxIcon.Question;
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
                        XtraMessageBox.Show(Messages.Messages.GreekLanguageCaption);
                        DialogResult dialogResult = XtraMessageBox.Show(restartNow2, title2, buttons, icon);
                        if (dialogResult == DialogResult.Yes)
                        {
                            Process.Start(Application.ExecutablePath);
                            Process.GetCurrentProcess().Kill();
                            bciGreek.Checked = true;
                            bciEnglish.Checked = false;
                        }
                        bciGreek.Checked = false;
                    }
                    else
                    {
                        XtraMessageBox.Show("Something went wrong....");
                    }
                }
            }
        }
        private void setEnglish(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string setEnglish = "en";

            if (System.Globalization.CultureInfo.CurrentCulture.Name == "en")
            {
                XtraMessageBox.Show(Messages.Messages.EnglishLanguageCaption);
                bciEnglish.Checked = true;
                bciGreek.Checked = false;
                return;
            }

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
                    XtraMessageBox.Show(Messages.Messages.EnglishLanguageCaption);
                    string restartNow = Messages.Messages.languageChangeRestartAppText;
                    string title = Messages.Messages.languageChangeRestartAppTitle;
                    string exception = Messages.Messages.languageChangeRestartAppException;
                    var buttons = MessageBoxButtons.YesNo;
                    var icon = MessageBoxIcon.Question;
                    if (saveSuccess)
                    {
                        DialogResult dialogResult = XtraMessageBox.Show(restartNow, title, buttons, icon);
                        if (dialogResult == DialogResult.Yes)
                        {
                            System.Diagnostics.Process.Start(Application.ExecutablePath);
                            Process.GetCurrentProcess().Kill();
                            bciGreek.Checked = false;
                            bciEnglish.Checked = true;
                        }
                        bciEnglish.Checked = false;
                    }
                    else
                    {
                        XtraMessageBox.Show(exception);
                    }
                }
            }
        }

        public void deleteEntryConfirmation()
        {
            string warning = Messages.Messages.deleteEntryConfirmationText;
            string title = Messages.Messages.deleteEntryConfirmationTitle;
            var buttons = MessageBoxButtons.YesNo;
            var icon = MessageBoxIcon.Warning;

            if (gridView1.IsGroupRow(gridView1.FocusedRowHandle)
               || gridView1.RowCount == 0)
                return;
            DialogResult dialogResult = XtraMessageBox.Show(warning, title, buttons, icon);
                if (dialogResult == DialogResult.Yes)
                {
                    bsCalls.RemoveCurrent();
                    callsTableAdapter.Update(dataSet1);
                    //int selectedRow = (int)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CallsId");
                    //callsTableAdapter.deleteSelectedRow(selectedRow);
                    //XtraMessageBox.Show("Delete successful!");
                }
            FillTableAdapter();
        }

        private void deleteEntry(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            deleteEntryConfirmation();
        }

        private void OpenEditForm(int id)
        {
            var openedForm = Application.OpenForms.OfType<EditEntry>().Select(t => t).Where(t => t.SelectedId == id).FirstOrDefault();

            if (openedForm != null)
            {
                openedForm.BringToFront();
            }
            else
            {
                EditEntry editEntry = new EditEntry(id);
                string create = Messages.Messages.editFormHeaderCreateCall;
                string edit = Messages.Messages.editFormHeaderEditCall;
                editEntry.Text = id < 0 ? editEntry.Text = create : editEntry.Text = edit;
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
