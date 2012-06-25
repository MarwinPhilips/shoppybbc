using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Shoppy.Database;
using Phidgets.Events;
using Phidgets;
using System.Drawing.Printing;
using Shoppy.RFIDInput;
using Shoppy.Helpers;
using Shoppy.Views;

namespace Shoppy.Views
{
	public partial class SellView: UserControl
	{
        SellAdmin sa = new SellAdmin();
        string rfid_num;
        public RFIDListener rfidlistener;

		public SellView()
		{
			InitializeComponent();
            rfidlistener = RFIDListener.GetInstance();
		}

        /* Der Barcodeleser liest den Code ein und gibt zum schluss noch eine Enter aus, damit das System weiss,
         das der Code nun fertig ist. Danach wird der Barcode in einer anderen Funktion mit der Datanbank-Einträgen
         verglichen und das barcode Textfeld wieder leer gesetzt*/
        #region inputs
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
            int AnzahlZeilen = dataGridView1.Rows.Count;
            Boolean isdouble = false;

            for (int i = 0; i < AnzahlZeilen; i++)
            {                               
                if (BarCode.Equals(dataGridView1.Rows[i].Cells[2].Value.ToString()))
                {
                    int Produktanzahl = int.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                    Produktanzahl += 1;
                    dataGridView1.Rows[i].Cells[4].Value = Produktanzahl;
                    isdouble = true;
                    newPreis();
                }
            }
            if (isdouble == false)
              {
            try
                {
                    dataGridView1.Rows.Add("", produkt[0, 0], produkt[0, 1], produkt[0, 2], 1);
                }
                catch   //Wenn der Barcode (Artikel) nicht in der Datenbank vorhanden ist, wird eine fehlermeldung ausgegeben
                {
                    MessageBox.Show("Fehler:Dieser Artikel ist nicht vorhanden");
                }
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
                double Anzahl = double.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                double intPreis = double.Parse(preis);
                if (Anzahl > 1)
                {
                    intPreis = Anzahl * intPreis;
                }
                TotalPreis = TotalPreis + intPreis;
            }
            txtTotalPay.Text = String.Format("{0:0.00}", TotalPreis);   
        }

        /*löscht den Inhalt und die Zeile von der Zeile bei der der "lösch"-Button betätigt wurde*/
        private void DeleteRow(DataGridViewCellEventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.Rows[e.RowIndex]);
        }

        /* Funktion zum überprüfen ob auf eine Zeile oder einen Button gedrückt wurde */
        

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

        /* überprüft ob eingabe eine Zahl ist*/
        private bool BinEineZahl(string eingabe)
        {
            try
            {
                Int32.Parse(eingabe);
                return false;
            }
            catch
            {
                return true;
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
            if (Eingabeüberprüfung.BinEinButton(dataGridView1, e.RowIndex, e.ColumnIndex))
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
            double zuBezahlenBetrag = double.Parse(txtTotalPay.Text);
            double kundenGehalt = double.Parse(sa.GetPayClient(rfid_num));
            if (kundenGehalt < zuBezahlenBetrag)
            {
                MessageBox.Show("Zu Wenig Geld auf dem Konto !");
            }
            else if (kundenGehalt >= zuBezahlenBetrag)
            {
                double newKundenGehalt = kundenGehalt - zuBezahlenBetrag;
                sa.UpdatePayClient(rfid_num, newKundenGehalt);
                txtGehalt.Text = newKundenGehalt.ToString();
                dataGridView1.Rows.Clear();
                newPreis();
            }
        }

        #endregion
 
        

        private void btnPrintSell_Click(object sender, EventArgs e)
        {
            PrintSell sellPrint = new PrintSell(double.Parse(txtTotalPay.Text.ToString()),dataGridView1);
            sellPrint.Kontrollblatt();
        }

        private void SellView_Load(object sender, EventArgs e)
        {
            txtInputBarcode.Select();
        }

        public void RFIDChanged(string newRFID)
        {
            if (rfid_num != newRFID)
            {
                rfid_num = newRFID;
            }
            if (rfid_num == "")
            {
                btnSellPay.Enabled = false;
                txtGehalt.Text = "";
            }
            else
            {
                try
                {
                    string Gehalt = sa.GetPayClient(rfid_num).ToString();
                    txtGehalt.Text = Gehalt;
                    btnSellPay.Enabled = true;
                    btnPrintSell.Enabled = true;
                }
                catch   /*Wenn der Kunde (RFID) nicht in der Datenbank vorhanden ist, wird eine Fehlermeldung ausgegeben*/
                {
                    //MessageBox.Show("Fehler: Der RFID konnte nicht gefunden werden. Bitte RFID als neuer Kunde hinzufügen.");
                }
            }
        }

        private void txtFields_Changed(object sender, EventArgs e)
        {
            TextBox[] txtBoxen_wthInt = new TextBox[] { txtInputBarcode };
            Eingabeüberprüfung.txtBoxValue_IsNumber(txtBoxen_wthInt);
        }
	}
}
