using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace Shoppy.Database
{
	class CamAdmin
	{
        string selectquery = "select id_kamera as Kamera-ID, IP,Anzeigename,Loginname,Passwort from kamera";
        public DataTable GetCams()
        {
            MySqlDataAdapter da = new MySqlDataAdapter(selectquery, Abfragen.verbindung);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        
        public void DeleteCam(string id)
        {
            Abfragen.Delete("delete from kamera where id_kamera='" + id + "';");
        }
        public void UpdateCam(string id, string ip, string anzeigename, string loginname, string passwort)
        {
            Abfragen.Update("update kamera set ip='" + ip + "', anzeigename='" + anzeigename + "', loginname='" + loginname + "', passwort='" + passwort +
               "' where id_kamera='"+id+"';");
        }

        internal void NewCam(string ip, string anzeigename, string loginname, string passwort)
        {
            Abfragen.Insert("insert into kamera(ip,anzeigename,loginname,passwort) values('" + ip + "','" + anzeigename + "','" + loginname + "','" + passwort + "');");
        }
    }
}
