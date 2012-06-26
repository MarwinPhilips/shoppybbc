using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Shoppy.Database;
using Phidgets; //Needed for the RFID class and the PhidgetException class
using Phidgets.Events;
using Shoppy.Helpers; //Needed for the phidget event handling classes
using Shoppy.RFIDInput;

namespace Shoppy.Views
{
    // Managed die Kunden welche für die Sell- und Payment-view Benötigt werden. CRUD für Kunden.
	public partial class ClientAdminView: UserControl
	{
        // Auf diesen Listener werden die RFID-Events gemelde4t.
        public RFIDListener rfidlistener;
        string rfid_num;
        ClientAdmin database = new ClientAdmin();
        string client = "";
       // Initialisert das ClientAdminView und füllt das DGV.
		public ClientAdminView()
		{
			InitializeComponent();
            FillData();
            dataGridView1.ReadOnly = true;
        }
        private void FillDGV(DataTable table)
        {
            dataGridView1.DataSource = table;
        }
        private void FillData()
        {
            if (client.Equals(""))
            {
                FillDGV(database.GetClient());
            }
            else if (!(client.Equals("")))
            {
                client = rfid_num;
                FillDGV(database.GetClientOnRFID(client));
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Eingabeüberprüfung.BinEinButton(dataGridView1, e.RowIndex, e.ColumnIndex))
            {
                DeleteRow(e);
            }
            else if (Eingabeüberprüfung.BinEineZeile(dataGridView1, e.RowIndex, e.ColumnIndex))
            {
                FillUpdateBoxes(e);
            }
        }

        private void FillUpdateBoxes(DataGridViewCellEventArgs e)
        {

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            txtUpdateRFID.Text = row.Cells[1].Value.ToString();
            txtUpdateName.Text = row.Cells[2].Value.ToString();
            txtUpdateVorname.Text = row.Cells[3].Value.ToString();
            txtUpdateGeld.Text = row.Cells[4].Value.ToString();            
        }

        private void DeleteRow(DataGridViewCellEventArgs e)
        {
            database.DeleteClient(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
            FillData();
        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            database.UpdateClient(txtUpdateRFID.Text, txtUpdateName.Text, txtUpdateVorname.Text, txtUpdateGeld.Text);
            FillData();
        }

        private void btnNewClient_Click(object sender, EventArgs e)
        {
            if (database.ClientExist(rfid_num) == true)
            {
                MessageBox.Show("Die RFID "+ txtNewRFID.Text +" ist bereits gebucht");
            }
            else
            {
                database.NewClient(txtNewRFID.Text, txtNewName.Text, txtNewVorname.Text, txtNewGeld.Text);
                FillData();
            }
        }
        

        // Wird der RFID-Wert geändert wird er in den Speicher rfid_num gespeichert und die TextBox txtNewRFID.Text
        // wird angepasst.
        public void RFIDChanged(string newRFID)
        {
            if (newRFID == "")
            {
                rfid_num = "";
                client = "";
                txtUpdateRFID.Text = "";
                txtUpdateName.Text = "";
                txtUpdateVorname.Text = "";
                txtUpdateGeld.Text = "";
                txtNewRFID.Text = "";
                txtNewName.Text = "";
                txtNewGeld.Text = "";
                txtNewVorname.Text = "";
                FillData();

            }

            if (database.ClientExist(newRFID))
            {
                
                rfid_num = newRFID;
                client = rfid_num;
                FillData();
                try
                {
                    txtUpdateRFID.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
                    txtUpdateName.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
                    txtUpdateVorname.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
                    txtUpdateGeld.Text = dataGridView1.Rows[0].Cells[4].Value.ToString();
                }
                catch
                {
                }
            }

            else if(database.ClientExist(newRFID)==false)
            {
                rfid_num = newRFID;
                txtNewRFID.Text = newRFID;
                client = "";
            }
        }

        private void txtFields_Changed(object sender, EventArgs e)
        {

            TextBox[]  txtBoxen_wthInt = new TextBox[] {txtUpdateGeld,txtNewGeld};
            Eingabeüberprüfung.txtBoxValue_IsNumber(txtBoxen_wthInt);

            TextBox[] txtBoxen_wthString = new TextBox[] { txtUpdateName, txtUpdateVorname, txtNewName, txtNewVorname };
            Eingabeüberprüfung.txtBoxValue_IsString(txtBoxen_wthString);
            
            

            TextBox[] txtBoxUpdate = new TextBox[] { txtUpdateVorname, txtUpdateRFID, txtUpdateName, txtUpdateGeld };
            if (Eingabeüberprüfung.TextBoxFilled(txtBoxUpdate))
            {
                btnUpdateClient.Enabled = true;

                txtUpdateName.Enabled = true;
                txtUpdateVorname.Enabled = true;
                txtUpdateGeld.Enabled = true;
            }
            else
            {
                btnUpdateClient.Enabled = false;

                txtUpdateName.Enabled = false;
                txtUpdateVorname.Enabled = false;
                txtUpdateGeld.Enabled = false;
            }
            
            
            TextBox[] txtBoxNew = new TextBox[] { txtNewVorname, txtNewRFID, txtNewName, txtNewGeld };
            if (Eingabeüberprüfung.TextBoxFilled(txtBoxNew))
            {
                btnNewClient.Enabled = true;
            }
            else
            {
                btnNewClient.Enabled = false;
            }            
        }
    }
}