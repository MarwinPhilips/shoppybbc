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
using Shoppy.Helpers;

namespace Shoppy.Views
{
    // Das UserControl zum Einzahlen von Geld auf die RFID.
    public partial class Payment_View : UserControl
    {
        ClientAdmin database = new ClientAdmin();
        string rfid_num;
        // An dieses Objekt werden die RFID-Actionlistener angehängt.
        public RFIDListener rfidlistener;
        
        // Initialisiert das Payment_View
        public Payment_View()
        {
            InitializeComponent();
            dataGridView1.ReadOnly = true;
        }
        private void FillDGV(DataTable table)
        {
            dataGridView1.DataSource = table;
        }

        private void FillData()
        {
            FillDGV(database.GetClientOnRFID(rfid_num));
        }
        // Wird der RFIDChanged Event ausgelöst ändert diese Methode die rfid_num und passt btnEnter und das data
        // GridView1 an
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
      
        private void btnInsert(object sender, EventArgs e)
        {
            string kunde = dataGridView1.Rows[0].Cells[0].Value.ToString();
            double betrag = double.Parse(txtBetrag.Text);
            database.InsertBetrag(kunde, betrag);
            FillData();
        }

        private void txtBetrag_TextChanged(object sender, EventArgs e)
        {
            TextBox[] txtBoxen_wthInt = new TextBox[] { txtBetrag };
            Eingabeüberprüfung.txtBoxValue_IsNumber(txtBoxen_wthInt);
        }
    }
}