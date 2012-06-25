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
        RFIDInput.RFIDListener rfidlistener;
        // Initialisiert das Form1
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


            this.rfidlistener = listener;
            this.rfidlistener.RFIDAttached += new RFIDInput.RFIDListener.RFIDAttachedChangeEventHandler(RFIDAttached);

            sellView1.rfidlistener = listener;
            sellView1.rfidlistener.RFIDchanged += new RFIDInput.RFIDListener.RFIDTagChangedEventHandler(sellView1.RFIDChanged);

            payment_View1.rfidlistener = listener;
            payment_View1.rfidlistener.RFIDchanged += new RFIDInput.RFIDListener.RFIDTagChangedEventHandler(payment_View1.RFIDChanged);

            sellerAdminView1.rfidlistener = listener; 
            sellerAdminView1.rfidlistener.RFIDchanged += new RFIDInput.RFIDListener.RFIDTagChangedEventHandler(sellerAdminView1.RFIDChanged);

            clientAdminView1.rfidlistener = listener;
            clientAdminView1.rfidlistener.RFIDchanged += new RFIDInput.RFIDListener.RFIDTagChangedEventHandler(clientAdminView1.RFIDChanged);


            login1.rfidlistener = listener;
            login1.rfidlistener.RFIDchanged += new RFIDInput.RFIDListener.RFIDTagChangedEventHandler(login1.RFIDChanged);

            listener.CheckAttached();
        }
        private void RFIDAttached(bool isAttached)
        {
            if (isAttached)
            {
                toolStripStatusLabel1.Text = "RFID: Angeschlossen";
            }
            else
            {
                toolStripStatusLabel1.Text = "RFID: nicht angeschlossen";
            }
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

