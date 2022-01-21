using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            // TODO: This line of code loads data into the 'dataSet1.CallType' table. You can move, or remove it, as needed.
            this.callTypeTableAdapter.Fill(this.dataSet1.CallType);
            // TODO: This line of code loads data into the 'dataSet1.CallingContact' table. You can move, or remove it, as needed.
            this.callingContactTableAdapter.Fill(this.dataSet1.CallingContact);
            // TODO: This line of code loads data into the 'dataSet1.CallReciever' table. You can move, or remove it, as needed.
            this.callRecieverTableAdapter.Fill(this.dataSet1.CallReciever);
            callsTableAdapter1.Connection.ConnectionString = Form1.ConnectionString;
            // TODO: This line of code loads data into the 'dataSet1.Calls' table. You can move, or remove it, as needed.
            this.callsTableAdapter1.FillByCallId(this.dataSet1.Calls, SelectedId);
        }
    }
}
