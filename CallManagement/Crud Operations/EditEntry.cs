﻿using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CallManagement.Crud_Operations
{
    public delegate void ReloadGridData();

    public partial class EditEntry : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public event ReloadGridData ReloadDataEvent;

        private bool dataChanged = false;
        private bool saveSuccess = false;
        private int _selectedId = 0;
        public int SelectedId { get => _selectedId; set => _selectedId = value; }

        public EditEntry(int id)
        {
            InitializeComponent();
            SelectedId = id;

            if(SelectedId == -1)
            {
                bindingSource1.EndEdit();
                bindingSource1.AddNew();
            }
        }

        private void EditEntry_Load(object sender, EventArgs e)
        {           
            FillTableAdapters();
            if (SelectedId.Equals(-1))
            {
                lciDateModified.Enabled = false;
            }
            else
            {
                lciDateCreated.Enabled = false;
            }
        }

        private void FillTableAdapters()
        {
            dataSet1.EnforceConstraints = false;
            callRecieverTableAdapter.Connection.ConnectionString = Form1.ConnectionString;
            callRecieverTableAdapter.Fill(this.dataSet1.CallReciever);

            callingContactTableAdapter.Connection.ConnectionString = Form1.ConnectionString;
            callingContactTableAdapter.Fill(this.dataSet1.CallingContact);

            callTypeTableAdapter.Connection.ConnectionString = Form1.ConnectionString;
            callTypeTableAdapter.Fill(this.dataSet1.CallType);          
           
            if (SelectedId != -1)
            {
                callsTableAdapter1.Connection.ConnectionString = Form1.ConnectionString;
                callsTableAdapter1.FillByCallId(this.dataSet1.Calls, SelectedId);
            }
        }

        private void SetModifiedDate()
        {
            DataRowView drvCall = bindingSource1.Current as DataRowView;
            
            if (drvCall == null)
                return;

            drvCall.BeginEdit();

            if (SelectedId.Equals(-1))
                drvCall.Row["CreationDate"] =  drvCall.Row["ModifiedDate"] =  dateCreatedEdit.EditValue;
            else
            drvCall.Row["ModifiedDate"] = dateModifiedEdit.EditValue;

            drvCall.EndEdit();
        }

        private void saveChanges()
        {
            try
            {
                SetModifiedDate();
                bindingSource1.EndEdit();
                callsTableAdapter1.Update(dataSet1.Calls);
                saveSuccess = true;
            }
            catch (Exception ex)
            {
                string exceptionInfo = ex.Message;
                XtraMessageBox.Show(exceptionInfo);
            }
            finally
            {
                ReloadDataEvent?.Invoke();
                Close();
            }
        }

        private void saveBtn(object sender, EventArgs e)
        {
            if (ValidateChildren())
                saveChanges();
        }

        private void callTypeValidation(object sender, CancelEventArgs e)
        {
            //Regex regex1 = new Regex(@"^[a-zA-Z]+$");
            //if (!regex1.IsMatch(callType.Text))
            if (string.IsNullOrEmpty(callType.Text))
            {
                //To set validation error
                dxErrorProvider.SetError(callType, "Call Type cannot be empty!");
                //To say the state of control in invalid
                e.Cancel = true;
            }
            else
            {
                //To clear the validation error
                this.dxErrorProvider.SetError(this.callType, "");
            }
        }

        private void callingContactValidation(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(callingContact.Text))
            {
                //To set validation error
                dxErrorProvider.SetError(callingContact, "Calling Contact cannot be empty!");
                //To say the state of control in invalid
                e.Cancel = true;
            }
            else
            {
                //To clear the validation error
                this.dxErrorProvider.SetError(this.callingContact, "");
            }
        }

        private void callRecieverValidation(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(callReciever.Text))
            {
                //To set validation error
                dxErrorProvider.SetError(callReciever, "Calling Reciever cannot be empty!");
                //To say the state of control in invalid
                e.Cancel = true;
            }
            else
            {
                //To clear the validation error
                this.dxErrorProvider.SetError(this.callReciever, "");
            }
        }

        private void callTypeChanged(object sender, EventArgs e)
        {
            dataChanged = true;
        }

        private void callingContactChanged(object sender, EventArgs e)
        {
            dataChanged = true;
        }

        private void callRecieverChanged(object sender, EventArgs e)
        {
            dataChanged = true;
        }

        private void formClosing(object sender, FormClosingEventArgs e)
        {
            if (saveSuccess)
            {
                saveSuccess = false;
                return;
            }

            string text = "Would you like to save before exit?";
            string title = "Confirm exit";
            var buttons = MessageBoxButtons.YesNoCancel;
            //string text2 = "Confirm exit?";
            //string title2 = "Confirm exit";
            //var buttons2 = MessageBoxButtons.YesNo;
            var icon = MessageBoxIcon.Question;

            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (dataChanged)
                {
                    DialogResult result = XtraMessageBox.Show(text, title, buttons, icon);
                    if (result == DialogResult.Cancel)
                    {
                        e.Cancel = true;
                    }
                    else if (result == DialogResult.Yes)
                    {
                        if (ValidateChildren())                        
                            saveChanges();

                        dataChanged = false;
                        e.Cancel = true;
                    }
                }
                //else
                //{
                //    DialogResult result2 = MessageBox.Show(text2, title2, buttons2, icon);
                //    if (result2 == DialogResult.No)
                //    {
                //        e.Cancel = true;
                //    }
                //}
            }
        }

        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string warning = "Are you sure you want to delete this entry?";
            string title = "Delete Entry";
            string warning2 = "Επιβεβαίωση διαγραφής;";
            string title2 = "Διαγραφή Κλήσης";
            var buttons = MessageBoxButtons.YesNo;
            var icon = MessageBoxIcon.Warning;

            if (System.Globalization.CultureInfo.CurrentCulture.Name == "en")
            {
                DialogResult dialogResult = XtraMessageBox.Show(warning, title, buttons, icon);
                if (dialogResult == DialogResult.Yes)
                {
                    bindingSource1.RemoveCurrent();
                    saveChanges();
                }
            }
            else
            {
                DialogResult dialogResult = XtraMessageBox.Show(warning2, title2, buttons, icon);
                if (dialogResult == DialogResult.Yes)
                {
                    bindingSource1.RemoveCurrent();
                    saveChanges();
                }
            }
        }
    }
}