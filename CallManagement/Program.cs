using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace CallManagement
{
    static class Program
    {
        static string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Megasoft\CallManagement";
        static userSettings userSettings = new userSettings();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void LoadCulture()
        {
            string fullPath = Path.Combine(path, @"appSettings.xml");

            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            if (!File.Exists(fullPath))
            {
                File.Create(fullPath);
                return;
            }

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(userSettings));

            using (FileStream fs = new FileStream(fullPath, FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read))
            {
                try
                {
                    userSettings = (userSettings)xmlSerializer.Deserialize(fs);
                }
                catch
                {
                    userSettings.language = "en";
                }
                
            }
        }

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //enable skins
            //BonusSkins.Register();
            //SkinManager.EnableFormSkins();
            LoadCulture();
            try
            {
                Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(userSettings.language);
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(userSettings.language);
            }
            catch
            {
                Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en");
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
            }
            Application.Run(new Form1());
        }
    }
}
