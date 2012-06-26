using System;
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
using Shoppy.RFIDInput;


namespace Shoppy.Views
{
    // Ein Login-Form mit welchem man sich per RFID anmelden kann.
    public partial class Login : UserControl
    {
        // An dieses Objekt werden die RFID-Actionlistener gemeldet.
        public RFIDListener rfidlistener;
        SellerAdmin sa = new SellerAdmin();
        // Wird benötigt um die visible- und enabled-Eigenschaft zu verändern.
        public TabControl tabcontrol;
        string rfid_num;
        // Der Eingeloggte Verkäufer wird hier gespeichert.
        public static string SellerName;
        // Initialisert das Login-UserControl.

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
                SellerName = sa.GetSellerName(txtUserRFID.Text);
                txtUserRFID.Text = "";
                MessageBox.Show("Hallo" + " "+SellerName);
                SellView sv = new SellView();
                sv.txtInputBarcode.Select();

            }
            else
            {
                label2.Text = "Bitte mit gültigem RFID anmelden!";
            }
        }
        // Wird die RFID gewechselt wird die Variable rfid_num angepasst und die TextBox txtUserRFID angepasst.
        public void RFIDChanged(string newRFID)
        {
            if (newRFID == "")
            {
                rfid_num = "";
                txtUserRFID.Text = "";
                btnLogin.Enabled = false;
                label2.Text = "";
            }
            else
            {
                rfid_num = newRFID;
                txtUserRFID.Text = rfid_num;
                btnLogin.Enabled = true;
            }
        }

        private void txtUserRFID_TextChanged(object sender, EventArgs e)
        {
            if (!txtUserRFID.Text.Equals(""))
            {
                btnLogin.Enabled = true;
            }
            else
            {
                btnLogin.Enabled = false;
            }
        }

    }
}
