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
	public partial class SellerAdminView: UserControl
	{
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
	}
}
