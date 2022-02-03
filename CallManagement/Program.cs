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
        public static string cultureString = string.Empty;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void ChangeCulture()
        {
            string fullPath = Path.Combine(path, @"languageSettings.xml");

            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            if (!File.Exists(fullPath))
            {
                File.Create(fullPath);
                return;
            }

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(string));

            using (FileStream fs = new FileStream(fullPath, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                cultureString = xmlSerializer.Deserialize(fs).ToString();
            }
        }

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //enable skins
            //BonusSkins.Register();
            //SkinManager.EnableFormSkins();
            ChangeCulture();
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(cultureString);
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(cultureString);
            Application.Run(new Form1());
        }
    }
}
