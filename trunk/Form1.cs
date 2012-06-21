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
            login1.tabcontrol = tabControl1;
            addListener();
            logout1.login = login1;
            logout1.control = tabControl1;
            
        }

        private void addListener()
        {
            RFIDInput.RFIDListener listener = RFIDInput.RFIDListener.GetInstance();

            payment_View1.rfidlistener = listener;
            payment_View1.rfidlistener.RFIDAttached +=new RFIDInput.RFIDListener.RFIDAttachedChangeEventHandler(payment_View1.RFIDAttached);
            payment_View1.rfidlistener.RFIDchanged += new RFIDInput.RFIDListener.RFIDTagChangedEventHandler(payment_View1.RFIDChanged);

            sellView1.rfidlistener = listener;
            sellView1.rfidlistener.RFIDAttached += new RFIDInput.RFIDListener.RFIDAttachedChangeEventHandler(sellView1.RFIDAttached);
            sellView1.rfidlistener.RFIDchanged += new RFIDInput.RFIDListener.RFIDTagChangedEventHandler(sellView1.RFIDChanged);

            sellerAdminView1.rfidlistener = listener;
            sellerAdminView1.rfidlistener.RFIDAttached += new RFIDInput.RFIDListener.RFIDAttachedChangeEventHandler(sellerAdminView1.RFIDAttached); 
            sellerAdminView1.rfidlistener.RFIDchanged += new RFIDInput.RFIDListener.RFIDTagChangedEventHandler(sellerAdminView1.RFIDChanged);

            clientAdminView1.rfidlistener = listener;
            clientAdminView1.rfidlistener.RFIDAttached += new RFIDInput.RFIDListener.RFIDAttachedChangeEventHandler(clientAdminView1.RFIDAttached);
            clientAdminView1.rfidlistener.RFIDchanged += new RFIDInput.RFIDListener.RFIDTagChangedEventHandler(clientAdminView1.RFIDChanged);


            login1.rfidlistener = listener;
            login1.rfidlistener.RFIDAttached += new RFIDInput.RFIDListener.RFIDAttachedChangeEventHandler(login1.RFIDAttached);
            login1.rfidlistener.RFIDchanged += new RFIDInput.RFIDListener.RFIDTagChangedEventHandler(login1.RFIDChanged);


        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose(true);
        }

        private void tabControl1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '&')
            {
                tabControl1.Enabled = false;
                tabControl1.Visible = false;
                login1.Enabled = true;
                login1.Visible = true;
            }
        }
    }
}

