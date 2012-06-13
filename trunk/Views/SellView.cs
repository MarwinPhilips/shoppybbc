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
	public partial class SellView: UserControl
	{

        SellAdmin sa = new SellAdmin();

		public SellView()
		{
			InitializeComponent();
		}

        private void txtInputBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                addprodukt(txtInputBarcode.Text);
                txtInputBarcode.Text = "";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (BinEinButton(e))
            {
                DeleteRow(e);
            }
        }

        private void addprodukt(string BarCode)
        {
            string[,] produkt = sa.GetProdukt(BarCode);
            try
            {
                dataGridView1.Rows.Add("", produkt[0, 0], produkt[0, 1], produkt[0, 2]);
            }
            catch 
            {
                MessageBox.Show("Fehler Artikel nicht vorhanden");
            }
        }

        private void newPreis() 
        {
            int AnzahlZeilen = dataGridView1.Rows.Count - 1;
            double TotalPreis = 0;
            for (int i = 0; i < AnzahlZeilen; i++)
            {
                string preis = dataGridView1.Rows[i].Cells[3].Value.ToString();
                double intPreis = double.Parse(preis);
                TotalPreis = TotalPreis + intPreis;
            }
            txtTotalPay.Text = TotalPreis.ToString();
        }


        private void DeleteRow(DataGridViewCellEventArgs e)
        {
            sa.DeleteProdukt(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
        }

        /* Funktion zum überprüfen ob auf eine Zeile oder einen Button gedrückt wurde*/
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

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            newPreis();
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {

        }


	}
}
