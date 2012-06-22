using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Shoppy.Views
{
    public partial class Logout : UserControl
    {
        public Login login;
        public TabControl control;
        public Logout()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login.Visible = true;
            login.Enabled = true;
            control.Enabled = false;
            control.Visible = false;
            control.SelectTab(0);
            Login.SellerName = "";
        }
    }
}
