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

namespace Shoppy.Views
{
	public partial class SellerAdminView: UserControl
	{
        RFID rfid;
        SellerAdmin database = new SellerAdmin();

        string rfid_num;
        string client;

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
            if (BinEinButton(e))
            {
                DeleteRow(e);
            }
            else if (BinEineZeile(e))
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

        private bool BinEineZeile(DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewTextBoxColumn && e.RowIndex != -1)
            {
                return true;
            }
            return false;
        }

        private bool BinEinButton(DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex != -1)
            {
                return true;
            }
            return false;
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
            rfid_num = e.Tag;
            txtUpdateRFID.Text = rfid_num;
            client = rfid_num;
            FillRows();
        }

        /*Event wenn RFID wieder weggenommen wird*/
        private void rfid_TagLost(object sender, TagEventArgs e)
        {
            rfid_num = "";
            txtUpdateRFID.Text = rfid_num;
            client = "";
            FillRows();
        }

        private void rfid_Attach(object sender, AttachEventArgs e)
        {
            RFID attached = (RFID)sender;

            if (rfid.outputs.Count > 0)
            {

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

	}
}
