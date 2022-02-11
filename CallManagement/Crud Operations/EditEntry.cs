using DevExpress.XtraEditors;
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

    public partial class EditEntry : Form
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
        }

        private void FillTableAdapters()
        {
            dataSet1.EnforceConstraints = false;
            callRecieverTableAdapter.Connection.ConnectionString = Form1.ConnectionString;
            callRecieverTableAdapter.Fill(this.dataSet11.CallReciever);

            callingContactTableAdapter.Connection.ConnectionString = Form1.ConnectionString;
            callingContactTableAdapter.Fill(this.dataSet11.CallingContact);

            callTypeTableAdapter.Connection.ConnectionString = Form1.ConnectionString;
            callTypeTableAdapter.Fill(this.dataSet11.CallType);          
           
            if (SelectedId != -1)
            {
                callsTableAdapter1.Connection.ConnectionString = Form1.ConnectionString;
                callsTableAdapter1.FillByCallId(this.dataSet1.Calls, SelectedId);
            }
        }

        private void SetModifiedDate()
        {
            DataRowView drvCall = bindingSource1.Current as DataRowView;

            drvCall.BeginEdit();

            if (SelectedId.Equals(-1))
                drvCall.Row["CreationDate"] = DateTime.Now;

            drvCall.Row["ModifiedDate"] = DateTime.Now;
            drvCall.EndEdit();
        }

        private void saveChanges()
        {
            if (this.ValidateChildren())
            {
                //Here the form is in valid state
                //Do what you need when the form is valid
                try
                {
                    SetModifiedDate();
                    this.bindingSource1.EndEdit();
                    this.callsTableAdapter1.Update(dataSet1.Calls);
                    saveSuccess = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Ooops, something went wrong");
                }
                finally
                {
                    this.ReloadDataEvent?.Invoke();
                    this.Close();
                }
            }
        }

        private void saveChangesBtn(object sender, EventArgs e)
        {
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
            string text2 = "Confirm exit?";
            string title2 = "Confirm exit";
            var buttons2 = MessageBoxButtons.YesNo;
            var icon = MessageBoxIcon.Question;

            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (dataChanged)
                {
                    DialogResult result = MessageBox.Show(text, title, buttons, icon);
                    if (result == DialogResult.Cancel)
                    {
                        e.Cancel = true;
                    }
                    else if (result == DialogResult.Yes)
                    {
                        saveChanges();
                        dataChanged = false;
                        e.Cancel = true;
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        e.Cancel = true;
                    }
                }
                else
                {
                    DialogResult result2 = MessageBox.Show(text2, title2, buttons2, icon);
                    if (result2 == DialogResult.No)
                    {
                        e.Cancel = true;
                    }
                }
            }
        }
    }
}