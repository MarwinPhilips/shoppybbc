using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace Shoppy.Database
{
	class SellerAdmin
	{
        public DataTable GetSellers()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("select RFID as ID, username as Loginname, Passwort,Name,Vorname from seller", Abfragen.verbindung);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void DeleteSeller(string id)
        {
            Abfragen.Delete("delete from seller where rfid='" + id + "';");
        }
        public void UpdateSeller(string rfid, string username, string passwort, string name, string vorname)
        {
            Abfragen.Update("update seller set username='" + username + "', passwort='" + passwort + "', name='" + name + "', vorname='" + name +
               "' where RFID='" + rfid + "';");
        }

        public void NewSeller(string rfid, string username, string passwort, string name,string vorname)
        {
            Abfragen.Insert("insert into seller(rfid,username,passwort,name,vorname) values('" + rfid + "','" + username + "','" + passwort + "','" + name + "','"+vorname+"');");
        }
	}
}
