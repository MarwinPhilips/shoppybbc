
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using Shoppy.Database;
using System.Windows.Forms;

namespace Shoppy.Database
{
    // Die Datenbankabfragen für Programmteile, welche mit dem Kunden zu tun haben, werden hier geschrieben.
    class ClientAdmin
    {
        // Gibt alle Kunden zurück.
        public DataTable GetClient()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT RFID, Name, Vorname,Geld FROM kunde", Abfragen.verbindung);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Dispose();
            return dt;
        }
        // Löscht einen Kunden nach RFID
        public void DeleteClient(String RFID)
        {
            Abfragen.Delete("DELETE FROM kunde WHERE RFID='" + RFID + "';");
        }
        // Updatet einen Kunden nach RFID.
        public void UpdateClient(string RFID, string Name, string Vorname, string Geld)
        {
            Abfragen.Update("update kunde set Name='" + Name + "', Vorname='" + Vorname + "', Geld='" + Geld + "' WHERE RFID='" + RFID + "';");
        }
        // Erzeugt einen neuen Datenbankeintrag.
        public void NewClient(string RFID, string Name, string Vorname, string Geld)
        {
            Abfragen.Insert("INSERT INTO kunde(RFID,name,vorname,geld) VALUES('" + RFID + "','" + Name + "','" + Vorname + "','" + Geld +"');");
        }
        // Gibt die Kundendaten eines Kunden zurück.
        public DataTable GetClientOnRFID(string RFID)
        {
            string selectquery = "SELECT RFID, name, vorname, geld FROM Kunde WHERE RFID = '" + RFID + "';";
            MySqlDataAdapter da = new MySqlDataAdapter(selectquery, Abfragen.verbindung);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Dispose();
            return dt;
        }
        // Lädt das Konto eines Kunden um den Betrag auf.
        public void InsertBetrag(string RFID, double Betrag)
        {
            string[,] ins = Abfragen.Select("SELECT Geld FROM Kunde WHERE RFID ='" + RFID + "';");
            Betrag += double.Parse(ins[0, 0]);
            Abfragen.Update("UPDATE kunde SET Geld ='" + Betrag +"' WHERE RFID = '" + RFID + "';");
        }

        public bool ClientExist(string RFID)
        {
            string[,] client = Abfragen.Select("SELECT name FROM Kunde WHERE RFID ='" + RFID + "';");
            if (client.Length == 0)
            {
                return false;
            }
            return true;
        }
        
	}
}



       
