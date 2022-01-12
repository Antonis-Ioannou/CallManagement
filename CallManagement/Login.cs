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
            comboBoxEdit2.Properties.Items.Clear();
            builder.DataSource = comboBoxEdit1.Text;
            builder.UserID = textEdit1.Text;
            builder.Password = textEdit2.Text;
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
                    comboBoxEdit2.Properties.Items.Add(dataset.Tables[0].Rows[i][0].ToString());
                    conn.Close();
                }

                MessageBox.Show("Connection OK");
                MessageBox.Show("Choose a database");
            }
            catch { MessageBox.Show("Invalid log-in credentials!", "Ooops, something went wrong :(", MessageBoxButtons.OK, MessageBoxIcon.Error); };
        }

        private void loginSave(object sender, EventArgs e)
        {
            if (comboBoxEdit2.EditValue != null)
                builder.InitialCatalog = comboBoxEdit2.EditValue.ToString();

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
                        MessageBox.Show("Created");
                    else
                        MessageBox.Show("Something went wrong....");
                    Close();
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            GetLoadServer(comboBoxEdit1);
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
