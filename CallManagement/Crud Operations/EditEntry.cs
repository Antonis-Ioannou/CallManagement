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
    public partial class EditEntry : Form
    {
        private int SelectedId = 0;

        public EditEntry(int id)
        {
            InitializeComponent();
            SelectedId = id;
        }

        private void EditEntry_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet11.CallReciever' table. You can move, or remove it, as needed.
            this.callRecieverTableAdapter.Fill(this.dataSet11.CallReciever);
            // TODO: This line of code loads data into the 'dataSet11.CallingContact' table. You can move, or remove it, as needed.
            this.callingContactTableAdapter.Fill(this.dataSet11.CallingContact);
            // TODO: This line of code loads data into the 'dataSet11.CallType' table. You can move, or remove it, as needed.
            this.callTypeTableAdapter.Fill(this.dataSet11.CallType);
            // TODO: This line of code loads data into the 'dataSet1.CallType' table. You can move, or remove it, as needed.       
            callsTableAdapter1.Connection.ConnectionString = Form1.ConnectionString;
            // TODO: This line of code loads data into the 'dataSet1.Calls' table. You can move, or remove it, as needed.
            this.callsTableAdapter1.FillByCallId(this.dataSet1.Calls, SelectedId);

            //check if last row is null
            //var lastEntry = new SqlCommand ("SELECT * from Calls WHERE CallsId = (SELECT max(CallsId) FROM Calls )");
            //var lastEntry = dataSet1.Calls.Select(y=>y.CallsId).Last();

            //create new row
            DataSet1.CallsRow newCall;
            newCall = dataSet1.Calls.NewCallsRow();
            this.dataSet1.Calls.Rows.Add(newCall);
            this.bindingSource1.EndEdit();
            this.callsTableAdapter1.Update(dataSet1.Calls);
        }

        private void saveChanges(object sender, EventArgs e)
        {
            try
            {
                this.bindingSource1.EndEdit();
                this.callsTableAdapter1.Update(dataSet1.Calls);
                MessageBox.Show("Update Successful");
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Update failed");
            }
        }
    }
}
