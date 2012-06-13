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
    public partial class SellAdminView : UserControl
    {
        SellAdmin database = new SellAdmin();
        public SellAdminView()
        {
            InitializeComponent();
            FillData();
        }

        private void FillData()
        {
            dataGridView1.DataSource = database.GetSell();
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
            txtUpdateBarcode.Text = row.Cells[3].Value.ToString();
            txtUpdatePreis.Text = row.Cells[4].Value.ToString();
            txtUpdateProdukt.Text = row.Cells[2].Value.ToString();
            txtUpdateVorrat.Text = row.Cells[5].Value.ToString();
            btnUpdateSell.Tag = row.Cells[1].Value.ToString();
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
            database.DeleteSell(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
            FillData();
        }

        private void btnUpdateSell_Click(object sender, EventArgs e) 
        {
            database.UpdateSell(btnUpdateSell.Tag.ToString(), txtUpdateProdukt.Text, txtUpdateBarcode.Text, txtUpdatePreis.Text, txtUpdateVorrat.Text);
            FillData();
        }

        private void btnNewSell_Click(object sender, EventArgs e)
        {
            database.NewSell(txtNewProdukt.Text, txtNewBarcode.Text, txtNewPreis.Text, txtNewVorrat.Text);
            FillData();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
