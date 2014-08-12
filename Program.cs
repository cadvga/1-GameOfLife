using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Life
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// Created by Oscar Foley (oscarfoley.com)
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmBase());
        }
    }
}