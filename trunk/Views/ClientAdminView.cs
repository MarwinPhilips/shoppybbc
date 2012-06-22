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
	public partial class ClientAdminView: UserControl
	{
        public RFIDListener rfidlistener;
        string rfid_num;
        ClientAdmin database = new ClientAdmin();
        string client = "";
       
		public ClientAdminView()
		{
			InitializeComponent();
            FillData();
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
            if (ClientExist(txtNewRFID.Text) == false)
            {
                MessageBox.Show("Die RFID "+ txtNewRFID.Text +" ist bereits gebucht");
            }
            else
            {
                database.NewClient(txtNewRFID.Text, txtNewName.Text, txtNewVorname.Text, txtNewGeld.Text);
                FillData();
            }
        }
        
        private bool ClientExist(string id)
        {
            for (int i = 0; i < dataGridView1.RowCount-1; i++)
            {
                  
                if(dataGridView1.Rows[i].Cells[1].Value.ToString().Equals(id)){
                    return false;
                }
            }
            return true;

        }

        /*private bool isnumber(string txt)
        {
            if (txtNewGeld.Text.Length != 0 || txtUpdateGeld.Text.Length != 0)
            {
                try
                {
                    double.Parse(txt);
                }
                catch
                {
                    return false;
                }
            }
            return true;
        }

        private void txtUpdateGeld_TextChanged(object sender, EventArgs e)
        {

            if (isnumber(txtUpdateGeld.Text) == false)
            {
                MessageBox.Show("Es können nur Zahlen eingegeben werden");
                if (txtUpdateGeld.Text.Length != 0)
                {
                    txtUpdateGeld.Text = txtUpdateGeld.Text.Remove(txtUpdateGeld.Text.Length - 1);
                }
            }
        }*/


        public void RFIDChanged(string newRFID)
        {
            if (newRFID == "")
            {
                rfid_num = "";
                txtNewRFID.Text = rfid_num;
                client = "";
                FillData();
            }
            else
            {
                rfid_num = newRFID;
                txtNewRFID.Text = rfid_num;
                client = rfid_num;
                FillData();
            }
        }
        private void txtFields_Changed(object sender, EventArgs e)
        {

            TextBox[] txtBoxen = new TextBox[] {txtNewGeld,txtUpdateGeld};
            if (Eingabeüberprüfung.txtBoxValue_IsNumber(txtBoxen)==false)
            {
                MessageBox.Show("Es können nur Zahlen eingegeben werden");
                if (txtUpdateGeld.Text.Length != 0)
                {
                    txtUpdateGeld.Text = txtUpdateGeld.Text.Remove(txtUpdateGeld.Text.Length - 1);
                }
                else if (txtNewGeld.Text.Length != 0) 
                {
                    txtNewGeld.Text = txtNewGeld.Text.Remove(txtNewGeld.Text.Length - 1);
                }
            }

            
            TextBox[] txtBoxNew = new TextBox[] { txtNewVorname, txtNewRFID, txtNewName, txtNewGeld };
            if (Eingabeüberprüfung.TextBoxFilled(txtBoxNew) == true)
            {
                btnNewClient.Enabled = true;
            }
            else
            {
                btnNewClient.Enabled = false;
            }

            TextBox[] txtBoxUpdate = new TextBox[] { txtUpdateVorname, txtUpdateRFID, txtUpdateName, txtUpdateGeld };
            if (Eingabeüberprüfung.TextBoxFilled(txtBoxUpdate) == true)
            {
                btnUpdateClient.Enabled = true;
            }
            else
            {
                btnUpdateClient.Enabled = false;
            }
        }

    }
}