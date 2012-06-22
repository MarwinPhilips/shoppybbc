﻿using System;
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
        public DataTable GetSeller(string RFID)
        {
            MySqlDataAdapter da = new MySqlDataAdapter("select RFID as ID, username as Loginname, Passwort,Name,Vorname from seller where RFID ='"+RFID+"'", Abfragen.verbindung);
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

        public bool SellerLogin(string RFID)
        {
            string[,] login = Abfragen.Select("SELECT Username FROM seller WHERE RFID = '" + RFID + "';");
            if (login.Length == 1)
            {
                return true;
            }
            return false;
        }

        public string GetSellerName(string RFID)
        {
            string[,] result = Abfragen.Select("SELECT name, vorname FROM seller WHERE RFID = '" + RFID + "';");

            string name = (result[0, 0] + " " + result[0, 1]);

            return name;
        }
	}
}
