using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
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
                drvCall.Row["CreationDate"] = DateTime.UtcNow;

            drvCall.Row["ModifiedDate"] = DateTime.UtcNow;
            drvCall.EndEdit();
        }

        private void saveChanges(object sender, EventArgs e)
        {
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
    }
}
