using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Shoppy.Database;

namespace Shoppy.Views
{
	public partial class ClientAdminView: UserControl
	{

        ClientAdmin database = new ClientAdmin();
		public ClientAdminView()
		{
			InitializeComponent();
            FillData();

        }

        private void FillData()
        {
            dataGridView1.DataSource = database.GetClient();
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
            txtUpdatePasswort.Text = row.Cells[5].Value.ToString();
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
            database.UpdateClient(txtUpdateRFID.Text, txtUpdateName.Text, txtUpdateVorname.Text, txtUpdateGeld.Text, txtUpdatePasswort.Text);
            FillData();
        }

        private void btnNewClient_Click(object sender, EventArgs e)
        {
            if (Check(txtNewRFID.Text) == false)
            {
                MessageBox.Show("Die RFID "+ txtNewRFID.Text +" ist bereits gebucht");
            }
            else
            {
                database.NewClient(txtNewRFID.Text, txtNewName.Text, txtNewVorname.Text, txtNewGeld.Text, txtNewPasswort.Text);
                FillData();
            }
        }
        
        private bool Check(string id)
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
            if (txtNewGeld.Text.Length != 0 || txtUpdateGeld.Text.Length != 0)
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



    }
}