﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Shoppy.Database
{
    class SellAdmin

    {
        public DataTable GetSell()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("select id_artikel as artikelID, Name,BarCode,Preis,Vorrat from artikel", Abfragen.verbindung);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public string[,] GetProdukt(string BarCode) 
        {
            string[,] resultat = Abfragen.Select("select Name as ProduktName,BarCode,Preis from artikel Where BarCode='" + BarCode + "';");
            return resultat;
        }

        public void DeleteSell(string id)
        {
            Abfragen.Delete("delete from artikel where id_artikel='" + id + "';");
        }

        public void UpdateSell(string id, string Produkt, string BarCode, string Preis, string Vorrat)
        {
            Abfragen.Update("update artikel set Name='" + Produkt + "', BarCode='" + BarCode + "', Preis='" + Preis + "', Vorrat='" + Vorrat +
               "' where id_artikel='" + id + "';");
        }

        public void NewSell(string Produkt, string BarCode, string Preis, string Vorrat)
        {
            Abfragen.Insert("insert into artikel(Name,BarCode,Preis,Vorrat) values('" + Produkt + "','" + BarCode + "','" + Preis + "','" + Vorrat + "');");
        }

        /* zahlenden Kunden aussuchen*/
        public void UpdatePayClient(string RFID, double Betrag)
        {
            Abfragen.Update("UPDATE kunde SET Geld='" + Betrag + "' WHERE RFID = '" + RFID + "';");
        }

        public string GetPayClient(string RFID)
        {
            string[,] resuliste = Abfragen.Select("SELECT Geld FROM kunde WHERE RFID = '" + RFID + "';");
            string resultat = resuliste[0, 0];
            return resultat;
        }
    }
}
