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

        /* Der Barcode leser liest den Code ein und gibt zum schluss noch eine Enter aus, damit das System weiss,
         das der Code nun fertig ist. Danach wird der Barcode in einer anderen Funktion mit der Datanbank-Einträgen
         verglichen und das barcode Textfeld wieder leer gesetzt*/
        private void txtInputBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                addprodukt(txtInputBarcode.Text);
                txtInputBarcode.Text = "";
            }
        }

        /* Beim aufruf dieser Funtkion wird der Artikel aus der Datanbank herausgelesen und in die Tabelle gelesen*/
        private void addprodukt(string BarCode)
        {
            string[,] produkt = sa.GetProdukt(BarCode);
            int AnzahlZeilen = dataGridView1.Rows.Count - 1;
            try
            {
                dataGridView1.Rows.Add("", produkt[0, 0], produkt[0, 1], produkt[0, 2], 1);
            }
            catch   /*Wenn der Barcode (Artikel) nicht in der Datenbank vorhanden ist, wird eine fehlermeldung ausgegeben*/
            {
                MessageBox.Show("Fehler:Dieser Artikel ist nicht vorhanden");
            }
        }

        /* Hier wird der GesamtPreis aller Aller Artikel zusammen gezählt und angezeigt*/
        private void newPreis() 
        {
            int AnzahlZeilen = dataGridView1.Rows.Count;
            double TotalPreis = 0;
            for (int i = 0; i < AnzahlZeilen; i++)
            { 
                string preis = dataGridView1.Rows[i].Cells[3].Value.ToString();
                int Anzahl = Int32.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                double intPreis = double.Parse(preis);
                if (Anzahl > 1)
                {
                    intPreis = Anzahl * intPreis;
                }
                TotalPreis = TotalPreis + intPreis;
            }
            txtTotalPay.Text = TotalPreis.ToString();
        }

        /*löscht den Inhalt und die Zeile von der Zeile bei der der "lösch"-Button betätigt wurde*/
        private void DeleteRow(DataGridViewCellEventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.Rows[e.RowIndex]);
        }

        /* Funktion zum überprüfen ob auf eine Zeile oder einen Button gedrückt wurde */
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

        /* Anzahl Artikel ändern*/
        private void SellMultipleProdukt_Click(object sender, EventArgs e)
        {
            if (txtMultipleProdukt.Text.Equals("") || BinEineZahl(txtMultipleProdukt.Text))
            {
                MessageBox.Show("Achtung! Ungültige Eingabe Im Eingabefeld. Bitte eine Zahl eingeben.");
                txtMultipleProdukt.Text = "";
                TabIndex.Equals(4);
            }
            else
            {
                int anzProdukts = Int32.Parse(txtMultipleProdukt.Text);
                int AnzahlRows = dataGridView1.Rows.Count - 1;
                dataGridView1.Rows[AnzahlRows].Cells[4].Value = anzProdukts.ToString();
                txtMultipleProdukt.Text = "";
                newPreis();
            }
        }

        /* Aufruf beim hinzufügen oder löschen einer Tabellenzeile*/
        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            newPreis();
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            newPreis();
        }

        /* Löscht den Eintrag bei dem der "löschbutton" betätigt wurde*/
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (BinEinButton(e))
            {
                DeleteRow(e);
            } 
        }
        /* löscht den GANZEN Ihnalt der Verkaufstabelle*/
        private void btnSellDeleteAll_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void btnSellPay_Click(object sender, EventArgs e)
        {
            int TotalKosten = Int32.Parse(txtTotalPay.Text);
            //string Gehalt = sa.getPayClient("sdf");
        }


        private bool BinEineZahl(string eingabe)
        {
            try
            {
                Int32.Parse(eingabe);
                return false;
            }catch{
                return true;
            }
        }

	}
}
