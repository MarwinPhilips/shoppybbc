
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Shoppy
{
    static class Shoppy
    {
        /// <summary>
        /// Der Haupteinstiegspunkt f�r die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 f = new Form1();
            Application.Run(f);
            f.Close();
            f.Dispose();          
        }
    }
}
