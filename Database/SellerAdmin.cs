using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace Shoppy.Database
{
    // Die Datenbankabfragen für Programmteile, welche mit den Produkten zu tun haben, werden hier geschrieben.
	class SellerAdmin
	{
        // Gibt alle Verkäufer zurück
        public DataTable GetSellers()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("select RFID as ID, username as Loginname, Passwort,Name,Vorname from seller", Abfragen.verbindung);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        // Gibt einen einzelnen Verkäufer nach RFID zurück
        public DataTable GetSeller(string RFID)
        {
            MySqlDataAdapter da = new MySqlDataAdapter("select RFID as ID, username as Loginname, Passwort,Name,Vorname from seller where RFID ='"+RFID+"'", Abfragen.verbindung);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        // Léscht einen einzelnen Seller nach ID
        public void DeleteSeller(string id)
        {
            Abfragen.Delete("delete from seller where rfid='" + id + "';");
        }
        // Updatet den Verkäufer nach RFID
        public void UpdateSeller(string rfid, string username, string passwort, string name, string vorname)
        {
            Abfragen.Update("update seller set username='" + username + "', passwort='" + passwort + "', name='" + name + "', vorname='" + name +
               "' where RFID='" + rfid + "';");
        }
        // Speichert einen neuen Verkäufer in der Datenkbank.
        public void NewSeller(string rfid, string username, string passwort, string name,string vorname)
        {
            Abfragen.Insert("insert into seller(rfid,username,passwort,name,vorname) values('" + rfid + "','" + username + "','" + passwort + "','" + name + "','"+vorname+"');");
        }
        // Ist der Seller in der Datebank -> True, sonst false.
        public bool SellerLogin(string RFID)
        {
            string[,] login = Abfragen.Select("SELECT Username FROM seller WHERE RFID = '" + RFID + "';");
            if (login.Length == 1)
            {
                return true;
            }
            return false;
        }
        // gibt den Namen des Verkäufers zurück.
        public string GetSellerName(string RFID)
        {
            string[,] result = Abfragen.Select("SELECT name, vorname FROM seller WHERE RFID = '" + RFID + "';");

            string name = (result[0, 0] + " " + result[0, 1]);

            return name;
        }
	}
}
