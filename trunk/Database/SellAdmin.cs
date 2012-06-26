using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Shoppy.Database
{
    // Die Datenbankabfragen für Programmteile, welche mit den Produkten zu tun haben, werden hier geschrieben.
    class SellAdmin

    {
        // gibt alle Artikel zurück
        public DataTable GetSell()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("select id_artikel as artikelID, Name,BarCode,Preis from artikel", Abfragen.verbindung);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        // gibt ein einzelnes Produkt nach Barcode zurück.
        public string[,] GetProdukt(string BarCode) 
        {
            string[,] resultat = Abfragen.Select("select Name as ProduktName,BarCode,Preis from artikel Where BarCode='" + BarCode + "';");
            return resultat;
        }
        // Löscht ein Produkt nach ID.
        public void DeleteSell(string id)
        {
            Abfragen.Delete("delete from artikel where id_artikel='" + id + "';");
        }
        // Updatet ein Produkt nach ID
        public void UpdateSell(string id, string Produkt, string BarCode, string Preis)
        {
            Abfragen.Update("update artikel set Name='" + Produkt + "', BarCode='" + BarCode + "', Preis='" + Preis + "' where id_artikel='" + id + "';");
        }
        // Speichert ein neues Produkt in die Datenbank.
        public void NewSell(string Produkt, string BarCode, string Preis)
        {
            Abfragen.Insert("insert into artikel(Name,BarCode,Preis) values('" + Produkt + "','" + BarCode + "','" + Preis + "');");
        }

        /* zahlenden Kunden aussuchen*/
        public void UpdatePayClient(string RFID, double Betrag)
        {
            Abfragen.Update("UPDATE kunde SET Geld='" + Betrag + "' WHERE RFID = '" + RFID + "';");
        }
        /* zahlenden Kunden aussuchen*/
        public string GetPayClient(string RFID)
        {
            string[,] resuliste = Abfragen.Select("SELECT Geld FROM kunde WHERE RFID = '" + RFID + "';");
            string resultat = resuliste[0, 0];
            return resultat;
        }
    }
}
