using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Shoppy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose(true);
        }

        /* private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
         {
             tabControl1.SelectedTab.Focus();
         }

         private void tabPage2_Enter(object sender, EventArgs e)
         {
             payment_View1.Focus();
         }*/

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            MessageBox.Show(e.TabPage.ToString());

            if (e.TabPage.ToString().Equals("TabPage:{Payment}"))
            {
                payment_View1.Focus();
            }
            else if (e.TabPage.ToString().Equals("TabPage:{Survey}"))
            {
                surveyView1.Focus();
            }
            else if (e.TabPage.ToString().Equals("TabPage:{Sell}"))
            {
                sellView1.Focus();
            }
        }
    }
}

