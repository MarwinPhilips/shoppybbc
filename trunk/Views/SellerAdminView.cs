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
using Shoppy.Helpers;

namespace Shoppy.Views
{
	public partial class SellerAdminView: UserControl
	{
        RFID rfid;
        SellerAdmin database = new SellerAdmin();


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
            database.UpdateSeller(txtUpdateRFID.Text, txtUpdateLoginname.Text, txtUpdatePasswort.Text, txtUpdateName.Text, txtNewVorname.Text);
            FillRows();
        }

        private void btnNewSeller_Click(object sender, EventArgs e)
        {
            database.NewSeller(txtNewRFID.Text, txtNewLoginname.Text, txtNewPasswort.Text, txtNewName.Text, txtNewVorname.Text);
            FillRows();
        }

        private void rfid_Tag(object sender, TagEventArgs e)
        {
            
            
            DataTable table = database.GetSeller(e.Tag);
            if (table.Rows.Count == 1)
            {
                txtUpdateLoginname.Text = table.Rows[0].ItemArray[1].ToString();
                txtUpdateName.Text = table.Rows[0].ItemArray[3].ToString();
                txtUpdatePasswort.Text = table.Rows[0].ItemArray[2].ToString();
                txtUpdateVorname.Text = table.Rows[0].ItemArray[4].ToString();
                dataGridView1.DataSource = table;
                txtUpdateRFID.Text = e.Tag;
            }
            else
            {
                txtNewRFID.Text = e.Tag;
            }

        }

        /*Event wenn RFID wieder weggenommen wird*/
        private void rfid_TagLost(object sender, TagEventArgs e)
        {
            
            FillRows();
        }

        private void rfid_Attach(object sender, AttachEventArgs e)
        {
            RFID attached = (RFID)sender;

            if (rfid.outputs.Count > 0)
            {
                label2.Text = "RFID: Angeschlossen.";
                rfid.Antenna = true;

            }
        }

        private void rfid_Detach(object sender, DetachEventArgs e)
        {
            RFID detached = (RFID)sender;

            if (rfid.outputs.Count < 0)
            {
                rfid.Antenna = false;
            }
            label2.Text = "RFID: Nicht angeschlossen.";
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
                label2.Text = "RFID: Nicht angeschlossen.";
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

	}
}
