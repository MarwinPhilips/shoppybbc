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
        public DataTable GetClient()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM kunde", Abfragen.verbindung);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public void DeleteClient(String RFID)
        {
            Abfragen.Delete("DELETE FROM kunde WHERE RFID='" + RFID + "';");
        }
	}
}

