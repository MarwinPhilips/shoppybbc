using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Shoppy.Database;
using Shoppy.RFIDInput;
using Shoppy.Helpers;

namespace Shoppy.Views
{
    // Dieses UserControl ermöglicht CRUD für Verkäufer.
	public partial class SellerAdminView: UserControl
	{
        SellerAdmin database = new SellerAdmin();
        // An dieses Objekt werden die RFID-Events gemeldet.
        public RFIDListener rfidlistener;
        string rfid_num;

        // Initialisiert das Objekt.
		public SellerAdminView()
		{
			InitializeComponent();
		}
        private void FillRows()
        {
            dataGridView1.DataSource = database.GetSellers();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Eingabeüberprüfung.BinEinButton(dataGridView1,e.RowIndex,e.ColumnIndex))
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
            txtUpdateLoginname.Text = row.Cells[2].Value.ToString();
            txtUpdateName.Text = row.Cells[4].Value.ToString();
            txtUpdatePasswort.Text = row.Cells[3].Value.ToString();
            txtUpdateVorname.Text = row.Cells[5].Value.ToString();
            txtUpdateRFID.Text = row.Cells[1].Value.ToString();
        }

        private void DeleteRow(DataGridViewCellEventArgs e)
        {
            database.DeleteSeller(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
            FillRows();
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            database.UpdateSeller(txtUpdateRFID.Text, txtUpdateLoginname.Text, txtUpdatePasswort.Text, txtUpdateName.Text, txtUpdateVorname.Text);
            FillRows();
        }

        private void btnNewSeller_Click(object sender, EventArgs e)
        {
            database.NewSeller(txtNewRFID.Text, txtNewLoginname.Text, txtNewPasswort.Text, txtNewName.Text, txtNewVorname.Text);
            FillRows();
        }

        // Wird die RFID gewechselt passt diese Methode die Variable rifd_num und die verschiedenen Textboxen an.
        public void RFIDChanged(string newRFID)
        {
            if (newRFID == "")
            {
                rfid_num = "";
                FillRows();
                txtUpdateRFID.Text = "";
                txtUpdateLoginname.Text = "";
                txtUpdatePasswort.Text = "";
                txtUpdateName.Text = "";
                txtUpdateVorname.Text = "";
                txtNewRFID.Text = "";
            }
            else
            {
                rfid_num = newRFID;
                DataTable table = database.GetSeller(rfid_num);
                if (table.Rows.Count == 1)
                {
                    txtUpdateLoginname.Text = table.Rows[0].ItemArray[1].ToString();
                    txtUpdateName.Text = table.Rows[0].ItemArray[3].ToString();
                    txtUpdatePasswort.Text = table.Rows[0].ItemArray[2].ToString();
                    txtUpdateVorname.Text = table.Rows[0].ItemArray[4].ToString();
                    txtNewRFID.Text = rfid_num;
                    dataGridView1.DataSource = table;
                    txtUpdateRFID.Text = rfid_num;
                }
                else
                {
                    txtNewRFID.Text = rfid_num;
                }
            }
        }

        private void txtFields_Changed(object sender, EventArgs e)
        {
            TextBox[] txtBoxen_wthString = new TextBox[] { txtUpdateName, txtUpdateVorname, txtNewName, txtNewVorname };
            Eingabeüberprüfung.txtBoxValue_IsString(txtBoxen_wthString);



            TextBox[] txtBoxUpdate = new TextBox[] { txtUpdateVorname, txtUpdateRFID, txtUpdateName, txtUpdateLoginname, txtUpdatePasswort};
            if (Eingabeüberprüfung.TextBoxFilled(txtBoxUpdate))
            {
                btnUpdateSeller.Enabled = true;
                txtUpdateLoginname.Enabled = true;
                txtUpdatePasswort.Enabled = true;
                txtUpdateName.Enabled = true;
                txtUpdateVorname.Enabled = true;
            }
            else
            {
                btnUpdateSeller.Enabled = false;
                txtUpdateLoginname.Enabled = false;
                txtUpdatePasswort.Enabled = false;
                txtUpdateName.Enabled = false;
                txtUpdateVorname.Enabled = false;
            }


            TextBox[] txtBoxNew = new TextBox[] { txtNewVorname, txtNewRFID, txtNewName, txtNewPasswort };
            if (Eingabeüberprüfung.TextBoxFilled(txtBoxNew))
            {
                btnNewSeller.Enabled = true;
                
            }
            else
            {
                btnNewSeller.Enabled = false;
            }  
        }
	}
}
