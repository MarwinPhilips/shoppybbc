﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Shoppy.Database;
using Phidgets.Events;
using Phidgets;


namespace Shoppy.Views
{
    public partial class Login : UserControl
    {
        SellerAdmin sa = new SellerAdmin();
        public TabControl tabcontrol;
        string rfid_num;
        
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (sa.SellerLogin(txtUserRFID.Text))
            {
                this.Visible = false;
                this.Enabled = false;
                tabcontrol.Visible = true;
                tabcontrol.Enabled = true;
                txtUserRFID.Text = "";
            }
            else
            {
                label2.Text = "Bitte mit gültigem RFID anmelden!";
            }
        }

        public void RFIDChanged(string newRFID)
        {
            if (newRFID == "")
            {
                rfid_num = "";
                txtUserRFID.Text = "";
            }
            else
            {
                rfid_num = newRFID;
                txtUserRFID.Text = rfid_num; ;
            }
        }

        public void RFIDAttached(bool IsAttached)
        {
            if (IsAttached)
            {
                label3.Text = "RFID: Angeschlossen.";
            }
            else
            {
                label3.Text = "RFID: Nicht angeschlossen.";
            }
        }
    }
}
