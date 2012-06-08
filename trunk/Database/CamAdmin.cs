using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Shoppy.Database
{
	class CamAdmin
	{
        public DataTable GetCams()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("select id_kamera as KameraID, IP,Anzeigename,Loginname,Passwort from kamera", Abfragen.verbindung);
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

        public void NewCam(string ip, string anzeigename, string loginname, string passwort)
        {
            Abfragen.Insert("insert into kamera(ip,anzeigename,loginname,passwort) values('" + ip + "','" + anzeigename + "','" + loginname + "','" + passwort + "');");
        }

        public DataTable getSuveyViewCams()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("select id_Kamera as ID,Anzeigename from kamera", Abfragen.verbindung);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataRow GetSingleCamInfo(string id)
        {
            MySqlDataAdapter da = new MySqlDataAdapter("select Anzeigename, id_Kamera as ID from kamera", Abfragen.verbindung);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt.Rows[0];
        }

    }
}
