using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Shoppy.Database;
using Phidgets;
using Shoppy.Helpers;


namespace Shoppy.Views
{
    // Dieses UserControl ermöglicht ein CRUD für die Produkte des Shopps.
    public partial class SellAdminView : UserControl
    {
        SellAdmin database = new SellAdmin();
        // Initialisiert das Objekt und füllt das DataGridView.
        public SellAdminView()
        {
            InitializeComponent();
            FillData();
            dataGridView1.ReadOnly = true;
        }

        private void FillData()
        {
            dataGridView1.DataSource = database.GetSell();
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
            txtUpdateBarcode.Text = row.Cells[3].Value.ToString();
            txtUpdatePreis.Text = row.Cells[4].Value.ToString();
            txtUpdateProdukt.Text = row.Cells[2].Value.ToString();
            btnUpdateSell.Tag = row.Cells[1].Value.ToString();
        }
        private void DeleteRow(DataGridViewCellEventArgs e)
        {
            database.DeleteSell(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
            FillData();
        }

        private void btnUpdateSell_Click(object sender, EventArgs e) 
        {
            database.UpdateSell(btnUpdateSell.Tag.ToString(), txtUpdateProdukt.Text, txtUpdateBarcode.Text, txtUpdatePreis.Text);
            FillData();
            txtUpdateBarcode.Text = "";
            txtUpdatePreis.Text = "";
            txtUpdateProdukt.Text = "";
        }

        private void btnNewSell_Click(object sender, EventArgs e)
        {
            database.NewSell(txtNewProdukt.Text, txtNewBarcode.Text, txtNewPreis.Text);
            FillData();
            txtNewBarcode.Text = "";
            txtNewPreis.Text = "";
            txtNewProdukt.Text = "";

        }
        private void txtFields_Changed(object sender, EventArgs e)
        {
            TextBox[] txtBoxen_wthInt = new TextBox[] { txtNewBarcode, txtNewPreis, txtUpdateBarcode, txtUpdatePreis};
            Eingabeüberprüfung.txtBoxValue_IsNumber(txtBoxen_wthInt);

            TextBox[] txtBoxNew = new TextBox[] { txtUpdateBarcode, txtUpdatePreis, txtUpdateProdukt };
            if (Eingabeüberprüfung.TextBoxFilled(txtBoxNew))
            {
                btnUpdateSell.Enabled = true;
            }
            else
            {
                btnUpdateSell.Enabled = false;
            } 
            
            TextBox[] txtBoxUpdate = new TextBox[] { txtNewBarcode,txtNewPreis,txtNewProdukt };
            if (Eingabeüberprüfung.TextBoxFilled(txtBoxUpdate))
            {
                btnNewSell.Enabled = true;                
            }
            else
            {
                btnNewSell.Enabled = false;
                
            }                                     
        }
    }
}
