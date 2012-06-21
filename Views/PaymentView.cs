using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Shoppy.Database;
using Phidgets; //Needed for the RFID class and the PhidgetException class
using Phidgets.Events; //Needed for the phidget event handling classes
using Shoppy.RFIDInput;

namespace Shoppy.Views
{
    public partial class Payment_View : UserControl
    {
        private RFID rfid; //Declare an RFID object
        ClientAdmin database = new ClientAdmin();
        string rfid_num;
        public RFIDListener listener;
        

        public Payment_View()
        {
            InitializeComponent();
            listener = RFIDListener.GetInstance();

        }

        private void FillData()
        {
            dataGridView1.DataSource = database.GetClientOnRFID(rfid_num);
        }

        public void Payment_View_Unload()
        {
            if (rfid != null)
            {
                rfid.Attach -= new AttachEventHandler(rfid_Attach);
                rfid.Detach -= new DetachEventHandler(rfid_Detach);

                rfid.Tag -= new TagEventHandler(rfid_Tag);
                rfid.TagLost -= new TagEventHandler(rfid_TagLost);
                rfid.close();

                label2.Text = "RFID: Nicht angeschlossen.";
            }
        }

        public void Payment_View_MyLoad()
        {
            if (rfid == null)
            {
                rfid = new RFID();
            }
            listener.RFIDAttached +=new RFIDListener.RFIDAttachedChangeEventHandler(RFIDAttached);
            listener.RFIDchanged +=new RFIDListener.RFIDTagChangedEventHandler(RFIDChanged);
        }
        public void RFIDChanged(string newRFID)
        {
            if (newRFID == "")
            {
                btnEnter.Enabled = false;
                rfid_num = "";
                dataGridView1.DataSource = "";
            }
            else
            {
                btnEnter.Enabled = true;
                rfid_num = newRFID;
                FillData();
            }
        }
        public void RFIDAttached(bool IsAttached)
        {
            if (IsAttached)
            {
                label2.Text = "RFID: Angeschlossen.";
            }
            else
            {
                label2.Text = "RFID: Nicht angeschlossen.";
            }
        }
        void rfid_Tag(object sender, TagEventArgs e)
        {
            
        }

        void rfid_TagLost(object sender, TagEventArgs e)
        {
            
        }

        void rfid_Attach(object sender, AttachEventArgs e)
        {
            RFID attached = (RFID)sender;

            if (rfid.outputs.Count > 0)
            {
                label2.Text = "RFID: Angeschlossen.";
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
            label2.Text = "RFID: Nicht angeschlossen.";
        }
        
        private void btnInsert(object sender, EventArgs e)
        {

            string kunde = dataGridView1.Rows[0].Cells[0].Value.ToString();
            MessageBox.Show(kunde);
            double betrag = double.Parse(txtBetrag.Text);
            database.InsertBetrag(kunde, betrag);
            FillData();
        }
    }
}