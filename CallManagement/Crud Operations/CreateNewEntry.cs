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
    public partial class CreateNewEntry : Form
    {
        private int SelectedId = 0;

        public CreateNewEntry(int id)
        {
            InitializeComponent();
            SelectedId = id;
        }

        public CreateNewEntry()
        {
            InitializeComponent();
        }

        private void CreateNewEntry_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.CallReciever' table. You can move, or remove it, as needed.
            this.callRecieverTableAdapter.Fill(this.dataSet1.CallReciever);
            // TODO: This line of code loads data into the 'dataSet1.CallingContact' table. You can move, or remove it, as needed.
            this.callingContactTableAdapter.Fill(this.dataSet1.CallingContact);
            // TODO: This line of code loads data into the 'dataSet1.CallType' table. You can move, or remove it, as needed.
            this.callTypeTableAdapter.Fill(this.dataSet1.CallType);
            // TODO: This line of code loads data into the 'dataSet1.Calls' table. You can move, or remove it, as needed.
            //this.callsTableAdapter1.FillByCallId(this.dataSet1.Calls, SelectedId);

            
        }

        private void createEntry(object sender, EventArgs e)
        {
            try
            {
                this.bindingSource1.EndEdit();
                this.callsTableAdapter1.Update(dataSet1.Calls);
                MessageBox.Show("Create Successful");
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Create failed");
            }
        }

    }
}
