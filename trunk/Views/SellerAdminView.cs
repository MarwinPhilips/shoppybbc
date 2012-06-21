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
	public partial class SellerAdminView: UserControl
	{
        SellerAdmin database = new SellerAdmin();
        public RFIDListener rfidlistener;
        string rfid_num;


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


        public void RFIDChanged(string newRFID)
        {
            if (newRFID == "")
            {
                rfid_num = "";
                FillRows();
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
                    dataGridView1.DataSource = table;
                    txtUpdateRFID.Text = rfid_num;
                }
                else
                {
                    txtNewRFID.Text = rfid_num;
                }
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

	}
}
