using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CallManagement.Custom_Message_Boxes
{
    public partial class DeleteEntry : Form
    {
        public DeleteEntry()
        {
            InitializeComponent();
        }

        private void deleteEntry(object sender, EventArgs e)
        {
            //string warning = "Are you sure you want to delete this entry?";
            //string title = "Delete Entry";
            //var buttons = MessageBoxButtons.YesNo;
            //var icon = MessageBoxIcon.Warning;

            //int selectedRow = (int)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CallsId");
            //callsTableAdapter.deleteSelectedRow(selectedRow);
            ////this.bindingSource1.EndEdit();
            ////this.callsTableAdapter1.Update(dataSet1.Calls);
            //MessageBox.Show("Delete successful!");
        }
    }
}
