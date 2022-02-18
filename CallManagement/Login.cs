using DevExpress.XtraEditors;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace CallManagement
{
    public partial class Login : Form
    {
        public SqlConnection conn = new SqlConnection();
        private SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

        public Login()
        {
            InitializeComponent();
        }

        private void loginUserName(object sender, EventArgs e)
        {

        }

        private void loginPassword(object sender, EventArgs e)
        {

        }

        private void loginServer(object sender, EventArgs e)
        {

        }

        private void loginDatabase(object sender, EventArgs e)
        {

        }

        private void loginConnect(object sender, EventArgs e)
        {
            comboBoxEditDatabase.Properties.Items.Clear();
            builder.DataSource = comboBoxEditServer.Text;
            builder.UserID = textEditUserName.Text;
            builder.Password = textEditPassword.Text;
            conn.ConnectionString = builder.ConnectionString;

            //---load databases---//
            try
            {
                conn.Open();
                var command = new SqlCommand();
                command.Connection = conn;
                command.CommandType = CommandType.Text;
                command.CommandText = "select name from master.sys.databases";
                var adaper = new SqlDataAdapter(command);
                var dataset = new DataSet();
                adaper.Fill(dataset);
                DataTable dtDatabases = dataset.Tables[0];
                for (int i = 0; i < dataset.Tables[0].Rows.Count; i++)
                {
                    comboBoxEditDatabase.Properties.Items.Add(dataset.Tables[0].Rows[i][0].ToString());
                    conn.Close();
                }

                XtraMessageBox.Show("Connection OK");
                XtraMessageBox.Show("Choose a database");
            }
            catch { XtraMessageBox.Show("Invalid log-in credentials!", "Ooops, something went wrong :(", MessageBoxButtons.OK, MessageBoxIcon.Error); };
        }

        private void enablingSaveBtn(object sender, EventArgs e)
        {
            simpleButtonSave.Enabled = true;
        }

        private void loginSave(object sender, EventArgs e)
        {
            if (comboBoxEditDatabase.EditValue != null)
                builder.InitialCatalog = comboBoxEditDatabase.EditValue.ToString();

            string connString = builder.ConnectionString.ToString();

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(string));
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Megasoft\CallManagement";

            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            using (FileStream fs = new FileStream(path + "\\conStr.xml", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                bool saveSuccess = true;
                try
                {
                    xmlSerializer.Serialize(fs, connString);
                }
                catch
                {
                    saveSuccess = false;
                }
                finally
                {
                    if (saveSuccess)
                    {
                        XtraMessageBox.Show("Created");
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        XtraMessageBox.Show("Something went wrong....");
                    }
                    Close();
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            GetLoadServer(comboBoxEditServer);
            simpleButtonSave.Enabled = false;
        }

        //---load servers---//
        private void GetLoadServer(ComboBoxEdit combo)
        {
            string serverName = Environment.MachineName;
            RegistryView registryView = Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32;
            using (RegistryKey registry = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, registryView))
            {
                RegistryKey instanceKey = registry.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL", false);
                if (instanceKey != null)
                {
                    foreach (var instanceName in instanceKey.GetValueNames())
                    {
                        combo.Properties.Items.Add(serverName + "\\" + instanceName);
                    }
                }
            }
        }
    }
}
