using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CallManagement
{
    public partial class CallTypes : Form
    {
        public CallTypes()
        {
            InitializeComponent();
        }

        private void CallTypes_Load(object sender, EventArgs e)
        {
            FillTableAdapter();
        }

        private void FillTableAdapter()
        {
            if (!string.IsNullOrEmpty(Form1.ConnectionString))
            {
                callTypeTableAdapter.Connection.ConnectionString = Form1.ConnectionString;
                callTypeTableAdapter.Fill(dataSet1.CallType);
            }
        }
    }
}