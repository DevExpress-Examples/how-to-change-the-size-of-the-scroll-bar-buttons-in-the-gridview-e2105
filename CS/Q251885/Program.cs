using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.Skins;

namespace Q251885 {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SkinManager.EnableFormSkins();
            Application.Run(new MainForm());
        }
    }
}