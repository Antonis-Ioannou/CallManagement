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

        private int SelectedId = 0;

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

        private void saveChanges(object sender, EventArgs e)
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
                    this.ReloadDataEvent?.Invoke();
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ooops, something went wrong");
                }
            }
            else
            {
                //List<BaseEdit> editorsWithErrors = new List<BaseEdit>();
                //foreach (Control ctrl in layoutControl1.Controls)
                //{
                //    BaseEdit be = ctrl as BaseEdit;
                //    if (be != null && be.ErrorText != string.Empty)
                //        editorsWithErrors.Add(be);
                //}


                //List<string> errors = new List<string>();
                //errors.Add("Error 1");
                //errors.Add("Error 2");
                //errors.Add("Error 3");
                //string errorMessage = string.Join("\n", errors.ToArray());
                //MessageBox.Show(errorMessage);


                var listOfErrors = this.dxErrorProvider.ContainerControl.Controls.Cast<Control>()
                                       .Select(c => this.dxErrorProvider.GetError(c))
                                       .Where(s => !string.IsNullOrEmpty(s))
                                       .ToList();
                MessageBox.Show("Please correct validation errors:\n - " +
                    string.Join("\n - ", listOfErrors.ToArray()),
                    "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

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
    }
}
