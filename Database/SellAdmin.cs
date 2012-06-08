using System;
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
            MySqlDataAdapter da = new MySqlDataAdapter("select id_artikel as artikelID, Name,Vorrat,Preis,BarCode from artikel", Abfragen.verbindung);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void DeleteSell(string id)
        {
            Abfragen.Delete("delete from artikel where id_artikel='" + id + "';");
        }
        public void UpdateSell(string id, string Produkt, string BarCode, string Preis, string Vorrat)
        {
            Abfragen.Update("update artikel set Name='" + Produkt + "', anzeigename='" + BarCode + "', loginname='" + Preis + "', Vorrat='" + Vorrat +
               "' where id_artikel='" + id + "';");
        }

        public void NewSell(string Produkt, string BarCode, string Preis, string Vorrat)
        {
            Abfragen.Insert("insert into artikel(Name,BarCode,Preis,Vorrat) values('" + Produkt + "','" + BarCode + "','" + Preis + "','" + Vorrat + "');");
        }

    }
}
