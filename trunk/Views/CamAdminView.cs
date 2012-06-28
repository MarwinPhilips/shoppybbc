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
    // CamAdminView erbt von UserControl und managed die Datenbankeinträge welche für die CamView benötigt werden.
    // CRUD für CameraView
	public partial class CamAdminView: UserControl
	{
        CamAdmin database = new CamAdmin();
        // Initialisiert die CamAdminView und füllt das Datagridview
		public CamAdminView()
		{
			InitializeComponent();
            FillData();
            dataGridView1.ReadOnly = true;
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
            if (Eingabeüberprüfung.txtBoxValue_validIP(txtNewIP))
            {
                txtNewIP.Text = "";
                MessageBox.Show("Fehler bei IPeingabe");
            }
            else 
            {
                database.NewCam(txtNewIP.Text, txtNewAnzeigename.Text, txtNewLoginname.Text, txtNewPasswort.Text);
                FillData();
            }
            
        }

        private void txtFields_Changed(object sender, EventArgs e)
        {
            TextBox[] txtBoxNew = new TextBox[] { txtNewAnzeigename, txtNewIP, txtNewLoginname, txtNewPasswort };


            if (Eingabeüberprüfung.TextBoxFilled(txtBoxNew))
            {
                btnNewCam.Enabled = true;                
            }
            else
            {
                btnNewCam.Enabled = false;
            }

            TextBox[] txtBoxUpdate = new TextBox[] { txtUpdateAnzeigename, txtUpdateIP, txtUpdateLoginname, txtUpdatePasswort };
            if (Eingabeüberprüfung.TextBoxFilled(txtBoxUpdate))
            {
                btnUpdateCam.Enabled = true;
                txtUpdateAnzeigename.Enabled = true;
                txtUpdateIP.Enabled = true;
                txtUpdateLoginname.Enabled = true;
                txtUpdatePasswort.Enabled = true;
            }
            else
            {
                btnUpdateCam.Enabled = false;
                txtUpdateAnzeigename.Enabled = false;
                txtUpdateIP.Enabled = false;
                txtUpdateLoginname.Enabled = false;
                txtUpdatePasswort.Enabled = false;
            }
        }
	}
}
