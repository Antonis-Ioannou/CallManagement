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
    public partial class CallReciever : Form
    {
        public CallReciever()
        {
            InitializeComponent();
        }

        private void CallReciever_Load(object sender, EventArgs e)
        {
            FillTableAdapter();
        }

        private void FillTableAdapter()
        {
            if (!string.IsNullOrEmpty(Form1.ConnectionString))
            {
                callRecieverTableAdapter.Connection.ConnectionString = Form1.ConnectionString;
                callRecieverTableAdapter.Fill(dataSet1.CallReciever);
            }
        }
    }
}
