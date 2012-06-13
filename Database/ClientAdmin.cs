
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using Shoppy.Database;

namespace Shoppy.Database
{
    class ClientAdmin
    {
        public DataTable GetClient()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM kunde", Abfragen.verbindung);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Dispose();
            return dt;
        }
        public void DeleteClient(String RFID)
        {
            Abfragen.Delete("DELETE FROM kunde WHERE RFID='" + RFID + "';");
        }
        public void UpdateClient(string RFID, string Name, string Vorname, string Geld, string Passwort)
        {
            Abfragen.Update("update kunde set Name='" + Name + "', Vorname='" + Vorname + "', Geld='" + Geld + "', Passwort='" + Passwort +
               "' where RFID='" + RFID + "';");
        }

        internal void NewClient(string RFID, string Name, string Vorname, string Geld, string Passwort)
        {
            Abfragen.Insert("INSERT INTO kunde(RFID,name,vorname,geld,passwort) VALUES('" + RFID + "','" + Name + "','" + Vorname + "','" + Geld + "','" + Passwort + "');");
        }


        public DataTable GetClientOnRFID(string RFID)
        {
            string selectquery = "SELECT RFID, name, vorname, geld FROM Kunde WHERE RFID = '" + RFID + "';";
            MySqlDataAdapter ad = new MySqlDataAdapter(selectquery, Abfragen.verbindung);
            DataTable td = new DataTable();
            ad.Fill(td);
            ad.Dispose();
            return td;
        }

        public void InsertBetrag(string RFID, string Betrag)
        {
            Abfragen.Update("UPDATE kunde SET Geld ='" + Betrag + "' WHERE RFID = '" + RFID + "';");
        }
        
	}
}



       
