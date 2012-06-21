using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Shoppy.Database;
using Shoppy.Helpers;

namespace Shoppy.Views
{
	public partial class CamAdminView: UserControl
	{
        CamAdmin database = new CamAdmin();
		public CamAdminView()
		{
			InitializeComponent();
            FillData();
            
		}

        private void FillData()
        {
            dataGridView1.DataSource = database.GetCams();
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
            txtUpdateAnzeigename.Text = row.Cells[3].Value.ToString();
            txtUpdateLoginname.Text = row.Cells[4].Value.ToString();
            txtUpdateIP.Text = row.Cells[2].Value.ToString();
            txtUpdatePasswort.Text = row.Cells[5].Value.ToString();
            btnUpdateCam.Tag = row.Cells[1].Value.ToString();
        }

        private void DeleteRow(DataGridViewCellEventArgs e)
        {
            database.DeleteCam(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
            FillData();
        }

        private void btnUpdateCam_Click(object sender, EventArgs e)
        {
            database.UpdateCam(btnUpdateCam.Tag.ToString(), txtUpdateIP.Text, txtUpdateAnzeigename.Text, txtUpdateLoginname.Text, txtUpdatePasswort.Text);
            FillData();
        }

        private void btnNewCam_Click(object sender, EventArgs e)
        {
            database.NewCam(txtNewIP.Text, txtNewAnzeigename.Text, txtNewLoginname.Text, txtNewPasswort.Text);
            FillData();
        }


	}
}
