using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Shoppy.Database
{
    class SellAdmin042000062008

    {
        public DataTable GetSell()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("select id_artikel as artikelID, Name,BarCode,Preis,Vorrat from artikel", Abfragen.verbindung);
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
            Abfragen.Update("update artikel set Name='" + Produkt + "', BarCode='" + BarCode + "', Preis='" + Preis + "', Vorrat='" + Vorrat +
               "' where id_artikel='" + id + "';");
        }

        public void NewSell(string Produkt, string BarCode, string Preis, string Vorrat)
        {
            Abfragen.Insert("insert into artikel(Name,BarCode,Preis,Vorrat) values('" + Produkt + "','" + BarCode + "','" + Preis + "','" + Vorrat + "');");
        }

    }
}
