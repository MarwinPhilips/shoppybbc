using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Shoppy.Database
{
    // Die Datenbankabfragen für Programmteile, welche mit der Kamera zu tun haben, werden hier geschrieben.
	class CamAdmin
	{
        // gibt alle Kameras zurück welche in der Datenbank gespeichert sind. Für CamAdminView
        public DataTable GetCams()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("select id_kamera as KameraID, IP,Anzeigename,Loginname,Passwort from kamera", Abfragen.verbindung);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        // Löscht eine Kamera nach ID
        public void DeleteCam(string id)
        {
            Abfragen.Delete("delete from kamera where id_kamera='" + id + "';");
        }
        // Updatet eine Kamera
        public void UpdateCam(string id, string ip, string anzeigename, string loginname, string passwort)
        {
            Abfragen.Update("update kamera set ip='" + ip + "', anzeigename='" + anzeigename + "', loginname='" + loginname + "', passwort='" + passwort +
               "' where id_kamera='"+id+"';");
        }
        // Speichert eine neue Kamera in der DB.
        public void NewCam(string ip, string anzeigename, string loginname, string passwort)
        {
            Abfragen.Insert("insert into kamera(ip,anzeigename,loginname,passwort) values('" + ip + "','" + anzeigename + "','" + loginname + "','" + passwort + "');");
        }
        // gibt alle Kameras zurück welche in der DB gespeichert sind. Für SurveyViewCamSwitcher.
        public DataTable getSurveyViewCams()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("select id_Kamera as ID,Anzeigename as Name from kamera", Abfragen.verbindung);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        // Gibt die Daten einer einzelnen Kamera zurück.
        public DataRow GetSingleCamInfo(string id)
        {
            MySqlDataAdapter da = new MySqlDataAdapter("select ip,Loginname,passwort from kamera where id_Kamera ='"+id+"';", Abfragen.verbindung);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt.Rows[0];
        }

    }
}
