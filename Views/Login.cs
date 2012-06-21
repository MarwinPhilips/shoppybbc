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


namespace Shoppy.Views
{
    public partial class Login : UserControl
    {
        SellerAdmin sa = new SellerAdmin();
        public TabControl tabcontrol;
        RFID rfid;
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
                View_Unload();
                tabcontrol.Visible = true;
                tabcontrol.Enabled = true;
                txtUserRFID.Text = "";
            }
            else
            {
                label2.Text = "Bitte mit gültigem RFID anmelden!";
            }
        }

        void rfid_Tag(object sender, TagEventArgs e)
        {
            rfid_num = e.Tag;
            txtUserRFID.Text = rfid_num;
            
        }

        void rfid_TagLost(object sender, TagEventArgs e)
        {
            rfid_num = "";
            txtUserRFID.Text = "";
        }


        void rfid_Attach(object sender, AttachEventArgs e)
        {
            RFID attached = (RFID)sender;

            if (rfid.outputs.Count > 0)
            {
                rfid.Antenna = true;
            }
        }

        void rfid_Detach(object sender, DetachEventArgs e)
        {
            RFID detached = (RFID)sender;

            if (rfid.outputs.Count < 0)
            {

                rfid.Antenna = false;

            }

        }

        public void View_Unload()
        {
            if (rfid != null)
            {
                rfid.Attach -= new AttachEventHandler(rfid_Attach);
                rfid.Detach -= new DetachEventHandler(rfid_Detach);

                rfid.Tag -= new TagEventHandler(rfid_Tag);
                rfid.TagLost -= new TagEventHandler(rfid_TagLost);
                rfid.close();
            }

        }

        public void View_MyLoad()
        {
            if (rfid == null)
            {
                rfid = new RFID();
            }

            rfid.Attach += new AttachEventHandler(rfid_Attach);
            rfid.Detach += new DetachEventHandler(rfid_Detach);

            rfid.Tag += new TagEventHandler(rfid_Tag);
            rfid.TagLost += new TagEventHandler(rfid_TagLost);
            rfid.open(-1);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (rfid == null)
            {
                rfid = new RFID();
            }

            rfid.Attach += new AttachEventHandler(rfid_Attach);
            rfid.Detach += new DetachEventHandler(rfid_Detach);

            rfid.Tag += new TagEventHandler(rfid_Tag);
            rfid.TagLost += new TagEventHandler(rfid_TagLost);
            rfid.open(-1);
        }
    }
}
