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
	public partial class ClientAdminView: UserControl
	{
        RFID rfid;
        string rfid_num;
        ClientAdmin database = new ClientAdmin();
        string client = "";
       
		public ClientAdminView()
		{
			InitializeComponent();
            FillData();
        }

        private void FillData()
        {
            if (client.Equals(""))
            {
                dataGridView1.DataSource = database.GetClient();
            }
            else if (!(client.Equals("")))
            {
                client = rfid_num;
                dataGridView1.DataSource = database.GetClientOnRFID(client);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
            txtUpdateRFID.Text = row.Cells[1].Value.ToString();
            txtUpdateName.Text = row.Cells[2].Value.ToString();
            txtUpdateVorname.Text = row.Cells[3].Value.ToString();
            txtUpdateGeld.Text = row.Cells[4].Value.ToString();            
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

        private bool isnumber(string id)
        {
            if (txtNewGeld.Text.Length != 0 || txtUpdateGeld.Text.Length != 0 || txtNewRFID.Text.Length != 0)
            {
                try
                {
                    double.Parse(id);
                }
                catch
                {
                    return false;
                }
            }
            return true;
        }

        private void txtNewGeld_TextChanged(object sender, EventArgs e)
        {
            if (isnumber(txtNewGeld.Text) == false)
            {
                MessageBox.Show("Es können nur Zahlen eingegeben werden");
                
                if (txtNewGeld.Text.Length != 0)
                {
                    txtNewGeld.Text = txtNewGeld.Text.Remove(txtNewGeld.Text.Length - 1);
                }
            }
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
        }

        /*private void txtNewRFID_TextChanged(object sender, EventArgs e)
        {
            if (isnumber(txtNewRFID.Text) == false)
            {
                MessageBox.Show("Es können nur Zahlen eingegeben werden");

                if (txtNewRFID.Text.Length != 0)
                {
                    txtNewRFID.Text = txtNewRFID.Text.Remove(txtNewRFID.Text.Length - 1);
                }
            }
        }*/

        private void rfid_Tag(object sender, TagEventArgs e)
        {
            rfid_num = e.Tag;
            txtNewRFID.Text = rfid_num;
            client = rfid_num;
            FillData();
        }

        /*Event wenn RFID wieder weggenommen wird*/
        private void rfid_TagLost(object sender, TagEventArgs e)
        {
            rfid_num = "";
            txtNewRFID.Text = rfid_num;
            client = "";
            FillData();
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

        private void ClientAdminView_Load(object sender, EventArgs e)
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