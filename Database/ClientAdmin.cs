using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace Shoppy.Database
{
	class ClientAdmin
	{
        string selectquery = "SELECT * FROM kunde";
        public DataTable GetClient()
        {
            MySqlDataAdapter da = new MySqlDataAdapter(selectquery, Abfragen.verbindung);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public void DeleteClient(String RFID)
        {
            Abfragen.Delete("DELETE FROM kunde WHERE RFID='" + RFID + "';");
        }
        public void UpdateClient(string RFID, string Name, string Vorname, string Geld, string Passwort)
        {
            Abfragen.Update("update kamera set Name='" + Name + "', Vorname='" + Vorname + "', Geld='" + Geld + "', Passwort='" + Passwort+
               "' where RFID='" + RFID + "';");
        }

        internal void NewClient(string RFID, string Name, string Vorname, string Geld, string Passwort)
        {
            Abfragen.Insert("INSERT INTO kamera(ip,anzeigename,loginname,passwort) VALUES('" + RFID + "','" + Name + "','" + Vorname + "','" + Geld + "','" + Passwort + "');");
        }
	}
}

